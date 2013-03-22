namespace FirebirdBackupKitTest
{
    partial class MainForm
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
            this.backupBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.backupSrcBox = new System.Windows.Forms.TextBox();
            this.backupDestBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.restoreDestBox = new System.Windows.Forms.TextBox();
            this.restoreSrcBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.restoreBtn = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.copyDestBox = new System.Windows.Forms.TextBox();
            this.copySrcBox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.copyBtn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.passwordBox = new System.Windows.Forms.TextBox();
            this.usernameBox = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.openFileDiag = new System.Windows.Forms.OpenFileDialog();
            this.backupSrcBtn = new System.Windows.Forms.Button();
            this.restoreSrcBtn = new System.Windows.Forms.Button();
            this.copySrcBtn = new System.Windows.Forms.Button();
            this.backupDestBtn = new System.Windows.Forms.Button();
            this.restoreDestBtn = new System.Windows.Forms.Button();
            this.copyDestBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // backupBtn
            // 
            this.backupBtn.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backupBtn.Location = new System.Drawing.Point(541, 135);
            this.backupBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.backupBtn.Name = "backupBtn";
            this.backupBtn.Size = new System.Drawing.Size(103, 46);
            this.backupBtn.TabIndex = 1;
            this.backupBtn.Text = "Backup";
            this.backupBtn.UseVisualStyleBackColor = true;
            this.backupBtn.Click += new System.EventHandler(this.backupBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 135);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Source:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 161);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Destination:";
            // 
            // backupSrcBox
            // 
            this.backupSrcBox.Location = new System.Drawing.Point(111, 135);
            this.backupSrcBox.Name = "backupSrcBox";
            this.backupSrcBox.Size = new System.Drawing.Size(385, 20);
            this.backupSrcBox.TabIndex = 5;
            this.backupSrcBox.Text = "c:\\database.fdb";
            // 
            // backupDestBox
            // 
            this.backupDestBox.Location = new System.Drawing.Point(111, 161);
            this.backupDestBox.Name = "backupDestBox";
            this.backupDestBox.Size = new System.Drawing.Size(385, 20);
            this.backupDestBox.TabIndex = 6;
            this.backupDestBox.Text = "c:\\database-backup.fbk";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 104);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 22);
            this.label4.TabIndex = 9;
            this.label4.Text = "Backup test:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 193);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(166, 22);
            this.label5.TabIndex = 15;
            this.label5.Text = "Restore backup test:";
            // 
            // restoreDestBox
            // 
            this.restoreDestBox.Location = new System.Drawing.Point(111, 250);
            this.restoreDestBox.Name = "restoreDestBox";
            this.restoreDestBox.Size = new System.Drawing.Size(385, 20);
            this.restoreDestBox.TabIndex = 14;
            this.restoreDestBox.Text = "c:\\database.fdb";
            // 
            // restoreSrcBox
            // 
            this.restoreSrcBox.Location = new System.Drawing.Point(111, 224);
            this.restoreSrcBox.Name = "restoreSrcBox";
            this.restoreSrcBox.Size = new System.Drawing.Size(385, 20);
            this.restoreSrcBox.TabIndex = 13;
            this.restoreSrcBox.Text = "c:\\database-backup.fbk";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(23, 250);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 16);
            this.label6.TabIndex = 12;
            this.label6.Text = "Destination:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(23, 224);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 16);
            this.label7.TabIndex = 11;
            this.label7.Text = "Source:";
            // 
            // restoreBtn
            // 
            this.restoreBtn.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.restoreBtn.Location = new System.Drawing.Point(541, 224);
            this.restoreBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.restoreBtn.Name = "restoreBtn";
            this.restoreBtn.Size = new System.Drawing.Size(103, 46);
            this.restoreBtn.TabIndex = 10;
            this.restoreBtn.Text = "Restore backup";
            this.restoreBtn.UseVisualStyleBackColor = true;
            this.restoreBtn.Click += new System.EventHandler(this.restoreBtn_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(12, 285);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(158, 22);
            this.label8.TabIndex = 21;
            this.label8.Text = "Copy database test:";
            // 
            // copyDestBox
            // 
            this.copyDestBox.Location = new System.Drawing.Point(111, 342);
            this.copyDestBox.Name = "copyDestBox";
            this.copyDestBox.Size = new System.Drawing.Size(385, 20);
            this.copyDestBox.TabIndex = 20;
            this.copyDestBox.Text = "c:\\database-copy.fdb";
            // 
            // copySrcBox
            // 
            this.copySrcBox.Location = new System.Drawing.Point(111, 316);
            this.copySrcBox.Name = "copySrcBox";
            this.copySrcBox.Size = new System.Drawing.Size(385, 20);
            this.copySrcBox.TabIndex = 19;
            this.copySrcBox.Text = "c:\\database.fdb";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(23, 342);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(70, 16);
            this.label9.TabIndex = 18;
            this.label9.Text = "Destination:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(23, 316);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(46, 16);
            this.label10.TabIndex = 17;
            this.label10.Text = "Source:";
            // 
            // copyBtn
            // 
            this.copyBtn.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.copyBtn.Location = new System.Drawing.Point(541, 317);
            this.copyBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.copyBtn.Name = "copyBtn";
            this.copyBtn.Size = new System.Drawing.Size(103, 46);
            this.copyBtn.TabIndex = 16;
            this.copyBtn.Text = "Copy database";
            this.copyBtn.UseVisualStyleBackColor = true;
            this.copyBtn.Click += new System.EventHandler(this.copyBtn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(159, 22);
            this.label3.TabIndex = 26;
            this.label3.Text = "Firebird Credentials";
            // 
            // passwordBox
            // 
            this.passwordBox.Location = new System.Drawing.Point(111, 66);
            this.passwordBox.Name = "passwordBox";
            this.passwordBox.PasswordChar = '*';
            this.passwordBox.Size = new System.Drawing.Size(204, 20);
            this.passwordBox.TabIndex = 25;
            this.passwordBox.Text = "masterkey";
            // 
            // usernameBox
            // 
            this.usernameBox.Location = new System.Drawing.Point(111, 40);
            this.usernameBox.Name = "usernameBox";
            this.usernameBox.Size = new System.Drawing.Size(204, 20);
            this.usernameBox.TabIndex = 24;
            this.usernameBox.Text = "SYSDBA";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(23, 66);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(59, 16);
            this.label11.TabIndex = 23;
            this.label11.Text = "Password:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(23, 40);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(61, 16);
            this.label12.TabIndex = 22;
            this.label12.Text = "Username:";
            // 
            // openFileDiag
            // 
            this.openFileDiag.Filter = "FDB files|*.fdb";
            // 
            // backupSrcBtn
            // 
            this.backupSrcBtn.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backupSrcBtn.Location = new System.Drawing.Point(502, 134);
            this.backupSrcBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.backupSrcBtn.Name = "backupSrcBtn";
            this.backupSrcBtn.Size = new System.Drawing.Size(26, 21);
            this.backupSrcBtn.TabIndex = 27;
            this.backupSrcBtn.Text = "…";
            this.backupSrcBtn.UseVisualStyleBackColor = true;
            this.backupSrcBtn.Click += new System.EventHandler(this.backupSrcBtn_Click);
            // 
            // restoreSrcBtn
            // 
            this.restoreSrcBtn.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.restoreSrcBtn.Location = new System.Drawing.Point(502, 225);
            this.restoreSrcBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.restoreSrcBtn.Name = "restoreSrcBtn";
            this.restoreSrcBtn.Size = new System.Drawing.Size(26, 21);
            this.restoreSrcBtn.TabIndex = 28;
            this.restoreSrcBtn.Text = "…";
            this.restoreSrcBtn.UseVisualStyleBackColor = true;
            this.restoreSrcBtn.Click += new System.EventHandler(this.restoreSrcBtn_Click);
            // 
            // copySrcBtn
            // 
            this.copySrcBtn.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.copySrcBtn.Location = new System.Drawing.Point(502, 317);
            this.copySrcBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.copySrcBtn.Name = "copySrcBtn";
            this.copySrcBtn.Size = new System.Drawing.Size(26, 21);
            this.copySrcBtn.TabIndex = 29;
            this.copySrcBtn.Text = "…";
            this.copySrcBtn.UseVisualStyleBackColor = true;
            this.copySrcBtn.Click += new System.EventHandler(this.copySrcBtn_Click);
            // 
            // backupDestBtn
            // 
            this.backupDestBtn.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backupDestBtn.Location = new System.Drawing.Point(502, 160);
            this.backupDestBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.backupDestBtn.Name = "backupDestBtn";
            this.backupDestBtn.Size = new System.Drawing.Size(26, 21);
            this.backupDestBtn.TabIndex = 30;
            this.backupDestBtn.Text = "…";
            this.backupDestBtn.UseVisualStyleBackColor = true;
            this.backupDestBtn.Click += new System.EventHandler(this.backupDestBtn_Click);
            // 
            // restoreDestBtn
            // 
            this.restoreDestBtn.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.restoreDestBtn.Location = new System.Drawing.Point(502, 249);
            this.restoreDestBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.restoreDestBtn.Name = "restoreDestBtn";
            this.restoreDestBtn.Size = new System.Drawing.Size(26, 21);
            this.restoreDestBtn.TabIndex = 31;
            this.restoreDestBtn.Text = "…";
            this.restoreDestBtn.UseVisualStyleBackColor = true;
            this.restoreDestBtn.Click += new System.EventHandler(this.restoreDestBtn_Click);
            // 
            // copyDestBtn
            // 
            this.copyDestBtn.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.copyDestBtn.Location = new System.Drawing.Point(502, 341);
            this.copyDestBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.copyDestBtn.Name = "copyDestBtn";
            this.copyDestBtn.Size = new System.Drawing.Size(26, 21);
            this.copyDestBtn.TabIndex = 32;
            this.copyDestBtn.Text = "…";
            this.copyDestBtn.UseVisualStyleBackColor = true;
            this.copyDestBtn.Click += new System.EventHandler(this.copyDestBtn_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(659, 387);
            this.Controls.Add(this.copyDestBtn);
            this.Controls.Add(this.restoreDestBtn);
            this.Controls.Add(this.backupDestBtn);
            this.Controls.Add(this.copySrcBtn);
            this.Controls.Add(this.restoreSrcBtn);
            this.Controls.Add(this.backupSrcBtn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.passwordBox);
            this.Controls.Add(this.usernameBox);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.copyDestBox);
            this.Controls.Add(this.copySrcBox);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.copyBtn);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.restoreDestBox);
            this.Controls.Add(this.restoreSrcBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.restoreBtn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.backupDestBox);
            this.Controls.Add(this.backupSrcBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.backupBtn);
            this.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FirebirdBackupKit Test Application";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button backupBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox backupSrcBox;
        private System.Windows.Forms.TextBox backupDestBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox restoreDestBox;
        private System.Windows.Forms.TextBox restoreSrcBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button restoreBtn;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox copyDestBox;
        private System.Windows.Forms.TextBox copySrcBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button copyBtn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox passwordBox;
        private System.Windows.Forms.TextBox usernameBox;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.OpenFileDialog openFileDiag;
        private System.Windows.Forms.Button backupSrcBtn;
        private System.Windows.Forms.Button restoreSrcBtn;
        private System.Windows.Forms.Button copySrcBtn;
        private System.Windows.Forms.Button backupDestBtn;
        private System.Windows.Forms.Button restoreDestBtn;
        private System.Windows.Forms.Button copyDestBtn;
    }
}

