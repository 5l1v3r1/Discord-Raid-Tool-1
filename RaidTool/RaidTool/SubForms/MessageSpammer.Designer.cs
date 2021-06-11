﻿
namespace RaidTool.SubForms
{
    partial class MessageSpammer
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.stopBtn = new Guna.UI.WinForms.GunaGradientButton();
            this.label1 = new System.Windows.Forms.Label();
            this.userMessageTxt = new Guna.UI.WinForms.GunaTextBox();
            this.startBtn = new Guna.UI.WinForms.GunaGradientButton();
            this.channelIDTxt = new Guna.UI.WinForms.GunaTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(19)))), ((int)(((byte)(19)))));
            this.panel2.Controls.Add(this.stopBtn);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.userMessageTxt);
            this.panel2.Controls.Add(this.startBtn);
            this.panel2.Controls.Add(this.channelIDTxt);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Location = new System.Drawing.Point(12, 22);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(519, 398);
            this.panel2.TabIndex = 26;
            // 
            // stopBtn
            // 
            this.stopBtn.Animated = true;
            this.stopBtn.AnimationHoverSpeed = 0.07F;
            this.stopBtn.AnimationSpeed = 0.03F;
            this.stopBtn.BackColor = System.Drawing.Color.Transparent;
            this.stopBtn.BaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.stopBtn.BaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.stopBtn.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.stopBtn.BorderSize = 2;
            this.stopBtn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.stopBtn.FocusedColor = System.Drawing.Color.Empty;
            this.stopBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.stopBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.stopBtn.Image = null;
            this.stopBtn.ImageSize = new System.Drawing.Size(20, 20);
            this.stopBtn.Location = new System.Drawing.Point(284, 322);
            this.stopBtn.Name = "stopBtn";
            this.stopBtn.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.stopBtn.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(21)))), ((int)(((byte)(21)))));
            this.stopBtn.OnHoverBorderColor = System.Drawing.Color.Black;
            this.stopBtn.OnHoverForeColor = System.Drawing.Color.Red;
            this.stopBtn.OnHoverImage = null;
            this.stopBtn.OnPressedColor = System.Drawing.Color.Black;
            this.stopBtn.Radius = 9;
            this.stopBtn.Size = new System.Drawing.Size(160, 36);
            this.stopBtn.TabIndex = 28;
            this.stopBtn.Text = "Stop";
            this.stopBtn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.stopBtn.Click += new System.EventHandler(this.stopBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(75, 127);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 27;
            this.label1.Text = "Message:";
            // 
            // userMessageTxt
            // 
            this.userMessageTxt.BackColor = System.Drawing.Color.Transparent;
            this.userMessageTxt.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.userMessageTxt.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.userMessageTxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.userMessageTxt.FocusedBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.userMessageTxt.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.userMessageTxt.FocusedForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.userMessageTxt.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.userMessageTxt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.userMessageTxt.Location = new System.Drawing.Point(78, 143);
            this.userMessageTxt.Multiline = true;
            this.userMessageTxt.Name = "userMessageTxt";
            this.userMessageTxt.PasswordChar = '\0';
            this.userMessageTxt.Radius = 5;
            this.userMessageTxt.SelectedText = "";
            this.userMessageTxt.Size = new System.Drawing.Size(366, 173);
            this.userMessageTxt.TabIndex = 26;
            // 
            // startBtn
            // 
            this.startBtn.Animated = true;
            this.startBtn.AnimationHoverSpeed = 0.07F;
            this.startBtn.AnimationSpeed = 0.03F;
            this.startBtn.BackColor = System.Drawing.Color.Transparent;
            this.startBtn.BaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.startBtn.BaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.startBtn.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.startBtn.BorderSize = 2;
            this.startBtn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.startBtn.FocusedColor = System.Drawing.Color.Empty;
            this.startBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.startBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.startBtn.Image = null;
            this.startBtn.ImageSize = new System.Drawing.Size(20, 20);
            this.startBtn.Location = new System.Drawing.Point(78, 322);
            this.startBtn.Name = "startBtn";
            this.startBtn.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.startBtn.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(21)))), ((int)(((byte)(21)))));
            this.startBtn.OnHoverBorderColor = System.Drawing.Color.Black;
            this.startBtn.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.startBtn.OnHoverImage = null;
            this.startBtn.OnPressedColor = System.Drawing.Color.Black;
            this.startBtn.Radius = 9;
            this.startBtn.Size = new System.Drawing.Size(160, 36);
            this.startBtn.TabIndex = 25;
            this.startBtn.Text = "Start";
            this.startBtn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.startBtn.Click += new System.EventHandler(this.startBtn_Click);
            // 
            // channelIDTxt
            // 
            this.channelIDTxt.BackColor = System.Drawing.Color.Transparent;
            this.channelIDTxt.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.channelIDTxt.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.channelIDTxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.channelIDTxt.FocusedBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.channelIDTxt.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.channelIDTxt.FocusedForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.channelIDTxt.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.channelIDTxt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.channelIDTxt.Location = new System.Drawing.Point(78, 82);
            this.channelIDTxt.Name = "channelIDTxt";
            this.channelIDTxt.PasswordChar = '\0';
            this.channelIDTxt.Radius = 5;
            this.channelIDTxt.SelectedText = "";
            this.channelIDTxt.Size = new System.Drawing.Size(160, 30);
            this.channelIDTxt.TabIndex = 22;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(75, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 21;
            this.label3.Text = "Channel ID:";
            // 
            // MessageSpammer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(21)))), ((int)(((byte)(21)))));
            this.ClientSize = new System.Drawing.Size(543, 444);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MessageSpammer";
            this.Text = "MessageSpammer";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private Guna.UI.WinForms.GunaGradientButton startBtn;
        private Guna.UI.WinForms.GunaTextBox channelIDTxt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private Guna.UI.WinForms.GunaTextBox userMessageTxt;
        private Guna.UI.WinForms.GunaGradientButton stopBtn;
    }
}