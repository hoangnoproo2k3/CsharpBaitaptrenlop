using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bai2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Text = "Điểm tuyển sinh";
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

        private void perform_Click(object sender, EventArgs e)
        {
            string hoTen = name.Text;
            double diemToan, diemLy, diemHoa;

            // Kiểm tra và chuyển đổi dữ liệu thành số nguyên
            if (!double.TryParse(math.Text, out diemToan) ||
                !double.TryParse(physics.Text, out diemLy) ||
                !double.TryParse(chemistry.Text, out diemHoa))
            {
                MessageBox.Show("Vui lòng nhập điểm hợp lệ (số từ 0 đến 10).");
                return;
            }

            // Kiểm tra dữ liệu nhập vào trong khoảng từ 0 đến 10
            if (diemToan < 0 || diemToan > 10 ||
                diemLy < 0 || diemLy > 10 ||
                diemHoa < 0 || diemHoa > 10)
            {
                MessageBox.Show("Vui lòng nhập điểm trong khoảng từ 0 đến 10.");
                return;
            }

            // Tính tổng điểm
            double tongDiem = diemToan + diemLy + diemHoa;
            num.ForeColor = Color.Red;
            num.Text = tongDiem.ToString();
            // Hiển thị thông tin kết quả
            string ketQua = tongDiem >= 21 ? "Đỗ" : "Trượt";
            //txtresult.Text = $"Họ tên: {hoTen}\nTổng điểm: {tongDiem}\nKết quả: {ketQua}";
            richresult.ForeColor = Color.Blue ;
            richresult.Text = $"Họ tên: {hoTen}\nTổng điểm: {tongDiem}\nKết quả: {ketQua}";
        }
    }
}
