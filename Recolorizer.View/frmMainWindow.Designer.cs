namespace Recolorizer.View {
    partial class frmMainWindow {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMainWindow));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnSelectImages = new System.Windows.Forms.Button();
            this.lbxInputImages = new System.Windows.Forms.ListBox();
            this.cldNewColor = new System.Windows.Forms.ColorDialog();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblHeight = new System.Windows.Forms.Label();
            this.numHeight = new System.Windows.Forms.NumericUpDown();
            this.lblWidth = new System.Windows.Forms.Label();
            this.numWidth = new System.Windows.Forms.NumericUpDown();
            this.chbResize = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnOutputFolder = new System.Windows.Forms.Button();
            this.txtOutputFolder = new System.Windows.Forms.TextBox();
            this.btnChooseColor = new System.Windows.Forms.Button();
            this.lblColorHex = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.opnInputFiles = new System.Windows.Forms.OpenFileDialog();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.picOutput = new System.Windows.Forms.PictureBox();
            this.picOriginal = new System.Windows.Forms.PictureBox();
            this.btnColorizeImages = new System.Windows.Forms.Button();
            this.ofdOutputFolder = new System.Windows.Forms.FolderBrowserDialog();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblSelectedImages = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblProcessing = new System.Windows.Forms.ToolStripStatusLabel();
            this.pgbProgress = new System.Windows.Forms.ToolStripProgressBar();
            this.btnShowHelp = new System.Windows.Forms.Button();
            this.lblR = new System.Windows.Forms.Label();
            this.lblB = new System.Windows.Forms.Label();
            this.lblG = new System.Windows.Forms.Label();
            this.chbAddSuffix = new System.Windows.Forms.CheckBox();
            this.txtSuffix = new System.Windows.Forms.TextBox();
            this.chbAddSizeSuffix = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numHeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numWidth)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picOutput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picOriginal)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnClear);
            this.groupBox1.Controls.Add(this.btnSelectImages);
            this.groupBox1.Controls.Add(this.lbxInputImages);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(517, 270);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Selecionar imagens:";
            // 
            // btnClear
            // 
            this.btnClear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnClear.Location = new System.Drawing.Point(14, 237);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 2;
            this.btnClear.Text = "Limpar";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnSelectImages
            // 
            this.btnSelectImages.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSelectImages.Location = new System.Drawing.Point(388, 237);
            this.btnSelectImages.Name = "btnSelectImages";
            this.btnSelectImages.Size = new System.Drawing.Size(115, 23);
            this.btnSelectImages.TabIndex = 1;
            this.btnSelectImages.Text = "Adicionar Imagens";
            this.btnSelectImages.UseVisualStyleBackColor = true;
            this.btnSelectImages.Click += new System.EventHandler(this.btnSelectImages_Click);
            // 
            // lbxInputImages
            // 
            this.lbxInputImages.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbxInputImages.FormattingEnabled = true;
            this.lbxInputImages.Location = new System.Drawing.Point(14, 19);
            this.lbxInputImages.Name = "lbxInputImages";
            this.lbxInputImages.Size = new System.Drawing.Size(489, 212);
            this.lbxInputImages.TabIndex = 0;
            this.lbxInputImages.SelectedIndexChanged += new System.EventHandler(this.lbxInputImages_SelectedIndexChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.chbAddSizeSuffix);
            this.groupBox2.Controls.Add(this.txtSuffix);
            this.groupBox2.Controls.Add(this.chbAddSuffix);
            this.groupBox2.Controls.Add(this.lblG);
            this.groupBox2.Controls.Add(this.lblB);
            this.groupBox2.Controls.Add(this.lblR);
            this.groupBox2.Controls.Add(this.lblHeight);
            this.groupBox2.Controls.Add(this.numHeight);
            this.groupBox2.Controls.Add(this.lblWidth);
            this.groupBox2.Controls.Add(this.numWidth);
            this.groupBox2.Controls.Add(this.chbResize);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.btnOutputFolder);
            this.groupBox2.Controls.Add(this.txtOutputFolder);
            this.groupBox2.Controls.Add(this.btnChooseColor);
            this.groupBox2.Controls.Add(this.lblColorHex);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(12, 288);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(650, 190);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Saída";
            // 
            // lblHeight
            // 
            this.lblHeight.AutoSize = true;
            this.lblHeight.Location = new System.Drawing.Point(394, 87);
            this.lblHeight.Name = "lblHeight";
            this.lblHeight.Size = new System.Drawing.Size(54, 13);
            this.lblHeight.TabIndex = 13;
            this.lblHeight.Text = "Altura(px):";
            this.lblHeight.Visible = false;
            // 
            // numHeight
            // 
            this.numHeight.Location = new System.Drawing.Point(454, 85);
            this.numHeight.Maximum = new decimal(new int[] {
            3000,
            0,
            0,
            0});
            this.numHeight.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numHeight.Name = "numHeight";
            this.numHeight.Size = new System.Drawing.Size(63, 20);
            this.numHeight.TabIndex = 12;
            this.numHeight.Value = new decimal(new int[] {
            32,
            0,
            0,
            0});
            this.numHeight.Visible = false;
            // 
            // lblWidth
            // 
            this.lblWidth.AutoSize = true;
            this.lblWidth.Location = new System.Drawing.Point(237, 87);
            this.lblWidth.Name = "lblWidth";
            this.lblWidth.Size = new System.Drawing.Size(63, 13);
            this.lblWidth.TabIndex = 11;
            this.lblWidth.Text = "Largura(px):";
            this.lblWidth.Visible = false;
            // 
            // numWidth
            // 
            this.numWidth.Location = new System.Drawing.Point(306, 85);
            this.numWidth.Maximum = new decimal(new int[] {
            3000,
            0,
            0,
            0});
            this.numWidth.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numWidth.Name = "numWidth";
            this.numWidth.Size = new System.Drawing.Size(63, 20);
            this.numWidth.TabIndex = 10;
            this.numWidth.Value = new decimal(new int[] {
            32,
            0,
            0,
            0});
            this.numWidth.Visible = false;
            // 
            // chbResize
            // 
            this.chbResize.AutoSize = true;
            this.chbResize.Location = new System.Drawing.Point(240, 62);
            this.chbResize.Name = "chbResize";
            this.chbResize.Size = new System.Drawing.Size(204, 17);
            this.chbResize.TabIndex = 9;
            this.chbResize.Text = "Redimensionar as  imagens alteradas.";
            this.chbResize.UseVisualStyleBackColor = true;
            this.chbResize.CheckedChanged += new System.EventHandler(this.chbResize_CheckedChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(237, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Pasta Destino:";
            // 
            // btnOutputFolder
            // 
            this.btnOutputFolder.Location = new System.Drawing.Point(598, 34);
            this.btnOutputFolder.Name = "btnOutputFolder";
            this.btnOutputFolder.Size = new System.Drawing.Size(39, 23);
            this.btnOutputFolder.TabIndex = 7;
            this.btnOutputFolder.Text = "...";
            this.btnOutputFolder.UseVisualStyleBackColor = true;
            this.btnOutputFolder.Click += new System.EventHandler(this.btnOutputFolder_Click);
            // 
            // txtOutputFolder
            // 
            this.txtOutputFolder.Location = new System.Drawing.Point(240, 36);
            this.txtOutputFolder.Name = "txtOutputFolder";
            this.txtOutputFolder.ReadOnly = true;
            this.txtOutputFolder.Size = new System.Drawing.Size(352, 20);
            this.txtOutputFolder.TabIndex = 6;
            // 
            // btnChooseColor
            // 
            this.btnChooseColor.Location = new System.Drawing.Point(14, 139);
            this.btnChooseColor.Name = "btnChooseColor";
            this.btnChooseColor.Size = new System.Drawing.Size(102, 23);
            this.btnChooseColor.TabIndex = 5;
            this.btnChooseColor.Text = "Escolher Cor";
            this.btnChooseColor.UseVisualStyleBackColor = true;
            this.btnChooseColor.Click += new System.EventHandler(this.btnChooseColor_Click);
            // 
            // lblColorHex
            // 
            this.lblColorHex.BackColor = System.Drawing.Color.White;
            this.lblColorHex.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblColorHex.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblColorHex.Location = new System.Drawing.Point(14, 34);
            this.lblColorHex.Name = "lblColorHex";
            this.lblColorHex.Size = new System.Drawing.Size(102, 102);
            this.lblColorHex.TabIndex = 4;
            this.lblColorHex.Text = "#FFFFFF";
            this.lblColorHex.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Nova cor da imagem:";
            // 
            // opnInputFiles
            // 
            this.opnInputFiles.FileName = "openFileDialog1";
            this.opnInputFiles.Multiselect = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.picOutput);
            this.groupBox3.Controls.Add(this.picOriginal);
            this.groupBox3.Location = new System.Drawing.Point(535, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(127, 270);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Previsão da saída";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 143);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Imagem modificada:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Imagem original:";
            // 
            // picOutput
            // 
            this.picOutput.BackColor = System.Drawing.Color.White;
            this.picOutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picOutput.Location = new System.Drawing.Point(12, 158);
            this.picOutput.Name = "picOutput";
            this.picOutput.Size = new System.Drawing.Size(102, 102);
            this.picOutput.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picOutput.TabIndex = 1;
            this.picOutput.TabStop = false;
            // 
            // picOriginal
            // 
            this.picOriginal.BackColor = System.Drawing.Color.White;
            this.picOriginal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picOriginal.Location = new System.Drawing.Point(12, 34);
            this.picOriginal.Name = "picOriginal";
            this.picOriginal.Size = new System.Drawing.Size(102, 102);
            this.picOriginal.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picOriginal.TabIndex = 0;
            this.picOriginal.TabStop = false;
            // 
            // btnColorizeImages
            // 
            this.btnColorizeImages.Location = new System.Drawing.Point(541, 489);
            this.btnColorizeImages.Name = "btnColorizeImages";
            this.btnColorizeImages.Size = new System.Drawing.Size(121, 23);
            this.btnColorizeImages.TabIndex = 3;
            this.btnColorizeImages.Text = "Alterar Imagens";
            this.btnColorizeImages.UseVisualStyleBackColor = true;
            this.btnColorizeImages.Click += new System.EventHandler(this.btnColorizeImages_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblSelectedImages,
            this.lblProcessing,
            this.pgbProgress});
            this.statusStrip1.Location = new System.Drawing.Point(0, 530);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(674, 22);
            this.statusStrip1.TabIndex = 4;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lblSelectedImages
            // 
            this.lblSelectedImages.AutoSize = false;
            this.lblSelectedImages.Name = "lblSelectedImages";
            this.lblSelectedImages.Size = new System.Drawing.Size(200, 17);
            this.lblSelectedImages.Text = "Nenhuma imagem selecionada";
            this.lblSelectedImages.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblProcessing
            // 
            this.lblProcessing.AutoSize = false;
            this.lblProcessing.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.lblProcessing.Margin = new System.Windows.Forms.Padding(10, 3, 0, 2);
            this.lblProcessing.Name = "lblProcessing";
            this.lblProcessing.Size = new System.Drawing.Size(200, 17);
            this.lblProcessing.Text = "Processando imagens [0/0]";
            this.lblProcessing.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblProcessing.Visible = false;
            // 
            // pgbProgress
            // 
            this.pgbProgress.Margin = new System.Windows.Forms.Padding(10, 3, 1, 3);
            this.pgbProgress.Name = "pgbProgress";
            this.pgbProgress.Size = new System.Drawing.Size(200, 16);
            this.pgbProgress.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.pgbProgress.Visible = false;
            // 
            // btnShowHelp
            // 
            this.btnShowHelp.Location = new System.Drawing.Point(12, 489);
            this.btnShowHelp.Name = "btnShowHelp";
            this.btnShowHelp.Size = new System.Drawing.Size(23, 23);
            this.btnShowHelp.TabIndex = 5;
            this.btnShowHelp.Text = "?";
            this.btnShowHelp.UseVisualStyleBackColor = true;
            this.btnShowHelp.Click += new System.EventHandler(this.btnShowHelp_Click);
            // 
            // lblR
            // 
            this.lblR.AutoSize = true;
            this.lblR.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblR.Location = new System.Drawing.Point(122, 66);
            this.lblR.Name = "lblR";
            this.lblR.Size = new System.Drawing.Size(41, 15);
            this.lblR.TabIndex = 14;
            this.lblR.Text = "R: 255";
            // 
            // lblB
            // 
            this.lblB.AutoSize = true;
            this.lblB.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblB.Location = new System.Drawing.Point(122, 96);
            this.lblB.Name = "lblB";
            this.lblB.Size = new System.Drawing.Size(41, 15);
            this.lblB.TabIndex = 15;
            this.lblB.Text = "B: 255";
            // 
            // lblG
            // 
            this.lblG.AutoSize = true;
            this.lblG.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblG.Location = new System.Drawing.Point(122, 81);
            this.lblG.Name = "lblG";
            this.lblG.Size = new System.Drawing.Size(42, 15);
            this.lblG.TabIndex = 16;
            this.lblG.Text = "G: 255";
            // 
            // chbAddSuffix
            // 
            this.chbAddSuffix.AutoSize = true;
            this.chbAddSuffix.Location = new System.Drawing.Point(240, 120);
            this.chbAddSuffix.Name = "chbAddSuffix";
            this.chbAddSuffix.Size = new System.Drawing.Size(207, 17);
            this.chbAddSuffix.TabIndex = 17;
            this.chbAddSuffix.Text = "Adicionar sufixo ao nome dos arquivos";
            this.chbAddSuffix.UseVisualStyleBackColor = true;
            this.chbAddSuffix.CheckedChanged += new System.EventHandler(this.chbAddSuffix_CheckedChanged);
            // 
            // txtSuffix
            // 
            this.txtSuffix.Location = new System.Drawing.Point(451, 118);
            this.txtSuffix.Name = "txtSuffix";
            this.txtSuffix.Size = new System.Drawing.Size(120, 20);
            this.txtSuffix.TabIndex = 18;
            this.txtSuffix.Visible = false;
            this.txtSuffix.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSuffix_KeyPress);
            // 
            // chbAddSizeSuffix
            // 
            this.chbAddSizeSuffix.AutoSize = true;
            this.chbAddSizeSuffix.Location = new System.Drawing.Point(240, 146);
            this.chbAddSizeSuffix.Name = "chbAddSizeSuffix";
            this.chbAddSizeSuffix.Size = new System.Drawing.Size(331, 17);
            this.chbAddSizeSuffix.TabIndex = 19;
            this.chbAddSizeSuffix.Text = "Adicionar sufixo de  tamanho da imagem (ex.: output_32x32.png)";
            this.chbAddSizeSuffix.UseVisualStyleBackColor = true;
            // 
            // frmMainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(674, 552);
            this.Controls.Add(this.btnShowHelp);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.btnColorizeImages);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmMainWindow";
            this.Text = "ReColor";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numHeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numWidth)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picOutput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picOriginal)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnSelectImages;
        private System.Windows.Forms.ListBox lbxInputImages;
        private System.Windows.Forms.ColorDialog cldNewColor;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnChooseColor;
        private System.Windows.Forms.Label lblColorHex;
        private System.Windows.Forms.OpenFileDialog opnInputFiles;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox picOutput;
        private System.Windows.Forms.PictureBox picOriginal;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnOutputFolder;
        private System.Windows.Forms.TextBox txtOutputFolder;
        private System.Windows.Forms.Button btnColorizeImages;
        private System.Windows.Forms.FolderBrowserDialog ofdOutputFolder;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lblSelectedImages;
        private System.Windows.Forms.ToolStripStatusLabel lblProcessing;
        private System.Windows.Forms.ToolStripProgressBar pgbProgress;
        private System.Windows.Forms.Label lblHeight;
        private System.Windows.Forms.NumericUpDown numHeight;
        private System.Windows.Forms.Label lblWidth;
        private System.Windows.Forms.NumericUpDown numWidth;
        private System.Windows.Forms.CheckBox chbResize;
        private System.Windows.Forms.Button btnShowHelp;
        private System.Windows.Forms.Label lblG;
        private System.Windows.Forms.Label lblB;
        private System.Windows.Forms.Label lblR;
        private System.Windows.Forms.CheckBox chbAddSizeSuffix;
        private System.Windows.Forms.TextBox txtSuffix;
        private System.Windows.Forms.CheckBox chbAddSuffix;
    }
}

