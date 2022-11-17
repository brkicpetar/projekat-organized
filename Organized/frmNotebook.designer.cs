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
            this.label1 = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.lbxNotebook = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbxNew)).BeginInit();
            this.SuspendLayout();
            // 
            // pbxNew
            // 
            this.pbxNew.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(64)))), ((int)(((byte)(87)))));
            this.pbxNew.Image = ((System.Drawing.Image)(resources.GetObject("pbxNew.Image")));
            this.pbxNew.Location = new System.Drawing.Point(544, 34);
            this.pbxNew.Name = "pbxNew";
            this.pbxNew.Size = new System.Drawing.Size(30, 30);
            this.pbxNew.TabIndex = 16;
            this.pbxNew.TabStop = false;
            // 
            // lblNotebook
            // 
            this.lblNotebook.AutoSize = true;
            this.lblNotebook.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNotebook.Location = new System.Drawing.Point(12, 9);
            this.lblNotebook.Name = "lblNotebook";
            this.lblNotebook.Size = new System.Drawing.Size(291, 77);
            this.lblNotebook.TabIndex = 17;
            this.lblNotebook.Text = "Notebook";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(18, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 41);
            this.label1.TabIndex = 18;
            this.label1.Text = "Search:";
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(150, 105);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(254, 37);
            this.txtSearch.TabIndex = 19;
            // 
            // lbxNotebook
            // 
            this.lbxNotebook.FormattingEnabled = true;
            this.lbxNotebook.ItemHeight = 30;
            this.lbxNotebook.Location = new System.Drawing.Point(19, 183);
            this.lbxNotebook.Name = "lbxNotebook";
            this.lbxNotebook.Size = new System.Drawing.Size(555, 334);
            this.lbxNotebook.TabIndex = 20;
            this.lbxNotebook.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lbxNotebook_MouseDoubleClick);
            // 
            // frmNotebook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(255)))), ((int)(((byte)(229)))));
            this.ClientSize = new System.Drawing.Size(616, 565);
            this.Controls.Add(this.lbxNotebook);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblNotebook);
            this.Controls.Add(this.pbxNew);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.ListBox lbxNotebook;
    }
}