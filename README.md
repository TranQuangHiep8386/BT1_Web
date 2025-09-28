# BT1_Web
README

k58ktp - Môn: Phát triển ứng dụng trên nền web

BÀI TẬP VỀ NHÀ 01:

TẠO SOLUTION GỒM CÁC PROJECT SAU: DLL đa năng, keyword: c# window library -> Class Library (.NET Framework) bắt buộc sử dụng .NET Framework 2.0: giải bài toán bất kỳ, độc lạ càng tốt, phải có dấu ấn cá nhân trong kết quả, biên dịch ra DLL. DLL độc lập vì nó ko nhập, ko xuất, nó nhận input truyền vào thuộc tính của nó, và trả về dữ liệu thông qua thuộc tính khác, hoặc thông qua giá trị trả về của hàm. Nó độc lập thì sẽ sử dụng được trên app dạng console (giao diện dòng lệnh - đen sì), cũng sử dụng được trên app desktop (dạng cửa sổ), và cũng sử dụng được trên web form (web chạy qua iis). Console app, bắt buộc sử dụng .NET Framework 2.0, sử dụng được DLL trên: nhập được input, gọi DLL, hiển thị kết quả, phải có dấu án cá nhân. keyword: c# window Console => Console App (.NET Framework), biên dịch ra EXE Windows Form Application, bắt buộc sử dụng .NET Framework 2.0**, sử dụng được DLL đa năng trên, kéo các control vào để có thể lấy đc input, gọi DLL truyền input để lấy đc kq, hiển thị kq ra window form, phải có dấu án cá nhân; keyword: c# window Desktop => Windows Form Application (.NET Framework), biên dịch ra EXE Web đơn giản, bắt buộc sử dụng .NET Framework 2.0, sử dụng web server là IIS, dùng file hosts để tự tạo domain, gắn domain này vào iis, file index.html có sử dụng html css js để xây dựng giao diện nhập được các input cho bài toán, dùng mã js để tiền xử lý dữ liệu, js để gửi lên backend. backend là api.aspx, trong code của api.aspx.cs thì lấy được các input mà js gửi lên, rồi sử dụng được DLL đa năng trên. kết quả gửi lại json cho client, js phía client sẽ nhận được json này hậu xử lý để thay đổi giao diện theo dữ liệu nhận dược, phải có dấu án cá nhân. keyword: c# window web => ASP.NET Web Application (.NET Framework) + tham khảo link chatgpt thầy gửi. project web này biên dịch ra DLL, phải kết hợp với IIS mới chạy được.

Tên bài toán: game tài xỉu giải trí

Tạo ra 4 project gồm : class library, console app, windows form application, web đơn giản

1. Tạo class library ( dll)

<img width="1920" height="784" alt="image" src="https://github.com/user-attachments/assets/7ae4dc25-ee57-4bdb-8bbf-8502bf3042c1" />

2. Console app

<img width="1920" height="788" alt="image" src="https://github.com/user-attachments/assets/8092b5fc-153f-480c-bced-d5e655387248" />

3. Windows form

<img width="1916" height="556" alt="image" src="https://github.com/user-attachments/assets/d6f83dc5-a2bb-4c20-ae97-1a8ee5ae818c" />

<img width="1170" height="674" alt="image" src="https://github.com/user-attachments/assets/dbe3583d-8f54-4d2d-a15d-dd986d74d9d2" />

4. Web đơn giản ( dùng iis)

<img width="1920" height="763" alt="image" src="https://github.com/user-attachments/assets/ac4175ef-aafb-4206-9062-b407908f47d5" />

<img width="1920" height="774" alt="image" src="https://github.com/user-attachments/assets/2be6a536-f3ca-4b92-8608-157bd62ed856" />

<img width="1920" height="1012" alt="image" src="https://github.com/user-attachments/assets/d3f73859-8728-4f6d-af69-587eb081aa40" />
