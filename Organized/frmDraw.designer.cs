namespace Organized
{
    partial class frmDraw
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDraw));
            this.pbxPlatno = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNaslov = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.rdbLine = new System.Windows.Forms.RadioButton();
            this.rdbRectangle = new System.Windows.Forms.RadioButton();
            this.rdbEllipse = new System.Windows.Forms.RadioButton();
            this.rdbFreehand = new System.Windows.Forms.RadioButton();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnChoose = new System.Windows.Forms.Button();
            this.numWeight = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.chkSolid = new System.Windows.Forms.CheckBox();
            this.colorDialog = new System.Windows.Forms.ColorDialog();
            ((System.ComponentModel.ISupportInitialize)(this.pbxPlatno)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numWeight)).BeginInit();
            this.SuspendLayout();
            // 
            // pbxPlatno
            // 
            this.pbxPlatno.BackColor = System.Drawing.Color.White;
            this.pbxPlatno.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbxPlatno.Location = new System.Drawing.Point(13, 107);
            this.pbxPlatno.Name = "pbxPlatno";
            this.pbxPlatno.Size = new System.Drawing.Size(775, 331);
            this.pbxPlatno.TabIndex = 0;
            this.pbxPlatno.TabStop = false;
            this.pbxPlatno.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            this.pbxPlatno.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            this.pbxPlatno.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseUp);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(169, 40);
            this.label1.TabIndex = 1;
            this.label1.Text = "New sketch:";
            // 
            // txtNaslov
            // 
            this.txtNaslov.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNaslov.Location = new System.Drawing.Point(188, 20);
            this.txtNaslov.Name = "txtNaslov";
            this.txtNaslov.Size = new System.Drawing.Size(600, 46);
            this.txtNaslov.TabIndex = 2;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(558, 448);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(230, 23);
            this.btnSave.TabIndex = 3;
            this.btnSave.Text = "Save...";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // rdbLine
            // 
            this.rdbLine.AutoSize = true;
            this.rdbLine.Location = new System.Drawing.Point(20, 84);
            this.rdbLine.Name = "rdbLine";
            this.rdbLine.Size = new System.Drawing.Size(44, 17);
            this.rdbLine.TabIndex = 4;
            this.rdbLine.TabStop = true;
            this.rdbLine.Text = "line";
            this.rdbLine.UseVisualStyleBackColor = true;
            this.rdbLine.CheckedChanged += new System.EventHandler(this.rdbLine_CheckedChanged);
            // 
            // rdbRectangle
            // 
            this.rdbRectangle.AutoSize = true;
            this.rdbRectangle.Location = new System.Drawing.Point(76, 84);
            this.rdbRectangle.Name = "rdbRectangle";
            this.rdbRectangle.Size = new System.Drawing.Size(73, 17);
            this.rdbRectangle.TabIndex = 5;
            this.rdbRectangle.TabStop = true;
            this.rdbRectangle.Text = "rectangle";
            this.rdbRectangle.UseVisualStyleBackColor = true;
            // 
            // rdbEllipse
            // 
            this.rdbEllipse.AutoSize = true;
            this.rdbEllipse.Location = new System.Drawing.Point(155, 84);
            this.rdbEllipse.Name = "rdbEllipse";
            this.rdbEllipse.Size = new System.Drawing.Size(58, 17);
            this.rdbEllipse.TabIndex = 6;
            this.rdbEllipse.TabStop = true;
            this.rdbEllipse.Text = "ellipse";
            this.rdbEllipse.UseVisualStyleBackColor = true;
            // 
            // rdbFreehand
            // 
            this.rdbFreehand.AutoSize = true;
            this.rdbFreehand.Location = new System.Drawing.Point(219, 84);
            this.rdbFreehand.Name = "rdbFreehand";
            this.rdbFreehand.Size = new System.Drawing.Size(72, 17);
            this.rdbFreehand.TabIndex = 7;
            this.rdbFreehand.TabStop = true;
            this.rdbFreehand.Text = "freehand";
            this.rdbFreehand.UseVisualStyleBackColor = true;
            this.rdbFreehand.CheckedChanged += new System.EventHandler(this.rdbFreehand_CheckedChanged);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Black;
            this.pictureBox2.Location = new System.Drawing.Point(487, 80);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(20, 20);
            this.pictureBox2.TabIndex = 8;
            this.pictureBox2.TabStop = false;
            // 
            // btnChoose
            // 
            this.btnChoose.Location = new System.Drawing.Point(513, 78);
            this.btnChoose.Name = "btnChoose";
            this.btnChoose.Size = new System.Drawing.Size(124, 23);
            this.btnChoose.TabIndex = 9;
            this.btnChoose.Text = "Select colour...";
            this.btnChoose.UseVisualStyleBackColor = true;
            this.btnChoose.Click += new System.EventHandler(this.button2_Click);
            // 
            // numWeight
            // 
            this.numWeight.Location = new System.Drawing.Point(716, 79);
            this.numWeight.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numWeight.Name = "numWeight";
            this.numWeight.Size = new System.Drawing.Size(72, 22);
            this.numWeight.TabIndex = 10;
            this.numWeight.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(665, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Weight";
            // 
            // chkSolid
            // 
            this.chkSolid.AutoSize = true;
            this.chkSolid.Location = new System.Drawing.Point(346, 84);
            this.chkSolid.Name = "chkSolid";
            this.chkSolid.Size = new System.Drawing.Size(52, 17);
            this.chkSolid.TabIndex = 12;
            this.chkSolid.Text = "Solid";
            this.chkSolid.UseVisualStyleBackColor = true;
            this.chkSolid.CheckedChanged += new System.EventHandler(this.chkSolid_CheckedChanged);
            // 
            // frmDraw
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(255)))), ((int)(((byte)(229)))));
            this.ClientSize = new System.Drawing.Size(800, 480);
            this.Controls.Add(this.chkSolid);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.numWeight);
            this.Controls.Add(this.btnChoose);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.rdbFreehand);
            this.Controls.Add(this.rdbEllipse);
            this.Controls.Add(this.rdbRectangle);
            this.Controls.Add(this.rdbLine);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtNaslov);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pbxPlatno);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmDraw";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Draw a sketch...";
            ((System.ComponentModel.ISupportInitialize)(this.pbxPlatno)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numWeight)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbxPlatno;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNaslov;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.RadioButton rdbLine;
        private System.Windows.Forms.RadioButton rdbRectangle;
        private System.Windows.Forms.RadioButton rdbEllipse;
        private System.Windows.Forms.RadioButton rdbFreehand;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btnChoose;
        private System.Windows.Forms.NumericUpDown numWeight;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox chkSolid;
        private System.Windows.Forms.ColorDialog colorDialog;
    }
}