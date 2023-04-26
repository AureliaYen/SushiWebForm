namespace 哪次不吃壽司
{
    partial class UCorderModify
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

        #region 元件設計工具產生的程式碼

        /// <summary> 
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCorderModify));
            this.label1 = new System.Windows.Forms.Label();
            this.dgvOrder = new System.Windows.Forms.DataGridView();
            this.but儲存修改 = new System.Windows.Forms.Button();
            this.butOrderSearch = new System.Windows.Forms.Button();
            this.but刪除訂單 = new System.Windows.Forms.Button();
            this.textBoxProductAmount = new System.Windows.Forms.TextBox();
            this.labelID = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.labelTime = new System.Windows.Forms.Label();
            this.textBoxProductPrice = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.labelnName = new System.Windows.Forms.Label();
            this.labe9 = new System.Windows.Forms.Label();
            this.textBoxOrderID = new System.Windows.Forms.TextBox();
            this.but重新載入 = new System.Windows.Forms.Button();
            this.textBoxProductName = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(489, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 38);
            this.label1.TabIndex = 8;
            this.label1.Text = "訂單維護";
            // 
            // dgvOrder
            // 
            this.dgvOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOrder.Location = new System.Drawing.Point(310, 79);
            this.dgvOrder.Name = "dgvOrder";
            this.dgvOrder.RowHeadersWidth = 51;
            this.dgvOrder.RowTemplate.Height = 27;
            this.dgvOrder.Size = new System.Drawing.Size(506, 515);
            this.dgvOrder.TabIndex = 9;
            this.dgvOrder.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvOrder_CellClick);
            // 
            // but儲存修改
            // 
            this.but儲存修改.Location = new System.Drawing.Point(19, 489);
            this.but儲存修改.Name = "but儲存修改";
            this.but儲存修改.Size = new System.Drawing.Size(123, 38);
            this.but儲存修改.TabIndex = 45;
            this.but儲存修改.Text = "儲存修改";
            this.but儲存修改.UseVisualStyleBackColor = true;
            this.but儲存修改.Click += new System.EventHandler(this.but儲存修改_Click);
            // 
            // butOrderSearch
            // 
            this.butOrderSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.butOrderSearch.Location = new System.Drawing.Point(171, 117);
            this.butOrderSearch.Name = "butOrderSearch";
            this.butOrderSearch.Size = new System.Drawing.Size(107, 38);
            this.butOrderSearch.TabIndex = 46;
            this.butOrderSearch.Text = "搜尋";
            this.butOrderSearch.UseVisualStyleBackColor = false;
            this.butOrderSearch.Click += new System.EventHandler(this.butOrderSearch_Click);
            // 
            // but刪除訂單
            // 
            this.but刪除訂單.Location = new System.Drawing.Point(154, 489);
            this.but刪除訂單.Name = "but刪除訂單";
            this.but刪除訂單.Size = new System.Drawing.Size(123, 38);
            this.but刪除訂單.TabIndex = 47;
            this.but刪除訂單.Text = "刪除訂單";
            this.but刪除訂單.UseVisualStyleBackColor = true;
            this.but刪除訂單.Click += new System.EventHandler(this.but刪除訂單_Click);
            // 
            // textBoxProductAmount
            // 
            this.textBoxProductAmount.Location = new System.Drawing.Point(135, 382);
            this.textBoxProductAmount.Name = "textBoxProductAmount";
            this.textBoxProductAmount.Size = new System.Drawing.Size(143, 34);
            this.textBoxProductAmount.TabIndex = 54;
            // 
            // labelID
            // 
            this.labelID.BackColor = System.Drawing.Color.White;
            this.labelID.Location = new System.Drawing.Point(135, 173);
            this.labelID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelID.Name = "labelID";
            this.labelID.Size = new System.Drawing.Size(143, 25);
            this.labelID.TabIndex = 52;
            this.labelID.Text = "00000";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 333);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 25);
            this.label3.TabIndex = 51;
            this.label3.Text = "商品價格";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 385);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 25);
            this.label2.TabIndex = 50;
            this.label2.Text = "商品數量";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 177);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 25);
            this.label4.TabIndex = 49;
            this.label4.Text = "會員ID";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 281);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 25);
            this.label5.TabIndex = 55;
            this.label5.Text = "商品名稱";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(18, 437);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(92, 25);
            this.label7.TabIndex = 58;
            this.label7.Text = "訂單時間";
            // 
            // labelTime
            // 
            this.labelTime.BackColor = System.Drawing.Color.White;
            this.labelTime.Location = new System.Drawing.Point(135, 439);
            this.labelTime.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTime.Name = "labelTime";
            this.labelTime.Size = new System.Drawing.Size(143, 25);
            this.labelTime.TabIndex = 59;
            this.labelTime.Text = "00000";
            // 
            // textBoxProductPrice
            // 
            this.textBoxProductPrice.Location = new System.Drawing.Point(135, 325);
            this.textBoxProductPrice.Name = "textBoxProductPrice";
            this.textBoxProductPrice.Size = new System.Drawing.Size(143, 34);
            this.textBoxProductPrice.TabIndex = 60;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(18, 229);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(92, 25);
            this.label6.TabIndex = 61;
            this.label6.Text = "會員名稱";
            // 
            // labelnName
            // 
            this.labelnName.BackColor = System.Drawing.Color.White;
            this.labelnName.Location = new System.Drawing.Point(135, 221);
            this.labelnName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelnName.Name = "labelnName";
            this.labelnName.Size = new System.Drawing.Size(143, 25);
            this.labelnName.TabIndex = 62;
            this.labelnName.Text = "Name";
            // 
            // labe9
            // 
            this.labe9.AutoSize = true;
            this.labe9.Location = new System.Drawing.Point(18, 81);
            this.labe9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labe9.Name = "labe9";
            this.labe9.Size = new System.Drawing.Size(92, 25);
            this.labe9.TabIndex = 64;
            this.labe9.Text = "訂單編號";
            // 
            // textBoxOrderID
            // 
            this.textBoxOrderID.Location = new System.Drawing.Point(19, 120);
            this.textBoxOrderID.Name = "textBoxOrderID";
            this.textBoxOrderID.Size = new System.Drawing.Size(143, 34);
            this.textBoxOrderID.TabIndex = 65;
            // 
            // but重新載入
            // 
            this.but重新載入.Location = new System.Drawing.Point(19, 533);
            this.but重新載入.Name = "but重新載入";
            this.but重新載入.Size = new System.Drawing.Size(123, 38);
            this.but重新載入.TabIndex = 66;
            this.but重新載入.Text = "重新載入";
            this.but重新載入.UseVisualStyleBackColor = true;
            this.but重新載入.Click += new System.EventHandler(this.but重新載入_Click);
            // 
            // textBoxProductName
            // 
            this.textBoxProductName.Location = new System.Drawing.Point(134, 272);
            this.textBoxProductName.Name = "textBoxProductName";
            this.textBoxProductName.Size = new System.Drawing.Size(143, 34);
            this.textBoxProductName.TabIndex = 67;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(679, 17);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(137, 55);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 68;
            this.pictureBox1.TabStop = false;
            // 
            // UCorderModify
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AntiqueWhite;
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.textBoxProductName);
            this.Controls.Add(this.but重新載入);
            this.Controls.Add(this.textBoxOrderID);
            this.Controls.Add(this.labe9);
            this.Controls.Add(this.labelnName);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBoxProductPrice);
            this.Controls.Add(this.labelTime);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBoxProductAmount);
            this.Controls.Add(this.labelID);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.but刪除訂單);
            this.Controls.Add(this.butOrderSearch);
            this.Controls.Add(this.but儲存修改);
            this.Controls.Add(this.dgvOrder);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "UCorderModify";
            this.Size = new System.Drawing.Size(850, 634);
            this.Load += new System.EventHandler(this.UCorderModify_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrder)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvOrder;
        private System.Windows.Forms.Button but儲存修改;
        private System.Windows.Forms.Button butOrderSearch;
        private System.Windows.Forms.Button but刪除訂單;
        private System.Windows.Forms.TextBox textBoxProductAmount;
        private System.Windows.Forms.Label labelID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label labelTime;
        private System.Windows.Forms.TextBox textBoxProductPrice;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label labelnName;
        private System.Windows.Forms.Label labe9;
        private System.Windows.Forms.TextBox textBoxOrderID;
        private System.Windows.Forms.Button but重新載入;
        private System.Windows.Forms.TextBox textBoxProductName;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
