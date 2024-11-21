namespace InventoryManagementSystem.Controller.InventoryFormController
{
    partial class InventoryForm
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

        #region
        private void InitializeComponent()
        {
            label1 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(587, 489);
            label1.Name = "label1";
            label1.Size = new Size(131, 31);
            label1.TabIndex = 0;
            label1.Text = "Inventory Page";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // CategoryForm 
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.InactiveCaption;
            ClientSize = new Size(1371, 1102);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "InventoryForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "InventoryForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
    }
}