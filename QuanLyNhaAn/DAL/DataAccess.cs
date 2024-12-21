using Microsoft.Data.SqlClient;
using PhanMemBaoCom.DTO;
using System.Data;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;
namespace PhanMemBaoCom.DAL
{
    public class DataAccess
    {
        private SqlConnection cn;

        public SqlConnection open()
        {
            Connection helper = new Connection();
            SqlConnection connection = helper.GetConnect();
            connection.Open();
            return connection;
        }

        public void close()
        {
            if (cn != null && cn.State == ConnectionState.Open)
            {
                cn.Close();
                cn.Dispose();
            }
        }

        //Dung cho chuc nang insert,update, delete return so dong
        public int ExecuteCommandText(SqlCommand cmd)
        {
                return cmd.ExecuteNonQuery();
        }

        //dung cho cac cau lenh count,sum,maximum, hoặc 1 trường duy nhất
        public string ExecuteScalar(string query, SqlConnection cn)
        {
                SqlCommand cmd = new SqlCommand(query, cn);
                return cmd.ExecuteScalar()?.ToString();
        }

        //dùng để select ra bảng dữ liệu. Truoc khi query cần gọi open và khi querry xong cần close
        public SqlDataReader ExecuteQuery(string query, SqlConnection cn)
        {
            try
            {
                SqlCommand cmd = new SqlCommand(query, cn);

                SqlDataReader reader = cmd.ExecuteReader();
                return reader;
            }
            catch (Exception ex)
            {
                throw new Exception("Error executing query: " + ex.Message);
            }
        }

        //public bool CheckExist(string tableName, string columnName, string value)
        //{
        //    string query = $"SELECT COUNT(*) FROM {tableName} WHERE {columnName} = '{value}'";
        //    return ExecuteScalar(query) != "0";
        //}

        public string ExportToExcel(DataGridView dt, string pathname, string formName = null)
        {
            try
            {
                if (dt == null || dt.Columns.Count == 0) return "No data to export.";

                Excel.Application excelApp = new Excel.Application();
                Excel.Workbook workbook = excelApp.Workbooks.Add();
                Excel._Worksheet worksheet = (Excel._Worksheet)workbook.Sheets[1];

                if (!string.IsNullOrEmpty(formName))
                {
                    worksheet.get_Range("A1", "Z1").Merge(false);
                    worksheet.get_Range("A1").Value = formName;
                }

                for (int i = 0; i < dt.Columns.Count; i++)
                {
                    worksheet.Cells[1, i + 1] = dt.Columns[i].HeaderText;
                }

                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    for (int j = 0; j < dt.Columns.Count; j++)
                    {
                        worksheet.Cells[i + 2, j + 1] = dt.Rows[i].Cells[j].Value?.ToString();
                    }
                }

                workbook.SaveAs(pathname);
                workbook.Close();
                excelApp.Quit();
                return "Export successful!";
            }
            catch (Exception ex)
            {
                return "Error: " + ex.Message;
            }
        }

    }
}
