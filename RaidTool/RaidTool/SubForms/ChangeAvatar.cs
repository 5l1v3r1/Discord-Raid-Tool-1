using System;
using System.Windows.Forms;

namespace RaidTool.SubForms
{
    public partial class ChangeAvatar : Form
    {
        public ChangeAvatar()
        {
            InitializeComponent();
        }

        private void startBtn_Click(object sender, EventArgs e)
        {
            Uri uriResult;
            bool result = Uri.TryCreate(avatarPathTxt.Text, UriKind.Absolute, out uriResult) && (uriResult.Scheme == Uri.UriSchemeHttp || uriResult.Scheme == Uri.UriSchemeHttps);
            if (result == true)
                Utils.ChangeAvatar(avatarPathTxt.Text);
            else
                MessageBox.Show("Please enter a vaild url.");
        }
    }
}