using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bai2._1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            // Thêm các mục vào ListBox
            LoadPublishers();
        }
        private void LoadPublishers()
        {
            // Thêm các nhà xuất bản vào ListBox
            listNXB.Items.Add("Nhà xuất bản A");
            listNXB.Items.Add("Nhà xuất bản B");
            listNXB.Items.Add("Nhà xuất bản C");
            listNXB.Items.Add("Nhà xuất bản D");
        }
        private void listNXB_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void bill_Click(object sender, EventArgs e)
        {
            // Kiểm tra và lấy dữ liệu từ các ô nhập liệu
            string tenSach = name.Text;
            int soLuong;
            double donGia;

            if (!int.TryParse(num.Text, out soLuong) || soLuong <= 0)
            {
                MessageBox.Show("Vui lòng nhập số lượng là số nguyên dương.");
                return;
            }

            if (!double.TryParse(price.Text, out donGia) || donGia <= 0)
            {
                MessageBox.Show("Vui lòng nhập đơn giá là số dương.");
                return;
            }

            // Kiểm tra xem có nhà xuất bản nào được chọn không
            if (listNXB.SelectedIndex == -1)
            {
                MessageBox.Show("Vui lòng chọn nhà xuất bản.");
                return;
            }

            // Lấy tên nhà xuất bản được chọn
            string nhaXuatBan = listNXB.SelectedItem.ToString();

            // Tính tổng tiền phải trả và thuế VAT
            double tongTien = soLuong * donGia;
            double thueVAT = tongTien * 0.1;
            double tongTienPhaiTra = tongTien + thueVAT;
            sum.Text = tongTien.ToString();
            vat.Text = thueVAT.ToString();
            // Hiển thị kết quả
            string message = $"Bạn đã mua sách: {tenSach}\nSố lượng: {soLuong}\nĐơn giá: {donGia}\nNhà xuất bản: {nhaXuatBan}\nTổng tiền phải trả: {tongTien}\nThuế VAT (10%): {thueVAT}\nTổng tiền sau thuế: {tongTienPhaiTra}";
            MessageBox.Show(message, "Kết quả");
        }
    }
}
