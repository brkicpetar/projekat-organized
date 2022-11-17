namespace Organized
{
    partial class CalendarElementDay
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
            this.lblBrojDana = new System.Windows.Forms.Label();
            this.pnlEvent1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pnlEvent2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lblEvent1 = new System.Windows.Forms.Label();
            this.lblEvent2 = new System.Windows.Forms.Label();
            this.pnlEvent1.SuspendLayout();
            this.pnlEvent2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblBrojDana
            // 
            this.lblBrojDana.AutoSize = true;
            this.lblBrojDana.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBrojDana.ForeColor = System.Drawing.Color.White;
            this.lblBrojDana.Location = new System.Drawing.Point(5, 5);
            this.lblBrojDana.Name = "lblBrojDana";
            this.lblBrojDana.Size = new System.Drawing.Size(22, 17);
            this.lblBrojDana.TabIndex = 0;
            this.lblBrojDana.Text = "00";
            // 
            // pnlEvent1
            // 
            this.pnlEvent1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(255)))), ((int)(((byte)(229)))));
            this.pnlEvent1.Controls.Add(this.lblEvent1);
            this.pnlEvent1.Controls.Add(this.panel2);
            this.pnlEvent1.Location = new System.Drawing.Point(0, 27);
            this.pnlEvent1.Name = "pnlEvent1";
            this.pnlEvent1.Size = new System.Drawing.Size(100, 30);
            this.pnlEvent1.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(0, 34);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(100, 30);
            this.panel2.TabIndex = 2;
            // 
            // pnlEvent2
            // 
            this.pnlEvent2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(255)))), ((int)(((byte)(229)))));
            this.pnlEvent2.Controls.Add(this.lblEvent2);
            this.pnlEvent2.Controls.Add(this.panel4);
            this.pnlEvent2.Location = new System.Drawing.Point(0, 61);
            this.pnlEvent2.Name = "pnlEvent2";
            this.pnlEvent2.Size = new System.Drawing.Size(100, 30);
            this.pnlEvent2.TabIndex = 3;
            // 
            // panel4
            // 
            this.panel4.Location = new System.Drawing.Point(0, 34);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(100, 30);
            this.panel4.TabIndex = 2;
            // 
            // lblEvent1
            // 
            this.lblEvent1.Location = new System.Drawing.Point(2, 2);
            this.lblEvent1.Name = "lblEvent1";
            this.lblEvent1.Size = new System.Drawing.Size(97, 28);
            this.lblEvent1.TabIndex = 3;
            this.lblEvent1.Text = "label1";
            // 
            // lblEvent2
            // 
            this.lblEvent2.Location = new System.Drawing.Point(2, -1);
            this.lblEvent2.Name = "lblEvent2";
            this.lblEvent2.Size = new System.Drawing.Size(97, 28);
            this.lblEvent2.TabIndex = 4;
            this.lblEvent2.Text = "label2";
            // 
            // CalendarElementDay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(95)))), ((int)(((byte)(113)))));
            this.Controls.Add(this.pnlEvent2);
            this.Controls.Add(this.pnlEvent1);
            this.Controls.Add(this.lblBrojDana);
            this.Name = "CalendarElementDay";
            this.Size = new System.Drawing.Size(100, 100);
            this.Load += new System.EventHandler(this.CalendarElementDay_Load);
            this.pnlEvent1.ResumeLayout(false);
            this.pnlEvent2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblBrojDana;
        private System.Windows.Forms.Panel pnlEvent1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel pnlEvent2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label lblEvent1;
        private System.Windows.Forms.Label lblEvent2;
    }
}
