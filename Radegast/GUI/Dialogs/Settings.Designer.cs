﻿// 
// Radegast Metaverse Client
// Copyright (c) 2009-2011, Radegast Development Team
// All rights reserved.
// 
// Redistribution and use in source and binary forms, with or without
// modification, are permitted provided that the following conditions are met:
// 
//     * Redistributions of source code must retain the above copyright notice,
//       this list of conditions and the following disclaimer.
//     * Redistributions in binary form must reproduce the above copyright
//       notice, this list of conditions and the following disclaimer in the
//       documentation and/or other materials provided with the distribution.
//     * Neither the name of the application "Radegast", nor the names of its
//       contributors may be used to endorse or promote products derived from
//       this software without specific prior written permission.
// 
// THIS SOFTWARE IS PROVIDED BY THE COPYRIGHT HOLDERS AND CONTRIBUTORS "AS IS"
// AND ANY EXPRESS OR IMPLIED WARRANTIES, INCLUDING, BUT NOT LIMITED TO, THE
// IMPLIED WARRANTIES OF MERCHANTABILITY AND FITNESS FOR A PARTICULAR PURPOSE ARE
// DISCLAIMED. IN NO EVENT SHALL THE COPYRIGHT HOLDER OR CONTRIBUTORS BE LIABLE
// FOR ANY DIRECT, INDIRECT, INCIDENTAL, SPECIAL, EXEMPLARY, OR CONSEQUENTIAL
// DAMAGES (INCLUDING, BUT NOT LIMITED TO, PROCUREMENT OF SUBSTITUTE GOODS OR
// SERVICES; LOSS OF USE, DATA, OR PROFITS; OR BUSINESS INTERRUPTION) HOWEVER
// CAUSED AND ON ANY THEORY OF LIABILITY, WHETHER IN CONTRACT, STRICT LIABILITY,
// OR TORT (INCLUDING NEGLIGENCE OR OTHERWISE) ARISING IN ANY WAY OUT OF THE USE
// OF THIS SOFTWARE, EVEN IF ADVISED OF THE POSSIBILITY OF SUCH DAMAGE.
//
// $Id$
//
namespace Radegast
{
    partial class frmSettings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSettings));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tbpGeneral = new System.Windows.Forms.TabPage();
            this.txtReconnectTime = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.gbDisplayNames = new System.Windows.Forms.GroupBox();
            this.rbDNOnlyDN = new System.Windows.Forms.RadioButton();
            this.rbDNDandUsernme = new System.Windows.Forms.RadioButton();
            this.rbDNSmart = new System.Windows.Forms.RadioButton();
            this.rbDNOff = new System.Windows.Forms.RadioButton();
            this.cbSyntaxHighlight = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbFontSize = new System.Windows.Forms.ComboBox();
            this.cbNoTyping = new System.Windows.Forms.CheckBox();
            this.cbMinToTrey = new System.Windows.Forms.CheckBox();
            this.cbMUEmotes = new System.Windows.Forms.CheckBox();
            this.cbRLV = new System.Windows.Forms.CheckBox();
            this.cbHideLoginGraphics = new System.Windows.Forms.CheckBox();
            this.cbAutoReconnect = new System.Windows.Forms.CheckBox();
            this.cbFriendsHighlight = new System.Windows.Forms.CheckBox();
            this.cbFriendsNotifications = new System.Windows.Forms.CheckBox();
            this.cbTrasactChat = new System.Windows.Forms.CheckBox();
            this.cbTrasactDialog = new System.Windows.Forms.CheckBox();
            this.cbIMTimeStamps = new System.Windows.Forms.CheckBox();
            this.cbChatTimestamps = new System.Windows.Forms.CheckBox();
            this.tbpAutoResponse = new System.Windows.Forms.TabPage();
            this.txtAutoResponse = new System.Windows.Forms.TextBox();
            this.gbAutoResponse = new System.Windows.Forms.GroupBox();
            this.rbAutoAlways = new System.Windows.Forms.RadioButton();
            this.rbAutoNonFriend = new System.Windows.Forms.RadioButton();
            this.rbAutobusy = new System.Windows.Forms.RadioButton();
            this.tabControl1.SuspendLayout();
            this.tbpGeneral.SuspendLayout();
            this.gbDisplayNames.SuspendLayout();
            this.tbpAutoResponse.SuspendLayout();
            this.gbAutoResponse.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tbpGeneral);
            this.tabControl1.Controls.Add(this.tbpAutoResponse);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Multiline = true;
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(496, 303);
            this.tabControl1.TabIndex = 0;
            // 
            // tbpGeneral
            // 
            this.tbpGeneral.Controls.Add(this.txtReconnectTime);
            this.tbpGeneral.Controls.Add(this.label2);
            this.tbpGeneral.Controls.Add(this.gbDisplayNames);
            this.tbpGeneral.Controls.Add(this.cbSyntaxHighlight);
            this.tbpGeneral.Controls.Add(this.label1);
            this.tbpGeneral.Controls.Add(this.cbFontSize);
            this.tbpGeneral.Controls.Add(this.cbNoTyping);
            this.tbpGeneral.Controls.Add(this.cbMinToTrey);
            this.tbpGeneral.Controls.Add(this.cbMUEmotes);
            this.tbpGeneral.Controls.Add(this.cbRLV);
            this.tbpGeneral.Controls.Add(this.cbHideLoginGraphics);
            this.tbpGeneral.Controls.Add(this.cbAutoReconnect);
            this.tbpGeneral.Controls.Add(this.cbFriendsHighlight);
            this.tbpGeneral.Controls.Add(this.cbFriendsNotifications);
            this.tbpGeneral.Controls.Add(this.cbTrasactChat);
            this.tbpGeneral.Controls.Add(this.cbTrasactDialog);
            this.tbpGeneral.Controls.Add(this.cbIMTimeStamps);
            this.tbpGeneral.Controls.Add(this.cbChatTimestamps);
            this.tbpGeneral.Location = new System.Drawing.Point(4, 22);
            this.tbpGeneral.Name = "tbpGeneral";
            this.tbpGeneral.Padding = new System.Windows.Forms.Padding(3);
            this.tbpGeneral.Size = new System.Drawing.Size(488, 277);
            this.tbpGeneral.TabIndex = 1;
            this.tbpGeneral.Text = "General";
            this.tbpGeneral.UseVisualStyleBackColor = true;
            // 
            // txtReconnectTime
            // 
            this.txtReconnectTime.Location = new System.Drawing.Point(139, 165);
            this.txtReconnectTime.Name = "txtReconnectTime";
            this.txtReconnectTime.Size = new System.Drawing.Size(53, 20);
            this.txtReconnectTime.TabIndex = 7;
            this.txtReconnectTime.Text = "120";
            this.txtReconnectTime.TextChanged += new System.EventHandler(this.txtReconnectTime_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 167);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "Autoreconnect time (sec)";
            // 
            // gbDisplayNames
            // 
            this.gbDisplayNames.Controls.Add(this.rbDNOnlyDN);
            this.gbDisplayNames.Controls.Add(this.rbDNDandUsernme);
            this.gbDisplayNames.Controls.Add(this.rbDNSmart);
            this.gbDisplayNames.Controls.Add(this.rbDNOff);
            this.gbDisplayNames.Location = new System.Drawing.Point(270, 75);
            this.gbDisplayNames.Name = "gbDisplayNames";
            this.gbDisplayNames.Size = new System.Drawing.Size(200, 109);
            this.gbDisplayNames.TabIndex = 15;
            this.gbDisplayNames.TabStop = false;
            this.gbDisplayNames.Text = "Display names";
            // 
            // rbDNOnlyDN
            // 
            this.rbDNOnlyDN.AutoSize = true;
            this.rbDNOnlyDN.Location = new System.Drawing.Point(6, 88);
            this.rbDNOnlyDN.Name = "rbDNOnlyDN";
            this.rbDNOnlyDN.Size = new System.Drawing.Size(110, 17);
            this.rbDNOnlyDN.TabIndex = 3;
            this.rbDNOnlyDN.TabStop = true;
            this.rbDNOnlyDN.Text = "Only display name";
            this.rbDNOnlyDN.UseVisualStyleBackColor = true;
            this.rbDNOnlyDN.CheckedChanged += new System.EventHandler(this.rbDNOnlyDN_CheckedChanged);
            // 
            // rbDNDandUsernme
            // 
            this.rbDNDandUsernme.AutoSize = true;
            this.rbDNDandUsernme.Location = new System.Drawing.Point(6, 65);
            this.rbDNDandUsernme.Name = "rbDNDandUsernme";
            this.rbDNDandUsernme.Size = new System.Drawing.Size(143, 17);
            this.rbDNDandUsernme.TabIndex = 2;
            this.rbDNDandUsernme.TabStop = true;
            this.rbDNDandUsernme.Text = "Display name (username)";
            this.rbDNDandUsernme.UseVisualStyleBackColor = true;
            this.rbDNDandUsernme.CheckedChanged += new System.EventHandler(this.rbDNDandUsernme_CheckedChanged);
            // 
            // rbDNSmart
            // 
            this.rbDNSmart.AutoSize = true;
            this.rbDNSmart.Location = new System.Drawing.Point(6, 42);
            this.rbDNSmart.Name = "rbDNSmart";
            this.rbDNSmart.Size = new System.Drawing.Size(52, 17);
            this.rbDNSmart.TabIndex = 1;
            this.rbDNSmart.TabStop = true;
            this.rbDNSmart.Text = "Smart";
            this.rbDNSmart.UseVisualStyleBackColor = true;
            this.rbDNSmart.CheckedChanged += new System.EventHandler(this.rbDNSmart_CheckedChanged);
            // 
            // rbDNOff
            // 
            this.rbDNOff.AutoSize = true;
            this.rbDNOff.Location = new System.Drawing.Point(6, 19);
            this.rbDNOff.Name = "rbDNOff";
            this.rbDNOff.Size = new System.Drawing.Size(39, 17);
            this.rbDNOff.TabIndex = 0;
            this.rbDNOff.TabStop = true;
            this.rbDNOff.Text = "Off";
            this.rbDNOff.UseVisualStyleBackColor = true;
            this.rbDNOff.CheckedChanged += new System.EventHandler(this.rbDNOff_CheckedChanged);
            // 
            // cbSyntaxHighlight
            // 
            this.cbSyntaxHighlight.AutoSize = true;
            this.cbSyntaxHighlight.Location = new System.Drawing.Point(270, 52);
            this.cbSyntaxHighlight.Name = "cbSyntaxHighlight";
            this.cbSyntaxHighlight.Size = new System.Drawing.Size(134, 17);
            this.cbSyntaxHighlight.TabIndex = 14;
            this.cbSyntaxHighlight.Text = "LSL syntax highlighting";
            this.cbSyntaxHighlight.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(267, 190);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Chat text size:";
            // 
            // cbFontSize
            // 
            this.cbFontSize.FormatString = "N2";
            this.cbFontSize.FormattingEnabled = true;
            this.cbFontSize.Items.AddRange(new object[] {
            "8.25",
            "9",
            "10",
            "12",
            "14",
            "16",
            "20"});
            this.cbFontSize.Location = new System.Drawing.Point(346, 187);
            this.cbFontSize.Name = "cbFontSize";
            this.cbFontSize.Size = new System.Drawing.Size(54, 21);
            this.cbFontSize.TabIndex = 16;
            this.cbFontSize.Text = "8.25";
            this.cbFontSize.SelectedIndexChanged += new System.EventHandler(this.cbFontSize_SelectedIndexChanged);
            this.cbFontSize.Leave += new System.EventHandler(this.cbFontSize_Leave);
            this.cbFontSize.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cbFontSize_KeyDown);
            // 
            // cbNoTyping
            // 
            this.cbNoTyping.AutoSize = true;
            this.cbNoTyping.Location = new System.Drawing.Point(270, 29);
            this.cbNoTyping.Name = "cbNoTyping";
            this.cbNoTyping.Size = new System.Drawing.Size(150, 17);
            this.cbNoTyping.TabIndex = 13;
            this.cbNoTyping.Text = "Don\'t use typing animation";
            this.cbNoTyping.UseVisualStyleBackColor = true;
            this.cbNoTyping.CheckedChanged += new System.EventHandler(this.cbTrasactChat_CheckedChanged);
            // 
            // cbMinToTrey
            // 
            this.cbMinToTrey.AutoSize = true;
            this.cbMinToTrey.Location = new System.Drawing.Point(270, 6);
            this.cbMinToTrey.Name = "cbMinToTrey";
            this.cbMinToTrey.Size = new System.Drawing.Size(133, 17);
            this.cbMinToTrey.TabIndex = 12;
            this.cbMinToTrey.Text = "Minimize to system tray";
            this.cbMinToTrey.UseVisualStyleBackColor = true;
            this.cbMinToTrey.CheckedChanged += new System.EventHandler(this.cbTrasactChat_CheckedChanged);
            // 
            // cbMUEmotes
            // 
            this.cbMUEmotes.AutoSize = true;
            this.cbMUEmotes.Location = new System.Drawing.Point(8, 235);
            this.cbMUEmotes.Name = "cbMUEmotes";
            this.cbMUEmotes.Size = new System.Drawing.Size(108, 17);
            this.cbMUEmotes.TabIndex = 10;
            this.cbMUEmotes.Text = "MU* style emotes";
            this.cbMUEmotes.UseVisualStyleBackColor = true;
            this.cbMUEmotes.CheckedChanged += new System.EventHandler(this.cbTrasactChat_CheckedChanged);
            // 
            // cbRLV
            // 
            this.cbRLV.AutoSize = true;
            this.cbRLV.Location = new System.Drawing.Point(8, 212);
            this.cbRLV.Name = "cbRLV";
            this.cbRLV.Size = new System.Drawing.Size(85, 17);
            this.cbRLV.TabIndex = 9;
            this.cbRLV.Text = "RLV support";
            this.cbRLV.UseVisualStyleBackColor = true;
            this.cbRLV.CheckedChanged += new System.EventHandler(this.cbTrasactChat_CheckedChanged);
            // 
            // cbHideLoginGraphics
            // 
            this.cbHideLoginGraphics.AutoSize = true;
            this.cbHideLoginGraphics.Location = new System.Drawing.Point(8, 189);
            this.cbHideLoginGraphics.Name = "cbHideLoginGraphics";
            this.cbHideLoginGraphics.Size = new System.Drawing.Size(141, 17);
            this.cbHideLoginGraphics.TabIndex = 8;
            this.cbHideLoginGraphics.Text = "Hide login slpash screen";
            this.cbHideLoginGraphics.UseVisualStyleBackColor = true;
            this.cbHideLoginGraphics.CheckedChanged += new System.EventHandler(this.cbTrasactChat_CheckedChanged);
            // 
            // cbAutoReconnect
            // 
            this.cbAutoReconnect.AutoSize = true;
            this.cbAutoReconnect.Location = new System.Drawing.Point(8, 144);
            this.cbAutoReconnect.Name = "cbAutoReconnect";
            this.cbAutoReconnect.Size = new System.Drawing.Size(169, 17);
            this.cbAutoReconnect.TabIndex = 6;
            this.cbAutoReconnect.Text = "Auto reconnect on disconnect";
            this.cbAutoReconnect.UseVisualStyleBackColor = true;
            this.cbAutoReconnect.CheckedChanged += new System.EventHandler(this.cbTrasactChat_CheckedChanged);
            // 
            // cbFriendsHighlight
            // 
            this.cbFriendsHighlight.AutoSize = true;
            this.cbFriendsHighlight.Location = new System.Drawing.Point(8, 121);
            this.cbFriendsHighlight.Name = "cbFriendsHighlight";
            this.cbFriendsHighlight.Size = new System.Drawing.Size(248, 17);
            this.cbFriendsHighlight.TabIndex = 5;
            this.cbFriendsHighlight.Text = "Highlight chat tab on friends online notifications";
            this.cbFriendsHighlight.UseVisualStyleBackColor = true;
            this.cbFriendsHighlight.CheckedChanged += new System.EventHandler(this.cbTrasactChat_CheckedChanged);
            // 
            // cbFriendsNotifications
            // 
            this.cbFriendsNotifications.AutoSize = true;
            this.cbFriendsNotifications.Location = new System.Drawing.Point(8, 98);
            this.cbFriendsNotifications.Name = "cbFriendsNotifications";
            this.cbFriendsNotifications.Size = new System.Drawing.Size(184, 17);
            this.cbFriendsNotifications.TabIndex = 4;
            this.cbFriendsNotifications.Text = "Display friends online notifications";
            this.cbFriendsNotifications.UseVisualStyleBackColor = true;
            this.cbFriendsNotifications.CheckedChanged += new System.EventHandler(this.cbTrasactChat_CheckedChanged);
            // 
            // cbTrasactChat
            // 
            this.cbTrasactChat.AutoSize = true;
            this.cbTrasactChat.Location = new System.Drawing.Point(8, 75);
            this.cbTrasactChat.Name = "cbTrasactChat";
            this.cbTrasactChat.Size = new System.Drawing.Size(170, 17);
            this.cbTrasactChat.TabIndex = 3;
            this.cbTrasactChat.Text = "Display L$ transactions in chat";
            this.cbTrasactChat.UseVisualStyleBackColor = true;
            this.cbTrasactChat.CheckedChanged += new System.EventHandler(this.cbTrasactChat_CheckedChanged);
            // 
            // cbTrasactDialog
            // 
            this.cbTrasactDialog.AutoSize = true;
            this.cbTrasactDialog.Location = new System.Drawing.Point(8, 52);
            this.cbTrasactDialog.Name = "cbTrasactDialog";
            this.cbTrasactDialog.Size = new System.Drawing.Size(176, 17);
            this.cbTrasactDialog.TabIndex = 2;
            this.cbTrasactDialog.Text = "Display dialog on L$ transaction";
            this.cbTrasactDialog.UseVisualStyleBackColor = true;
            this.cbTrasactDialog.CheckedChanged += new System.EventHandler(this.cbTrasactDialog_CheckedChanged);
            // 
            // cbIMTimeStamps
            // 
            this.cbIMTimeStamps.AutoSize = true;
            this.cbIMTimeStamps.Location = new System.Drawing.Point(8, 29);
            this.cbIMTimeStamps.Name = "cbIMTimeStamps";
            this.cbIMTimeStamps.Size = new System.Drawing.Size(137, 17);
            this.cbIMTimeStamps.TabIndex = 1;
            this.cbIMTimeStamps.Text = "Show timestamps in  IM";
            this.cbIMTimeStamps.UseVisualStyleBackColor = true;
            // 
            // cbChatTimestamps
            // 
            this.cbChatTimestamps.AutoSize = true;
            this.cbChatTimestamps.Location = new System.Drawing.Point(8, 6);
            this.cbChatTimestamps.Name = "cbChatTimestamps";
            this.cbChatTimestamps.Size = new System.Drawing.Size(143, 17);
            this.cbChatTimestamps.TabIndex = 0;
            this.cbChatTimestamps.Text = "Show timestamps in chat";
            this.cbChatTimestamps.UseVisualStyleBackColor = true;
            // 
            // tbpAutoResponse
            // 
            this.tbpAutoResponse.Controls.Add(this.txtAutoResponse);
            this.tbpAutoResponse.Controls.Add(this.gbAutoResponse);
            this.tbpAutoResponse.Location = new System.Drawing.Point(4, 22);
            this.tbpAutoResponse.Name = "tbpAutoResponse";
            this.tbpAutoResponse.Padding = new System.Windows.Forms.Padding(3);
            this.tbpAutoResponse.Size = new System.Drawing.Size(488, 277);
            this.tbpAutoResponse.TabIndex = 2;
            this.tbpAutoResponse.Text = "Auto Response";
            this.tbpAutoResponse.UseVisualStyleBackColor = true;
            // 
            // txtAutoResponse
            // 
            this.txtAutoResponse.AccessibleName = "Auto response text";
            this.txtAutoResponse.Location = new System.Drawing.Point(8, 63);
            this.txtAutoResponse.Multiline = true;
            this.txtAutoResponse.Name = "txtAutoResponse";
            this.txtAutoResponse.Size = new System.Drawing.Size(282, 87);
            this.txtAutoResponse.TabIndex = 1;
            // 
            // gbAutoResponse
            // 
            this.gbAutoResponse.Controls.Add(this.rbAutoAlways);
            this.gbAutoResponse.Controls.Add(this.rbAutoNonFriend);
            this.gbAutoResponse.Controls.Add(this.rbAutobusy);
            this.gbAutoResponse.Location = new System.Drawing.Point(3, 6);
            this.gbAutoResponse.Name = "gbAutoResponse";
            this.gbAutoResponse.Size = new System.Drawing.Size(287, 51);
            this.gbAutoResponse.TabIndex = 0;
            this.gbAutoResponse.TabStop = false;
            this.gbAutoResponse.Text = "Send auto response when:";
            // 
            // rbAutoAlways
            // 
            this.rbAutoAlways.AutoSize = true;
            this.rbAutoAlways.Location = new System.Drawing.Point(216, 19);
            this.rbAutoAlways.Name = "rbAutoAlways";
            this.rbAutoAlways.Size = new System.Drawing.Size(58, 17);
            this.rbAutoAlways.TabIndex = 2;
            this.rbAutoAlways.Text = "Always";
            this.rbAutoAlways.UseVisualStyleBackColor = true;
            this.rbAutoAlways.CheckedChanged += new System.EventHandler(this.rbAutoAlways_CheckedChanged);
            // 
            // rbAutoNonFriend
            // 
            this.rbAutoNonFriend.AutoSize = true;
            this.rbAutoNonFriend.Location = new System.Drawing.Point(100, 19);
            this.rbAutoNonFriend.Name = "rbAutoNonFriend";
            this.rbAutoNonFriend.Size = new System.Drawing.Size(110, 17);
            this.rbAutoNonFriend.TabIndex = 1;
            this.rbAutoNonFriend.Text = "IM from non-friend";
            this.rbAutoNonFriend.UseVisualStyleBackColor = true;
            this.rbAutoNonFriend.CheckedChanged += new System.EventHandler(this.rbAutoNonFriend_CheckedChanged);
            // 
            // rbAutobusy
            // 
            this.rbAutobusy.AutoSize = true;
            this.rbAutobusy.Checked = true;
            this.rbAutobusy.Location = new System.Drawing.Point(6, 19);
            this.rbAutobusy.Name = "rbAutobusy";
            this.rbAutobusy.Size = new System.Drawing.Size(88, 17);
            this.rbAutobusy.TabIndex = 0;
            this.rbAutobusy.TabStop = true;
            this.rbAutobusy.Text = "In busy mode";
            this.rbAutobusy.UseVisualStyleBackColor = true;
            this.rbAutobusy.CheckedChanged += new System.EventHandler(this.rbAutobusy_CheckedChanged);
            // 
            // frmSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(496, 303);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmSettings";
            this.Text = "Settings - Radegast";
            this.tabControl1.ResumeLayout(false);
            this.tbpGeneral.ResumeLayout(false);
            this.tbpGeneral.PerformLayout();
            this.gbDisplayNames.ResumeLayout(false);
            this.gbDisplayNames.PerformLayout();
            this.tbpAutoResponse.ResumeLayout(false);
            this.tbpAutoResponse.PerformLayout();
            this.gbAutoResponse.ResumeLayout(false);
            this.gbAutoResponse.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.ComboBox cbFontSize;
        public System.Windows.Forms.TabControl tabControl1;
        public System.Windows.Forms.TabPage tbpGeneral;
        public System.Windows.Forms.CheckBox cbIMTimeStamps;
        public System.Windows.Forms.CheckBox cbChatTimestamps;
        public System.Windows.Forms.CheckBox cbTrasactChat;
        public System.Windows.Forms.CheckBox cbTrasactDialog;
        public System.Windows.Forms.CheckBox cbFriendsNotifications;
        public System.Windows.Forms.CheckBox cbAutoReconnect;
        public System.Windows.Forms.CheckBox cbHideLoginGraphics;
        public System.Windows.Forms.CheckBox cbRLV;
        public System.Windows.Forms.CheckBox cbMUEmotes;
        public System.Windows.Forms.CheckBox cbFriendsHighlight;
        public System.Windows.Forms.CheckBox cbMinToTrey;
        public System.Windows.Forms.CheckBox cbNoTyping;
        public System.Windows.Forms.TextBox txtReconnectTime;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.TabPage tbpAutoResponse;
        public System.Windows.Forms.GroupBox gbAutoResponse;
        public System.Windows.Forms.TextBox txtAutoResponse;
        public System.Windows.Forms.RadioButton rbAutoAlways;
        public System.Windows.Forms.RadioButton rbAutoNonFriend;
        public System.Windows.Forms.RadioButton rbAutobusy;
        public System.Windows.Forms.CheckBox cbSyntaxHighlight;
        public System.Windows.Forms.GroupBox gbDisplayNames;
        public System.Windows.Forms.RadioButton rbDNOnlyDN;
        public System.Windows.Forms.RadioButton rbDNDandUsernme;
        public System.Windows.Forms.RadioButton rbDNSmart;
        public System.Windows.Forms.RadioButton rbDNOff;


    }
}