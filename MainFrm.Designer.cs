﻿namespace RCSE_Reloaded
{
    partial class MainFrm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.elementHost1 = new System.Windows.Forms.Integration.ElementHost();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.itemFile = new System.Windows.Forms.ToolStripMenuItem();
            this.itemOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.itemNew = new System.Windows.Forms.ToolStripMenuItem();
            this.split1 = new System.Windows.Forms.ToolStripSeparator();
            this.itemQuit = new System.Windows.Forms.ToolStripMenuItem();
            this.itemEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.itemFormat = new System.Windows.Forms.ToolStripMenuItem();
            this.itemCSharp = new System.Windows.Forms.ToolStripMenuItem();
            this.itemHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.itemSave = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // elementHost1
            // 
            this.elementHost1.Dock = System.Windows.Forms.DockStyle.Top;
            this.elementHost1.Location = new System.Drawing.Point(0, 25);
            this.elementHost1.Name = "elementHost1";
            this.elementHost1.Size = new System.Drawing.Size(800, 400);
            this.elementHost1.TabIndex = 1;
            this.elementHost1.Text = "elementHost1";
            this.elementHost1.ChildChanged += new System.EventHandler<System.Windows.Forms.Integration.ChildChangedEventArgs>(this.elementHost1_ChildChanged);
            this.elementHost1.Child = null;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.itemFile,
            this.itemEdit,
            this.itemFormat,
            this.itemHelp});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 25);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // itemFile
            // 
            this.itemFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.itemOpen,
            this.itemNew,
            this.itemSave,
            this.split1,
            this.itemQuit});
            this.itemFile.Name = "itemFile";
            this.itemFile.Size = new System.Drawing.Size(58, 21);
            this.itemFile.Text = "文件(&F)";
            this.itemFile.Click += new System.EventHandler(this.itemFile_Click);
            // 
            // itemOpen
            // 
            this.itemOpen.Name = "itemOpen";
            this.itemOpen.Size = new System.Drawing.Size(180, 22);
            this.itemOpen.Text = "打开(&P)";
            this.itemOpen.Click += new System.EventHandler(this.itemOpen_Click);
            // 
            // itemNew
            // 
            this.itemNew.Name = "itemNew";
            this.itemNew.Size = new System.Drawing.Size(180, 22);
            this.itemNew.Text = "新建(&N)";
            this.itemNew.Click += new System.EventHandler(this.itemNew_Click);
            // 
            // split1
            // 
            this.split1.Name = "split1";
            this.split1.Size = new System.Drawing.Size(177, 6);
            // 
            // itemQuit
            // 
            this.itemQuit.Name = "itemQuit";
            this.itemQuit.Size = new System.Drawing.Size(180, 22);
            this.itemQuit.Text = "退出(&Q)";
            this.itemQuit.Click += new System.EventHandler(this.itemQuit_Click);
            // 
            // itemEdit
            // 
            this.itemEdit.Name = "itemEdit";
            this.itemEdit.Size = new System.Drawing.Size(59, 21);
            this.itemEdit.Text = "编辑(&E)";
            // 
            // itemFormat
            // 
            this.itemFormat.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.itemCSharp});
            this.itemFormat.Name = "itemFormat";
            this.itemFormat.Size = new System.Drawing.Size(62, 21);
            this.itemFormat.Text = "格式(&O)";
            // 
            // itemCSharp
            // 
            this.itemCSharp.Name = "itemCSharp";
            this.itemCSharp.Size = new System.Drawing.Size(92, 22);
            this.itemCSharp.Text = "C#";
            this.itemCSharp.Click += new System.EventHandler(this.itemCSharp_Click);
            // 
            // itemHelp
            // 
            this.itemHelp.Name = "itemHelp";
            this.itemHelp.Size = new System.Drawing.Size(61, 21);
            this.itemHelp.Text = "帮助(&H)";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 428);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(800, 22);
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // itemSave
            // 
            this.itemSave.Name = "itemSave";
            this.itemSave.Size = new System.Drawing.Size(180, 22);
            this.itemSave.Text = "保存(&S)";
            this.itemSave.Click += new System.EventHandler(this.保存SToolStripMenuItem_Click);
            // 
            // MainFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.elementHost1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = global::RCSE_Reloaded.Properties.Resources.rcse;
            this.KeyPreview = true;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "MainFrm";
            this.Text = "RCSE v0.4 Beta";
            this.Load += new System.EventHandler(this.MainFrm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Integration.ElementHost elementHost1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem itemFile;
        private System.Windows.Forms.ToolStripMenuItem itemEdit;
        private System.Windows.Forms.ToolStripMenuItem itemFormat;
        private System.Windows.Forms.ToolStripMenuItem itemHelp;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripMenuItem itemOpen;
        private System.Windows.Forms.ToolStripMenuItem itemNew;
        private System.Windows.Forms.ToolStripSeparator split1;
        private System.Windows.Forms.ToolStripMenuItem itemQuit;
        private System.Windows.Forms.ToolStripMenuItem itemCSharp;
        private System.Windows.Forms.ToolStripMenuItem itemSave;
    }
}

