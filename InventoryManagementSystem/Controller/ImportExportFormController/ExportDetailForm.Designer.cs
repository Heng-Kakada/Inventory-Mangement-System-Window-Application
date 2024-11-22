namespace InventoryManagementSystem.Controller.ImportExportFormController
{
    partial class ExportDetailForm
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
            pHead = new Panel();
            exportDetailFormTitle = new Label();
            pBottom = new Panel();
            pBody = new Panel();
            panel3 = new Panel();
            dgvExportDetail = new DataGridView();
            panel2 = new Panel();
            btnDelete = new Button();
            textBox1 = new TextBox();
            btnUpdate = new Button();
            label1 = new Label();
            btnAdd = new Button();
            panel1 = new Panel();
            colId = new DataGridViewTextBoxColumn();
            colQtyExport = new DataGridViewTextBoxColumn();
            colUnitPrice = new DataGridViewTextBoxColumn();
            colSubTotal = new DataGridViewTextBoxColumn();
            colExportId = new DataGridViewTextBoxColumn();
            colProductId = new DataGridViewTextBoxColumn();
            colInventoryId = new DataGridViewTextBoxColumn();
            pHead.SuspendLayout();
            pBody.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvExportDetail).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // pHead
            // 
            pHead.Controls.Add(exportDetailFormTitle);
            pHead.Dock = DockStyle.Top;
            pHead.Location = new Point(0, 0);
            pHead.Margin = new Padding(3, 2, 3, 2);
            pHead.Name = "pHead";
            pHead.Size = new Size(1800, 80);
            pHead.TabIndex = 0;
            // 
            // exportDetailFormTitle
            // 
            exportDetailFormTitle.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            exportDetailFormTitle.AutoSize = true;
            exportDetailFormTitle.Font = new Font("Microsoft Sans Serif", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            exportDetailFormTitle.Location = new Point(773, 23);
            exportDetailFormTitle.Name = "exportDetailFormTitle";
            exportDetailFormTitle.Size = new Size(374, 33);
            exportDetailFormTitle.TabIndex = 12;
            exportDetailFormTitle.Text = "Export History's Information";
            // 
            // pBottom
            // 
            pBottom.Dock = DockStyle.Bottom;
            pBottom.Location = new Point(0, 797);
            pBottom.Margin = new Padding(3, 2, 3, 2);
            pBottom.Name = "pBottom";
            pBottom.Size = new Size(1800, 103);
            pBottom.TabIndex = 1;
            // 
            // pBody
            // 
            pBody.Controls.Add(panel3);
            pBody.Controls.Add(panel2);
            pBody.Controls.Add(panel1);
            pBody.Dock = DockStyle.Fill;
            pBody.Location = new Point(0, 80);
            pBody.Name = "pBody";
            pBody.Size = new Size(1800, 717);
            pBody.TabIndex = 2;
            // 
            // panel3
            // 
            panel3.Controls.Add(dgvExportDetail);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(300, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(1452, 717);
            panel3.TabIndex = 3;
            // 
            // dgvExportDetail
            // 
            dgvExportDetail.AllowUserToAddRows = false;
            dgvExportDetail.AllowUserToDeleteRows = false;
            dgvExportDetail.BackgroundColor = SystemColors.Control;
            dgvExportDetail.BorderStyle = BorderStyle.Fixed3D;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.ActiveCaptionText;
            dataGridViewCellStyle1.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = Color.FromArgb(0, 192, 0);
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvExportDetail.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvExportDetail.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvExportDetail.Columns.AddRange(new DataGridViewColumn[] { colId, colQtyExport, colUnitPrice, colSubTotal, colExportId, colProductId, colInventoryId });
            dgvExportDetail.Dock = DockStyle.Fill;
            dgvExportDetail.GridColor = SystemColors.Control;
            dgvExportDetail.Location = new Point(0, 0);
            dgvExportDetail.Name = "dgvExportDetail";
            dgvExportDetail.ReadOnly = true;
            dgvExportDetail.Size = new Size(1452, 717);
            dgvExportDetail.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.Controls.Add(btnDelete);
            panel2.Controls.Add(textBox1);
            panel2.Controls.Add(btnUpdate);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(btnAdd);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(300, 717);
            panel2.TabIndex = 2;
            // 
            // btnDelete
            // 
            btnDelete.Anchor = AnchorStyles.None;
            btnDelete.BackColor = Color.Salmon;
            btnDelete.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnDelete.Location = new Point(62, 410);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(120, 60);
            btnDelete.TabIndex = 20;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            // 
            // textBox1
            // 
            textBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            textBox1.BackColor = SystemColors.Control;
            textBox1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(15, 45);
            textBox1.Margin = new Padding(3, 2, 3, 2);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "search ...";
            textBox1.Size = new Size(269, 26);
            textBox1.TabIndex = 22;
            // 
            // btnUpdate
            // 
            btnUpdate.Anchor = AnchorStyles.None;
            btnUpdate.BackColor = Color.LightYellow;
            btnUpdate.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnUpdate.Location = new Point(62, 297);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(120, 60);
            btnUpdate.TabIndex = 19;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(20, 10);
            label1.Name = "label1";
            label1.Size = new Size(70, 24);
            label1.TabIndex = 21;
            label1.Text = "Search";
            // 
            // btnAdd
            // 
            btnAdd.Anchor = AnchorStyles.None;
            btnAdd.BackColor = Color.LightGreen;
            btnAdd.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAdd.Location = new Point(62, 187);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(120, 60);
            btnAdd.TabIndex = 18;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            panel1.Dock = DockStyle.Right;
            panel1.Location = new Point(1752, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(48, 717);
            panel1.TabIndex = 1;
            // 
            // colId
            // 
            colId.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            dataGridViewCellStyle2.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            colId.DefaultCellStyle = dataGridViewCellStyle2;
            colId.FillWeight = 120F;
            colId.HeaderText = "ID";
            colId.Name = "colId";
            colId.ReadOnly = true;
            colId.Width = 45;
            // 
            // colQtyExport
            // 
            colQtyExport.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colQtyExport.HeaderText = "Qty";
            colQtyExport.Name = "colQtyExport";
            colQtyExport.ReadOnly = true;
            // 
            // colUnitPrice
            // 
            colUnitPrice.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colUnitPrice.HeaderText = "Unit Price";
            colUnitPrice.Name = "colUnitPrice";
            colUnitPrice.ReadOnly = true;
            // 
            // colSubTotal
            // 
            colSubTotal.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colSubTotal.HeaderText = "Sub Total";
            colSubTotal.Name = "colSubTotal";
            colSubTotal.ReadOnly = true;
            // 
            // colExportId
            // 
            colExportId.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colExportId.HeaderText = "Export ID";
            colExportId.Name = "colExportId";
            colExportId.ReadOnly = true;
            // 
            // colProductId
            // 
            colProductId.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colProductId.HeaderText = "Product ID";
            colProductId.Name = "colProductId";
            colProductId.ReadOnly = true;
            // 
            // colInventoryId
            // 
            colInventoryId.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colInventoryId.HeaderText = "Inventory ID";
            colInventoryId.Name = "colInventoryId";
            colInventoryId.ReadOnly = true;
            // 
            // ExportDetailForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.InactiveCaption;
            ClientSize = new Size(1800, 900);
            Controls.Add(pBody);
            Controls.Add(pBottom);
            Controls.Add(pHead);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
            Name = "ExportDetailForm";
            Text = "Export History Form";
            pHead.ResumeLayout(false);
            pHead.PerformLayout();
            pBody.ResumeLayout(false);
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvExportDetail).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pHead;
        private Panel pBottom;
        private Panel pBody;
        private DataGridView dgvExportDetail;
        private Label exportDetailFormTitle;
        private Panel panel3;
        private Panel panel2;
        private Panel panel1;
        private Button btnDelete;
        private TextBox textBox1;
        private Button btnUpdate;
        private Label label1;
        private Button btnAdd;
        private DataGridViewTextBoxColumn colId;
        private DataGridViewTextBoxColumn colQtyExport;
        private DataGridViewTextBoxColumn colUnitPrice;
        private DataGridViewTextBoxColumn colSubTotal;
        private DataGridViewTextBoxColumn colExportId;
        private DataGridViewTextBoxColumn colProductId;
        private DataGridViewTextBoxColumn colInventoryId;
    }
}