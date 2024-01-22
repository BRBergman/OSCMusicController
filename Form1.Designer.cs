namespace WinFormsApp1
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
            if (disposing && ( components != null ))
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
			splitContainer1 = new SplitContainer();
			OnOffBox = new CheckBox();
			PortTextBox = new TextBox();
			CloseWNP = new Button();
			OpenWNP = new Button();
			Prev = new Button();
			Play = new Button();
			Next = new Button();
			WNPEnabled = new CheckBox();
			((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
			splitContainer1.Panel2.SuspendLayout();
			splitContainer1.SuspendLayout();
			SuspendLayout();
			// 
			// splitContainer1
			// 
			splitContainer1.Dock = DockStyle.Fill;
			splitContainer1.Location = new Point(0, 0);
			splitContainer1.Name = "splitContainer1";
			// 
			// splitContainer1.Panel2
			// 
			splitContainer1.Panel2.Controls.Add(WNPEnabled);
			splitContainer1.Panel2.Controls.Add(OnOffBox);
			splitContainer1.Panel2.Controls.Add(PortTextBox);
			splitContainer1.Panel2.Controls.Add(CloseWNP);
			splitContainer1.Panel2.Controls.Add(OpenWNP);
			splitContainer1.Panel2.Controls.Add(Prev);
			splitContainer1.Panel2.Controls.Add(Play);
			splitContainer1.Panel2.Controls.Add(Next);
			splitContainer1.Panel2.ForeColor = SystemColors.ControlText;
			splitContainer1.Panel2.Paint += splitContainer1_Panel2_Paint;
			splitContainer1.Size = new Size(800, 450);
			splitContainer1.SplitterDistance = 118;
			splitContainer1.TabIndex = 0;
			// 
			// OnOffBox
			// 
			OnOffBox.AutoCheck = false;
			OnOffBox.AutoSize = true;
			OnOffBox.Location = new Point(178, 184);
			OnOffBox.Name = "OnOffBox";
			OnOffBox.RightToLeft = RightToLeft.Yes;
			OnOffBox.Size = new Size(76, 19);
			OnOffBox.TabIndex = 7;
			OnOffBox.Text = "On or Off";
			OnOffBox.UseVisualStyleBackColor = true;
			// 
			// PortTextBox
			// 
			PortTextBox.Location = new Point(260, 182);
			PortTextBox.Name = "PortTextBox";
			PortTextBox.PlaceholderText = "Enter Port";
			PortTextBox.Size = new Size(100, 23);
			PortTextBox.TabIndex = 6;
			PortTextBox.Text = "1234";
			PortTextBox.TextChanged += PortTextBox_TextChanged;
			PortTextBox.KeyPress += PortTextBox_KeyPress;
			// 
			// CloseWNP
			// 
			CloseWNP.Location = new Point(179, 131);
			CloseWNP.Name = "CloseWNP";
			CloseWNP.Size = new Size(155, 23);
			CloseWNP.TabIndex = 5;
			CloseWNP.Text = "Close Connection";
			CloseWNP.UseVisualStyleBackColor = true;
			CloseWNP.Click += Close_Click;
			// 
			// OpenWNP
			// 
			OpenWNP.Location = new Point(180, 102);
			OpenWNP.Name = "OpenWNP";
			OpenWNP.Size = new Size(155, 23);
			OpenWNP.TabIndex = 4;
			OpenWNP.Text = "Open Connection";
			OpenWNP.UseVisualStyleBackColor = true;
			OpenWNP.Click += Open_Click;
			// 
			// Prev
			// 
			Prev.Location = new Point(179, 223);
			Prev.Name = "Prev";
			Prev.Size = new Size(75, 23);
			Prev.TabIndex = 3;
			Prev.Text = "Prev";
			Prev.UseVisualStyleBackColor = true;
			Prev.Click += Prev_Click;
			// 
			// Play
			// 
			Play.Location = new Point(260, 223);
			Play.Name = "Play";
			Play.Size = new Size(75, 23);
			Play.TabIndex = 2;
			Play.Text = "Play/Pause";
			Play.UseVisualStyleBackColor = true;
			Play.Click += Play_Click;
			// 
			// Next
			// 
			Next.Location = new Point(341, 223);
			Next.Name = "Next";
			Next.Size = new Size(75, 23);
			Next.TabIndex = 1;
			Next.Text = "Next";
			Next.UseVisualStyleBackColor = true;
			Next.Click += Next_Click;
			// 
			// WNPEnabled
			// 
			WNPEnabled.AutoSize = true;
			WNPEnabled.Checked = true;
			WNPEnabled.CheckState = CheckState.Checked;
			WNPEnabled.Location = new Point(223, 75);
			WNPEnabled.Name = "WNPEnabled";
			WNPEnabled.Size = new Size(120, 19);
			WNPEnabled.TabIndex = 8;
			WNPEnabled.Text = "Web Now Playing";
			WNPEnabled.UseVisualStyleBackColor = true;
			WNPEnabled.CheckedChanged += WNPEnabled_CheckedChanged;
			// 
			// Form1
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(800, 450);
			Controls.Add(splitContainer1);
			Name = "Form1";
			Text = "BRBergman's Media Controller";
			splitContainer1.Panel2.ResumeLayout(false);
			splitContainer1.Panel2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
			splitContainer1.ResumeLayout(false);
			ResumeLayout(false);
		}

		#endregion

		private SplitContainer splitContainer1;
        private Button Next;
        private Button Play;
        private Button Prev;
        private Button OpenWNP;
        private Button CloseWNP;
		private TextBox PortTextBox;
		private CheckBox OnOffBox;
		private CheckBox WNPEnabled;
	}
}