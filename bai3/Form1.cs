using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bai3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            string[] items = { "Nội soi", "Siêu âm", "X-quang", "Thử máu" };
            service.Items.AddRange(items);
        }
        private void service_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (service.SelectedIndex != -1 && !selected.Items.Contains(service.SelectedItem))
            {
                // Thêm mục đã chọn vào ListBox thứ hai
                selected.Items.Add(service.SelectedItem);
            }
        }
        private bool IsValidDate(string ngay, string thang, string nam)
        {
            int ngayValue, thangValue, namValue;

            // Kiểm tra xem các giá trị có phải là số nguyên không âm không
            if (!int.TryParse(ngay, out ngayValue) || ngayValue <= 0 ||
                !int.TryParse(thang, out thangValue) || thangValue <= 0 ||
                !int.TryParse(nam, out namValue) || namValue <= 0)
            {
                return false;
            }

            // Kiểm tra xem ngày và tháng có hợp lệ không
            if (thangValue < 1 || thangValue > 12 || ngayValue < 1 || ngayValue > DateTime.DaysInMonth(namValue, thangValue))
            {
                return false;
            }

            // Nếu không có vấn đề gì, ngày tháng năm là hợp lệ
            return true;
        }
        private void choose_Click(object sender, EventArgs e)
        {
            string ten = name.Text;
            string ngay = day.Text;
            string thang = month.Text;
            string nam = year.Text;
            ListBox.ObjectCollection items = selected.Items;
            // Tạo một chuỗi để lưu trữ danh sách các dịch vụ đã chọn
            string message = "";

            // Kiểm tra xem tên không được để trống và ngày, tháng, năm hợp lệ
            if (!string.IsNullOrEmpty(ten) && IsValidDate(ngay, thang, nam))
            {
                // Kiểm tra xem danh sách các dịch vụ đã chọn có rỗng không
                if (items.Count > 0)
                {
                    // Duyệt qua danh sách các dịch vụ đã chọn
                    foreach (var item in items)
                    {
                        // Kiểm tra xem item có phải là phần tử cuối cùng không
                        if (item.Equals(items[items.Count - 1]))
                        {
                            // Nếu là phần tử cuối cùng, không thêm dấu phẩy
                            message += item.ToString();
                        }
                        else
                        {
                            message += item.ToString() + ", ";
                        }
                    }
                    richResult.Text = $"Họ tên: {ten}\nNgày khám: {ngay}/{thang}/{nam}\nDịch vụ khám: {message}";
                }
                else
                {
                    MessageBox.Show("Vui lòng chọn dịch vụ.");
                }
            }
            else
            {
                MessageBox.Show("Vui lòng nhập thông tin hợp lệ.");
            }
        }

        private void continu_Click(object sender, EventArgs e)
        {
            // Khởi tạo lại các ô nhập liệu
            name.Text = "";
            day.Text = "";
            month.Text = "";
            year.Text = "";

            // Xóa danh sách chọn trong ListBox
            selected.Items.Clear();
        }

        private void exit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn thoát khỏi ứng dụng không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            // Kiểm tra xem người dùng đã chọn Yes hay No
            if (result == DialogResult.Yes)
            {
                // Thoát ứng dụng
                Application.Exit();
            }
        }
    }
}
