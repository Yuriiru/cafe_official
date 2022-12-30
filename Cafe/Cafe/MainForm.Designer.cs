namespace Cafe
{
    partial class MainForm
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.AddProductBtn = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button_delete = new System.Windows.Forms.Button();
            this.button_redact = new System.Windows.Forms.Button();
            this.Price = new System.Windows.Forms.Label();
            this.Plasce_location = new System.Windows.Forms.Label();
            this.Count = new System.Windows.Forms.Label();
            this.Type = new System.Windows.Forms.Label();
            this.NameLabel = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(23, 69);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(500, 342);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // AddOfficeBtn
            // 
            this.AddProductBtn.Location = new System.Drawing.Point(23, 12);
            this.AddProductBtn.Name = "AddProductBtn";
            this.AddProductBtn.Size = new System.Drawing.Size(187, 23);
            this.AddProductBtn.TabIndex = 1;
            this.AddProductBtn.Text = "Добавить новый продукт";
            this.AddProductBtn.UseVisualStyleBackColor = true;
            this.AddProductBtn.Visible = false;
            this.AddProductBtn.Click += new System.EventHandler(this.AddProductBtn_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(278, 12);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(164, 21);
            this.comboBox1.TabIndex = 2;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(512, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(162, 20);
            this.textBox1.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(697, 10);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(79, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Поиск";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button_delete);
            this.groupBox1.Controls.Add(this.button_redact);
            this.groupBox1.Controls.Add(this.Price);
            this.groupBox1.Controls.Add(this.Plasce_location);
            this.groupBox1.Controls.Add(this.Count);
            this.groupBox1.Controls.Add(this.Type);
            this.groupBox1.Controls.Add(this.NameLabel);
            this.groupBox1.Location = new System.Drawing.Point(576, 69);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(347, 333);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            // 
            // button_delete
            // 
            this.button_delete.Location = new System.Drawing.Point(153, 277);
            this.button_delete.Name = "button_delete";
            this.button_delete.Size = new System.Drawing.Size(106, 23);
            this.button_delete.TabIndex = 6;
            this.button_delete.Text = "Удалить";
            this.button_delete.UseVisualStyleBackColor = true;
            this.button_delete.Click += new System.EventHandler(this.button_delete_Click);
            // 
            // button_redact
            // 
            this.button_redact.Location = new System.Drawing.Point(26, 277);
            this.button_redact.Name = "button_redact";
            this.button_redact.Size = new System.Drawing.Size(108, 23);
            this.button_redact.TabIndex = 5;
            this.button_redact.Text = "Редактировать";
            this.button_redact.UseVisualStyleBackColor = true;
            this.button_redact.Click += new System.EventHandler(this.button_redact_Click);
            // 
            // Description
            // 
            this.Price.AutoSize = true;
            this.Price.Location = new System.Drawing.Point(23, 136);
            this.Price.Name = "Description";
            this.Price.Size = new System.Drawing.Size(36, 13);
            this.Price.TabIndex = 4;
            this.Price.Text = "Цена:";
            // 
            // Address
            // 
            this.Plasce_location.AutoSize = true;
            this.Plasce_location.Location = new System.Drawing.Point(23, 97);
            this.Plasce_location.Name = "Address";
            this.Plasce_location.Size = new System.Drawing.Size(92, 13);
            this.Plasce_location.TabIndex = 3;
            this.Plasce_location.Text = "Место хранения:";
            // 
            // Code
            // 
            this.Count.AutoSize = true;
            this.Count.Location = new System.Drawing.Point(21, 67);
            this.Count.Name = "Code";
            this.Count.Size = new System.Drawing.Size(69, 13);
            this.Count.TabIndex = 2;
            this.Count.Text = "Количество:";
            // 
            // City
            // 
            this.Type.AutoSize = true;
            this.Type.Location = new System.Drawing.Point(22, 43);
            this.Type.Name = "City";
            this.Type.Size = new System.Drawing.Size(78, 13);
            this.Type.TabIndex = 1;
            this.Type.Text = "Тип продукта:";
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Location = new System.Drawing.Point(21, 16);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(60, 13);
            this.NameLabel.TabIndex = 0;
            this.NameLabel.Text = "Название:";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(817, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 6;
            this.button2.Text = "Выйти";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.AddProductBtn);
            this.Controls.Add(this.dataGridView1);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button AddProductBtn;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label Price;
        private System.Windows.Forms.Label Plasce_location;
        private System.Windows.Forms.Label Count;
        private System.Windows.Forms.Label Type;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button_delete;
        private System.Windows.Forms.Button button_redact;
    }
}