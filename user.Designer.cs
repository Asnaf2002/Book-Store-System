namespace project_front
{
    partial class user
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(user));
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridViewBooks_CellContentClick = new System.Windows.Forms.DataGridView();
            this.lblT = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.PrBtn = new System.Windows.Forms.Button();
            this.RBtn = new System.Windows.Forms.Button();
            this.AddBtn = new System.Windows.Forms.Button();
            this.PTb = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.QTb = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.BTTb = new System.Windows.Forms.TextBox();
            this.CNTb = new System.Windows.Forms.TextBox();
            this.BookId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Title = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBooks_CellContentClick)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel1.Controls.Add(this.dataGridViewBooks_CellContentClick);
            this.panel1.Controls.Add(this.lblT);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.PrBtn);
            this.panel1.Controls.Add(this.RBtn);
            this.panel1.Controls.Add(this.AddBtn);
            this.panel1.Controls.Add(this.PTb);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.QTb);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.BTTb);
            this.panel1.Controls.Add(this.CNTb);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(796, 526);
            this.panel1.TabIndex = 1;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // dataGridViewBooks_CellContentClick
            // 
            this.dataGridViewBooks_CellContentClick.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dataGridViewBooks_CellContentClick.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewBooks_CellContentClick.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.BookId,
            this.Title,
            this.Quantity,
            this.Price,
            this.Total});
            this.dataGridViewBooks_CellContentClick.GridColor = System.Drawing.Color.White;
            this.dataGridViewBooks_CellContentClick.Location = new System.Drawing.Point(30, 198);
            this.dataGridViewBooks_CellContentClick.Name = "dataGridViewBooks_CellContentClick";
            this.dataGridViewBooks_CellContentClick.Size = new System.Drawing.Size(547, 247);
            this.dataGridViewBooks_CellContentClick.TabIndex = 66;
            this.dataGridViewBooks_CellContentClick.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick_1);
            // 
            // lblT
            // 
            this.lblT.AutoSize = true;
            this.lblT.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblT.ForeColor = System.Drawing.Color.Black;
            this.lblT.Location = new System.Drawing.Point(74, 471);
            this.lblT.Name = "lblT";
            this.lblT.Size = new System.Drawing.Size(90, 32);
            this.lblT.TabIndex = 65;
            this.lblT.Text = "Total :";
            this.lblT.Click += new System.EventHandler(this.lblT_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(28, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 21);
            this.label3.TabIndex = 64;
            this.label3.Text = "Book Id";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(770, 3);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(23, 23);
            this.label8.TabIndex = 63;
            this.label8.Text = "X";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Stencil", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.label1.Location = new System.Drawing.Point(283, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(255, 32);
            this.label1.TabIndex = 60;
            this.label1.Text = "BOOK STORE BILL";
            // 
            // PrBtn
            // 
            this.PrBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.PrBtn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PrBtn.ForeColor = System.Drawing.Color.White;
            this.PrBtn.Location = new System.Drawing.Point(459, 468);
            this.PrBtn.Name = "PrBtn";
            this.PrBtn.Size = new System.Drawing.Size(111, 44);
            this.PrBtn.TabIndex = 58;
            this.PrBtn.Text = "Print Bill";
            this.PrBtn.UseVisualStyleBackColor = false;
            this.PrBtn.Click += new System.EventHandler(this.PrBtn_Click);
            // 
            // RBtn
            // 
            this.RBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.RBtn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RBtn.ForeColor = System.Drawing.Color.White;
            this.RBtn.Location = new System.Drawing.Point(633, 198);
            this.RBtn.Name = "RBtn";
            this.RBtn.Size = new System.Drawing.Size(85, 35);
            this.RBtn.TabIndex = 57;
            this.RBtn.Text = "Reset";
            this.RBtn.UseVisualStyleBackColor = false;
            this.RBtn.Click += new System.EventHandler(this.RBtn_Click);
            // 
            // AddBtn
            // 
            this.AddBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.AddBtn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddBtn.ForeColor = System.Drawing.Color.White;
            this.AddBtn.Location = new System.Drawing.Point(633, 143);
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.Size = new System.Drawing.Size(109, 35);
            this.AddBtn.TabIndex = 56;
            this.AddBtn.Text = "Add To Bill";
            this.AddBtn.UseVisualStyleBackColor = false;
            this.AddBtn.Click += new System.EventHandler(this.SaveBtn_Click);
            // 
            // PTb
            // 
            this.PTb.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PTb.Location = new System.Drawing.Point(455, 143);
            this.PTb.Name = "PTb";
            this.PTb.Size = new System.Drawing.Size(115, 27);
            this.PTb.TabIndex = 55;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(451, 107);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 21);
            this.label7.TabIndex = 54;
            this.label7.Text = "Price";
            // 
            // QTb
            // 
            this.QTb.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QTb.Location = new System.Drawing.Point(314, 143);
            this.QTb.Name = "QTb";
            this.QTb.Size = new System.Drawing.Size(113, 27);
            this.QTb.TabIndex = 53;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(310, 107);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 21);
            this.label6.TabIndex = 52;
            this.label6.Text = "Quantity";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(169, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 21);
            this.label2.TabIndex = 48;
            this.label2.Text = "Book Title";
            // 
            // BTTb
            // 
            this.BTTb.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTTb.Location = new System.Drawing.Point(173, 143);
            this.BTTb.Name = "BTTb";
            this.BTTb.Size = new System.Drawing.Size(113, 27);
            this.BTTb.TabIndex = 47;
            // 
            // CNTb
            // 
            this.CNTb.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CNTb.Location = new System.Drawing.Point(30, 143);
            this.CNTb.Name = "CNTb";
            this.CNTb.Size = new System.Drawing.Size(121, 27);
            this.CNTb.TabIndex = 46;
            this.CNTb.TextChanged += new System.EventHandler(this.CNTb_TextChanged);
            // 
            // BookId
            // 
            this.BookId.HeaderText = "Book Id";
            this.BookId.Name = "BookId";
            // 
            // Title
            // 
            this.Title.HeaderText = "Book Title";
            this.Title.Name = "Title";
            // 
            // Quantity
            // 
            this.Quantity.HeaderText = "Quantity";
            this.Quantity.Name = "Quantity";
            // 
            // Price
            // 
            this.Price.HeaderText = "Price per unit";
            this.Price.Name = "Price";
            // 
            // Total
            // 
            this.Total.HeaderText = "Total Price";
            this.Total.Name = "Total";
            // 
            // user
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(791, 524);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "user";
            this.Text = "user";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBooks_CellContentClick)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button PrBtn;
        private System.Windows.Forms.Button RBtn;
        private System.Windows.Forms.Button AddBtn;
        private System.Windows.Forms.TextBox PTb;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox QTb;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox BTTb;
        private System.Windows.Forms.TextBox CNTb;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblT;
        private System.Windows.Forms.DataGridView dataGridViewBooks_CellContentClick;
        private System.Windows.Forms.DataGridViewTextBoxColumn BookId;
        private System.Windows.Forms.DataGridViewTextBoxColumn Title;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total;
    }
}