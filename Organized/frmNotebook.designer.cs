namespace Organized
{
    partial class frmNotebook
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmNotebook));
            this.pbxNew = new System.Windows.Forms.PictureBox();
            this.lblNotebook = new System.Windows.Forms.Label();
            this.lbxNotebook = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbxNew)).BeginInit();
            this.SuspendLayout();
            // 
            // pbxNew
            // 
            this.pbxNew.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(64)))), ((int)(((byte)(87)))));
            this.pbxNew.Image = ((System.Drawing.Image)(resources.GetObject("pbxNew.Image")));
            this.pbxNew.Location = new System.Drawing.Point(538, 14);
            this.pbxNew.Name = "pbxNew";
            this.pbxNew.Size = new System.Drawing.Size(30, 30);
            this.pbxNew.TabIndex = 16;
            this.pbxNew.TabStop = false;
            this.pbxNew.Click += new System.EventHandler(this.pbxNew_Click);
            // 
            // lblNotebook
            // 
            this.lblNotebook.AutoSize = true;
            this.lblNotebook.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNotebook.Location = new System.Drawing.Point(12, 7);
            this.lblNotebook.Name = "lblNotebook";
            this.lblNotebook.Size = new System.Drawing.Size(146, 40);
            this.lblNotebook.TabIndex = 17;
            this.lblNotebook.Text = "Notebook";
            // 
            // lbxNotebook
            // 
            this.lbxNotebook.FormattingEnabled = true;
            this.lbxNotebook.Location = new System.Drawing.Point(15, 53);
            this.lbxNotebook.Name = "lbxNotebook";
            this.lbxNotebook.Size = new System.Drawing.Size(555, 381);
            this.lbxNotebook.TabIndex = 20;
            this.lbxNotebook.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lbxNotebook_MouseDoubleClick);
            // 
            // frmNotebook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(255)))), ((int)(((byte)(229)))));
            this.ClientSize = new System.Drawing.Size(586, 450);
            this.Controls.Add(this.lbxNotebook);
            this.Controls.Add(this.lblNotebook);
            this.Controls.Add(this.pbxNew);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmNotebook";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Organized";
            this.Load += new System.EventHandler(this.frmNotebook_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbxNew)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbxNew;
        private System.Windows.Forms.Label lblNotebook;
        private System.Windows.Forms.ListBox lbxNotebook;
    }
}