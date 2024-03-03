using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace bai5
{
    public partial class Form1 : Form
    {
        private string connectionString = ConfigurationManager.ConnectionStrings["bai5"].ConnectionString;

        public Form1()
        {
            InitializeComponent();
            LoadDataFromDB();
        }


        private void LoadDataFromDB()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string query = "SELECT * FROM PHONG"; // Thay YourTableName bằng tên bảng của bạn

                    SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    id.Enabled = true;
                    // Hiển thị dữ liệu lên DataGridView hoặc ListBox
                    dataGridView.DataSource = dataTable; // dataGridView là tên của DataGridView trong giao diện của bạn
                    update.Enabled = false;
                    delete.Enabled = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải dữ liệu từ cơ sở dữ liệu: " + ex.Message);
            }
        }

        private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView.Rows[e.RowIndex];

                // Lấy thông tin từ item được chọn
                string idP = row.Cells["MAP"].Value.ToString();
                string tenP = row.Cells["TENP"].Value.ToString();
                string diaDiem = row.Cells["DIADIEM"].Value.ToString();
                id.Enabled = false;

                // Điền thông tin vào các input trong form
                id.Text = idP;
                nameP.Text = tenP;
                addressP.Text = diaDiem;

                // Vô hiệu hóa các button không liên quan
                add.Enabled = false;
                update.Enabled = true;
                delete.Enabled= true;
            }
        }

        private void add_Click(object sender, EventArgs e)
        {
            // Lấy thông tin từ các input
            string idStr = id.Text.Trim();
            string tenP = nameP.Text.Trim();
            string diaDiem = addressP.Text.Trim();

            // Kiểm tra xem các input đã được điền đầy đủ chưa
            if (string.IsNullOrEmpty(idStr) || string.IsNullOrEmpty(tenP) || string.IsNullOrEmpty(diaDiem))
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin!");
                return;
            }

            // Chuyển đổi ID từ chuỗi sang số nguyên
            if (!int.TryParse(idStr, out int idParsed))
            {
                MessageBox.Show("ID không hợp lệ!");
                return;
            }

            try
                {
                    // Thêm dữ liệu vào cơ sở dữ liệu
                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        connection.Open();

                        string query = "INSERT INTO PHONG (MAP, TENP, DIADIEM) VALUES (@id, @tenP, @diaDiem)";

                        SqlCommand command = new SqlCommand(query, connection);
                        command.Parameters.AddWithValue("@id", idParsed);
                        command.Parameters.AddWithValue("@tenP", tenP);
                        command.Parameters.AddWithValue("@diaDiem", diaDiem);

                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Thêm mới thành công!");
                            LoadDataFromDB(); // Làm mới danh sách hiển thị
                        ClearInputs();
                        }
                        else
                        {
                            MessageBox.Show("Thêm mới không thành công!");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex.Message);
                }
            }
        private void ClearInputs()
        {
            id.Text = "";
            nameP.Text = "";
            addressP.Text = "";
        }

        private void update_Click(object sender, EventArgs e)
        {
            // Lấy thông tin từ các input
            string idStr = id.Text.Trim();
            string tenP = nameP.Text.Trim();
            string diaDiem = addressP.Text.Trim();

            // Kiểm tra xem các input đã được điền đầy đủ chưa
            if (string.IsNullOrEmpty(idStr) || string.IsNullOrEmpty(tenP) || string.IsNullOrEmpty(diaDiem))
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin!");
                return;
            }

            // Chuyển đổi ID từ chuỗi sang số nguyên
            if (!int.TryParse(idStr, out int idParsed))
            {
                MessageBox.Show("ID không hợp lệ!");
                return;
            }

            try
            {
                // Cập nhật thông tin vào cơ sở dữ liệu
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string query = "UPDATE PHONG SET TENP = @tenP, DIADIEM = @diaDiem WHERE MAP = @id";

                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@id", idParsed);
                    command.Parameters.AddWithValue("@tenP", tenP);
                    command.Parameters.AddWithValue("@diaDiem", diaDiem);

                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Cập nhật thành công!");
                        LoadDataFromDB(); // Làm mới danh sách hiển thị
                        ClearInputs(); // Xóa nội dung các input
                        add.Enabled = true;
                        id.Focus();
                    }
                    else
                    {
                        MessageBox.Show("Không có bản ghi nào được cập nhật!");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void delete_Click(object sender, EventArgs e)
        {
            // Kiểm tra xem người dùng đã chọn một bản ghi để xóa chưa
            if (dataGridView.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn một bản ghi để xóa!");
                return;
            }

            // Hiển thị hộp thoại xác nhận từ người dùng
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa bản ghi này không?", "Xác nhận xóa", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                // Lấy ID của bản ghi được chọn
                int id = Convert.ToInt32(dataGridView.SelectedRows[0].Cells["MAP"].Value);

                try
                {
                    // Thực hiện xóa bản ghi từ cơ sở dữ liệu
                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        connection.Open();

                        string query = "DELETE FROM PHONG WHERE MAP = @id";

                        SqlCommand command = new SqlCommand(query, connection);
                        command.Parameters.AddWithValue("@id", id);

                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Xóa thành công!");
                            LoadDataFromDB(); // Làm mới danh sách hiển thị
                            ClearInputs(); // Xóa nội dung các input
                        }
                        else
                        {
                            MessageBox.Show("Không có bản ghi nào được xóa!");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex.Message);
                }
            }

        }

        private void exit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn thoát chương trình không?", "Xác nhận thoát", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                Application.Exit(); // Thoát chương trình
            }
        }
    }
       
}
