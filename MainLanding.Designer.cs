namespace Valet_Parking_System
{
    partial class MainLanding
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
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            tableLayoutPanel1 = new TableLayoutPanel();
            tableLayoutPanel3 = new TableLayoutPanel();
            OperatorHoverPanel = new Panel();
            OperatorButton = new Button();
            AdminHoverPanel = new Panel();
            BookingsHoverPanel = new Panel();
            AdminButton = new Button();
            BookingsButton = new Button();
            DashBoardButton = new Button();
            DashHoverPanel = new Panel();
            tableLayoutPanel2 = new TableLayoutPanel();
            UserNameLabel = new Label();
            label2 = new Label();
            tableLayoutPanel5 = new TableLayoutPanel();
            BtnMyDb = new Button();
            ConnectionText = new Label();
            BtnGenerateTables = new Button();
            tableLayoutPanel4 = new TableLayoutPanel();
            ContentPanel = new Panel();
            panel1 = new Panel();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            tableLayoutPanel5.SuspendLayout();
            tableLayoutPanel4.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.BackColor = Color.FromArgb(238, 242, 243);
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(tableLayoutPanel3, 0, 1);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 0, 0);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel4, 0, 3);
            tableLayoutPanel1.Controls.Add(panel1, 0, 2);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Margin = new Padding(0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 4;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 60F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 62F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 3F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(1600, 900);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.BackColor = Color.FromArgb(254, 254, 254);
            tableLayoutPanel3.ColumnCount = 6;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 40F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 40F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel3.Controls.Add(OperatorHoverPanel, 3, 1);
            tableLayoutPanel3.Controls.Add(OperatorButton, 3, 0);
            tableLayoutPanel3.Controls.Add(AdminHoverPanel, 4, 1);
            tableLayoutPanel3.Controls.Add(BookingsHoverPanel, 2, 1);
            tableLayoutPanel3.Controls.Add(AdminButton, 4, 0);
            tableLayoutPanel3.Controls.Add(BookingsButton, 2, 0);
            tableLayoutPanel3.Controls.Add(DashBoardButton, 1, 0);
            tableLayoutPanel3.Controls.Add(DashHoverPanel, 1, 1);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(0, 60);
            tableLayoutPanel3.Margin = new Padding(0);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 2;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 2F));
            tableLayoutPanel3.Size = new Size(1600, 62);
            tableLayoutPanel3.TabIndex = 1;
            // 
            // OperatorHoverPanel
            // 
            OperatorHoverPanel.Dock = DockStyle.Fill;
            OperatorHoverPanel.Location = new Point(800, 60);
            OperatorHoverPanel.Margin = new Padding(0);
            OperatorHoverPanel.Name = "OperatorHoverPanel";
            OperatorHoverPanel.Size = new Size(380, 2);
            OperatorHoverPanel.TabIndex = 10;
            // 
            // OperatorButton
            // 
            OperatorButton.Dock = DockStyle.Fill;
            OperatorButton.Enabled = false;
            OperatorButton.FlatAppearance.BorderColor = Color.FromArgb(254, 254, 254);
            OperatorButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(254, 254, 254);
            OperatorButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(254, 254, 254);
            OperatorButton.FlatStyle = FlatStyle.Flat;
            OperatorButton.Font = new Font("Dubai", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            OperatorButton.ForeColor = Color.FromArgb(37, 42, 53);
            OperatorButton.Location = new Point(800, 0);
            OperatorButton.Margin = new Padding(0);
            OperatorButton.Name = "OperatorButton";
            OperatorButton.Size = new Size(380, 60);
            OperatorButton.TabIndex = 9;
            OperatorButton.Text = "Operator";
            OperatorButton.UseVisualStyleBackColor = true;
            OperatorButton.Click += NavigationButton_Click;
            OperatorButton.MouseEnter += NavigationButton_MouseEnter;
            OperatorButton.MouseLeave += NavigationButton_MouseLeave;
            // 
            // AdminHoverPanel
            // 
            AdminHoverPanel.Dock = DockStyle.Fill;
            AdminHoverPanel.Location = new Point(1180, 60);
            AdminHoverPanel.Margin = new Padding(0);
            AdminHoverPanel.Name = "AdminHoverPanel";
            AdminHoverPanel.Size = new Size(380, 2);
            AdminHoverPanel.TabIndex = 7;
            // 
            // BookingsHoverPanel
            // 
            BookingsHoverPanel.Dock = DockStyle.Fill;
            BookingsHoverPanel.Location = new Point(420, 60);
            BookingsHoverPanel.Margin = new Padding(0);
            BookingsHoverPanel.Name = "BookingsHoverPanel";
            BookingsHoverPanel.Size = new Size(380, 2);
            BookingsHoverPanel.TabIndex = 5;
            // 
            // AdminButton
            // 
            AdminButton.Dock = DockStyle.Fill;
            AdminButton.Enabled = false;
            AdminButton.FlatAppearance.BorderColor = Color.FromArgb(254, 254, 254);
            AdminButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(254, 254, 254);
            AdminButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(254, 254, 254);
            AdminButton.FlatStyle = FlatStyle.Flat;
            AdminButton.Font = new Font("Dubai", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            AdminButton.ForeColor = Color.FromArgb(37, 42, 53);
            AdminButton.Location = new Point(1180, 0);
            AdminButton.Margin = new Padding(0);
            AdminButton.Name = "AdminButton";
            AdminButton.Size = new Size(380, 60);
            AdminButton.TabIndex = 3;
            AdminButton.Text = "Admin";
            AdminButton.UseVisualStyleBackColor = true;
            AdminButton.Click += NavigationButton_Click;
            AdminButton.MouseEnter += NavigationButton_MouseEnter;
            AdminButton.MouseLeave += NavigationButton_MouseLeave;
            // 
            // BookingsButton
            // 
            BookingsButton.Dock = DockStyle.Fill;
            BookingsButton.Enabled = false;
            BookingsButton.FlatAppearance.BorderColor = Color.FromArgb(254, 254, 254);
            BookingsButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(254, 254, 254);
            BookingsButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(254, 254, 254);
            BookingsButton.FlatStyle = FlatStyle.Flat;
            BookingsButton.Font = new Font("Dubai", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BookingsButton.ForeColor = Color.FromArgb(37, 42, 53);
            BookingsButton.Location = new Point(420, 0);
            BookingsButton.Margin = new Padding(0);
            BookingsButton.Name = "BookingsButton";
            BookingsButton.Size = new Size(380, 60);
            BookingsButton.TabIndex = 1;
            BookingsButton.Text = "Bookings";
            BookingsButton.UseVisualStyleBackColor = true;
            BookingsButton.Click += NavigationButton_Click;
            BookingsButton.MouseEnter += NavigationButton_MouseEnter;
            BookingsButton.MouseLeave += NavigationButton_MouseLeave;
            // 
            // DashBoardButton
            // 
            DashBoardButton.Dock = DockStyle.Fill;
            DashBoardButton.Enabled = false;
            DashBoardButton.FlatAppearance.BorderColor = Color.FromArgb(254, 254, 254);
            DashBoardButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(254, 254, 254);
            DashBoardButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(254, 254, 254);
            DashBoardButton.FlatStyle = FlatStyle.Flat;
            DashBoardButton.Font = new Font("Dubai", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            DashBoardButton.ForeColor = Color.FromArgb(37, 42, 53);
            DashBoardButton.Location = new Point(40, 0);
            DashBoardButton.Margin = new Padding(0);
            DashBoardButton.Name = "DashBoardButton";
            DashBoardButton.Size = new Size(380, 60);
            DashBoardButton.TabIndex = 0;
            DashBoardButton.Text = "DashBoard";
            DashBoardButton.UseVisualStyleBackColor = true;
            DashBoardButton.Click += NavigationButton_Click;
            DashBoardButton.MouseEnter += NavigationButton_MouseEnter;
            DashBoardButton.MouseLeave += NavigationButton_MouseLeave;
            // 
            // DashHoverPanel
            // 
            DashHoverPanel.Dock = DockStyle.Fill;
            DashHoverPanel.Location = new Point(40, 60);
            DashHoverPanel.Margin = new Padding(0);
            DashHoverPanel.Name = "DashHoverPanel";
            DashHoverPanel.Size = new Size(380, 2);
            DashHoverPanel.TabIndex = 4;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.BackColor = Color.FromArgb(37, 42, 53);
            tableLayoutPanel2.ColumnCount = 5;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 40F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 231F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 53.8461533F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 46.1538467F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 43F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.Controls.Add(UserNameLabel, 3, 0);
            tableLayoutPanel2.Controls.Add(label2, 1, 0);
            tableLayoutPanel2.Controls.Add(tableLayoutPanel5, 2, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(0, 0);
            tableLayoutPanel2.Margin = new Padding(0);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Size = new Size(1600, 60);
            tableLayoutPanel2.TabIndex = 0;
            // 
            // UserNameLabel
            // 
            UserNameLabel.AutoSize = true;
            UserNameLabel.Dock = DockStyle.Top;
            UserNameLabel.Font = new Font("Dubai", 11.999999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            UserNameLabel.ForeColor = Color.FromArgb(254, 254, 254);
            UserNameLabel.Location = new Point(963, 0);
            UserNameLabel.Margin = new Padding(0);
            UserNameLabel.Name = "UserNameLabel";
            UserNameLabel.Size = new Size(593, 40);
            UserNameLabel.TabIndex = 1;
            UserNameLabel.Text = "TestOperator";
            UserNameLabel.TextAlign = ContentAlignment.MiddleRight;
            UserNameLabel.Visible = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Dock = DockStyle.Fill;
            label2.Font = new Font("Dubai Medium", 16F, FontStyle.Bold);
            label2.ForeColor = Color.FromArgb(254, 254, 254);
            label2.Location = new Point(40, 0);
            label2.Margin = new Padding(0);
            label2.Name = "label2";
            label2.Size = new Size(231, 60);
            label2.TabIndex = 0;
            label2.Text = "ValetParking";
            label2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // tableLayoutPanel5
            // 
            tableLayoutPanel5.ColumnCount = 3;
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel5.Controls.Add(BtnMyDb, 0, 0);
            tableLayoutPanel5.Controls.Add(ConnectionText, 2, 0);
            tableLayoutPanel5.Controls.Add(BtnGenerateTables, 1, 0);
            tableLayoutPanel5.Location = new Point(274, 3);
            tableLayoutPanel5.Name = "tableLayoutPanel5";
            tableLayoutPanel5.RowCount = 1;
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel5.Size = new Size(686, 54);
            tableLayoutPanel5.TabIndex = 2;
            // 
            // BtnMyDb
            // 
            BtnMyDb.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            BtnMyDb.BackColor = Color.FromArgb(57, 62, 73);
            BtnMyDb.FlatStyle = FlatStyle.Flat;
            BtnMyDb.Location = new Point(3, 10);
            BtnMyDb.Name = "BtnMyDb";
            BtnMyDb.Size = new Size(222, 34);
            BtnMyDb.TabIndex = 6;
            BtnMyDb.Text = "My DB";
            BtnMyDb.UseVisualStyleBackColor = false;
            BtnMyDb.Click += BtnMyDb_Click;
            // 
            // ConnectionText
            // 
            ConnectionText.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            ConnectionText.AutoSize = true;
            ConnectionText.Font = new Font("Dubai", 8F);
            ConnectionText.ForeColor = SystemColors.ButtonHighlight;
            ConnectionText.Location = new Point(460, 13);
            ConnectionText.Margin = new Padding(4, 0, 4, 0);
            ConnectionText.Name = "ConnectionText";
            ConnectionText.Size = new Size(222, 27);
            ConnectionText.TabIndex = 4;
            ConnectionText.Text = "ConnectionText";
            ConnectionText.TextAlign = ContentAlignment.BottomLeft;
            // 
            // BtnGenerateTables
            // 
            BtnGenerateTables.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            BtnGenerateTables.BackColor = Color.FromArgb(57, 62, 73);
            BtnGenerateTables.FlatStyle = FlatStyle.Flat;
            BtnGenerateTables.Location = new Point(231, 10);
            BtnGenerateTables.Name = "BtnGenerateTables";
            BtnGenerateTables.Size = new Size(222, 34);
            BtnGenerateTables.TabIndex = 7;
            BtnGenerateTables.Text = "Generate Tables";
            BtnGenerateTables.UseVisualStyleBackColor = false;
            BtnGenerateTables.Click += BtnGenerateTables_Click;
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.BackColor = Color.FromArgb(228, 232, 233);
            tableLayoutPanel4.ColumnCount = 3;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel4.Controls.Add(ContentPanel, 1, 0);
            tableLayoutPanel4.Dock = DockStyle.Fill;
            tableLayoutPanel4.Location = new Point(0, 125);
            tableLayoutPanel4.Margin = new Padding(0);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 2;
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel4.Size = new Size(1600, 775);
            tableLayoutPanel4.TabIndex = 2;
            // 
            // ContentPanel
            // 
            ContentPanel.Dock = DockStyle.Fill;
            ContentPanel.Location = new Point(20, 0);
            ContentPanel.Margin = new Padding(0);
            ContentPanel.Name = "ContentPanel";
            ContentPanel.Size = new Size(1560, 755);
            ContentPanel.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(218, 222, 223);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 122);
            panel1.Margin = new Padding(0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1600, 3);
            panel1.TabIndex = 3;
            // 
            // MainLanding
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = SystemColors.ControlDark;
            BackgroundImageLayout = ImageLayout.None;
            ClientSize = new Size(1600, 900);
            Controls.Add(tableLayoutPanel1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 5, 4, 5);
            Name = "MainLanding";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Valet System";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            tableLayoutPanel5.ResumeLayout(false);
            tableLayoutPanel5.PerformLayout();
            tableLayoutPanel4.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel2;
        private TableLayoutPanel tableLayoutPanel3;
        private Label label2;
        private Button DashBoardButton;
        private Button AdminButton;
        private Button BookingsButton;
        private Panel BookingsHoverPanel;
        private Panel DashHoverPanel;
        private Panel AdminHoverPanel;
        private TableLayoutPanel tableLayoutPanel4;
        private Panel ContentPanel;
        private Panel panel1;
        private Label UserNameLabel;
        private Button OperatorButton;
        private Panel OperatorHoverPanel;
        private TableLayoutPanel tableLayoutPanel5;
        private Label ConnectionText;
        private Button BtnMyDb;
        private Button BtnGenerateTables;
    }
}