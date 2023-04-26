using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Runtime.CompilerServices;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace 哪次不吃壽司
{
    public partial class UCorderModify : UserControl
    {
        SqlConnectionStringBuilder scsb;
        string strDBConnectString = "";
        List<int> SearchID = new List<int>();

        public UCorderModify()
        {
            InitializeComponent();
        }

        private void UCorderModify_Load(object sender, EventArgs e)
        {
            scsb = new SqlConnectionStringBuilder();
            scsb.DataSource = @".";  //伺服器名稱, @字串忽略特殊符號
            scsb.InitialCatalog = "Sushi";   //資料庫名稱
            scsb.IntegratedSecurity = true;  //windows驗證
            strDBConnectString = scsb.ToString();
            訂單維護表Data();
            
        }
        void 訂單維護表Data ()
        {
            SqlConnection con = new SqlConnection(strDBConnectString);
            con.Open();
            string strSQL = "select *from OrderHistory";
            SqlCommand cmd = new SqlCommand(strSQL, con);
            SqlDataReader reader = cmd.ExecuteReader();


            if (reader.HasRows) //HasRows(bool)如果有讀到資料
            {
                DataTable dt = new DataTable();
                dt.Load(reader); // DataTable讀取reader匯給DataGridView;只能讀取，不能雙向修改資料
                dgvOrder.DataSource = dt;


            }
            reader.Close();
            con.Close();
        }
        void Clear()
        {
            textBoxProductName.Text = "";
            textBoxProductPrice.Clear();
            textBoxProductAmount.Clear();

        }

        private void dgvOrder_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex>=0)
            {
                string strOrderID = dgvOrder.Rows[e.RowIndex].Cells[0].Value.ToString();
                int intOrderID = 0;
                bool isID = int.TryParse(strOrderID, out intOrderID);
                if (isID == true)
                {
                    SqlConnection con = new SqlConnection(strDBConnectString);
                    con.Open();
                    string strSQL = "select * from OrderHistory where 訂單編號 =@OrderID";
                    SqlCommand cmd = new SqlCommand(strSQL, con);
                    cmd.Parameters.AddWithValue("@OrderID", intOrderID);
                    SqlDataReader reader = cmd.ExecuteReader();

                    if (reader.Read()==true)
                    {

                        textBoxOrderID.Text = reader["訂單編號"].ToString();
                        labelID.Text = reader["會員ID"].ToString();
                        labelnName.Text = reader["會員名稱"].ToString();
                        textBoxProductName.Text = reader["商品名稱"].ToString();
                        textBoxProductPrice.Text = reader["商品價格"].ToString();
                        textBoxProductAmount.Text = reader["商品數量"].ToString();
                        labelTime.Text = reader["訂購時間"].ToString();
                    }
                }

            }

        }

        private void but儲存修改_Click(object sender, EventArgs e)
        {
            int intOrderID = 0;
            Int32.TryParse(textBoxOrderID.Text, out intOrderID);
            if ((textBoxOrderID.Text!="")&&(labelID.Text!="")&&(labelnName.Text!="")&&(textBoxProductName.Text!="")&&(textBoxProductPrice.Text!="")&&(textBoxProductAmount.Text!="")&&(labelTime.Text!=""))
            {
                SqlConnection con = new SqlConnection(strDBConnectString);
                con.Open();
                string strSQL = "update OrderHistory set 商品名稱=@NewProductName, 商品價格=@NewPrice, 商品數量=@NewAmount where 訂單編號=@SearchID";
                SqlCommand cmd = new SqlCommand(strSQL, con);
                cmd.Parameters.AddWithValue("@SearchID", intOrderID);
                cmd.Parameters.AddWithValue("@NewProductName", textBoxProductName.Text);
                cmd.Parameters.AddWithValue("@NewPrice", textBoxProductPrice.Text);
                cmd.Parameters.AddWithValue("@NewAmount", textBoxProductAmount.Text);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("更新成功");
                Clear();
                訂單維護表Data();
            }
            else
            {
                MessageBox.Show("請將資料輸入完整");
            }
        }


        private void but刪除訂單_Click(object sender, EventArgs e)
        {
            int intID = 0;
            Int32.TryParse(textBoxOrderID.Text, out intID);
            if (intID > 0)
            {
                SqlConnection con = new SqlConnection(strDBConnectString);
                con.Open();
                string strSQL = "delete from OrderHistory where 訂單編號 =@DeleteID";
                SqlCommand cmd = new SqlCommand(strSQL, con);
                cmd.Parameters.AddWithValue("@DeleteID", intID);
                cmd.ExecuteNonQuery();
                con.Close();
                Clear();
                訂單維護表Data();
            }
            else
            {
                MessageBox.Show("請選取要刪除的資料");
            }

        }

        private void butOrderSearch_Click(object sender, EventArgs e)
        {
            int intID = 0;
            Int32.TryParse(textBoxOrderID.Text, out intID);

            if (textBoxOrderID.Text!="")
            {
                SqlConnection con = new SqlConnection(strDBConnectString);
                con.Open();
                string strSQL = "select * from OrderHistory where 訂單編號=@SearchID";
                SqlCommand cmd = new SqlCommand(strSQL, con);
                cmd.Parameters.AddWithValue("@SearchID",intID);
                SqlDataReader reader = cmd.ExecuteReader();
                if(reader.Read()==true)
                {
                    labelID.Text = reader["會員ID"].ToString();
                    labelnName.Text = reader["會員名稱"].ToString();
                    textBoxProductName.Text = reader["商品名稱"].ToString();
                    textBoxProductPrice.Text = reader["商品價格"].ToString();
                    textBoxProductAmount.Text = reader["商品數量"].ToString();
                    labelTime.Text = reader["訂購時間"].ToString();
                }
                else
                {
                    MessageBox.Show("查無此訂單");
                    Clear();
                }
            }
        }

        private void but重新載入_Click(object sender, EventArgs e)
        {
            訂單維護表Data();
        }
    }

}
