namespace LoginScreen
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
            btnIDClear = new Button();
            lblErrorMsg = new Label();
            btnLogin = new Button();
            txtPW = new TextBox();
            txtID = new TextBox();
            lblAppName = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            btnPWClear = new Button();
            chkShowPW = new CheckBox();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // btnIDClear
            // 
            btnIDClear.Anchor = AnchorStyles.Left;
            btnIDClear.Font = new Font("맑은 고딕", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 129);
            btnIDClear.Location = new Point(373, 168);
            btnIDClear.Name = "btnIDClear";
            btnIDClear.Size = new Size(61, 44);
            btnIDClear.TabIndex = 3;
            btnIDClear.Text = "초기화";
            btnIDClear.UseVisualStyleBackColor = true;
            btnIDClear.Click += btnIDClear_Click;
            // 
            // lblErrorMsg
            // 
            lblErrorMsg.Anchor = AnchorStyles.None;
            lblErrorMsg.AutoSize = true;
            lblErrorMsg.Font = new Font("맑은 고딕", 9F, FontStyle.Regular, GraphicsUnit.Point, 129);
            lblErrorMsg.ForeColor = Color.Red;
            lblErrorMsg.Location = new Point(74, 303);
            lblErrorMsg.Name = "lblErrorMsg";
            lblErrorMsg.Size = new Size(287, 20);
            lblErrorMsg.TabIndex = 6;
            lblErrorMsg.Text = "아이디 또는 비밀번호가 잘못 되었습니다.";
            lblErrorMsg.Visible = false;
            // 
            // btnLogin
            // 
            btnLogin.Anchor = AnchorStyles.None;
            btnLogin.BackColor = Color.DarkOrange;
            btnLogin.Font = new Font("맑은 고딕", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 129);
            btnLogin.ForeColor = SystemColors.ControlText;
            btnLogin.Location = new Point(144, 364);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(146, 58);
            btnLogin.TabIndex = 1;
            btnLogin.Text = "로그인";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // txtPW
            // 
            txtPW.Anchor = AnchorStyles.None;
            txtPW.Font = new Font("맑은 고딕", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 129);
            txtPW.ForeColor = Color.Silver;
            txtPW.Location = new Point(68, 238);
            txtPW.Name = "txtPW";
            txtPW.Size = new Size(299, 38);
            txtPW.TabIndex = 4;
            txtPW.Text = "패스워드";
            txtPW.Enter += txtPW_Enter;
            txtPW.KeyDown += txtPW_KeyDown;
            txtPW.Leave += txtPW_Leave;
            // 
            // txtID
            // 
            txtID.Anchor = AnchorStyles.None;
            txtID.Font = new Font("맑은 고딕", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 129);
            txtID.ForeColor = Color.Silver;
            txtID.Location = new Point(68, 171);
            txtID.Name = "txtID";
            txtID.Size = new Size(299, 38);
            txtID.TabIndex = 2;
            txtID.Text = "아이디";
            txtID.FontChanged += txtID_FontChanged;
            txtID.Enter += txtID_Enter;
            txtID.KeyDown += txtID_KeyDown;
            txtID.Leave += txtID_Leave;
            // 
            // lblAppName
            // 
            lblAppName.Anchor = AnchorStyles.None;
            lblAppName.AutoSize = true;
            lblAppName.Font = new Font("맑은 고딕", 36F, FontStyle.Regular, GraphicsUnit.Point, 129);
            lblAppName.ForeColor = SystemColors.HotTrack;
            lblAppName.Location = new Point(124, 38);
            lblAppName.Name = "lblAppName";
            lblAppName.Size = new Size(186, 81);
            lblAppName.TabIndex = 0;
            lblAppName.Text = "Login";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 15F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 70F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 15F));
            tableLayoutPanel1.Controls.Add(lblAppName, 1, 0);
            tableLayoutPanel1.Controls.Add(txtID, 1, 1);
            tableLayoutPanel1.Controls.Add(txtPW, 1, 2);
            tableLayoutPanel1.Controls.Add(btnLogin, 1, 4);
            tableLayoutPanel1.Controls.Add(lblErrorMsg, 1, 3);
            tableLayoutPanel1.Controls.Add(btnIDClear, 2, 1);
            tableLayoutPanel1.Controls.Add(btnPWClear, 2, 2);
            tableLayoutPanel1.Controls.Add(chkShowPW, 0, 2);
            tableLayoutPanel1.Location = new Point(12, 12);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 5;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 35F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 15F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 15F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.Size = new Size(437, 450);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // btnPWClear
            // 
            btnPWClear.Anchor = AnchorStyles.Left;
            btnPWClear.Font = new Font("맑은 고딕", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 129);
            btnPWClear.Location = new Point(373, 235);
            btnPWClear.Name = "btnPWClear";
            btnPWClear.Size = new Size(61, 44);
            btnPWClear.TabIndex = 5;
            btnPWClear.Text = "초기화";
            btnPWClear.UseVisualStyleBackColor = true;
            btnPWClear.Click += btnPWClear_Click;
            // 
            // chkShowPW
            // 
            chkShowPW.Anchor = AnchorStyles.None;
            chkShowPW.AutoSize = true;
            chkShowPW.Font = new Font("맑은 고딕", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 129);
            chkShowPW.Location = new Point(4, 247);
            chkShowPW.Name = "chkShowPW";
            chkShowPW.Size = new Size(56, 21);
            chkShowPW.TabIndex = 7;
            chkShowPW.Text = "보기";
            chkShowPW.UseVisualStyleBackColor = true;
            chkShowPW.CheckedChanged += chkShowPW_CheckedChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(461, 474);
            Controls.Add(tableLayoutPanel1);
            Name = "Form1";
            Text = "Form1";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button btnIDClear;
        private Label lblErrorMsg;
        private Button btnLogin;
        private TextBox txtPW;
        private TextBox txtID;
        private Label lblAppName;
        private TableLayoutPanel tableLayoutPanel1;
        private Button btnPWClear;
        private CheckBox chkShowPW;
    }
}
