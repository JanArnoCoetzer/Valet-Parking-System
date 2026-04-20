namespace Valet_Parking_System.SubForms.LoginFormWidgets
{
    partial class LoginWidget
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tableLayoutPanel1 = new TableLayoutPanel();
            tableLayoutPanel2 = new TableLayoutPanel();
            ValidationErrorLabel = new Label();
            txtpassword = new TextBox();
            txtName = new TextBox();
            txtParkingAvailable = new Label();
            tableLayoutPanel3 = new TableLayoutPanel();
            BtnLogin = new Button();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 120F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 120F));
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 1, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Margin = new Padding(0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(795, 386);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Controls.Add(ValidationErrorLabel, 0, 5);
            tableLayoutPanel2.Controls.Add(txtpassword, 0, 3);
            tableLayoutPanel2.Controls.Add(txtName, 0, 2);
            tableLayoutPanel2.Controls.Add(txtParkingAvailable, 0, 0);
            tableLayoutPanel2.Controls.Add(tableLayoutPanel3, 0, 6);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(120, 20);
            tableLayoutPanel2.Margin = new Padding(0);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 7;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 80F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 57F));
            tableLayoutPanel2.Size = new Size(555, 346);
            tableLayoutPanel2.TabIndex = 1;
            // 
            // ValidationErrorLabel
            // 
            ValidationErrorLabel.AutoSize = true;
            tableLayoutPanel2.SetColumnSpan(ValidationErrorLabel, 2);
            ValidationErrorLabel.Dock = DockStyle.Fill;
            ValidationErrorLabel.Font = new Font("Dubai", 10F);
            ValidationErrorLabel.ForeColor = Color.Red;
            ValidationErrorLabel.Location = new Point(0, 248);
            ValidationErrorLabel.Margin = new Padding(0);
            ValidationErrorLabel.Name = "ValidationErrorLabel";
            ValidationErrorLabel.Size = new Size(555, 40);
            ValidationErrorLabel.TabIndex = 29;
            ValidationErrorLabel.Text = "This is an Error Code";
            ValidationErrorLabel.TextAlign = ContentAlignment.MiddleCenter;
            ValidationErrorLabel.Visible = false;
            // 
            // txtpassword
            // 
            txtpassword.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtpassword.Font = new Font("Dubai", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtpassword.ForeColor = Color.FromArgb(37, 42, 53);
            txtpassword.Location = new Point(0, 164);
            txtpassword.Margin = new Padding(0);
            txtpassword.Name = "txtpassword";
            txtpassword.PasswordChar = '*';
            txtpassword.PlaceholderText = "Password";
            txtpassword.Size = new Size(555, 41);
            txtpassword.TabIndex = 11;
            txtpassword.TextAlign = HorizontalAlignment.Center;
            // 
            // txtName
            // 
            txtName.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtName.Font = new Font("Dubai", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtName.ForeColor = Color.FromArgb(37, 42, 53);
            txtName.Location = new Point(0, 124);
            txtName.Margin = new Padding(0);
            txtName.Name = "txtName";
            txtName.PlaceholderText = "Name";
            txtName.Size = new Size(555, 41);
            txtName.TabIndex = 10;
            txtName.TextAlign = HorizontalAlignment.Center;
            // 
            // txtParkingAvailable
            // 
            txtParkingAvailable.AutoSize = true;
            txtParkingAvailable.Dock = DockStyle.Fill;
            txtParkingAvailable.FlatStyle = FlatStyle.Flat;
            txtParkingAvailable.Font = new Font("Dubai", 28F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtParkingAvailable.ForeColor = Color.FromArgb(8, 108, 236);
            txtParkingAvailable.Location = new Point(0, 0);
            txtParkingAvailable.Margin = new Padding(0);
            txtParkingAvailable.Name = "txtParkingAvailable";
            txtParkingAvailable.Size = new Size(555, 80);
            txtParkingAvailable.TabIndex = 6;
            txtParkingAvailable.Text = "Valet Parking System";
            txtParkingAvailable.TextAlign = ContentAlignment.TopCenter;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 3;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 330F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.Controls.Add(BtnLogin, 1, 0);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(0, 288);
            tableLayoutPanel3.Margin = new Padding(0);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 1;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.Size = new Size(555, 58);
            tableLayoutPanel3.TabIndex = 12;
            // 
            // BtnLogin
            // 
            BtnLogin.BackColor = Color.FromArgb(8, 108, 236);
            BtnLogin.Dock = DockStyle.Fill;
            BtnLogin.FlatStyle = FlatStyle.Flat;
            BtnLogin.Font = new Font("Dubai Medium", 11.999999F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnLogin.ForeColor = Color.FromArgb(254, 254, 254);
            BtnLogin.Location = new Point(112, 0);
            BtnLogin.Margin = new Padding(0);
            BtnLogin.Name = "BtnLogin";
            BtnLogin.Size = new Size(330, 58);
            BtnLogin.TabIndex = 13;
            BtnLogin.Text = "Log In";
            BtnLogin.UseVisualStyleBackColor = false;
            BtnLogin.Click += BtnLogin_Click;
            // 
            // LoginWidget
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(254, 254, 254);
            Controls.Add(tableLayoutPanel1);
            Margin = new Padding(0);
            Name = "LoginWidget";
            Size = new Size(795, 386);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            tableLayoutPanel3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel2;
        private Label txtParkingAvailable;
        private TextBox txtpassword;
        private TextBox txtName;
        private TableLayoutPanel tableLayoutPanel3;
        private Button BtnLogin;
        private Label ValidationErrorLabel;
    }
}
