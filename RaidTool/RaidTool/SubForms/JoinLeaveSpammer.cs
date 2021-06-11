using System;
using System.Windows.Forms;

namespace RaidTool.SubForms
{
    public partial class JoinLeaveSpammer : Form
    {
        public JoinLeaveSpammer()
        {
            InitializeComponent();
        }

        private void startBtn_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(serverIDTxt.Text) && Utils.IsVaildID(serverIDTxt.Text) == true && !String.IsNullOrEmpty(serverIDTxt.Text))
            {
                Utils.JoinLeave = true;
                string invite = serverInviteTxt.Text;
                string server = serverIDTxt.Text;
                Utils.JoinLeaverSpammer(invite, server);
            }
            else
                MessageBox.Show("One or more of the fields is empty, Fill then with the required data to continue.");
        }

        private void stopBtn_Click(object sender, EventArgs e)
        {
            Utils.JoinLeave = false;
        }
    }
}