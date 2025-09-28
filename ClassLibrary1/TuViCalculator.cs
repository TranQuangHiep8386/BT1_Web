using System;

namespace TuViLib
{
    public class TuViCalculator
    {
        private static readonly string[] Animals = {
            "Tý","Sửu","Dần","Mão","Thìn","Tỵ","Ngọ","Mùi","Thân","Dậu","Tuất","Hợi"
        };

        private struct WesternSign
        {
            public string Name;
            public int StartMonth, StartDay;
            public int EndMonth, EndDay;
        }

        private static readonly WesternSign[] Western = new WesternSign[] {
            new WesternSign {Name="Ma Kết", StartMonth=12, StartDay=22, EndMonth=1, EndDay=19},
            new WesternSign {Name="Bảo Bình", StartMonth=1, StartDay=20, EndMonth=2, EndDay=18},
            new WesternSign {Name="Song Ngư", StartMonth=2, StartDay=19, EndMonth=3, EndDay=20},
            new WesternSign {Name="Bạch Dương", StartMonth=3, StartDay=21, EndMonth=4, EndDay=19},
            new WesternSign {Name="Kim Ngưu", StartMonth=4, StartDay=20, EndMonth=5, EndDay=20},
            new WesternSign {Name="Song Tử", StartMonth=5, StartDay=21, EndMonth=6, EndDay=20},
            new WesternSign {Name="Cự Giải", StartMonth=6, StartDay=21, EndMonth=7, EndDay=22},
            new WesternSign {Name="Sư Tử", StartMonth=7, StartDay=23, EndMonth=8, EndDay=22},
            new WesternSign {Name="Xử Nữ", StartMonth=8, StartDay=23, EndMonth=9, EndDay=22},
            new WesternSign {Name="Thiên Bình", StartMonth=9, StartDay=23, EndMonth=10, EndDay=22},
            new WesternSign {Name="Bọ Cạp", StartMonth=10, StartDay=23, EndMonth=11, EndDay=21},
            new WesternSign {Name="Nhân Mã", StartMonth=11, StartDay=22, EndMonth=12, EndDay=21}
        };

        public static string GetChineseZodiac(int year)
        {
            int idx = (year - 4) % 12;
            if (idx < 0) idx += 12;
            return Animals[idx];
        }

        public static string GetWesternSign(DateTime dob)
        {
            int m = dob.Month;
            int d = dob.Day;
            foreach (WesternSign z in Western)
            {
                if (z.StartMonth == z.EndMonth)
                {
                    if (m == z.StartMonth && d >= z.StartDay && d <= z.EndDay) return z.Name;
                }
                else if (z.StartMonth < z.EndMonth)
                {
                    if ((m == z.StartMonth && d >= z.StartDay) ||
                        (m == z.EndMonth && d <= z.EndDay) ||
                        (m > z.StartMonth && m < z.EndMonth))
                        return z.Name;
                }
                else // qua năm mới
                {
                    if ((m == z.StartMonth && d >= z.StartDay) ||
                        (m == z.EndMonth && d <= z.EndDay) ||
                        (m > z.StartMonth || m < z.EndMonth))
                        return z.Name;
                }
            }
            return "?";
        }
        // Simple deterministic random based on name+dob
        private static int SimpleHash(string s)
        {
            uint h = 2166136261;
            foreach (char c in s)
            {
                h ^= c;
                h *= 16777619;
            }
            return (int)(h & 0x7fffffff);
        }

        public static string GetReport(string name, DateTime dob, string gender)
        {
            string zodiac = GetChineseZodiac(dob.Year);
            string western = GetWesternSign(dob);

            int seed = SimpleHash(name.ToLower() + "|" + dob.ToString("yyyy-MM-dd") + "|" + gender);
            Random rand = new Random(seed);

            string[] career = {
                "Sự nghiệp thuận lợi, có cơ hội mở rộng mối quan hệ.",
                "Cần chủ động hơn trong công việc.",
                "Có thể gặp thử thách nhỏ nhưng sẽ có bài học quý.",
                "Thời điểm tốt để học thêm kỹ năng mới."
            };
            string[] love = {
                "Tình cảm êm đềm.",
                "Giao tiếp rõ ràng giúp giải quyết hiểu lầm.",
                "Có người quan tâm, hãy mở lòng.",
                "Nên tập trung yêu bản thân trước."
            };
            string[] money = {
                "Tài chính ổn định.",
                "Cẩn trọng chi tiêu.",
                "Có thể có khoản thu bất ngờ.",
                "Nên kiểm tra ngân sách."
            };
            string luckyColor = new string[] {
                "Đỏ","Xanh lá","Vàng","Tím","Xanh dương","Trắng","Đen"
            }[rand.Next(7)];

            int luckyNumber = rand.Next(1, 91);

            return string.Format(
                "{0} ({1})\\nSinh: {2:d}\\nCon Giáp: {3}\\nCung: {4}\\n\\n- Sự nghiệp: {5}\\n- Tình cảm: {6}\\n- Tài chính: {7}\\nCon số may mắn: {8}\\nMàu hợp: {9}",
                name, gender, dob, zodiac, western,
                career[rand.Next(career.Length)],
                love[rand.Next(love.Length)],
                money[rand.Next(money.Length)],
                luckyNumber, luckyColor
            );
        }
    }
}