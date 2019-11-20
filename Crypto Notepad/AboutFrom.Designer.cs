﻿namespace Crypto_Notepad
{
    partial class AboutFrom
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AboutFrom));
            this.appVersionLabel = new System.Windows.Forms.Label();
            this.randomColorTimer = new System.Windows.Forms.Timer(this.components);
            this.copyToClipboardLabel = new System.Windows.Forms.Label();
            this.appInfoRichTextBox = new Crypto_Notepad.HideCaretRichTextBox();
            this.aboutToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // appVersionLabel
            // 
            this.appVersionLabel.AutoSize = true;
            this.appVersionLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.appVersionLabel.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.appVersionLabel.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.appVersionLabel.Location = new System.Drawing.Point(4, 10);
            this.appVersionLabel.Name = "appVersionLabel";
            this.appVersionLabel.Size = new System.Drawing.Size(210, 22);
            this.appVersionLabel.TabIndex = 1;
            this.appVersionLabel.Text = "Crypto Notepad 1.0.0";
            this.aboutToolTip.SetToolTip(this.appVersionLabel, "Left click to copy debug info to the clipboard");
            this.appVersionLabel.MouseClick += new System.Windows.Forms.MouseEventHandler(this.AppVersionLabel_MouseClick);
            // 
            // randomColorTimer
            // 
            this.randomColorTimer.Interval = 200;
            this.randomColorTimer.Tick += new System.EventHandler(this.RandomColorTimer_Tick);
            // 
            // copyToClipboardLabel
            // 
            this.copyToClipboardLabel.AutoSize = true;
            this.copyToClipboardLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.copyToClipboardLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.copyToClipboardLabel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.copyToClipboardLabel.Location = new System.Drawing.Point(214, 15);
            this.copyToClipboardLabel.Name = "copyToClipboardLabel";
            this.copyToClipboardLabel.Size = new System.Drawing.Size(81, 14);
            this.copyToClipboardLabel.TabIndex = 3;
            this.copyToClipboardLabel.Text = "copied to clipboard";
            this.copyToClipboardLabel.Visible = false;
            // 
            // appInfoRichTextBox
            // 
            this.appInfoRichTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(50)))));
            this.appInfoRichTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.appInfoRichTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.appInfoRichTextBox.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.appInfoRichTextBox.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.appInfoRichTextBox.Location = new System.Drawing.Point(0, 44);
            this.appInfoRichTextBox.Name = "appInfoRichTextBox";
            this.appInfoRichTextBox.ReadOnly = true;
            this.appInfoRichTextBox.RightMargin = 700;
            this.appInfoRichTextBox.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.appInfoRichTextBox.ShowSelectionMargin = true;
            this.appInfoRichTextBox.Size = new System.Drawing.Size(439, 303);
            this.appInfoRichTextBox.TabIndex = 2;
            this.appInfoRichTextBox.TabStop = false;
            this.appInfoRichTextBox.Text = resources.GetString("appInfoRichTextBox.Text");
            this.appInfoRichTextBox.WordWrap = false;
            this.appInfoRichTextBox.LinkClicked += new System.Windows.Forms.LinkClickedEventHandler(this.AppInfoRichTextBox_LinkClicked);
            // 
            // AboutFrom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(50)))));
            this.ClientSize = new System.Drawing.Size(435, 323);
            this.Controls.Add(this.copyToClipboardLabel);
            this.Controls.Add(this.appInfoRichTextBox);
            this.Controls.Add(this.appVersionLabel);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AboutFrom";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "About";
            this.Load += new System.EventHandler(this.AboutWindow_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label appVersionLabel;
        private HideCaretRichTextBox appInfoRichTextBox;
        private System.Windows.Forms.Timer randomColorTimer;
        private System.Windows.Forms.Label copyToClipboardLabel;
        private System.Windows.Forms.ToolTip aboutToolTip;
    }
}