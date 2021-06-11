using System;
using System.Windows.Forms;

namespace RaidTool.SubForms
{
    public partial class EmbedSpammer : Form
    {
        public EmbedSpammer()
        {
            InitializeComponent();
        }

        private void startBtn_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(titleTxt.Text) && !String.IsNullOrEmpty(userMessageTxt.Text) && !String.IsNullOrEmpty(footerTxt.Text) && !String.IsNullOrEmpty(channelIDTxt.Text) && Utils.IsVaildID(channelIDTxt.Text) == true)
            {
                Utils.EmbedMessage = true;
                Utils.EmbedSpammer(titleTxt.Text, userMessageTxt.Text, footerTxt.Text, channelIDTxt.Text);
            }
            else
            {
                MessageBox.Show("One or more of the fields is empty, Fill then with the required data to continue.");
            }
        }

        private void stopBtn_Click(object sender, EventArgs e)
        {
            Utils.EmbedMessage = false;
        }
    }
}