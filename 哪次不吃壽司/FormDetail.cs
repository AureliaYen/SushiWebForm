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

namespace 哪次不吃壽司
{
    public partial class FormDetail : Form
    {
        public int PID = 0; //public為了從外面傳東西進來 
        string strMyDBConnection = "";
        string image_dir = @"全部壽司\";
        string image_name = "";
        bool is修改圖檔 = false;

        public FormDetail()
        {
            InitializeComponent();
        }

        private void FormDetail_Load(object sender, EventArgs e)
        {
            SqlConnectionStringBuilder scsb = new SqlConnectionStringBuilder();
            scsb.DataSource = @".";
            scsb.InitialCatalog = "Sushi";
            scsb.IntegratedSecurity = true;
            strMyDBConnection = scsb.ToString();

            if (PID > 0)
            {
                //修改模式
                groupBox修改.Visible = true;
                groupBox新增.Visible = false;
                顯示商品詳細資訊();
            }
            else
            {
                //新增模式
                groupBox新增.Visible = true;
                groupBox修改.Visible = false;
            }
        }
        void 顯示商品詳細資訊()  //為了form1點及圖片時可以跳到商品詳細資訊
        {
            SqlConnection con = new SqlConnection(strMyDBConnection);
            con.Open();
            string strSQL = "select *from Products where pid = @SearchID ";
            SqlCommand cmd = new SqlCommand(strSQL, con);
            cmd.Parameters.AddWithValue("@SearchID", PID);
            SqlDataReader reader = cmd.ExecuteReader();

            int i = 0;
            while (reader.Read())
            {
                labelID.Text = reader["pid"].ToString();
                textBox商品名稱.Text = reader["pname"].ToString();
                textBox商品價格.Text = reader["price"].ToString();
                textBox商品描述.Text = reader["pdesc"].ToString();
                image_name = reader["pimage"].ToString();
                pictureBox商品圖檔.Image = Image.FromFile(image_dir + image_name);
                i++;
            }
            reader.Close();
            con.Close();
            Console.WriteLine($"查詢{i}筆資料");
        }
        private void but選取圖片_Click(object sender, EventArgs e)
        {
            OpenFileDialog f = new OpenFileDialog();  //檔案開啟對話框
            f.Filter = "檔案類型(*jpg, *jpge, *png)|*jpg; *jpge; *png"; //過濾器描述|過濾器語法
            DialogResult R = f.ShowDialog();

            if (R == DialogResult.OK)
            {
                pictureBox商品圖檔.Image = Image.FromFile(f.FileName); //指定使用者圖檔到pictureBox商品圖檔;(f.FileName)為使用者檔案名稱
                string fileExtension = System.IO.Path.GetExtension(f.SafeFileName);//SafeFileName不包含目錄
                Random myRand = new Random();  //亂數檔名
                image_name = DateTime.Now.ToString("yyyyMMddHHmmss") + myRand.Next
                    (1000, 10000).ToString() + fileExtension;
                is修改圖檔 = true;
                Console.WriteLine(image_name);
            }
        }
        private void but儲存修改_Click(object sender, EventArgs e)
        {

            if ((textBox商品名稱.Text != "") && (textBox商品價格.Text != "") && (textBox商品描述.Text != ""))
            {
                if (is修改圖檔 == true) //判斷圖檔是否修改
                {
                    pictureBox商品圖檔.Image.Save(image_dir + image_name);
                    is修改圖檔 = false;
                }
                SqlConnection con = new SqlConnection(strMyDBConnection);
                con.Open();
                string strSQL = "update Products set pname=@NewPname, price=@NewPrice,  pdesc=@NewPdesc, pimage=@NewPimage where pid= @SearchID";
                SqlCommand cmd = new SqlCommand(strSQL, con);
                cmd.Parameters.AddWithValue("@SearchID", PID);
                cmd.Parameters.AddWithValue("@NewPname", textBox商品名稱.Text);
                int intPrice = 0;
                Int32.TryParse(textBox商品價格.Text, out intPrice);
                cmd.Parameters.AddWithValue("@NewPrice", intPrice);
                cmd.Parameters.AddWithValue("@NewPdesc", textBox商品描述.Text);
                cmd.Parameters.AddWithValue("@NewPimage", image_name);
                int rows = cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("儲存成功");
            }
            else
            {
                MessageBox.Show("請將所有欄位填妥");
            }
        }

        private void but清空欄位_Click(object sender, EventArgs e)
        {
            labelID.Text = "";
            textBox商品價格.Text = "";
            textBox商品名稱.Text = "";
            textBox商品描述.Text = "";
            pictureBox商品圖檔.Image = null;


        }

        private void but儲存圖片_Click(object sender, EventArgs e)
        {
            if ((textBox商品名稱.Text != "") && (textBox商品價格.Text != "") && (textBox商品描述.Text != ""))
            {
                if (is修改圖檔 == true) //判斷圖檔是否修改
                {
                    pictureBox商品圖檔.Image.Save(image_dir + image_name);
                    is修改圖檔 = false;
                }
                SqlConnection con = new SqlConnection(strMyDBConnection);
                con.Open();
                string strSQL = "insert into Products values (@NewPname,@NewPrice,@NewPdesc,@NewPimage);";
                SqlCommand cmd = new SqlCommand(strSQL, con);
                cmd.Parameters.AddWithValue("@NewPname", textBox商品名稱.Text);
                int intPrice = 0;
                Int32.TryParse(textBox商品價格.Text, out intPrice);
                cmd.Parameters.AddWithValue("@NewPrice", intPrice);
                cmd.Parameters.AddWithValue("@NewPdesc", textBox商品描述.Text);
                cmd.Parameters.AddWithValue("@NewPimage", image_name);
                int rows = cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("儲存成功");


            }
            //insert into products
            else
            {
                MessageBox.Show("請將所有欄位填妥");
            }
        }

    }
}
