using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 哪次不吃壽司
{
    public partial class UCcustomer : UserControl
    {        
        SqlConnectionStringBuilder scsb; 
        string strDBConnectString = "";
        List<int> SearchID = new List<int>(); 

        public UCcustomer()
        {
            InitializeComponent();
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void UCcustomer_Load(object sender, EventArgs e)
        {
            scsb = new SqlConnectionStringBuilder();
            scsb.DataSource = @".";  //伺服器名稱, @字串忽略特殊符號
            scsb.InitialCatalog = "Sushi";   //資料庫名稱
            scsb.IntegratedSecurity = true;  //windows驗證
            strDBConnectString = scsb.ToString();

            comboBox關鍵字搜尋.Items.Add("姓名");  //cm預設帶入
            comboBox關鍵字搜尋.Items.Add("電話");
            comboBox關鍵字搜尋.Items.Add("Email");
            comboBox關鍵字搜尋.SelectedIndex= 0;

            if(GlobalVar.str類別 == "員工")
            {
                comboBox類別.Items.Add("一般會員");
                comboBox類別.SelectedIndex = 0;
            }
            else if (GlobalVar.str類別 == "管理職")
            {
                comboBox類別.Items.Add("一般會員");
                comboBox類別.Items.Add("員工");
                comboBox類別.Items.Add("管理職");
                comboBox類別.SelectedIndex = 0;
            }
            else if (GlobalVar.str類別 == "程式管理員")
            {
                comboBox類別.Items.Add("一般會員");
                comboBox類別.Items.Add("員工");
                comboBox類別.Items.Add("管理職");
                comboBox類別.Items.Add("程式管理員");
                comboBox類別.SelectedIndex = 0;
            }

            MemberData();
        }
        void Clear()
        {
            textName.Clear();
            textPhone.Clear();
            textEmail.Clear();
            textPoints.Clear();
            dtpBirthday.Value = new DateTime(1970,1,1,1,1,1,1);
         
        }

        private void but新增資料_Click(object sender, EventArgs e)
        {
            if ((textName.Text != "") && (textEmail.Text != "") && (textPhone.Text != "") && (textPoints.Text != ""))
            {
                SqlConnection con = new SqlConnection(strDBConnectString);
                con.Open();
                string strSQL = "insert into Member values (@NewName,@NewPhone,@NewEmail,@NewBirth,@NewPoint,@NewType)";
                SqlCommand cmd = new SqlCommand(strSQL,con);

                cmd.Parameters.AddWithValue("@NewName", textName.Text);
                cmd.Parameters.AddWithValue("@NewPhone", textPhone.Text);
                cmd.Parameters.AddWithValue("@NewEmail", textEmail.Text);
                cmd.Parameters.AddWithValue("@NewBirth", dtpBirthday.Value);
                int intPoints = 0;
                Int32.TryParse(textPoints.Text, out intPoints);
                cmd.Parameters.AddWithValue("@NewPoint", intPoints);
                cmd.Parameters.AddWithValue("@NewType", comboBox類別.Text);


                int rows = cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show($"成功新增{rows}筆資料");
                MemberData();
            }
            else
            {
                MessageBox.Show("請將資料輸入完整");
            }
        }

        private void but刪除欄位_Click(object sender, EventArgs e)
        {
            int intID= 0;
            Int32.TryParse(labelIDShow.Text, out intID);
            if (intID>0)
            {
                SqlConnection con = new SqlConnection(strDBConnectString);
                con.Open();
                string strSQL = "delete from Member where id=@DeleteID";
                SqlCommand cmd = new SqlCommand(strSQL,con);
                cmd.Parameters.AddWithValue("@DeleteID", intID);
                int row = cmd.ExecuteNonQuery();
                con.Close();
                Clear();
                MessageBox.Show($"成功刪除{row}筆資料");
                MemberData();
            }
            else
            {
                MessageBox.Show("請選取要刪除的資料");
            }
        }

        private void but資料修改_Click(object sender, EventArgs e)
        {
            int intID = 0;
            Int32.TryParse(labelIDShow.Text, out intID);
            if ((intID > 0) && (textName.Text != "") && (textEmail.Text != "")&&(textPhone.Text!="")&&(textPoints.Text!=""))
                {
                SqlConnection con = new SqlConnection(strDBConnectString);
                con.Open();
                string strSQL = "update Member set 姓名= @NewName,電話=@NewPhone,Email=@NewEmail,會員點數=@NewPoints,類別=@NewRight where id= @SearID" ;
                SqlCommand cmd = new SqlCommand(strSQL, con);
                cmd.Parameters.AddWithValue("@SearID", intID);
                cmd.Parameters.AddWithValue("@NewName", textName.Text);
                cmd.Parameters.AddWithValue("@NewPhone", textPhone.Text);
                cmd.Parameters.AddWithValue("@NewEmail", textEmail.Text);
                int intPoints = 0;
                Int32.TryParse(textPoints.Text, out intPoints);
                cmd.Parameters.AddWithValue("@NewPoints",intPoints);
                cmd.Parameters.AddWithValue("@NewRight", comboBox類別.Text); 

                int rows = cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show($"成功更新{rows}筆資料");
                Clear();
                MemberData();
            }
            else
            {
                MessageBox.Show("請將資料輸入完整");
            }
        }

        private void but清空欄位_Click(object sender, EventArgs e)
        {
            Clear();
        }
        void MemberData()
        {
            SqlConnection con = new SqlConnection(strDBConnectString);
            con.Open();
            string strSQL = "select *from Member";
            SqlCommand cmd = new SqlCommand(strSQL, con);
            SqlDataReader reader = cmd.ExecuteReader();

            if (reader.HasRows) //HasRows(bool)如果有讀到資料
            {
                DataTable dt = new DataTable();
                dt.Load(reader); // DataTable讀取reader匯給DataGridView;只能讀取，不能雙向修改資料
                dgv會員資料列表.DataSource = dt;
            }
            reader.Close();
            con.Close();
        }
        private void dgv會員資料列表_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >=0)
            {
                string strSelectedID = dgv會員資料列表.Rows[e.RowIndex].Cells[0].Value.ToString();
                int intSelectedID = 0;
                bool isID = int.TryParse(strSelectedID, out intSelectedID);
                if (isID==true)
                {
                    SqlConnection con = new SqlConnection(strDBConnectString);
                    con.Open();
                    string strSQL = "select * from Member where id= @SearchID";
                    SqlCommand cmd = new SqlCommand(strSQL, con);
                    cmd.Parameters.AddWithValue("@SearchID", intSelectedID);
                    SqlDataReader reader = cmd.ExecuteReader();


                    if (reader.Read() == true)
                    {
                        labelIDShow.Text = reader["id"].ToString();  //類似陣列reader[資料庫欄位]
                        textName.Text = reader["姓名"].ToString();
                        textPhone.Text = reader["電話"].ToString();
                        textEmail.Text = reader["email"].ToString();
                        dtpBirthday.Value = Convert.ToDateTime(reader["生日"]);
                        textPoints.Text = reader["會員點數"].ToString();
                        comboBox類別.Text= reader["類別"].ToString() ;

                    }
                }
            }
        }

        private void but關鍵字搜尋_Click(object sender, EventArgs e)
        {
            listBox搜尋結果.Items.Clear();
            SearchID.Clear();
            string strKeyword = comboBox關鍵字搜尋.SelectedItem.ToString(); //combobox關鍵字
            if (textBox關鍵字搜尋.Text !="")
            {
                SqlConnection con = new SqlConnection(strDBConnectString);
                con.Open();
                string strSQL = "select * from Member where " + strKeyword + " like @SearchKeyWord and @BirthStart<=生日 and @BirthEnd>=生日";
                SqlCommand cmd = new SqlCommand(strSQL, con);
                cmd.Parameters.AddWithValue("@SearchKeyWord", "%"+ textBox關鍵字搜尋.Text+"%");
                cmd.Parameters.AddWithValue("@BirthStart",dtpFrom.Value);
                cmd.Parameters.AddWithValue("@BirthEnd",dtpTo.Value);
                SqlDataReader reader= cmd.ExecuteReader();

                int i = 0; //為了讀很多筆
                while(reader.Read()==true)
                {
                    SearchID.Add((int)reader["id"]);
                    //listBox搜尋結果.Items.Add($"{(int)reader["id"]} {reader["姓名"].ToString()} {reader["電話"].ToString()} {reader["Email"].ToString()} {reader["類別"].ToString()}");
                    listBox搜尋結果.Items.Add($" {reader["姓名"].ToString()} {reader["電話"].ToString()} {reader["Email"].ToString()}");
                    i++;
                }
                if (i<=0)
                {
                    MessageBox.Show("查無此人");
                }
                reader.Close();
                con.Close();
            }
            else
            {
                MessageBox.Show("請輸入關鍵字");
            }
        }

        private void listBox搜尋結果_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox搜尋結果.SelectedIndex>=0)  //0代表第一個
            {
                int intSelectedID = SearchID[listBox搜尋結果.SelectedIndex];
                SqlConnection con = new SqlConnection(strDBConnectString);
                con.Open();
                string strSQL = "select * from Member where id =@SearchID ";
                SqlCommand cmd = new SqlCommand(strSQL,con);
                cmd.Parameters.AddWithValue("@SearchID", intSelectedID);
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read()==true)
                {
                    labelIDShow.Text = reader["id"].ToString(); 
                    textName.Text = reader["姓名"].ToString();
                    textPhone.Text = reader["電話"].ToString();
                    textEmail.Text = reader["email"].ToString();
                    dtpBirthday.Value = Convert.ToDateTime(reader["生日"]);  //生日需 Convert.ToDateTime
                    textPoints.Text = reader["會員點數"].ToString();
                    comboBox類別.Text = reader["類別"].ToString() ;
                }
                else
                {
                    MessageBox.Show("查無此人");
                    Clear();  
                }
            }
        }
    }
}
