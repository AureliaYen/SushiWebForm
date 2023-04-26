namespace 哪次不吃壽司
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pictureBoxBot = new System.Windows.Forms.PictureBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.labelLogin = new System.Windows.Forms.Label();
            this.butCustomer = new System.Windows.Forms.Button();
            this.butProduct = new System.Windows.Forms.Button();
            this.butOrder = new System.Windows.Forms.Button();
            this.butMenu = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBot)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pictureBoxBot);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.butCustomer);
            this.groupBox1.Controls.Add(this.butProduct);
            this.groupBox1.Controls.Add(this.butOrder);
            this.groupBox1.Controls.Add(this.butMenu);
            this.groupBox1.Location = new System.Drawing.Point(4, 5);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(213, 643);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // pictureBoxBot
            // 
            this.pictureBoxBot.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxBot.Image")));
            this.pictureBoxBot.Location = new System.Drawing.Point(8, 187);
            this.pictureBoxBot.Name = "pictureBoxBot";
            this.pictureBoxBot.Size = new System.Drawing.Size(199, 448);
            this.pictureBoxBot.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxBot.TabIndex = 5;
            this.pictureBoxBot.TabStop = false;
            this.pictureBoxBot.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.groupBox2.Controls.Add(this.labelLogin);
            this.groupBox2.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.groupBox2.Location = new System.Drawing.Point(8, 24);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(198, 157);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            // 
            // labelLogin
            // 
            this.labelLogin.AutoSize = true;
            this.labelLogin.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labelLogin.ForeColor = System.Drawing.Color.Black;
            this.labelLogin.Location = new System.Drawing.Point(18, 30);
            this.labelLogin.Name = "labelLogin";
            this.labelLogin.Size = new System.Drawing.Size(105, 29);
            this.labelLogin.TabIndex = 0;
            this.labelLogin.Text = "登入資訊";
            // 
            // butCustomer
            // 
            this.butCustomer.Location = new System.Drawing.Point(21, 514);
            this.butCustomer.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.butCustomer.Name = "butCustomer";
            this.butCustomer.Size = new System.Drawing.Size(173, 52);
            this.butCustomer.TabIndex = 4;
            this.butCustomer.Text = "會員維護";
            this.butCustomer.UseVisualStyleBackColor = true;
            this.butCustomer.Visible = false;
            this.butCustomer.Click += new System.EventHandler(this.butCustomer_Click);
            // 
            // butProduct
            // 
            this.butProduct.Location = new System.Drawing.Point(21, 431);
            this.butProduct.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.butProduct.Name = "butProduct";
            this.butProduct.Size = new System.Drawing.Size(173, 58);
            this.butProduct.TabIndex = 3;
            this.butProduct.Text = "商品維護";
            this.butProduct.UseVisualStyleBackColor = true;
            this.butProduct.Visible = false;
            this.butProduct.Click += new System.EventHandler(this.butProduct_Click);
            // 
            // butOrder
            // 
            this.butOrder.Location = new System.Drawing.Point(21, 349);
            this.butOrder.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.butOrder.Name = "butOrder";
            this.butOrder.Size = new System.Drawing.Size(173, 52);
            this.butOrder.TabIndex = 2;
            this.butOrder.Text = "訂單維護";
            this.butOrder.UseVisualStyleBackColor = true;
            this.butOrder.Visible = false;
            this.butOrder.Click += new System.EventHandler(this.butOrder_Click);
            // 
            // butMenu
            // 
            this.butMenu.Location = new System.Drawing.Point(21, 271);
            this.butMenu.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.butMenu.Name = "butMenu";
            this.butMenu.Size = new System.Drawing.Size(173, 52);
            this.butMenu.TabIndex = 1;
            this.butMenu.Text = "菜單";
            this.butMenu.UseVisualStyleBackColor = true;
            this.butMenu.Visible = false;
            this.butMenu.Click += new System.EventHandler(this.butMenu_Click);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(225, 14);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(850, 634);
            this.panel1.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(1089, 659);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "哪次不吃壽司";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBot)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button butCustomer;
        private System.Windows.Forms.Button butProduct;
        private System.Windows.Forms.Button butOrder;
        private System.Windows.Forms.Button butMenu;
        private System.Windows.Forms.Label labelLogin;
        private System.Windows.Forms.PictureBox pictureBoxBot;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}

