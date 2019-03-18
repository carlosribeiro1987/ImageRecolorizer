using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;

namespace Recolorizer.View {
    public partial class frmMainWindow : Form {
        public frmMainWindow() {
            InitializeComponent();
        }
        Color selectedColor = Color.White;
        List<string> selectedImages = new List<string>();
        string outputFolder = Directory.GetCurrentDirectory() + @"\colorized_images";

        private void btnChooseColor_Click(object sender, EventArgs e) {
            cldNewColor.ShowDialog();
            selectedColor = cldNewColor.Color;
            lblColorHex.Text = string.Format("#{0:x2}{1:x2}{2:x2}", selectedColor.R, selectedColor.G, selectedColor.B).ToUpperInvariant();
            lblR.Text = string.Format("R: {0}", selectedColor.R);
            lblG.Text = string.Format("G: {0}", selectedColor.G);
            lblB.Text = string.Format("B: {0}", selectedColor.B);
            if (selectedColor.GetBrightness() < 0.6f)
                lblColorHex.ForeColor = Color.White;
            else
                lblColorHex.ForeColor = Color.Black;            
            lblColorHex.BackColor = cldNewColor.Color;            
            if (lbxInputImages.Items.Count > 0) {
                lbxInputImages.SelectedIndex = -1;
                lbxInputImages.SelectedIndex = 0;
            }
        }

        private void btnSelectImages_Click(object sender, EventArgs e) {
            opnInputFiles.Filter = "Imagens com transparência (*.png, *.tiff, *.tif, *.ico)|*.png;*.tiff;*.tif";
            opnInputFiles.ShowDialog();
            if (opnInputFiles.FileNames.Length <= 0)
                return;
            foreach (string file in opnInputFiles.FileNames) {
                selectedImages.Add(file);
                lbxInputImages.Items.Add(file);
            }
            if (selectedImages.Count <= 0)
                lblSelectedImages.Text = "Nenhuma imagem selecionada.";
            else if (selectedImages.Count == 1)
                lblSelectedImages.Text ="1 imagem selecionada.";
            else
                lblSelectedImages.Text = string.Format("{0} imagens selecionadas.", selectedImages.Count);
            if (lbxInputImages.Items.Count > 0) {
                lbxInputImages.SelectedIndex = -1;
                lbxInputImages.SelectedIndex = 0;
            }
        }

        private Bitmap ChangeColor(Bitmap input, Color newColor) {
            Bitmap output = new Bitmap(input.Width, input.Height);
            for (int x = 0; x < input.Width; x++) {
                for (int y = 0; y < input.Height; y++) {
                    if (input.GetPixel(x, y).A <= 0)
                        output.SetPixel(x, y, input.GetPixel(x, y));                    
                    else 
                        output.SetPixel(x, y, Color.FromArgb(input.GetPixel(x, y).A, newColor.R, newColor.G, newColor.B));                    
                }
            }
            return output;
        }

        private void lbxInputImages_SelectedIndexChanged(object sender, EventArgs e) {
            Bitmap bmp;
            if (lbxInputImages.Items.Count <= 0)
                return;
            if (lbxInputImages.SelectedItem != null) {
                bmp = new Bitmap(lbxInputImages.GetItemText(lbxInputImages.SelectedItem));
                picOriginal.Image = bmp;
                picOutput.Image = ChangeColor((Bitmap)picOriginal.Image, selectedColor);
                if ((selectedColor.GetBrightness() < 0.55f) || (selectedColor == Color.Silver))
                    picOutput.BackColor = Color.White;                
                else 
                    picOutput.BackColor = Color.Gray;                
            }
        }

        private void btnOutputFolder_Click(object sender, EventArgs e) {
            ofdOutputFolder.ShowDialog();
            if (!string.IsNullOrWhiteSpace(ofdOutputFolder.SelectedPath))
                outputFolder = ofdOutputFolder.SelectedPath;
                txtOutputFolder.Text = ofdOutputFolder.SelectedPath;
        }

        private void btnColorizeImages_Click(object sender, EventArgs e) {
            if (selectedImages.Count < 1) {
                MessageBox.Show("Nenhuma imagem selecionada.\r\nSelecione as imagens a serem alteradas.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!Directory.Exists(outputFolder)) 
                Directory.CreateDirectory(outputFolder);            
            string[] images = selectedImages.ToArray();
            string suffix = string.Empty;
            string sizeSuffix = string.Empty;
            pgbProgress.Maximum = images.Length;
            pgbProgress.Visible = true;
            lblProcessing.Visible = true;
            for (int i = 0; i < images.Length; i++) {
                pgbProgress.Value = i + 1;
                lblProcessing.Text = string.Format("Processando imagens... [{0}/{1}]", i + 1, images.Length);
                this.Refresh();
                Bitmap inputBmp = new Bitmap(images[i]);
                Bitmap tempBmp = ChangeColor(inputBmp, selectedColor);
                Bitmap outputBmp;
                if (chbResize.Checked) 
                    outputBmp = new Bitmap(tempBmp, Convert.ToInt32(numWidth.Value), Convert.ToInt32(numHeight.Value));
                else
                    outputBmp = tempBmp;
                FileInfo info = new FileInfo(images[i]);
                string outputName = info.Name.Remove(info.Name.LastIndexOf('.')).Replace('-', '_').Replace(' ', '_');
                string outputExt = info.Extension.ToLowerInvariant();
                if (chbAddSuffix.Checked)
                    suffix = string.Format("_{0}", txtSuffix.Text).ToLowerInvariant();
                if (chbAddSizeSuffix.Checked)
                    sizeSuffix = string.Format(@"_{0:00}x{1}", (int)numWidth.Value, (int)numHeight.Value).ToLowerInvariant();
                switch (outputExt) {
                    case ".png":
                        outputBmp.Save(string.Format(@"{0}\{1}{2}{3}{4}", outputFolder, outputName, suffix, sizeSuffix, outputExt), ImageFormat.Png);
                        break;
                    case ".tiff":
                    case ".tif":
                        outputBmp.Save(string.Format(@"{0}\{1}{2}{3}{4}", outputFolder, outputName, suffix, sizeSuffix, outputExt), ImageFormat.Tiff);
                        break;
                    case ".ico":
                        outputBmp.Save(string.Format(@"{0}\{1}{2}{3}{4}", outputFolder, outputName, suffix, sizeSuffix, outputExt), ImageFormat.Icon);
                        break;
                }
            }
            pgbProgress.Visible = false;
            pgbProgress.Value = 0;
            lblProcessing.Visible = false;
            if (MessageBox.Show("Todas as imagens foram alteradas. \r\nDeseja abrir a pasta destino?", "Tarefa finalizada", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes) {
                Process.Start(outputFolder);
            }            
        }

        private void Form1_Load(object sender, EventArgs e) {
            txtOutputFolder.Text = outputFolder;
        }

        private void chbResize_CheckedChanged(object sender, EventArgs e) {
            lblWidth.Visible = chbResize.Checked;
            numWidth.Visible = chbResize.Checked;
            lblHeight.Visible = chbResize.Checked;
            numHeight.Visible = chbResize.Checked;
        }

        private void btnClear_Click(object sender, EventArgs e) {
            lbxInputImages.Items.Clear();
            selectedImages.Clear();
        }

        private void btnShowHelp_Click(object sender, EventArgs e) {
            frmAboutWindow about = new frmAboutWindow();
            about.ShowDialog();
        }

        private void txtSuffix_KeyPress(object sender, KeyPressEventArgs e) {
            if (!(char.IsLetter(e.KeyChar) || char.IsNumber(e.KeyChar) || char.IsControl(e.KeyChar))) {
                e.KeyChar = '\0';
                return;
            }
        }

        private void chbAddSuffix_CheckedChanged(object sender, EventArgs e) {
            txtSuffix.Visible = chbAddSuffix.Checked;
        }
    }
}
