using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace Recolorizer.View {
    public partial class frmAboutWindow : Form {
        public frmAboutWindow() {
            InitializeComponent();
        }

        //Email
        private void picEmail_Click(object sender, EventArgs e) {
            try {
                Process.Start("mailto:carlos.ribeiro.537h#gmail.com");
            }
            catch(Exception ex) {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void picEmail_MouseEnter(object sender, EventArgs e) {
            picEmail.Image = Properties.Resources.ios7_email_hover;
        }

        private void picEmail_MouseLeave(object sender, EventArgs e) {
            picEmail.Image = Properties.Resources.ios7_email;
        }

        private void picEmail_MouseDown(object sender, MouseEventArgs e) {
            picEmail.Image = Properties.Resources.ios7_email_down;
        }

        private void picEmail_MouseUp(object sender, MouseEventArgs e) {
            picEmail.Image = Properties.Resources.ios7_email;
        }

        private void picEmail_MouseMove(object sender, MouseEventArgs e) {
            picEmail.Image = Properties.Resources.ios7_email_hover;
        }

        //GitHub
        private void picGithub_Click(object sender, EventArgs e) {
            try {
                Process.Start("https://github.com/carlosribeiro1987");
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void picGithub_MouseEnter(object sender, EventArgs e) {
            picGithub.Image = Properties.Resources.social_github_hover;
        }

        private void picGithub_MouseLeave(object sender, EventArgs e) {
            picGithub.Image = Properties.Resources.social_github;
        }

        private void picGithub_MouseDown(object sender, MouseEventArgs e) {
            picGithub.Image = Properties.Resources.social_github_down;
        }

        private void picGithub_MouseUp(object sender, MouseEventArgs e) {
            picGithub.Image = Properties.Resources.social_github;
        }

        private void picGithub_MouseMove(object sender, MouseEventArgs e) {
            picGithub.Image = Properties.Resources.social_github_hover;
        }

        //LinkedIn
        private void picLinkedIn_Click(object sender, EventArgs e) {
            try {
                Process.Start("https://linkedin.com/carlosribeiro1987");
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void picLinkedIn_MouseEnter(object sender, EventArgs e) {
            picLinkedIn.Image = Properties.Resources.social_linkedin_hover;
        }

        private void picLinkedIn_MouseLeave(object sender, EventArgs e) {
            picLinkedIn.Image = Properties.Resources.social_linkedin;
        }

        private void picLinkedIn_MouseDown(object sender, MouseEventArgs e) {
            picLinkedIn.Image = Properties.Resources.social_linkedin_down;
        }

        private void picLinkedIn_MouseUp(object sender, MouseEventArgs e) {
            picLinkedIn.Image = Properties.Resources.social_linkedin;
        }

        private void picLinkedIn_MouseMove(object sender, MouseEventArgs e) {
            picLinkedIn.Image = Properties.Resources.social_linkedin_hover;
        }

        private void btnClose_Click(object sender, EventArgs e) {
            Close();
        }

        private void frmAboutWindow_Load(object sender, EventArgs e) {
            btnClose.Focus();
            
        }


    }
}
