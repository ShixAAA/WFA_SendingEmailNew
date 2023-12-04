using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WFA_SendingEmail.UsersClasses;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static WFA_SendingEmail.UsersClasses.InfoEmail;

namespace WFA_SendingEmail
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            textBoxEmail.Text = "task_code_development@list.ru";
            textBoxName.Text = "Антон Игоревич";
            comboBoxService.SelectedIndex = 0;
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private bool IsNullOrWhiteSpaceTextBox()
        {
            if (string.IsNullOrWhiteSpace(textBoxEmail.Text) ||
               string.IsNullOrWhiteSpace(textBoxName.Text) ||
               string.IsNullOrWhiteSpace(textBoxSubject.Text) ||
               string.IsNullOrWhiteSpace(textBoxBody.Text))
            {
                MessageBox.Show("Заполните все поля!");
                return true;
            }
            return false;
        }

        private void TextBoxIsCleaning()
        {
            DialogResult result = MessageBox.Show("Очистить поля ввода?",
            "Сообщение",
            MessageBoxButtons.YesNo);
            if (DialogResult.Yes == result)
                foreach (System.Windows.Forms.TextBox textBox in Controls.OfType<System.Windows.Forms.TextBox>())
                textBox.Text = "";
        }

        private InfoEmail SetInfoEmail(EmailsTypes type)
        {
            StringPair toInfo = new StringPair(textBoxEmail.Text, textBoxName.Text);
            string subject = textBoxSubject.Text;
            string body = $"{DateTime.Now} \n" +
            $"{Dns.GetHostName()} \n" +
            $"{Dns.GetHostAddresses(Dns.GetHostName()).First()} \n" +
            $"{textBoxBody.Text}";

            if (type == EmailsTypes.Gmail)
                return new InfoGMail(toInfo, subject, body);
            else
                return new InfoMailRu(toInfo, subject, body);
        }

        private void buttonSent_Click(object sender, EventArgs e)
        {
            if(IsNullOrWhiteSpaceTextBox()) return;

            try
            {
                SendingEmail sendingEmail = new SendingEmail(SetInfoEmail(comboBoxService.SelectedItem.ToString() == "GMail" ?
                EmailsTypes.Gmail :
                EmailsTypes.MailRu));
                sendingEmail.Send();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
            MessageBox.Show("Письмо отправлено!");
            TextBoxIsCleaning();

        }
    }
}
