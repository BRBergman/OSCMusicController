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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.Close = new System.Windows.Forms.Button();
            this.Open = new System.Windows.Forms.Button();
            this.Prev = new System.Windows.Forms.Button();
            this.Play = new System.Windows.Forms.Button();
            this.Next = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.Close);
            this.splitContainer1.Panel2.Controls.Add(this.Open);
            this.splitContainer1.Panel2.Controls.Add(this.Prev);
            this.splitContainer1.Panel2.Controls.Add(this.Play);
            this.splitContainer1.Panel2.Controls.Add(this.Next);
            this.splitContainer1.Panel2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.splitContainer1.Panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer1_Panel2_Paint);
            this.splitContainer1.Size = new System.Drawing.Size(800, 450);
            this.splitContainer1.SplitterDistance = 118;
            this.splitContainer1.TabIndex = 0;
            // 
            // Close
            // 
            this.Close.Location = new System.Drawing.Point(179, 131);
            this.Close.Name = "Close";
            this.Close.Size = new System.Drawing.Size(155, 23);
            this.Close.TabIndex = 5;
            this.Close.Text = "Close Connection";
            this.Close.UseVisualStyleBackColor = true;
            this.Close.Click += new System.EventHandler(this.Close_Click);
            // 
            // Open
            // 
            this.Open.Location = new System.Drawing.Point(180, 102);
            this.Open.Name = "Open";
            this.Open.Size = new System.Drawing.Size(155, 23);
            this.Open.TabIndex = 4;
            this.Open.Text = "Open Connection";
            this.Open.UseVisualStyleBackColor = true;
            this.Open.Click += new System.EventHandler(this.Open_Click);
            // 
            // Prev
            // 
            this.Prev.Location = new System.Drawing.Point(179, 223);
            this.Prev.Name = "Prev";
            this.Prev.Size = new System.Drawing.Size(75, 23);
            this.Prev.TabIndex = 3;
            this.Prev.Text = "Prev";
            this.Prev.UseVisualStyleBackColor = true;
            this.Prev.Click += new System.EventHandler(this.Prev_Click);
            // 
            // Play
            // 
            this.Play.Location = new System.Drawing.Point(260, 223);
            this.Play.Name = "Play";
            this.Play.Size = new System.Drawing.Size(75, 23);
            this.Play.TabIndex = 2;
            this.Play.Text = "Play/Pause";
            this.Play.UseVisualStyleBackColor = true;
            this.Play.Click += new System.EventHandler(this.Play_Click);
            // 
            // Next
            // 
            this.Next.Location = new System.Drawing.Point(341, 223);
            this.Next.Name = "Next";
            this.Next.Size = new System.Drawing.Size(75, 23);
            this.Next.TabIndex = 1;
            this.Next.Text = "Next";
            this.Next.UseVisualStyleBackColor = true;
            this.Next.Click += new System.EventHandler(this.Next_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.splitContainer1);
            this.Name = "Form1";
            this.Text = "BRBergman\'s Media Controller";
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private SplitContainer splitContainer1;
        private Button Next;
        private Button Play;
        private Button Prev;
        private Button Open;
        private Button Close;
    }
}