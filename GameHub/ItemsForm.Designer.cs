namespace GameHub
{
    partial class ItemsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ItemsForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ItemsGV = new Guna.UI2.WinForms.Guna2DataGridView();
            this.button5 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.PriceCb = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.ItemNameTb = new System.Windows.Forms.TextBox();
            this.ItemNumTb = new System.Windows.Forms.TextBox();
            this.CatCb = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ItemsGV)).BeginInit();
            this.SuspendLayout();
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.SystemColors.HighlightText;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Lucida Fax", 9.75F);
            this.button4.ForeColor = System.Drawing.SystemColors.Desktop;
            this.button4.Location = new System.Drawing.Point(22, 124);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(102, 31);
            this.button4.TabIndex = 19;
            this.button4.Text = "Users";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.HighlightText;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Lucida Fax", 9.75F);
            this.button3.ForeColor = System.Drawing.SystemColors.Desktop;
            this.button3.Location = new System.Drawing.Point(22, 69);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(102, 31);
            this.button3.TabIndex = 17;
            this.button3.Text = "Order";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.SystemColors.InfoText;
            this.label7.Font = new System.Drawing.Font("Lucida Fax", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label7.Location = new System.Drawing.Point(42, 458);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 15);
            this.label7.TabIndex = 18;
            this.label7.Text = "LogOut";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Desktop;
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.ItemsGV);
            this.panel1.Controls.Add(this.button5);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.PriceCb);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.ItemNameTb);
            this.panel1.Controls.Add(this.ItemNumTb);
            this.panel1.Controls.Add(this.CatCb);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(130, 39);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(865, 467);
            this.panel1.TabIndex = 16;
            // 
            // ItemsGV
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.MediumBlue;
            this.ItemsGV.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.ItemsGV.BackgroundColor = System.Drawing.Color.DarkBlue;
            this.ItemsGV.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SunkenHorizontal;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ItemsGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.ItemsGV.ColumnHeadersHeight = 25;
            this.ItemsGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.RoyalBlue;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Navy;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.ItemsGV.DefaultCellStyle = dataGridViewCellStyle3;
            this.ItemsGV.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.ItemsGV.Location = new System.Drawing.Point(400, 98);
            this.ItemsGV.Name = "ItemsGV";
            this.ItemsGV.RowHeadersVisible = false;
            this.ItemsGV.RowHeadersWidth = 51;
            this.ItemsGV.RowTemplate.Height = 30;
            this.ItemsGV.Size = new System.Drawing.Size(406, 308);
            this.ItemsGV.TabIndex = 20;
            this.ItemsGV.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.ItemsGV.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.ItemsGV.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.ItemsGV.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.ItemsGV.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.ItemsGV.ThemeStyle.BackColor = System.Drawing.Color.DarkBlue;
            this.ItemsGV.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.ItemsGV.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.ItemsGV.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.ItemsGV.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ItemsGV.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.ItemsGV.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.ItemsGV.ThemeStyle.HeaderStyle.Height = 25;
            this.ItemsGV.ThemeStyle.ReadOnly = false;
            this.ItemsGV.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.PaleTurquoise;
            this.ItemsGV.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SunkenHorizontal;
            this.ItemsGV.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ItemsGV.ThemeStyle.RowsStyle.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ItemsGV.ThemeStyle.RowsStyle.Height = 30;
            this.ItemsGV.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.Navy;
            this.ItemsGV.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.White;
            this.ItemsGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ItemsGV_CellContentClick);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.SystemColors.HighlightText;
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Lucida Fax", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.SystemColors.Desktop;
            this.button5.Location = new System.Drawing.Point(178, 271);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(67, 32);
            this.button5.TabIndex = 18;
            this.button5.Text = "Delete";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.HighlightText;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Lucida Fax", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.Desktop;
            this.button2.Location = new System.Drawing.Point(105, 271);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(67, 32);
            this.button2.TabIndex = 17;
            this.button2.Text = "Edit";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Lucida Fax", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.label8.Location = new System.Drawing.Point(536, 65);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(121, 22);
            this.label8.TabIndex = 16;
            this.label8.Text = "Games List";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Lucida Fax", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.label5.Location = new System.Drawing.Point(28, 206);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 18);
            this.label5.TabIndex = 15;
            this.label5.Text = "GamePrice";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Lucida Fax", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.label4.Location = new System.Drawing.Point(28, 127);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 18);
            this.label4.TabIndex = 14;
            this.label4.Text = "GameName";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Lucida Fax", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.label3.Location = new System.Drawing.Point(28, 90);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 18);
            this.label3.TabIndex = 13;
            this.label3.Text = "ItemNum";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // PriceCb
            // 
            this.PriceCb.BackColor = System.Drawing.SystemColors.Desktop;
            this.PriceCb.Font = new System.Drawing.Font("Lucida Fax", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PriceCb.ForeColor = System.Drawing.SystemColors.Window;
            this.PriceCb.Location = new System.Drawing.Point(140, 203);
            this.PriceCb.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.PriceCb.Name = "PriceCb";
            this.PriceCb.Size = new System.Drawing.Size(141, 23);
            this.PriceCb.TabIndex = 12;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.HighlightText;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Lucida Fax", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.Desktop;
            this.button1.Location = new System.Drawing.Point(36, 271);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(63, 32);
            this.button1.TabIndex = 8;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ItemNameTb
            // 
            this.ItemNameTb.BackColor = System.Drawing.SystemColors.Desktop;
            this.ItemNameTb.Font = new System.Drawing.Font("Lucida Fax", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ItemNameTb.ForeColor = System.Drawing.SystemColors.Window;
            this.ItemNameTb.Location = new System.Drawing.Point(140, 124);
            this.ItemNameTb.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ItemNameTb.Name = "ItemNameTb";
            this.ItemNameTb.Size = new System.Drawing.Size(143, 23);
            this.ItemNameTb.TabIndex = 6;
            this.ItemNameTb.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // ItemNumTb
            // 
            this.ItemNumTb.BackColor = System.Drawing.SystemColors.Desktop;
            this.ItemNumTb.Font = new System.Drawing.Font("Lucida Fax", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ItemNumTb.ForeColor = System.Drawing.SystemColors.Window;
            this.ItemNumTb.Location = new System.Drawing.Point(140, 85);
            this.ItemNumTb.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ItemNumTb.Name = "ItemNumTb";
            this.ItemNumTb.Size = new System.Drawing.Size(143, 23);
            this.ItemNumTb.TabIndex = 5;
            // 
            // CatCb
            // 
            this.CatCb.BackColor = System.Drawing.SystemColors.Desktop;
            this.CatCb.Font = new System.Drawing.Font("Lucida Fax", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CatCb.ForeColor = System.Drawing.SystemColors.Window;
            this.CatCb.FormattingEnabled = true;
            this.CatCb.Items.AddRange(new object[] {
            "Fighting",
            "FPS"});
            this.CatCb.Location = new System.Drawing.Point(140, 159);
            this.CatCb.Name = "CatCb";
            this.CatCb.Size = new System.Drawing.Size(143, 25);
            this.CatCb.TabIndex = 3;
            this.CatCb.Text = "Genre";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Fax", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.label1.Location = new System.Drawing.Point(368, 25);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 22);
            this.label1.TabIndex = 2;
            this.label1.Text = "Manage Games";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.Desktop;
            this.label6.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.label6.Location = new System.Drawing.Point(985, 9);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(21, 23);
            this.label6.TabIndex = 14;
            this.label6.Text = "X";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // ItemsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1017, 518);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ItemsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ItemsForm";
            this.Load += new System.EventHandler(this.ItemsForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ItemsGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox PriceCb;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox ItemNameTb;
        private System.Windows.Forms.TextBox ItemNumTb;
        private System.Windows.Forms.ComboBox CatCb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button2;
        private Guna.UI2.WinForms.Guna2DataGridView ItemsGV;
    }
}