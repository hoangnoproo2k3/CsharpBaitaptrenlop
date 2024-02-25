using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bai4
{
    public partial class MainForm : Form
    {
        private SqlConnection connection;
        private string connectionString = "Data Source=HOANGPROO\\SQLEXPRESS;Initial Catalog=Contacts;Integrated Security=True;Encrypt=False";
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            // Hiển thị thông tin của các sách trên DataGridView
            DisplayBooks();
            // Vô hiệu hóa các TextBox
            DisableTextBoxes();

            // Vô hiệu hóa các nút Lưu, Xóa, Bỏ qua
            save.Enabled = false;
            delete.Enabled = false;
            skip.Enabled = false;
        }
        private void DisplayBooks()
        {
            // Code để hiển thị thông tin của các sách trên DataGridView
            try
            {
                connection = new SqlConnection(connectionString);
                connection.Open();

                string query = "SELECT Masach, Tieude, Dongia, Soluong FROM SACH";
                SqlCommand command = new SqlCommand(query, connection);
                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    DataTable dataTable = new DataTable();
                    dataTable.Load(reader);
                    listData.DataSource = dataTable;
                }

                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi: " + ex.Message);
            }
            finally
            {
                if (connection.State == ConnectionState.Open)
                {
                    connection.Close();
                }
            }

        }
        private void listData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                //EnableTextBoxes();

                DataGridViewRow row = listData.Rows[e.RowIndex];

                // Lấy giá trị từ các cột trong hàng được chọn
                id.Text = row.Cells["Masach"].Value.ToString();
                title.Text = row.Cells["Tieude"].Value.ToString();
                price.Text = row.Cells["Dongia"].Value.ToString();
                num.Text = row.Cells["Soluong"].Value.ToString();

                // Hiển thị thông tin lên các TextBox
                //id.Text = masach;
                //title.Text = tieude;
                //price.Text = dongia;
                //num.Text = soluong;

                // Kích hoạt các nút cần thiết
                save.Enabled = false;
                delete.Enabled = true;
                skip.Enabled = false;
            }

        }
        private void EnableTextBoxes()
        {
            id.Enabled = true;
            title.Enabled = true;
            price.Enabled = true;
            num.Enabled = true;
        }

        private void DisableTextBoxes()
        {
            id.Enabled = false;
            title.Enabled = false;
            price.Enabled = false;
            num.Enabled = false;
        }
        private bool IsValidData()
        {
            // Kiểm tra xem các TextBox có dữ liệu hợp lệ không
            if (string.IsNullOrWhiteSpace(id.Text) ||
                string.IsNullOrWhiteSpace(title.Text) ||
                string.IsNullOrWhiteSpace(price.Text) ||
                string.IsNullOrWhiteSpace(num.Text))
            {
                return false;
            }

            // Kiểm tra xem các giá trị có thể chuyển đổi sang kiểu dữ liệu cần thiết không
            decimal dongia;
            int soluong;
            if (!decimal.TryParse(price.Text, out dongia) ||
                !int.TryParse(num.Text, out soluong))
            {
                return false;
            }

            return true;
        }
        private void add_Click(object sender, EventArgs e)
        {
            EnableTextBoxes();
            // Kích hoạt các nút cần thiết
            add.Enabled = false;
            save.Enabled = true;
            delete.Enabled = false;
            skip.Enabled = true;
        }

        private void save_Click(object sender, EventArgs e)
        {
            //Kiểm tra xem các TextBox có dữ liệu hợp lệ không
            if (!IsValidData())
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin vào các trường.");
                return;
            }

            try
            {
                // Tạo câu lệnh SQL INSERT
                string query = "INSERT INTO SACH (Masach, Tieude, Dongia, Soluong) VALUES (@Masach, @Tieude, @Dongia, @Soluong)";

                // Tạo kết nối đến cơ sở dữ liệu
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    //if (!IsValidData())
                    //{
                    //    MessageBox.Show("Vui lòng điền đầy đủ thông tin vào các trường.");
                    //    return;
                    //}
                    // Tạo đối tượng SqlCommand và thiết lập các tham số
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Masach", id.Text);
                        command.Parameters.AddWithValue("@Tieude", title.Text);
                        command.Parameters.AddWithValue("@Dongia", price.Text);
                        command.Parameters.AddWithValue("@Soluong", num.Text);

                        // Thực thi câu lệnh INSERT
                        int rowsAffected = command.ExecuteNonQuery();
                        RefreshDataGridView();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Thêm mới sách thành công.");
                        }
                        else
                        {
                            MessageBox.Show("Thêm mới sách không thành công.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi: " + ex.Message);
            }
        }
        private void RefreshDataGridView()
        {
            try
            {
                // Xóa các dữ liệu cũ từ DataGridView
                listData.DataSource = null;

                // Tạo câu lệnh SQL SELECT để lấy lại dữ liệu từ cơ sở dữ liệu
                string query = "SELECT Masach, Tieude, Dongia, Soluong FROM SACH";

                // Tạo kết nối đến cơ sở dữ liệu
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    // Tạo đối tượng SqlDataAdapter để lấy dữ liệu từ cơ sở dữ liệu
                    using (SqlDataAdapter adapter = new SqlDataAdapter(query, connection))
                    {
                        // Tạo một đối tượng DataTable để lưu trữ dữ liệu
                        DataTable dataTable = new DataTable();

                        // Đổ dữ liệu từ SqlDataAdapter vào DataTable
                        adapter.Fill(dataTable);

                        // Đặt DataTable làm nguồn dữ liệu cho DataGridView
                        listData.DataSource = dataTable;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi: " + ex.Message);
            }
        }

    }
}
