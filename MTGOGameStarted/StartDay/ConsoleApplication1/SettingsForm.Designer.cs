using System;
using System.IO.IsolatedStorage;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.Reflection;
using System.Collections;
using System.Windows.Forms;
using System.Linq;
using System.Windows;
using System.Data;
using System.Drawing;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace MtgoGame
{
    partial class SettingsForm
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
            this.InputBoxEmail = new System.Windows.Forms.TextBox();
            this.InputBoxPassword = new System.Windows.Forms.TextBox();
            this.InputBoxHost = new System.Windows.Forms.TextBox();
            this.InputBoxPort = new System.Windows.Forms.TextBox();
            this.ButtonSave = new System.Windows.Forms.Button();
            this.ButtonClose = new System.Windows.Forms.Button();
            this.LabelEmail = new System.Windows.Forms.Label();
            this.LabelPassword = new System.Windows.Forms.Label();
            this.LabelHost = new System.Windows.Forms.Label();
            this.LabelPort = new System.Windows.Forms.Label();
            //this.SuspendLayout();
            // 
            // InputBoxEmail
            // 
            this.InputBoxEmail.Location = new System.Drawing.Point(132, 12);
            this.InputBoxEmail.Name = "InputBoxEmail";
            this.InputBoxEmail.Size = new System.Drawing.Size(140, 20);
            this.InputBoxEmail.TabIndex = 0;
            this.InputBoxEmail.Text = ConsoleApplication1.Properties.Settings.Default.Email;
            // 
            // InputBoxPassword
            // 
            this.InputBoxPassword.Location = new System.Drawing.Point(132, 58);
            this.InputBoxPassword.Name = "InputBoxPassword";
            this.InputBoxPassword.Size = new System.Drawing.Size(140, 20);
            this.InputBoxPassword.TabIndex = 1;
            this.InputBoxPassword.Text = ConsoleApplication1.Properties.Settings.Default.Password;
            // 
            // InputBoxHost
            // 
            this.InputBoxHost.Location = new System.Drawing.Point(132, 112);
            this.InputBoxHost.Name = "InputBoxHost";
            this.InputBoxHost.Size = new System.Drawing.Size(100, 20);
            this.InputBoxHost.TabIndex = 2;
            this.InputBoxHost.Text = ConsoleApplication1.Properties.Settings.Default.Host;
            // 
            // InputBoxPort
            // 
            this.InputBoxPort.Location = new System.Drawing.Point(132, 166);
            this.InputBoxPort.Name = "InputBoxPort";
            this.InputBoxPort.Size = new System.Drawing.Size(100, 20);
            this.InputBoxPort.TabIndex = 3;
            this.InputBoxPort.Text = ConsoleApplication1.Properties.Settings.Default.Port;
            // 
            // ButtonSave
            // 
            this.ButtonSave.Location = new System.Drawing.Point(197, 227);
            this.ButtonSave.Name = "ButtonSave";
            this.ButtonSave.Size = new System.Drawing.Size(75, 23);
            this.ButtonSave.TabIndex = 4;
            this.ButtonSave.Text = "SAVE";
            this.ButtonSave.UseVisualStyleBackColor = true;
            this.ButtonSave.Click += new System.EventHandler(this.ButtonSave_Click);

            // 
            // ButtonClose
            // 
            this.ButtonClose.Location = new System.Drawing.Point(93, 227);
            this.ButtonClose.Name = "ButtonClose";
            this.ButtonClose.Size = new System.Drawing.Size(75, 23);
            this.ButtonClose.TabIndex = 5;
            this.ButtonClose.Text = "CLOSE";
            this.ButtonClose.UseVisualStyleBackColor = true;
            this.ButtonClose.Click += new System.EventHandler(this.ButtonClose_Click);
            // 
            // LabelEmail
            // 
            this.LabelEmail.AutoSize = true;
            this.LabelEmail.Location = new System.Drawing.Point(12, 15);
            this.LabelEmail.Name = "LabelEmail";
            this.LabelEmail.Size = new System.Drawing.Size(73, 13);
            this.LabelEmail.TabIndex = 6;
            this.LabelEmail.Text = "Email Address";
            // 
            // LabelPassword
            // 
            this.LabelPassword.AutoSize = true;
            this.LabelPassword.Location = new System.Drawing.Point(12, 61);
            this.LabelPassword.Name = "LabelPassword";
            this.LabelPassword.Size = new System.Drawing.Size(53, 13);
            this.LabelPassword.TabIndex = 7;
            this.LabelPassword.Text = "Password";
            // 
            // LabelHost
            // 
            this.LabelHost.AutoSize = true;
            this.LabelHost.Location = new System.Drawing.Point(12, 115);
            this.LabelHost.Name = "LabelHost";
            this.LabelHost.Size = new System.Drawing.Size(29, 13);
            this.LabelHost.TabIndex = 8;
            this.LabelHost.Text = "Host";
            // 
            // LabelPort
            // 
            this.LabelPort.AutoSize = true;
            this.LabelPort.Location = new System.Drawing.Point(12, 169);
            this.LabelPort.Name = "LabelPort";
            this.LabelPort.Size = new System.Drawing.Size(26, 13);
            this.LabelPort.TabIndex = 9;
            this.LabelPort.Text = "Port";
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.LabelPort);
            this.Controls.Add(this.LabelHost);
            this.Controls.Add(this.LabelPassword);
            this.Controls.Add(this.LabelEmail);
            this.Controls.Add(this.ButtonClose);
            this.Controls.Add(this.ButtonSave);
            this.Controls.Add(this.InputBoxPort);
            this.Controls.Add(this.InputBoxHost);
            this.Controls.Add(this.InputBoxPassword);
            this.Controls.Add(this.InputBoxEmail);
            this.Name = "Connection Settings";
            this.Text = "Connection Settings";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private void ButtonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion

        private void ButtonSave_Click(object sender, EventArgs e)
        {

            ConsoleApplication1.Properties.Settings.Default.Email = this.InputBoxEmail.Text;
            ConsoleApplication1.Properties.Settings.Default.Password = this.InputBoxPassword.Text;
            ConsoleApplication1.Properties.Settings.Default.Host = this.InputBoxHost.Text;
            ConsoleApplication1.Properties.Settings.Default.Port = this.InputBoxPort.Text;
            ConsoleApplication1.Properties.Settings.Default.Save();

        }

        private System.Windows.Forms.TextBox InputBoxEmail;
        private System.Windows.Forms.TextBox InputBoxPassword;
        private System.Windows.Forms.TextBox InputBoxHost;
        private System.Windows.Forms.TextBox InputBoxPort;
        private System.Windows.Forms.Button ButtonSave;
        private System.Windows.Forms.Button ButtonClose;
        private System.Windows.Forms.Label LabelEmail;
        private System.Windows.Forms.Label LabelPassword;
        private System.Windows.Forms.Label LabelHost;
        private System.Windows.Forms.Label LabelPort;
    }   
}