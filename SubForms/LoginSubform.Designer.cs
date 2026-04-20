namespace Valet_Parking_System.SubForms
{
    partial class LoginSubform
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
            loginWidget = new Valet_Parking_System.SubForms.LoginFormWidgets.LoginWidget();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 24.4897976F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 51.0204124F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 24.4897976F));
            tableLayoutPanel1.Controls.Add(loginWidget, 1, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Margin = new Padding(0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 24.4897976F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 51.0204124F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 24.4897976F));
            tableLayoutPanel1.Size = new Size(1560, 757);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // loginWidget
            // 
            loginWidget.BackColor = Color.FromArgb(254, 254, 254);
            loginWidget.Location = new Point(382, 185);
            loginWidget.Margin = new Padding(0);
            loginWidget.Name = "loginWidget";
            loginWidget.Size = new Size(795, 386);
            loginWidget.TabIndex = 0;
            // 
            // LoginSubform
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tableLayoutPanel1);
            Margin = new Padding(0);
            Name = "LoginSubform";
            Size = new Size(1560, 757);
            tableLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private LoginFormWidgets.LoginWidget loginWidget;
    }
}
