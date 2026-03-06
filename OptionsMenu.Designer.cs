namespace ClockWidget
{
    partial class OptionsMenu
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
            components = new System.ComponentModel.Container();
            linkLabelDisplaySettings = new LinkLabel();
            label1 = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            pictureBox1 = new PictureBox();
            linkLabelCreditGitHub = new LinkLabel();
            label = new Label();
            toolTip1 = new ToolTip(components);
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // linkLabelDisplaySettings
            // 
            linkLabelDisplaySettings.Anchor = AnchorStyles.Right;
            linkLabelDisplaySettings.AutoSize = true;
            linkLabelDisplaySettings.LinkArea = new LinkArea(0, 16);
            linkLabelDisplaySettings.Location = new Point(371, 323);
            linkLabelDisplaySettings.Name = "linkLabelDisplaySettings";
            linkLabelDisplaySettings.Size = new Size(80, 21);
            linkLabelDisplaySettings.TabIndex = 0;
            linkLabelDisplaySettings.TabStop = true;
            linkLabelDisplaySettings.Text = "Select Display";
            linkLabelDisplaySettings.UseCompatibleTextRendering = true;
            linkLabelDisplaySettings.LinkClicked += linkLabelDisplaySettings_LinkClicked;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Left;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(3, 0);
            label1.Name = "label1";
            label1.Size = new Size(151, 51);
            label1.TabIndex = 1;
            label1.Text = "Clock Widget Settings";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 30F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Controls.Add(label, 1, 1);
            tableLayoutPanel1.Controls.Add(pictureBox1, 2, 0);
            tableLayoutPanel1.Controls.Add(label1, 0, 0);
            tableLayoutPanel1.Controls.Add(linkLabelCreditGitHub, 1, 0);
            tableLayoutPanel1.Controls.Add(linkLabelDisplaySettings, 1, 6);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 7;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 14.2857141F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 14.2857141F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 14.2857141F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 14.2857141F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 14.2857141F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 14.2857141F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 14.2857141F));
            tableLayoutPanel1.Size = new Size(484, 361);
            tableLayoutPanel1.TabIndex = 2;
            tableLayoutPanel1.Paint += tableLayoutPanel1_Paint;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(457, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(24, 45);
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            toolTip1.SetToolTip(pictureBox1, "test");
            // 
            // linkLabelCreditGitHub
            // 
            linkLabelCreditGitHub.Anchor = AnchorStyles.Right;
            linkLabelCreditGitHub.AutoSize = true;
            linkLabelCreditGitHub.Location = new Point(318, 18);
            linkLabelCreditGitHub.Name = "linkLabelCreditGitHub";
            linkLabelCreditGitHub.Size = new Size(133, 15);
            linkLabelCreditGitHub.TabIndex = 3;
            linkLabelCreditGitHub.TabStop = true;
            linkLabelCreditGitHub.Text = "Created by Tyler Peaster";
            linkLabelCreditGitHub.LinkClicked += linkLabelCreditGitHub_LinkClicked;
            // 
            // label
            // 
            label.AutoSize = true;
            label.Dock = DockStyle.Fill;
            label.Location = new Point(230, 51);
            label.Name = "label";
            label.Size = new Size(221, 51);
            label.TabIndex = 4;
            label.Text = "label2";
            toolTip1.SetToolTip(label, "TEST");
            // 
            // toolTip1
            // 
            toolTip1.BackColor = SystemColors.GrayText;
            toolTip1.ForeColor = SystemColors.Highlight;
            toolTip1.ToolTipIcon = ToolTipIcon.Info;
            // 
            // OptionsMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(484, 361);
            Controls.Add(tableLayoutPanel1);
            Name = "OptionsMenu";
            Text = "OptionsMenu";
            Load += OptionsMenu_Load;
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private LinkLabel linkLabelDisplaySettings;
        private Label label1;
        private TableLayoutPanel tableLayoutPanel1;
        private LinkLabel linkLabelCreditGitHub;
        private Label label;
        private ToolTip toolTip1;
        private PictureBox pictureBox1;
    }
}