namespace WinRev
{
    partial class RTForm
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
            btnopen = new Button();
            btnSave = new Button();
            btnClose = new Button();
            ctnCustom = new Button();
            btnColor = new Button();
            btnFont = new Button();
            txtinput = new RichTextBox();
            openFileDialog1 = new OpenFileDialog();
            fontDialog1 = new FontDialog();
            colorDialog1 = new ColorDialog();
            saveFileDialog1 = new SaveFileDialog();
            SuspendLayout();
            // 
            // btnopen
            // 
            btnopen.Location = new Point(38, 28);
            btnopen.Name = "btnopen";
            btnopen.Size = new Size(75, 25);
            btnopen.TabIndex = 0;
            btnopen.Text = "OPEN";
            btnopen.UseVisualStyleBackColor = true;
            btnopen.Click += button1_Click;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(360, 28);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(75, 23);
            btnSave.TabIndex = 1;
            btnSave.Text = "SAVE";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += button2_Click;
            // 
            // btnClose
            // 
            btnClose.Location = new Point(696, 28);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(75, 23);
            btnClose.TabIndex = 2;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // ctnCustom
            // 
            ctnCustom.Location = new Point(696, 328);
            ctnCustom.Name = "ctnCustom";
            ctnCustom.Size = new Size(75, 23);
            ctnCustom.TabIndex = 3;
            ctnCustom.Text = "Custom";
            ctnCustom.UseVisualStyleBackColor = true;
            ctnCustom.Click += ctnCustom_Click;
            // 
            // btnColor
            // 
            btnColor.Location = new Point(360, 328);
            btnColor.Name = "btnColor";
            btnColor.Size = new Size(75, 23);
            btnColor.TabIndex = 4;
            btnColor.Text = "Color";
            btnColor.UseVisualStyleBackColor = true;
            btnColor.Click += btnColor_Click;
            // 
            // btnFont
            // 
            btnFont.Location = new Point(38, 328);
            btnFont.Name = "btnFont";
            btnFont.Size = new Size(75, 25);
            btnFont.TabIndex = 5;
            btnFont.Text = "Font";
            btnFont.UseVisualStyleBackColor = true;
            btnFont.Click += button6_Click;
            // 
            // txtinput
            // 
            txtinput.Location = new Point(38, 75);
            txtinput.Name = "txtinput";
            txtinput.Size = new Size(733, 230);
            txtinput.TabIndex = 6;
            txtinput.Text = "";
            // 
            // RTForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 368);
            Controls.Add(txtinput);
            Controls.Add(btnFont);
            Controls.Add(btnColor);
            Controls.Add(ctnCustom);
            Controls.Add(btnClose);
            Controls.Add(btnSave);
            Controls.Add(btnopen);
            Name = "RTForm";
            Text = "RTForm";
            FormClosing += RTForm_FormClosing;
            Load += RTForm_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button btnopen;
        private Button btnSave;
        private Button btnClose;
        private Button ctnCustom;
        private Button btnColor;
        private Button btnFont;
        private RichTextBox txtinput;
        private OpenFileDialog openFileDialog1;
        private FontDialog fontDialog1;
        private ColorDialog colorDialog1;
        private SaveFileDialog saveFileDialog1;
    }
}