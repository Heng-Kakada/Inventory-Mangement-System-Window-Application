namespace InventoryManagementSystem.Controller.SettingFormController
{
    partial class AboutUsForm
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
            label1.Location = new Point(220, 256);
            label1.Name = "label1";
            label1.Size = new Size(165, 31);
            label1.TabIndex = 0;
            label1.Text = "About Us Page";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // AboutUsForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoValidate = AutoValidate.EnablePreventFocusChange;
            BackColor = SystemColors.InactiveCaption;
            ClientSize = new Size(636, 637);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "AboutUsForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "About Us Form";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
    }
}