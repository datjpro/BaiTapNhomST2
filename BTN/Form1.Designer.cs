namespace BTN
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lbUserName = new Label();
            txtUserName = new TextBox();
            SuspendLayout();
            // 
            // lbUserName
            // 
            lbUserName.AutoSize = true;
            lbUserName.Location = new Point(92, 118);
            lbUserName.Name = "lbUserName";
            lbUserName.Size = new Size(82, 20);
            lbUserName.TabIndex = 0;
            lbUserName.Text = "User Name";
            // 
            // txtUserName
            // 
            txtUserName.Location = new Point(188, 121);
            txtUserName.Name = "txtUserName";
            txtUserName.Size = new Size(125, 27);
            txtUserName.TabIndex = 1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1038, 552);
            Controls.Add(txtUserName);
            Controls.Add(lbUserName);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbUserName;
        private TextBox txtUserName;
    }
}
