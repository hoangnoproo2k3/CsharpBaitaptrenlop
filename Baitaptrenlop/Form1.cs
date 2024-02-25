using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Baitaptrenlop
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            result.ReadOnly = true;
            result.TabStop = false;
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn thoát khỏi ứng dụng không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            // Kiểm tra xem người dùng đã chọn Yes hay No
            if (result == DialogResult.Yes)
            {
                // Thoát ứng dụng
                Application.Exit();
            }
        }

        private void perform_Click(object sender, EventArgs e)
        {
            int number1, number2, number3;
            if (!int.TryParse(a.Text, out number1) ||
                !int.TryParse(b.Text, out number2) ||
                !int.TryParse(c.Text, out number3))
            {
                MessageBox.Show("Vui lòng nhập các số nguyên hợp lệ vào các ô textbox.");
                return;
            }

            // Tìm số lớn nhất
            int maxNumber = Math.Max(Math.Max(number1, number2), number3);

            // Hiển thị số lớn nhất trong ô kết quả
            result.Text = "Số lớn nhất là: " + maxNumber.ToString();
            result.ReadOnly = true;
        }

        private void continu_Click(object sender, EventArgs e)
        {
            // Xóa dữ liệu trong các ô TextBox
            a.Text = "";
            b.Text = "";
            c.Text = "";

            // Reset dữ liệu trong ô kết quả (nếu cần)
            result.Text = "";

            // Đặt focus vào ô TextBox đầu tiên (nếu cần)
            a.Focus();
        }
    }
}
