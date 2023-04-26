using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 哪次不吃壽司
{
    public partial class FormLogin : Form
    {
        Form1 myForm = new Form1();
        SqlConnectionStringBuilder scsb;
        string strDBConnectionString = "";
        public static bool isVertified = false;
        public FormLogin()
        {
            InitializeComponent();
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {
            SqlConnectionStringBuilder scsb = new SqlConnectionStringBuilder();
            scsb.DataSource = @".";
            scsb.InitialCatalog = "Sushi";
            scsb.IntegratedSecurity = true;
            strDBConnectionString = scsb.ToString();
        }

        private void butLogin_Click(object sender, EventArgs e)
        {
            if ((textBoxName.Text != "") && (textBoxPassword.Text != ""))
            {

                SqlConnection con = new SqlConnection(strDBConnectionString);
                con.Open();
                string strSQL = "select * from Member where Email= @strAccount and 電話 = @strPassword";
                SqlCommand cmd = new SqlCommand(strSQL, con);
                cmd.Parameters.AddWithValue("@strAccount", textBoxName.Text);
                cmd.Parameters.AddWithValue("@strPassword", textBoxPassword.Text);
                SqlDataReader reader = cmd.ExecuteReader();


                if (reader.Read() == true)
                {
                    textBoxName.Text = reader["Email"].ToString();
                    textBoxPassword.Text = reader["電話"].ToString();
                    GlobalVar.isVertified = true;        
                    GlobalVar.memberID = (int)reader["id"];
                    GlobalVar.str類別 = reader["類別"].ToString();
                    GlobalVar.str登入姓名 = reader["姓名"].ToString();

                    myForm.ShowDialog();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("帳號輸入錯誤");
                }
                reader.Close();
                con.Close();
            }
            else
            {
                MessageBox.Show("請輸入帳號密碼");
            }
        }

        private void labelEnroll_Click(object sender, EventArgs e)
        {
            FormEnroll myFormEnroll= new FormEnroll();
            myFormEnroll.ShowDialog();
        }
    }
}
