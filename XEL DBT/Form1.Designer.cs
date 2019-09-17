namespace XEL_DBT
{
    partial class frmMain
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
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.materialProgressBar1 = new MaterialSkin.Controls.MaterialProgressBar();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.txtServer = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.txtDb = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            this.txtPass = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel6 = new MaterialSkin.Controls.MaterialLabel();
            this.txtUser = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.btnDetach = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnCopyL = new MaterialSkin.Controls.MaterialRaisedButton();
            this.materialLabel7 = new MaterialSkin.Controls.MaterialLabel();
            this.txtUSBLoc = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel8 = new MaterialSkin.Controls.MaterialLabel();
            this.txtMdfLoc = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel9 = new MaterialSkin.Controls.MaterialLabel();
            this.txtLdfLoc = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.btnAttach = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnExport = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnImport = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnCopyR = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnConn = new MaterialSkin.Controls.MaterialRaisedButton();
            this.SuspendLayout();
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.BackColor = System.Drawing.Color.Transparent;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(27, 53);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(172, 24);
            this.materialLabel1.TabIndex = 0;
            this.materialLabel1.Text = "LOCAL COMPUTER";
            // 
            // materialProgressBar1
            // 
            this.materialProgressBar1.Depth = 0;
            this.materialProgressBar1.Location = new System.Drawing.Point(36, 396);
            this.materialProgressBar1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialProgressBar1.Name = "materialProgressBar1";
            this.materialProgressBar1.Size = new System.Drawing.Size(834, 5);
            this.materialProgressBar1.TabIndex = 3;
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.BackColor = System.Drawing.Color.Transparent;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(460, 53);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(110, 24);
            this.materialLabel2.TabIndex = 4;
            this.materialLabel2.Text = "DATA FILES";
            // 
            // txtServer
            // 
            this.txtServer.BackColor = System.Drawing.Color.White;
            this.txtServer.Depth = 0;
            this.txtServer.Hint = "";
            this.txtServer.Location = new System.Drawing.Point(132, 104);
            this.txtServer.MaxLength = 32767;
            this.txtServer.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtServer.Name = "txtServer";
            this.txtServer.PasswordChar = '\0';
            this.txtServer.SelectedText = "";
            this.txtServer.SelectionLength = 0;
            this.txtServer.SelectionStart = 0;
            this.txtServer.Size = new System.Drawing.Size(208, 28);
            this.txtServer.TabIndex = 6;
            this.txtServer.TabStop = false;
            this.txtServer.Text = "localhost\\sql2012";
            this.txtServer.UseSystemPasswordChar = false;
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.BackColor = System.Drawing.Color.Transparent;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel3.Location = new System.Drawing.Point(31, 104);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(67, 24);
            this.materialLabel3.TabIndex = 7;
            this.materialLabel3.Text = "Server:";
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.BackColor = System.Drawing.Color.Transparent;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel4.Location = new System.Drawing.Point(32, 138);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(94, 24);
            this.materialLabel4.TabIndex = 9;
            this.materialLabel4.Text = "Database:";
            // 
            // txtDb
            // 
            this.txtDb.BackColor = System.Drawing.Color.White;
            this.txtDb.Depth = 0;
            this.txtDb.Hint = "";
            this.txtDb.Location = new System.Drawing.Point(132, 138);
            this.txtDb.MaxLength = 32767;
            this.txtDb.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtDb.Name = "txtDb";
            this.txtDb.PasswordChar = '\0';
            this.txtDb.SelectedText = "";
            this.txtDb.SelectionLength = 0;
            this.txtDb.SelectionStart = 0;
            this.txtDb.Size = new System.Drawing.Size(208, 28);
            this.txtDb.TabIndex = 8;
            this.txtDb.TabStop = false;
            this.txtDb.Text = "perfectstar";
            this.txtDb.UseSystemPasswordChar = false;
            // 
            // materialLabel5
            // 
            this.materialLabel5.AutoSize = true;
            this.materialLabel5.BackColor = System.Drawing.Color.Transparent;
            this.materialLabel5.Depth = 0;
            this.materialLabel5.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel5.Location = new System.Drawing.Point(32, 206);
            this.materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel5.Name = "materialLabel5";
            this.materialLabel5.Size = new System.Drawing.Size(99, 24);
            this.materialLabel5.TabIndex = 13;
            this.materialLabel5.Text = "Password:";
            // 
            // txtPass
            // 
            this.txtPass.BackColor = System.Drawing.Color.White;
            this.txtPass.Depth = 0;
            this.txtPass.Hint = "";
            this.txtPass.Location = new System.Drawing.Point(132, 206);
            this.txtPass.MaxLength = 32767;
            this.txtPass.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtPass.Name = "txtPass";
            this.txtPass.PasswordChar = '\0';
            this.txtPass.SelectedText = "";
            this.txtPass.SelectionLength = 0;
            this.txtPass.SelectionStart = 0;
            this.txtPass.Size = new System.Drawing.Size(208, 28);
            this.txtPass.TabIndex = 12;
            this.txtPass.TabStop = false;
            this.txtPass.UseSystemPasswordChar = true;
            // 
            // materialLabel6
            // 
            this.materialLabel6.AutoSize = true;
            this.materialLabel6.BackColor = System.Drawing.Color.Transparent;
            this.materialLabel6.Depth = 0;
            this.materialLabel6.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel6.Location = new System.Drawing.Point(31, 172);
            this.materialLabel6.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel6.Name = "materialLabel6";
            this.materialLabel6.Size = new System.Drawing.Size(100, 24);
            this.materialLabel6.TabIndex = 11;
            this.materialLabel6.Text = "Username:";
            // 
            // txtUser
            // 
            this.txtUser.BackColor = System.Drawing.Color.White;
            this.txtUser.Depth = 0;
            this.txtUser.Hint = "";
            this.txtUser.Location = new System.Drawing.Point(132, 172);
            this.txtUser.MaxLength = 32767;
            this.txtUser.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtUser.Name = "txtUser";
            this.txtUser.PasswordChar = '\0';
            this.txtUser.SelectedText = "";
            this.txtUser.SelectionLength = 0;
            this.txtUser.SelectionStart = 0;
            this.txtUser.Size = new System.Drawing.Size(208, 28);
            this.txtUser.TabIndex = 10;
            this.txtUser.TabStop = false;
            this.txtUser.Text = "sa";
            this.txtUser.UseSystemPasswordChar = false;
            // 
            // btnDetach
            // 
            this.btnDetach.AutoSize = true;
            this.btnDetach.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnDetach.Depth = 0;
            this.btnDetach.Icon = null;
            this.btnDetach.Location = new System.Drawing.Point(472, 218);
            this.btnDetach.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnDetach.Name = "btnDetach";
            this.btnDetach.Primary = true;
            this.btnDetach.Size = new System.Drawing.Size(88, 36);
            this.btnDetach.TabIndex = 14;
            this.btnDetach.Text = "DETACH";
            this.btnDetach.UseVisualStyleBackColor = true;
            this.btnDetach.Click += new System.EventHandler(this.BtnDetach_Click);
            // 
            // btnCopyL
            // 
            this.btnCopyL.AutoSize = true;
            this.btnCopyL.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnCopyL.Depth = 0;
            this.btnCopyL.Icon = null;
            this.btnCopyL.Location = new System.Drawing.Point(749, 218);
            this.btnCopyL.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnCopyL.Name = "btnCopyL";
            this.btnCopyL.Primary = true;
            this.btnCopyL.Size = new System.Drawing.Size(80, 36);
            this.btnCopyL.TabIndex = 15;
            this.btnCopyL.Text = "COPY L";
            this.btnCopyL.UseVisualStyleBackColor = true;
            // 
            // materialLabel7
            // 
            this.materialLabel7.AutoSize = true;
            this.materialLabel7.BackColor = System.Drawing.Color.Transparent;
            this.materialLabel7.Depth = 0;
            this.materialLabel7.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel7.Location = new System.Drawing.Point(468, 104);
            this.materialLabel7.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel7.Name = "materialLabel7";
            this.materialLabel7.Size = new System.Drawing.Size(50, 24);
            this.materialLabel7.TabIndex = 17;
            this.materialLabel7.Text = "USB:";
            // 
            // txtUSBLoc
            // 
            this.txtUSBLoc.BackColor = System.Drawing.Color.White;
            this.txtUSBLoc.Depth = 0;
            this.txtUSBLoc.Hint = "";
            this.txtUSBLoc.Location = new System.Drawing.Point(569, 104);
            this.txtUSBLoc.MaxLength = 32767;
            this.txtUSBLoc.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtUSBLoc.Name = "txtUSBLoc";
            this.txtUSBLoc.PasswordChar = '\0';
            this.txtUSBLoc.SelectedText = "";
            this.txtUSBLoc.SelectionLength = 0;
            this.txtUSBLoc.SelectionStart = 0;
            this.txtUSBLoc.Size = new System.Drawing.Size(301, 28);
            this.txtUSBLoc.TabIndex = 16;
            this.txtUSBLoc.TabStop = false;
            this.txtUSBLoc.UseSystemPasswordChar = false;
            // 
            // materialLabel8
            // 
            this.materialLabel8.AutoSize = true;
            this.materialLabel8.BackColor = System.Drawing.Color.Transparent;
            this.materialLabel8.Depth = 0;
            this.materialLabel8.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel8.Location = new System.Drawing.Point(468, 138);
            this.materialLabel8.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel8.Name = "materialLabel8";
            this.materialLabel8.Size = new System.Drawing.Size(67, 24);
            this.materialLabel8.TabIndex = 19;
            this.materialLabel8.Text = "DB DF:";
            // 
            // txtMdfLoc
            // 
            this.txtMdfLoc.BackColor = System.Drawing.Color.White;
            this.txtMdfLoc.Depth = 0;
            this.txtMdfLoc.Enabled = false;
            this.txtMdfLoc.Hint = "";
            this.txtMdfLoc.Location = new System.Drawing.Point(569, 138);
            this.txtMdfLoc.MaxLength = 32767;
            this.txtMdfLoc.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtMdfLoc.Name = "txtMdfLoc";
            this.txtMdfLoc.PasswordChar = '\0';
            this.txtMdfLoc.SelectedText = "";
            this.txtMdfLoc.SelectionLength = 0;
            this.txtMdfLoc.SelectionStart = 0;
            this.txtMdfLoc.Size = new System.Drawing.Size(301, 28);
            this.txtMdfLoc.TabIndex = 18;
            this.txtMdfLoc.TabStop = false;
            this.txtMdfLoc.UseSystemPasswordChar = false;
            // 
            // materialLabel9
            // 
            this.materialLabel9.AutoSize = true;
            this.materialLabel9.BackColor = System.Drawing.Color.Transparent;
            this.materialLabel9.Depth = 0;
            this.materialLabel9.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel9.Location = new System.Drawing.Point(468, 172);
            this.materialLabel9.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel9.Name = "materialLabel9";
            this.materialLabel9.Size = new System.Drawing.Size(65, 24);
            this.materialLabel9.TabIndex = 21;
            this.materialLabel9.Text = "DB LF:";
            // 
            // txtLdfLoc
            // 
            this.txtLdfLoc.BackColor = System.Drawing.Color.White;
            this.txtLdfLoc.Depth = 0;
            this.txtLdfLoc.Enabled = false;
            this.txtLdfLoc.Hint = "";
            this.txtLdfLoc.Location = new System.Drawing.Point(569, 172);
            this.txtLdfLoc.MaxLength = 32767;
            this.txtLdfLoc.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtLdfLoc.Name = "txtLdfLoc";
            this.txtLdfLoc.PasswordChar = '\0';
            this.txtLdfLoc.SelectedText = "";
            this.txtLdfLoc.SelectionLength = 0;
            this.txtLdfLoc.SelectionStart = 0;
            this.txtLdfLoc.Size = new System.Drawing.Size(301, 28);
            this.txtLdfLoc.TabIndex = 20;
            this.txtLdfLoc.TabStop = false;
            this.txtLdfLoc.UseSystemPasswordChar = false;
            // 
            // btnAttach
            // 
            this.btnAttach.AutoSize = true;
            this.btnAttach.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAttach.Depth = 0;
            this.btnAttach.Icon = null;
            this.btnAttach.Location = new System.Drawing.Point(566, 218);
            this.btnAttach.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnAttach.Name = "btnAttach";
            this.btnAttach.Primary = true;
            this.btnAttach.Size = new System.Drawing.Size(89, 36);
            this.btnAttach.TabIndex = 22;
            this.btnAttach.Text = "ATTACH";
            this.btnAttach.UseVisualStyleBackColor = true;
            this.btnAttach.Click += new System.EventHandler(this.BtnAttach_Click);
            // 
            // btnExport
            // 
            this.btnExport.AutoSize = true;
            this.btnExport.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnExport.Depth = 0;
            this.btnExport.Icon = null;
            this.btnExport.Location = new System.Drawing.Point(36, 290);
            this.btnExport.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnExport.Name = "btnExport";
            this.btnExport.Primary = true;
            this.btnExport.Size = new System.Drawing.Size(150, 36);
            this.btnExport.TabIndex = 23;
            this.btnExport.Text = "EXPORT TO USB";
            this.btnExport.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExport.UseVisualStyleBackColor = false;
            // 
            // btnImport
            // 
            this.btnImport.AutoSize = true;
            this.btnImport.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnImport.Depth = 0;
            this.btnImport.Icon = null;
            this.btnImport.Location = new System.Drawing.Point(37, 332);
            this.btnImport.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnImport.Name = "btnImport";
            this.btnImport.Primary = true;
            this.btnImport.Size = new System.Drawing.Size(174, 36);
            this.btnImport.TabIndex = 24;
            this.btnImport.Text = "IMPORT FROM USB";
            this.btnImport.UseVisualStyleBackColor = true;
            // 
            // btnCopyR
            // 
            this.btnCopyR.AutoSize = true;
            this.btnCopyR.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnCopyR.Depth = 0;
            this.btnCopyR.Icon = null;
            this.btnCopyR.Location = new System.Drawing.Point(661, 218);
            this.btnCopyR.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnCopyR.Name = "btnCopyR";
            this.btnCopyR.Primary = true;
            this.btnCopyR.Size = new System.Drawing.Size(82, 36);
            this.btnCopyR.TabIndex = 25;
            this.btnCopyR.Text = "COPY R";
            this.btnCopyR.UseVisualStyleBackColor = true;
            // 
            // btnConn
            // 
            this.btnConn.AutoSize = true;
            this.btnConn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnConn.Depth = 0;
            this.btnConn.Icon = null;
            this.btnConn.Location = new System.Drawing.Point(36, 249);
            this.btnConn.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnConn.Name = "btnConn";
            this.btnConn.Primary = true;
            this.btnConn.Size = new System.Drawing.Size(101, 36);
            this.btnConn.TabIndex = 26;
            this.btnConn.Text = "CONNECT";
            this.btnConn.UseVisualStyleBackColor = true;
            this.btnConn.Click += new System.EventHandler(this.BtnConn_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(903, 413);
            this.Controls.Add(this.btnConn);
            this.Controls.Add(this.btnCopyR);
            this.Controls.Add(this.btnImport);
            this.Controls.Add(this.btnExport);
            this.Controls.Add(this.btnAttach);
            this.Controls.Add(this.materialLabel9);
            this.Controls.Add(this.txtLdfLoc);
            this.Controls.Add(this.materialLabel8);
            this.Controls.Add(this.txtMdfLoc);
            this.Controls.Add(this.materialLabel7);
            this.Controls.Add(this.txtUSBLoc);
            this.Controls.Add(this.btnCopyL);
            this.Controls.Add(this.btnDetach);
            this.Controls.Add(this.materialLabel5);
            this.Controls.Add(this.txtPass);
            this.Controls.Add(this.materialLabel6);
            this.Controls.Add(this.txtUser);
            this.Controls.Add(this.materialLabel4);
            this.Controls.Add(this.txtDb);
            this.Controls.Add(this.materialLabel3);
            this.Controls.Add(this.txtServer);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.materialProgressBar1);
            this.Controls.Add(this.materialLabel1);
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "XEL DBT";
            this.Shown += new System.EventHandler(this.Form_Shown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialProgressBar materialProgressBar1;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtServer;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtDb;
        private MaterialSkin.Controls.MaterialLabel materialLabel5;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtPass;
        private MaterialSkin.Controls.MaterialLabel materialLabel6;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtUser;
        private MaterialSkin.Controls.MaterialRaisedButton btnDetach;
        private MaterialSkin.Controls.MaterialRaisedButton btnCopyL;
        private MaterialSkin.Controls.MaterialLabel materialLabel7;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtUSBLoc;
        private MaterialSkin.Controls.MaterialLabel materialLabel8;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtMdfLoc;
        private MaterialSkin.Controls.MaterialLabel materialLabel9;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtLdfLoc;
        private MaterialSkin.Controls.MaterialRaisedButton btnAttach;
        private MaterialSkin.Controls.MaterialRaisedButton btnExport;
        private MaterialSkin.Controls.MaterialRaisedButton btnImport;
        private MaterialSkin.Controls.MaterialRaisedButton btnCopyR;
        private MaterialSkin.Controls.MaterialRaisedButton btnConn;
    }
}