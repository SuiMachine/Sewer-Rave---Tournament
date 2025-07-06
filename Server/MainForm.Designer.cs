
namespace Server
{
    partial class MainForm
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
			NumB_PortUsed = new NumericUpDown();
			tableLayoutPanel1 = new TableLayoutPanel();
			tableLayoutPanel2 = new TableLayoutPanel();
			button1 = new Button();
			label1 = new Label();
			B_Reset = new Button();
			RB_Log = new RichTextBox();
			((System.ComponentModel.ISupportInitialize)NumB_PortUsed).BeginInit();
			tableLayoutPanel1.SuspendLayout();
			tableLayoutPanel2.SuspendLayout();
			SuspendLayout();
			// 
			// NumB_PortUsed
			// 
			NumB_PortUsed.Anchor = AnchorStyles.Left | AnchorStyles.Right;
			NumB_PortUsed.Location = new Point(54, 6);
			NumB_PortUsed.Maximum = new decimal(new int[] { 49151, 0, 0, 0 });
			NumB_PortUsed.Minimum = new decimal(new int[] { 1024, 0, 0, 0 });
			NumB_PortUsed.Name = "NumB_PortUsed";
			NumB_PortUsed.Size = new Size(82, 23);
			NumB_PortUsed.TabIndex = 0;
			NumB_PortUsed.Value = new decimal(new int[] { 1024, 0, 0, 0 });
			// 
			// tableLayoutPanel1
			// 
			tableLayoutPanel1.ColumnCount = 1;
			tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
			tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 0, 0);
			tableLayoutPanel1.Controls.Add(RB_Log, 0, 1);
			tableLayoutPanel1.Dock = DockStyle.Fill;
			tableLayoutPanel1.Location = new Point(0, 0);
			tableLayoutPanel1.Name = "tableLayoutPanel1";
			tableLayoutPanel1.RowCount = 3;
			tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 41F));
			tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 142F));
			tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
			tableLayoutPanel1.Size = new Size(755, 450);
			tableLayoutPanel1.TabIndex = 1;
			// 
			// tableLayoutPanel2
			// 
			tableLayoutPanel2.ColumnCount = 4;
			tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 51F));
			tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 88F));
			tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 97F));
			tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 68F));
			tableLayoutPanel2.Controls.Add(button1, 3, 0);
			tableLayoutPanel2.Controls.Add(NumB_PortUsed, 1, 0);
			tableLayoutPanel2.Controls.Add(label1, 0, 0);
			tableLayoutPanel2.Controls.Add(B_Reset, 2, 0);
			tableLayoutPanel2.Dock = DockStyle.Fill;
			tableLayoutPanel2.Location = new Point(3, 3);
			tableLayoutPanel2.Name = "tableLayoutPanel2";
			tableLayoutPanel2.RowCount = 1;
			tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
			tableLayoutPanel2.Size = new Size(749, 35);
			tableLayoutPanel2.TabIndex = 0;
			// 
			// button1
			// 
			button1.Anchor = AnchorStyles.Left;
			button1.Location = new Point(239, 6);
			button1.Name = "button1";
			button1.Size = new Size(139, 23);
			button1.TabIndex = 3;
			button1.Text = "Save config";
			button1.UseVisualStyleBackColor = true;
			// 
			// label1
			// 
			label1.Anchor = AnchorStyles.Right;
			label1.AutoSize = true;
			label1.Location = new Point(16, 10);
			label1.Name = "label1";
			label1.Size = new Size(32, 15);
			label1.TabIndex = 1;
			label1.Text = "Port:";
			// 
			// B_Reset
			// 
			B_Reset.Anchor = AnchorStyles.Left;
			B_Reset.Location = new Point(142, 6);
			B_Reset.Name = "B_Reset";
			B_Reset.Size = new Size(91, 23);
			B_Reset.TabIndex = 2;
			B_Reset.Text = "Restart server";
			B_Reset.UseVisualStyleBackColor = true;
			B_Reset.Click += B_Reset_Click;
			// 
			// RB_Log
			// 
			RB_Log.Dock = DockStyle.Fill;
			RB_Log.Location = new Point(3, 44);
			RB_Log.Name = "RB_Log";
			RB_Log.Size = new Size(749, 136);
			RB_Log.TabIndex = 1;
			RB_Log.Text = "";
			// 
			// MainForm
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(755, 450);
			Controls.Add(tableLayoutPanel1);
			Name = "MainForm";
			Text = "Sewer Rave - Tournament Server";
			Load += MainForm_Load;
			((System.ComponentModel.ISupportInitialize)NumB_PortUsed).EndInit();
			tableLayoutPanel1.ResumeLayout(false);
			tableLayoutPanel2.ResumeLayout(false);
			tableLayoutPanel2.PerformLayout();
			ResumeLayout(false);
		}
		#endregion

		private NumericUpDown NumB_PortUsed;
		private TableLayoutPanel tableLayoutPanel1;
		private TableLayoutPanel tableLayoutPanel2;
		private Label label1;
		private Button B_Reset;
		private Button button1;
		private RichTextBox RB_Log;
	}
}
