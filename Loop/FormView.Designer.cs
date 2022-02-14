namespace Loop
{
    partial class FormView
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
            this.components = new System.ComponentModel.Container();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.txtMoves = new System.Windows.Forms.Label();
            this.txtFinish = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.TMR_Tick);
            // 
            // txtMoves
            // 
            this.txtMoves.AutoSize = true;
            this.txtMoves.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtMoves.ForeColor = System.Drawing.Color.White;
            this.txtMoves.Location = new System.Drawing.Point(1, -4);
            this.txtMoves.Name = "txtMoves";
            this.txtMoves.Size = new System.Drawing.Size(141, 41);
            this.txtMoves.TabIndex = 0;
            this.txtMoves.Text = "moves: 0";
            // 
            // txtFinish
            // 
            this.txtFinish.AutoSize = true;
            this.txtFinish.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtFinish.ForeColor = System.Drawing.Color.Fuchsia;
            this.txtFinish.Location = new System.Drawing.Point(197, -4);
            this.txtFinish.Name = "txtFinish";
            this.txtFinish.Size = new System.Drawing.Size(86, 54);
            this.txtFinish.TabIndex = 1;
            this.txtFinish.Text = "xyz";
            // 
            // FormView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(900, 900);
            this.Controls.Add(this.txtFinish);
            this.Controls.Add(this.txtMoves);
            this.Name = "FormView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Loop";
            this.Load += new System.EventHandler(this.FormView_Load);
            this.Click += new System.EventHandler(this.FormView_Click);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.FormView_Paint);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private Label txtMoves;
        private Label txtFinish;
    }
}