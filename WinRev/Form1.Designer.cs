namespace WinRev
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
            btncancel = new Button();
            btnOk = new Button();
            lblpasswor = new Label();
            lblusername = new Label();
            txtpassword = new TextBox();
            txtuser = new TextBox();
            SuspendLayout();
            // 
            // btncancel
            // 
            btncancel.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btncancel.Location = new Point(65, 277);
            btncancel.Name = "btncancel";
            btncancel.Size = new Size(75, 23);
            btncancel.TabIndex = 3;
            btncancel.Text = "Cancel";
            btncancel.UseVisualStyleBackColor = true;
            btncancel.Click += btncancel_Click;
            // 
            // btnOk
            // 
            btnOk.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnOk.Location = new Point(311, 277);
            btnOk.Name = "btnOk";
            btnOk.Size = new Size(75, 23);
            btnOk.TabIndex = 2;
            btnOk.Text = "Ok";
            btnOk.UseVisualStyleBackColor = true;
            btnOk.Click += btnOk_Click;
            // 
            // lblpasswor
            // 
            lblpasswor.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            lblpasswor.AutoSize = true;
            lblpasswor.Location = new Point(27, 170);
            lblpasswor.Name = "lblpasswor";
            lblpasswor.Size = new Size(57, 15);
            lblpasswor.TabIndex = 2;
            lblpasswor.Text = "password";
            // 
            // lblusername
            // 
            lblusername.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            lblusername.AutoSize = true;
            lblusername.Location = new Point(27, 52);
            lblusername.Name = "lblusername";
            lblusername.Size = new Size(59, 15);
            lblusername.TabIndex = 3;
            lblusername.Text = "username";
            // 
            // txtpassword
            // 
            txtpassword.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtpassword.Location = new Point(99, 162);
            txtpassword.Name = "txtpassword";
            txtpassword.Size = new Size(287, 23);
            txtpassword.TabIndex = 1;
            txtpassword.UseSystemPasswordChar = true;
            // 
            // txtuser
            // 
            txtuser.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtuser.Location = new Point(99, 49);
            txtuser.Name = "txtuser";
            txtuser.Size = new Size(287, 23);
            txtuser.TabIndex = 0;
            // 
            // Form1
            // 
            AcceptButton = btnOk;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btncancel;
            ClientSize = new Size(446, 362);
            Controls.Add(txtuser);
            Controls.Add(txtpassword);
            Controls.Add(lblusername);
            Controls.Add(lblpasswor);
            Controls.Add(btnOk);
            Controls.Add(btncancel);
            MinimumSize = new Size(462, 401);
            Name = "Form1";
            Text = "lojinform";
            FormClosing += Form1_FormClosing;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btncancel;
        private Button btnOk;
        private Label lblpasswor;
        private Label lblusername;
        private TextBox txtpassword;
        private TextBox txtuser;
    }
}