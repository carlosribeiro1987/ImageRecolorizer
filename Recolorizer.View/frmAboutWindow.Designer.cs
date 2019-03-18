namespace Recolorizer.View {
    partial class frmAboutWindow {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAboutWindow));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtAboutSoftware = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.picEmail = new System.Windows.Forms.PictureBox();
            this.picLinkedIn = new System.Windows.Forms.PictureBox();
            this.picGithub = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picEmail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLinkedIn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picGithub)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtAboutSoftware);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(423, 268);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sobre o programa:";
            // 
            // txtAboutSoftware
            // 
            this.txtAboutSoftware.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAboutSoftware.Location = new System.Drawing.Point(12, 19);
            this.txtAboutSoftware.Multiline = true;
            this.txtAboutSoftware.Name = "txtAboutSoftware";
            this.txtAboutSoftware.ReadOnly = true;
            this.txtAboutSoftware.Size = new System.Drawing.Size(399, 236);
            this.txtAboutSoftware.TabIndex = 0;
            this.txtAboutSoftware.TabStop = false;
            this.txtAboutSoftware.Text = resources.GetString("txtAboutSoftware.Text");
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.picEmail);
            this.groupBox2.Controls.Add(this.picLinkedIn);
            this.groupBox2.Controls.Add(this.picGithub);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(12, 286);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(423, 171);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Desenvolvedor";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(159, 147);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Carlos Ribeiro - 2019";
            // 
            // picEmail
            // 
            this.picEmail.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picEmail.Image = global::Recolorizer.View.Properties.Resources.ios7_email;
            this.picEmail.Location = new System.Drawing.Point(242, 89);
            this.picEmail.Name = "picEmail";
            this.picEmail.Size = new System.Drawing.Size(50, 50);
            this.picEmail.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picEmail.TabIndex = 3;
            this.picEmail.TabStop = false;
            this.picEmail.Click += new System.EventHandler(this.picEmail_Click);
            this.picEmail.MouseDown += new System.Windows.Forms.MouseEventHandler(this.picEmail_MouseDown);
            this.picEmail.MouseEnter += new System.EventHandler(this.picEmail_MouseEnter);
            this.picEmail.MouseLeave += new System.EventHandler(this.picEmail_MouseLeave);
            this.picEmail.MouseMove += new System.Windows.Forms.MouseEventHandler(this.picEmail_MouseMove);
            this.picEmail.MouseUp += new System.Windows.Forms.MouseEventHandler(this.picEmail_MouseUp);
            // 
            // picLinkedIn
            // 
            this.picLinkedIn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picLinkedIn.Image = global::Recolorizer.View.Properties.Resources.social_linkedin;
            this.picLinkedIn.Location = new System.Drawing.Point(186, 89);
            this.picLinkedIn.Name = "picLinkedIn";
            this.picLinkedIn.Size = new System.Drawing.Size(50, 50);
            this.picLinkedIn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picLinkedIn.TabIndex = 2;
            this.picLinkedIn.TabStop = false;
            this.picLinkedIn.Click += new System.EventHandler(this.picLinkedIn_Click);
            this.picLinkedIn.MouseDown += new System.Windows.Forms.MouseEventHandler(this.picLinkedIn_MouseDown);
            this.picLinkedIn.MouseEnter += new System.EventHandler(this.picLinkedIn_MouseEnter);
            this.picLinkedIn.MouseLeave += new System.EventHandler(this.picLinkedIn_MouseLeave);
            this.picLinkedIn.MouseMove += new System.Windows.Forms.MouseEventHandler(this.picLinkedIn_MouseMove);
            this.picLinkedIn.MouseUp += new System.Windows.Forms.MouseEventHandler(this.picLinkedIn_MouseUp);
            // 
            // picGithub
            // 
            this.picGithub.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picGithub.Image = global::Recolorizer.View.Properties.Resources.social_github;
            this.picGithub.Location = new System.Drawing.Point(130, 89);
            this.picGithub.Name = "picGithub";
            this.picGithub.Size = new System.Drawing.Size(50, 50);
            this.picGithub.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picGithub.TabIndex = 1;
            this.picGithub.TabStop = false;
            this.picGithub.Click += new System.EventHandler(this.picGithub_Click);
            this.picGithub.MouseDown += new System.Windows.Forms.MouseEventHandler(this.picGithub_MouseDown);
            this.picGithub.MouseEnter += new System.EventHandler(this.picGithub_MouseEnter);
            this.picGithub.MouseLeave += new System.EventHandler(this.picGithub_MouseLeave);
            this.picGithub.MouseMove += new System.Windows.Forms.MouseEventHandler(this.picGithub_MouseMove);
            this.picGithub.MouseUp += new System.Windows.Forms.MouseEventHandler(this.picGithub_MouseUp);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(10, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(402, 46);
            this.label1.TabIndex = 0;
            this.label1.Text = "Caso tenha alguma dúvida, sugestão ou crítica, entre em contato em um dos links a" +
    "baixo:";
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(186, 463);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 2;
            this.btnClose.Text = "Fechar";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // frmAboutWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(447, 496);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(463, 534);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(463, 534);
            this.Name = "frmAboutWindow";
            this.Text = "Sobre";
            this.Load += new System.EventHandler(this.frmAboutWindow_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picEmail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLinkedIn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picGithub)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtAboutSoftware;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.PictureBox picEmail;
        private System.Windows.Forms.PictureBox picLinkedIn;
        private System.Windows.Forms.PictureBox picGithub;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnClose;
    }
}