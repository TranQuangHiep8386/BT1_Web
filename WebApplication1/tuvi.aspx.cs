using System;
using System.Globalization;

namespace WebApplication1
{
    public partial class tuvi : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnXem_Click(object sender, EventArgs e)
        {
            string name = txtName.Text.Trim();
            string gender = ddlGender.SelectedValue;
            DateTime dob;

            if (name == "")
            {
                litResult.Text = "<div class='output'>Vui lòng nhập họ tên.</div>";
                return;
            }

            if (!DateTime.TryParseExact(txtDob.Text, "dd/MM/yyyy",
                CultureInfo.InvariantCulture, DateTimeStyles.None, out dob))
            {
                litResult.Text = "<div class='output'>Ngày sinh không hợp lệ. Vui lòng nhập theo định dạng dd/MM/yyyy.</div>";
                return;
            }

            // Ví dụ kết quả tạm thời
            litResult.Text = $"<div class='output'>Xin chào <b>{name}</b> ({gender}), sinh ngày {dob:dd/MM/yyyy}.<br/>Chúc bạn một ngày tốt lành!</div>";
        }
    }
}
