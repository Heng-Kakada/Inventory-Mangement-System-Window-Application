namespace InventoryManagementSystem.Controller
{
    partial class ProductForm
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProductForm));
            pHead = new Panel();
            lbCategory = new Label();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            comboBox1 = new ComboBox();
            pBottom = new Panel();
            pBody = new Panel();
            dgvProduct = new DataGridView();
            pNo = new DataGridViewTextBoxColumn();
            pCode = new DataGridViewTextBoxColumn();
            pName = new DataGridViewTextBoxColumn();
            pPrice = new DataGridViewTextBoxColumn();
            pQty = new DataGridViewTextBoxColumn();
            pImg = new DataGridViewImageColumn();
            pHead.SuspendLayout();
            pBody.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvProduct).BeginInit();
            SuspendLayout();
            // 
            // pHead
            // 
            pHead.Controls.Add(lbCategory);
            pHead.Controls.Add(button3);
            pHead.Controls.Add(button2);
            pHead.Controls.Add(button1);
            pHead.Controls.Add(comboBox1);
            pHead.Dock = DockStyle.Top;
            pHead.Location = new Point(0, 0);
            pHead.Margin = new Padding(3, 2, 3, 2);
            pHead.Name = "pHead";
            pHead.Size = new Size(1200, 70);
            pHead.TabIndex = 0;
            // 
            // lbCategory
            // 
            lbCategory.AutoSize = true;
            lbCategory.Font = new Font("Khmer OS Siemreap", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbCategory.Location = new Point(27, 10);
            lbCategory.Name = "lbCategory";
            lbCategory.Size = new Size(88, 24);
            lbCategory.TabIndex = 4;
            lbCategory.Text = "ប្រភេទទំនេញ :";
            // 
            // button3
            // 
            button3.Location = new Point(449, 26);
            button3.Name = "button3";
            button3.Size = new Size(75, 34);
            button3.TabIndex = 3;
            button3.Text = "button3";
            button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(348, 26);
            button2.Name = "button2";
            button2.Size = new Size(75, 34);
            button2.TabIndex = 2;
            button2.Text = "button2";
            button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(250, 26);
            button1.Name = "button1";
            button1.Size = new Size(75, 34);
            button1.TabIndex = 1;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(27, 37);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(174, 23);
            comboBox1.TabIndex = 0;
            // 
            // pBottom
            // 
            pBottom.Dock = DockStyle.Bottom;
            pBottom.Location = new Point(0, 924);
            pBottom.Margin = new Padding(3, 2, 3, 2);
            pBottom.Name = "pBottom";
            pBottom.Size = new Size(1200, 76);
            pBottom.TabIndex = 1;
            // 
            // pBody
            // 
            pBody.Controls.Add(dgvProduct);
            pBody.Dock = DockStyle.Fill;
            pBody.Location = new Point(0, 70);
            pBody.Name = "pBody";
            pBody.Size = new Size(1200, 854);
            pBody.TabIndex = 2;
            // 
            // dgvProduct
            // 
            dgvProduct.AllowUserToAddRows = false;
            dgvProduct.AllowUserToDeleteRows = false;
            dgvProduct.BackgroundColor = SystemColors.InactiveCaption;
            dgvProduct.BorderStyle = BorderStyle.Fixed3D;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.ActiveCaptionText;
            dataGridViewCellStyle1.Font = new Font("Khmer OS Siemreap", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = Color.FromArgb(0, 192, 0);
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvProduct.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvProduct.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProduct.Columns.AddRange(new DataGridViewColumn[] { pNo, pCode, pName, pPrice, pQty, pImg });
            dgvProduct.Dock = DockStyle.Fill;
            dgvProduct.GridColor = SystemColors.InactiveCaption;
            dgvProduct.Location = new Point(0, 0);
            dgvProduct.Name = "dgvProduct";
            dgvProduct.ReadOnly = true;
            dgvProduct.Size = new Size(1200, 854);
            dgvProduct.TabIndex = 0;
            // 
            // pNo
            // 
            pNo.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            dataGridViewCellStyle2.Font = new Font("Khmer OS Siemreap", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            pNo.DefaultCellStyle = dataGridViewCellStyle2;
            pNo.HeaderText = "លេខសម្គាល់";
            pNo.Name = "pNo";
            pNo.ReadOnly = true;
            // 
            // pCode
            // 
            pCode.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle3.Font = new Font("Khmer OS Siemreap", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            pCode.DefaultCellStyle = dataGridViewCellStyle3;
            pCode.HeaderText = "លេខកូដ";
            pCode.Name = "pCode";
            pCode.ReadOnly = true;
            pCode.Width = 79;
            // 
            // pName
            // 
            pName.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle4.Font = new Font("Khmer OS Siemreap", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            pName.DefaultCellStyle = dataGridViewCellStyle4;
            pName.HeaderText = "ឈ្មោះទំនេញ";
            pName.Name = "pName";
            pName.ReadOnly = true;
            // 
            // pPrice
            // 
            pPrice.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle5.Font = new Font("Khmer OS Siemreap", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            pPrice.DefaultCellStyle = dataGridViewCellStyle5;
            pPrice.HeaderText = "តម្លៃទំនេញ";
            pPrice.Name = "pPrice";
            pPrice.ReadOnly = true;
            pPrice.Width = 92;
            // 
            // pQty
            // 
            pQty.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle6.Font = new Font("Khmer OS Siemreap", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            pQty.DefaultCellStyle = dataGridViewCellStyle6;
            pQty.HeaderText = "ចំនួនស្តុក";
            pQty.Name = "pQty";
            pQty.ReadOnly = true;
            pQty.Width = 84;
            // 
            // pImg
            // 
            pImg.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.Font = new Font("Khmer OS Siemreap", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle7.NullValue = resources.GetObject("dataGridViewCellStyle7.NullValue");
            pImg.DefaultCellStyle = dataGridViewCellStyle7;
            pImg.HeaderText = "រូបភាព";
            pImg.Name = "pImg";
            pImg.ReadOnly = true;
            pImg.Resizable = DataGridViewTriState.True;
            pImg.SortMode = DataGridViewColumnSortMode.Automatic;
            pImg.Width = 70;
            // 
            // ProductForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.InactiveCaption;
            ClientSize = new Size(1200, 1000);
            Controls.Add(pBody);
            Controls.Add(pBottom);
            Controls.Add(pHead);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
            Name = "ProductForm";
            Text = "ProductForm";
            pHead.ResumeLayout(false);
            pHead.PerformLayout();
            pBody.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvProduct).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pHead;
        private Panel pBottom;
        private Button button3;
        private Button button2;
        private Button button1;
        private ComboBox comboBox1;
        private Panel pBody;
        private DataGridView dgvProduct;
        private Label lbCategory;
        private DataGridViewTextBoxColumn pNo;
        private DataGridViewTextBoxColumn pCode;
        private DataGridViewTextBoxColumn pName;
        private DataGridViewTextBoxColumn pPrice;
        private DataGridViewTextBoxColumn pQty;
        private DataGridViewImageColumn pImg;
    }
}