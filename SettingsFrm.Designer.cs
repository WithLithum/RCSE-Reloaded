﻿namespace RCSE_Reloaded
{
    partial class SettingsFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingsFrm));
            this.groupDisplay = new System.Windows.Forms.GroupBox();
            this.checkLightColor = new System.Windows.Forms.CheckBox();
            this.labelMainMenu = new System.Windows.Forms.Label();
            this.checkUseMainMenu = new System.Windows.Forms.CheckBox();
            this.buttonOK = new System.Windows.Forms.Button();
            this.groupDisplay.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupDisplay
            // 
            resources.ApplyResources(this.groupDisplay, "groupDisplay");
            this.groupDisplay.Controls.Add(this.checkLightColor);
            this.groupDisplay.Controls.Add(this.labelMainMenu);
            this.groupDisplay.Controls.Add(this.checkUseMainMenu);
            this.groupDisplay.Name = "groupDisplay";
            this.groupDisplay.TabStop = false;
            // 
            // checkLightColor
            // 
            resources.ApplyResources(this.checkLightColor, "checkLightColor");
            this.checkLightColor.Name = "checkLightColor";
            this.checkLightColor.UseVisualStyleBackColor = true;
            // 
            // labelMainMenu
            // 
            resources.ApplyResources(this.labelMainMenu, "labelMainMenu");
            this.labelMainMenu.Name = "labelMainMenu";
            // 
            // checkUseMainMenu
            // 
            resources.ApplyResources(this.checkUseMainMenu, "checkUseMainMenu");
            this.checkUseMainMenu.Name = "checkUseMainMenu";
            this.checkUseMainMenu.UseVisualStyleBackColor = true;
            // 
            // buttonOK
            // 
            resources.ApplyResources(this.buttonOK, "buttonOK");
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.UseVisualStyleBackColor = true;
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // SettingsFrm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.buttonOK);
            this.Controls.Add(this.groupDisplay);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SettingsFrm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Load += new System.EventHandler(this.SettingsFrm_Load);
            this.groupDisplay.ResumeLayout(false);
            this.groupDisplay.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupDisplay;
        private System.Windows.Forms.Label labelMainMenu;
        private System.Windows.Forms.CheckBox checkUseMainMenu;
        private System.Windows.Forms.Button buttonOK;
        private System.Windows.Forms.CheckBox checkLightColor;
    }
}