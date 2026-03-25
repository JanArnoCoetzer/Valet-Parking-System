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
            AdminHoverPanel = new Panel();
            RetrievalQueueHoverPanel = new Panel();
            BookingsHoverPanel = new Panel();
            AdminButton = new Button();
            RetrievalQueueButton = new Button();
            BookingsButton = new Button();
            DashBoardButton = new Button();
            DashHoverPanel = new Panel();
            tableLayoutPanel2 = new TableLayoutPanel();
            label1 = new Label();
            label2 = new Label();
            tableLayoutPanel4 = new TableLayoutPanel();
            ContentPanel = new Panel();
            panel1 = new Panel();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
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
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 60F));
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
            tableLayoutPanel3.Controls.Add(AdminHoverPanel, 4, 1);
            tableLayoutPanel3.Controls.Add(RetrievalQueueHoverPanel, 3, 1);
            tableLayoutPanel3.Controls.Add(BookingsHoverPanel, 2, 1);
            tableLayoutPanel3.Controls.Add(AdminButton, 4, 0);
            tableLayoutPanel3.Controls.Add(RetrievalQueueButton, 3, 0);
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
            tableLayoutPanel3.Size = new Size(1600, 60);
            tableLayoutPanel3.TabIndex = 1;
            // 
            // AdminHoverPanel
            // 
            AdminHoverPanel.Dock = DockStyle.Fill;
            AdminHoverPanel.Location = new Point(1180, 58);
            AdminHoverPanel.Margin = new Padding(0);
            AdminHoverPanel.Name = "AdminHoverPanel";
            AdminHoverPanel.Size = new Size(380, 2);
            AdminHoverPanel.TabIndex = 7;
            // 
            // RetrievalQueueHoverPanel
            // 
            RetrievalQueueHoverPanel.Dock = DockStyle.Fill;
            RetrievalQueueHoverPanel.Location = new Point(800, 58);
            RetrievalQueueHoverPanel.Margin = new Padding(0);
            RetrievalQueueHoverPanel.Name = "RetrievalQueueHoverPanel";
            RetrievalQueueHoverPanel.Size = new Size(380, 2);
            RetrievalQueueHoverPanel.TabIndex = 6;
            // 
            // BookingsHoverPanel
            // 
            BookingsHoverPanel.Dock = DockStyle.Fill;
            BookingsHoverPanel.Location = new Point(420, 58);
            BookingsHoverPanel.Margin = new Padding(0);
            BookingsHoverPanel.Name = "BookingsHoverPanel";
            BookingsHoverPanel.Size = new Size(380, 2);
            BookingsHoverPanel.TabIndex = 5;
            // 
            // AdminButton
            // 
            AdminButton.Dock = DockStyle.Fill;
            AdminButton.FlatAppearance.BorderColor = Color.FromArgb(254, 254, 254);
            AdminButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(254, 254, 254);
            AdminButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(254, 254, 254);
            AdminButton.FlatStyle = FlatStyle.Flat;
            AdminButton.Font = new Font("Dubai", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            AdminButton.ForeColor = Color.FromArgb(37, 42, 53);
            AdminButton.Location = new Point(1180, 0);
            AdminButton.Margin = new Padding(0);
            AdminButton.Name = "AdminButton";
            AdminButton.Size = new Size(380, 58);
            AdminButton.TabIndex = 3;
            AdminButton.Text = "Admin";
            AdminButton.UseVisualStyleBackColor = true;
            AdminButton.Click += NavigationButton_Click;
            AdminButton.MouseEnter += NavigationButton_MouseEnter;
            AdminButton.MouseLeave += NavigationButton_MouseLeave;
            // 
            // RetrievalQueueButton
            // 
            RetrievalQueueButton.Dock = DockStyle.Fill;
            RetrievalQueueButton.FlatAppearance.BorderColor = Color.FromArgb(254, 254, 254);
            RetrievalQueueButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(254, 254, 254);
            RetrievalQueueButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(254, 254, 254);
            RetrievalQueueButton.FlatStyle = FlatStyle.Flat;
            RetrievalQueueButton.Font = new Font("Dubai", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            RetrievalQueueButton.ForeColor = Color.FromArgb(37, 42, 53);
            RetrievalQueueButton.Location = new Point(800, 0);
            RetrievalQueueButton.Margin = new Padding(0);
            RetrievalQueueButton.Name = "RetrievalQueueButton";
            RetrievalQueueButton.Size = new Size(380, 58);
            RetrievalQueueButton.TabIndex = 2;
            RetrievalQueueButton.Text = "Retrieval Queue";
            RetrievalQueueButton.UseVisualStyleBackColor = true;
            RetrievalQueueButton.Click += NavigationButton_Click;
            RetrievalQueueButton.MouseEnter += NavigationButton_MouseEnter;
            RetrievalQueueButton.MouseLeave += NavigationButton_MouseLeave;
            // 
            // BookingsButton
            // 
            BookingsButton.Dock = DockStyle.Fill;
            BookingsButton.FlatAppearance.BorderColor = Color.FromArgb(254, 254, 254);
            BookingsButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(254, 254, 254);
            BookingsButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(254, 254, 254);
            BookingsButton.FlatStyle = FlatStyle.Flat;
            BookingsButton.Font = new Font("Dubai", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BookingsButton.ForeColor = Color.FromArgb(37, 42, 53);
            BookingsButton.Location = new Point(420, 0);
            BookingsButton.Margin = new Padding(0);
            BookingsButton.Name = "BookingsButton";
            BookingsButton.Size = new Size(380, 58);
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
            DashBoardButton.FlatAppearance.BorderColor = Color.FromArgb(254, 254, 254);
            DashBoardButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(254, 254, 254);
            DashBoardButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(254, 254, 254);
            DashBoardButton.FlatStyle = FlatStyle.Flat;
            DashBoardButton.Font = new Font("Dubai", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            DashBoardButton.ForeColor = Color.FromArgb(37, 42, 53);
            DashBoardButton.Location = new Point(40, 0);
            DashBoardButton.Margin = new Padding(0);
            DashBoardButton.Name = "DashBoardButton";
            DashBoardButton.Size = new Size(380, 58);
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
            DashHoverPanel.Location = new Point(40, 58);
            DashHoverPanel.Margin = new Padding(0);
            DashHoverPanel.Name = "DashHoverPanel";
            DashHoverPanel.Size = new Size(380, 2);
            DashHoverPanel.TabIndex = 4;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.BackColor = Color.FromArgb(37, 42, 53);
            tableLayoutPanel2.ColumnCount = 6;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 40F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 310F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 59F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 88F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 40F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.Controls.Add(label1, 4, 0);
            tableLayoutPanel2.Controls.Add(label2, 1, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(0, 0);
            tableLayoutPanel2.Margin = new Padding(0);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Size = new Size(1600, 60);
            tableLayoutPanel2.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = DockStyle.Fill;
            label1.Font = new Font("Dubai", 11.999999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(254, 254, 254);
            label1.Location = new Point(1472, 0);
            label1.Margin = new Padding(0);
            label1.Name = "label1";
            label1.Size = new Size(88, 60);
            label1.TabIndex = 1;
            label1.Text = "John";
            label1.TextAlign = ContentAlignment.MiddleLeft;
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
            label2.Size = new Size(310, 60);
            label2.TabIndex = 0;
            label2.Text = "ValetParking";
            label2.TextAlign = ContentAlignment.MiddleLeft;
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
            tableLayoutPanel4.Location = new Point(0, 123);
            tableLayoutPanel4.Margin = new Padding(0);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 2;
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel4.Size = new Size(1600, 777);
            tableLayoutPanel4.TabIndex = 2;
            // 
            // ContentPanel
            // 
            ContentPanel.Dock = DockStyle.Fill;
            ContentPanel.Location = new Point(20, 0);
            ContentPanel.Margin = new Padding(0);
            ContentPanel.Name = "ContentPanel";
            ContentPanel.Size = new Size(1560, 757);
            ContentPanel.TabIndex = 0;
            ContentPanel.Paint += ContentPanel_Paint;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(218, 222, 223);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 120);
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
        private Button RetrievalQueueButton;
        private Button BookingsButton;
        private Panel BookingsHoverPanel;
        private Panel DashHoverPanel;
        private Panel AdminHoverPanel;
        private Panel RetrievalQueueHoverPanel;
        private TableLayoutPanel tableLayoutPanel4;
        private Panel ContentPanel;
        private Panel panel1;
        private Label label1;
    }
}