﻿namespace Epicor_Integration
{
    partial class Revision_Master
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Revision_Master));
            this.savebtn = new System.Windows.Forms.Button();
            this.cancelbtn = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.gid_desc = new System.Windows.Forms.TextBox();
            this.Searchbtn = new System.Windows.Forms.Button();
            this.Searchtxt = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.newrev_txt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.currev_txt = new System.Windows.Forms.TextBox();
            this.revdesc_txt = new System.Windows.Forms.TextBox();
            this.checkout_chk = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // savebtn
            // 
            this.savebtn.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.savebtn.Location = new System.Drawing.Point(18, 268);
            this.savebtn.Name = "savebtn";
            this.savebtn.Size = new System.Drawing.Size(75, 23);
            this.savebtn.TabIndex = 36;
            this.savebtn.Text = "&Save";
            this.savebtn.UseVisualStyleBackColor = true;
            this.savebtn.Click += new System.EventHandler(this.savebtn_Click);
            // 
            // cancelbtn
            // 
            this.cancelbtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelbtn.Location = new System.Drawing.Point(129, 268);
            this.cancelbtn.Name = "cancelbtn";
            this.cancelbtn.Size = new System.Drawing.Size(75, 23);
            this.cancelbtn.TabIndex = 35;
            this.cancelbtn.Text = "&Cancel";
            this.cancelbtn.UseVisualStyleBackColor = true;
            this.cancelbtn.Click += new System.EventHandler(this.cancelbtn_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.gid_desc);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(202, 51);
            this.groupBox1.TabIndex = 37;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "ECO Group";
            // 
            // gid_desc
            // 
            this.gid_desc.Location = new System.Drawing.Point(6, 19);
            this.gid_desc.Name = "gid_desc";
            this.gid_desc.Size = new System.Drawing.Size(186, 20);
            this.gid_desc.TabIndex = 1;
            // 
            // Searchbtn
            // 
            this.Searchbtn.Location = new System.Drawing.Point(6, 19);
            this.Searchbtn.Name = "Searchbtn";
            this.Searchbtn.Size = new System.Drawing.Size(75, 23);
            this.Searchbtn.TabIndex = 38;
            this.Searchbtn.Text = "&Search";
            this.Searchbtn.UseVisualStyleBackColor = true;
            this.Searchbtn.Click += new System.EventHandler(this.Searchbtn_Click);
            // 
            // Searchtxt
            // 
            this.Searchtxt.Location = new System.Drawing.Point(87, 21);
            this.Searchtxt.Name = "Searchtxt";
            this.Searchtxt.Size = new System.Drawing.Size(100, 20);
            this.Searchtxt.TabIndex = 39;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.newrev_txt);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.currev_txt);
            this.groupBox2.Controls.Add(this.revdesc_txt);
            this.groupBox2.Controls.Add(this.Searchbtn);
            this.groupBox2.Controls.Add(this.Searchtxt);
            this.groupBox2.Location = new System.Drawing.Point(12, 69);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(202, 156);
            this.groupBox2.TabIndex = 40;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Part";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 13);
            this.label3.TabIndex = 45;
            this.label3.Text = "New Revision:";
            // 
            // newrev_txt
            // 
            this.newrev_txt.Location = new System.Drawing.Point(87, 73);
            this.newrev_txt.Name = "newrev_txt";
            this.newrev_txt.Size = new System.Drawing.Size(100, 20);
            this.newrev_txt.TabIndex = 44;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 43;
            this.label2.Text = "Cur Revision:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 105);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 13);
            this.label1.TabIndex = 42;
            this.label1.Text = "Revision Description:";
            // 
            // currev_txt
            // 
            this.currev_txt.Location = new System.Drawing.Point(87, 47);
            this.currev_txt.Name = "currev_txt";
            this.currev_txt.Size = new System.Drawing.Size(100, 20);
            this.currev_txt.TabIndex = 41;
            // 
            // revdesc_txt
            // 
            this.revdesc_txt.Location = new System.Drawing.Point(9, 121);
            this.revdesc_txt.Name = "revdesc_txt";
            this.revdesc_txt.Size = new System.Drawing.Size(178, 20);
            this.revdesc_txt.TabIndex = 40;
            // 
            // checkout_chk
            // 
            this.checkout_chk.AutoSize = true;
            this.checkout_chk.Checked = true;
            this.checkout_chk.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkout_chk.Location = new System.Drawing.Point(21, 231);
            this.checkout_chk.Name = "checkout_chk";
            this.checkout_chk.Size = new System.Drawing.Size(99, 17);
            this.checkout_chk.TabIndex = 41;
            this.checkout_chk.Text = "Check Out Part";
            this.checkout_chk.UseVisualStyleBackColor = true;
            // 
            // Revision_Master
            // 
            this.AcceptButton = this.Searchbtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.cancelbtn;
            this.ClientSize = new System.Drawing.Size(227, 304);
            this.Controls.Add(this.checkout_chk);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.savebtn);
            this.Controls.Add(this.cancelbtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Revision_Master";
            this.Text = "Add Item Revision";
            this.Load += new System.EventHandler(this.Revision_Master_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button savebtn;
        private System.Windows.Forms.Button cancelbtn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox gid_desc;
        private System.Windows.Forms.Button Searchbtn;
        private System.Windows.Forms.TextBox Searchtxt;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox currev_txt;
        private System.Windows.Forms.TextBox revdesc_txt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox newrev_txt;
        private System.Windows.Forms.CheckBox checkout_chk;
    }
}