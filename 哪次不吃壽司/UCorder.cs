using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace 哪次不吃壽司
{
    public partial class UCorder : UserControl
    {
        SqlConnectionStringBuilder scsb;
        string strDBConnectionString = "";
        List<string> listPname = new List<string>();
        List<int> listPrice = new List<int>();
        List<int> listPID = new List<int>();
        int intAdd = 0;
        bool isAdd = false;



        public UCorder()
        {
            InitializeComponent();
        }
        private void UCorder_Load(object sender, EventArgs e)
        {
            SqlConnectionStringBuilder scsb = new SqlConnectionStringBuilder();
            scsb.DataSource = @".";
            scsb.InitialCatalog = "Sushi";
            scsb.IntegratedSecurity = true;
            strDBConnectionString = scsb.ToString();
            全部壽司();
            listview圖片();
            if (GlobalVar.str類別!="一般會員")
            {
                but重新載入.Visible= true;
                pictureBoxbot.Visible= false;
            }

            listViewOrderList.View = View.Details;  //列表模式
            listViewOrderList.Columns.Add("商品名稱", 140);
            listViewOrderList.Columns.Add("價格", 60);
            listViewOrderList.Columns.Add("數量", 60);
            listViewOrderList.FullRowSelect = true;  //全列選擇
            listViewOrderList.GridLines = true;  //格線

        }
        void 全部壽司()
        {
            SqlConnection con = new SqlConnection(strDBConnectionString);
            con.Open();
            string strSQL = "select*from Products";
            SqlCommand cmd = new SqlCommand(strSQL, con);
            SqlDataReader reader = cmd.ExecuteReader();

            string image_dir = @"全部壽司\";  //到時候更改資料庫
            string image_name = "";
            int i = 0;
            while(reader.Read())
            {
                listPID.Add((int)reader["pid"]);
                listPname.Add(reader["pname"].ToString());
                listPrice.Add((int)reader["price"]);
                image_name = reader["pimage"].ToString();
                Image myProductImage = Image.FromFile(image_dir+image_name);
                imageListMenu.Images.Add(myProductImage);
                i++;
            }
            reader.Close();
            con.Close();
        }

        void listview圖片()
        {
            listView商品展示.Clear(); //先清除前面的資料
            listView商品展示.View = View.LargeIcon;  //大圖檔模式
            imageListMenu.ImageSize = new Size(120, 120);
            listView商品展示.LargeImageList = imageListMenu;

            for (int i = 0; i < imageListMenu.Images.Count; i++)
            {
                ListViewItem item = new ListViewItem();
                item.ImageIndex = i;
                item.Font = new Font("微軟正黑體", 12, FontStyle.Regular);
                item.Text = listPname[i] + "" + listPrice[i] + "元"; //物品展現內容，對應順序i
                item.Tag = listPID[i];
                listView商品展示.Items.Add(item);
            }
        }

      


        private void butClear_Click(object sender, EventArgs e)
        {
            int intAdd = 0;
            listViewOrderList.Clear();
            listViewOrderList.View = View.Details;  //列表模式
            listViewOrderList.Columns.Add("商品名稱", 140);
            listViewOrderList.Columns.Add("價格", 60);
            listViewOrderList.Columns.Add("數量", 60);
            listViewOrderList.FullRowSelect = true;  //全列選擇
            listViewOrderList.GridLines = true;  //格線
            isAdd = false;
        }

        private void butSubmit_Click(object sender, EventArgs e)

        {
            if (isAdd==true)
            {
                
                GlobalVar.PID = (int)listView商品展示.SelectedItems[0].Tag;
                SqlConnection con = new SqlConnection(strDBConnectionString);
                con.Open();
                string strSQL2 = "insert into OrderHistory values (@NewID,@NewName,@NewProduct,@NewPrice,1,@NewTime);";
                SqlCommand cmd2 = new SqlCommand(strSQL2, con);
                cmd2.Parameters.AddWithValue("@NewID", GlobalVar.memberID);
                cmd2.Parameters.AddWithValue("@NewName", GlobalVar.str登入姓名);
                cmd2.Parameters.AddWithValue("@NewProduct", listPname[(GlobalVar.PID) - 1]);
                cmd2.Parameters.AddWithValue("@NewPrice", listPrice[(GlobalVar.PID) - 1]);
                cmd2.Parameters.AddWithValue("@NewTime", DateTime.Now);

                SqlDataReader reader = cmd2.ExecuteReader();
                con.Close();
                MessageBox.Show("送出成功");
                isAdd = false;
            }
            else
            {
                MessageBox.Show("請輸入所需商品");

            }

        }

        private void butCheckout_Click(object sender, EventArgs e)
        {
            MessageBox.Show("工作人員在前往結帳的路上，請在座位上稍等");

        }

        private void listView商品展示_ItemActivate(object sender, EventArgs e)
        {
            GlobalVar.PID = (int)listView商品展示.SelectedItems[0].Tag;
            SqlConnection con = new SqlConnection(strDBConnectionString);
            con.Open();
            string strSQL = "select *from Products where pid = @SearchID ";
            SqlCommand cmd = new SqlCommand(strSQL, con);
            cmd.Parameters.AddWithValue("@SearchID", GlobalVar.PID);
            SqlDataReader reader = cmd.ExecuteReader();
     

                while (reader.Read())
                {
                    ListViewItem item = new ListViewItem();
                    listViewOrderList.Font = new Font("微軟正黑體", 12, FontStyle.Regular);
                    item.Text = (listPname[(GlobalVar.PID) - 1]);
                    item.SubItems.Add(listPrice[(GlobalVar.PID) - 1].ToString());
                    item.SubItems.Add("1");
                    item.Tag = listPID[(GlobalVar.PID) - 1];
                    listViewOrderList.Items.Add(item);
                }
                intAdd++;
                isAdd = true;

        }

        private void but重新載入_Click(object sender, EventArgs e)
        {
            listview圖片();
        }

        private void label軍艦_Click(object sender, EventArgs e)
        {
            listView商品展示.Clear(); //先清除前面的資料
            listView商品展示.View = View.LargeIcon;  //大圖檔模式
            imageListMenu.ImageSize = new Size(120, 120);
            listView商品展示.LargeImageList = imageListMenu;

            for (int i = 20; i < 30; i++)
            {
                ListViewItem item = new ListViewItem();
                item.ImageIndex = i;
                item.Font = new Font("微軟正黑體", 12, FontStyle.Regular);
                item.Text = listPname[i] + "" + listPrice[i] + "元"; //物品展現內容，對應順序i
                item.Tag = listPID[i];
                listView商品展示.Items.Add(item);
            }
            全部壽司();
        }

        private void label全部_Click(object sender, EventArgs e)  //要更改
        {

            listView商品展示.Clear(); //先清除前面的資料
            listView商品展示.View = View.LargeIcon;  //大圖檔模式
            imageListMenu.ImageSize = new Size(120, 120);
            listView商品展示.LargeImageList = imageListMenu;

            for (int i = 0;i<=42 ; i++)
            {
                ListViewItem item = new ListViewItem();
                item.ImageIndex = i;
                item.Font = new Font("微軟正黑體", 12, FontStyle.Regular);
                item.Text = listPname[i] + "" + listPrice[i] + "元"; //物品展現內容，對應順序i
                item.Tag = listPID[i];
                listView商品展示.Items.Add(item);
            }

        }

        private void label握壽司_Click(object sender, EventArgs e)
        {
            listView商品展示.Clear(); //先清除前面的資料
            listView商品展示.View = View.LargeIcon;  //大圖檔模式
            imageListMenu.ImageSize = new Size(120, 120);
            listView商品展示.LargeImageList = imageListMenu;
            
            for (int i = 0; i<20; i++)
            {
                ListViewItem item = new ListViewItem();
                item.ImageIndex = i;
                item.Font = new Font("微軟正黑體", 12, FontStyle.Regular);
                item.Text = listPname[i] + "" + listPrice[i] + "元"; //物品展現內容，對應順序i
                item.Tag = listPID[i];
                listView商品展示.Items.Add(item);
            }
            全部壽司();
        }

        private void label甜點飲料_Click(object sender, EventArgs e)
        {
            listView商品展示.Clear(); //先清除前面的資料
            listView商品展示.View = View.LargeIcon;  //大圖檔模式
            imageListMenu.ImageSize = new Size(120, 120);
            listView商品展示.LargeImageList = imageListMenu;

            for (int i = 30; i < 42; i++)
            {
                ListViewItem item = new ListViewItem();
                item.ImageIndex = i;
                item.Font = new Font("微軟正黑體", 12, FontStyle.Regular);
                item.Text = listPname[i] + "" + listPrice[i] + "元"; //物品展現內容，對應順序i
                item.Tag = listPID[i];
                listView商品展示.Items.Add(item);
            }
            全部壽司();
        }

        private void label新商品_Click(object sender, EventArgs e)
        {
            listView商品展示.Clear(); //先清除前面的資料
            listView商品展示.View = View.LargeIcon;  //大圖檔模式
            imageListMenu.ImageSize = new Size(120, 120);
            listView商品展示.LargeImageList = imageListMenu;

            for (int i = 42; i <=42; i++) //要更改
            {
                ListViewItem item = new ListViewItem();
                item.ImageIndex = i;
                item.Font = new Font("微軟正黑體", 12, FontStyle.Regular);
                item.Text = listPname[i] + "" + listPrice[i] + "元"; //物品展現內容，對應順序i
                item.Tag = listPID[i];
                listView商品展示.Items.Add(item);
            }

        }
    }
}
