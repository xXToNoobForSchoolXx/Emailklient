using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Web;
using System.Net.Mail;

namespace TesterEmail
{
    public partial class TesterEmailForm : Form
    {
        public TesterEmailForm()
        {
            InitializeComponent();
        }

        private void buttonSend_Click(object sender, EventArgs e)
        {
            MailMessage mail = new MailMessage(textBoxFrom.Text, textBoxTo.Text, textBoxSubject.Text, textBoxMassage.Text);
            mail.Attachments.Add(new Attachment(textBoxAttach.Text));
            SmtpClient client = new SmtpClient(textBoxSMTP.Text);
            client.Port = 587;
            client.Credentials = new System.Net.NetworkCredential(textBoxUsername.Text, textBoxPassword.Text);
            client.EnableSsl = true;
            client.Send(mail);
            MessageBox.Show("Mail Sent!", "Successful", MessageBoxButtons.OK);
            clearBoxes();
        }

        private void buttonAttach_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "JPG Files (*.jpg)|*.jpg| PNG Files(*.png)|*.png| Excel Documents(*.xlsx)|*.xlsx| " +
                "PowerPoint Presentations(*.pptx)|*.pptx|";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                textBoxAttach.Text = openFileDialog.FileName;
            }
        }

        public void clearBoxes()
        {
            textBoxAttach.Clear();
            textBoxFrom.Clear();
            textBoxMassage.Clear();
            textBoxPassword.Clear();
            textBoxSMTP.Clear();
            textBoxSubject.Clear();
            textBoxTo.Clear();
            textBoxUsername.Clear();
        }
    }
}