using System;
using System.Drawing;
using System.Windows.Forms;
using TuViLib;

namespace TuViWinForm
{
    public partial class Form1 : Form
    {
        TextBox txtName;
        DateTimePicker dtpDob;
        ComboBox cbGender;
        Button btnXem;
        TextBox txtOutput;

        public Form1()
        {
            this.Text = "Xem Tử Vi";
            this.Size = new Size(500, 400);

            Label lbl1 = new Label();
            lbl1.Text = "Họ tên:";
            lbl1.Location = new Point(20, 20);
            this.Controls.Add(lbl1);

            txtName = new TextBox();
            txtName.Location = new Point(100, 20);
            txtName.Width = 300;
            this.Controls.Add(txtName);

            Label lbl2 = new Label();
            lbl2.Text = "Ngày sinh:";
            lbl2.Location = new Point(20, 60);
            this.Controls.Add(lbl2);

            dtpDob = new DateTimePicker();
            dtpDob.Format = DateTimePickerFormat.Short;
            dtpDob.Location = new Point(100, 60);
            this.Controls.Add(dtpDob);

            Label lbl3 = new Label();
            lbl3.Text = "Giới tính:";
            lbl3.Location = new Point(20, 100);
            this.Controls.Add(lbl3);

            cbGender = new ComboBox();
            cbGender.Items.AddRange(new string[] { "Nam", "Nữ", "Khác" });
            cbGender.Location = new Point(100, 100);
            this.Controls.Add(cbGender);

            btnXem = new Button();
            btnXem.Text = "Xem tử vi";
            btnXem.Location = new Point(100, 140);
            btnXem.Click += new EventHandler(BtnXem_Click);
            this.Controls.Add(btnXem);

            txtOutput = new TextBox();
            txtOutput.Location = new Point(20, 180);
            txtOutput.Size = new Size(440, 150);
            txtOutput.Multiline = true;
            txtOutput.ScrollBars = ScrollBars.Vertical;
            this.Controls.Add(txtOutput);
        }

        void BtnXem_Click(object sender, EventArgs e)
        {
            string name = txtName.Text.Trim();
            string gender = cbGender.Text;
            DateTime dob = dtpDob.Value;

            if (name == "")
            {
                MessageBox.Show("Vui lòng nhập tên.");
                return;
            }

            string report = TuViCalculator.GetReport(name, dob, gender);
            txtOutput.Text = report;
        }
    }
}