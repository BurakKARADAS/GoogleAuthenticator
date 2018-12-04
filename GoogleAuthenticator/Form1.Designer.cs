namespace GoogleAuthenticator
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.txtCurrentCodes = new System.Windows.Forms.TextBox();
            this.btnTest = new System.Windows.Forms.Button();
            this.txtCode = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSetupCode = new System.Windows.Forms.TextBox();
            this.btnGetCurrentCode = new System.Windows.Forms.Button();
            this.btnSetup = new System.Windows.Forms.Button();
            this.pbQR = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSecretKey = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtAccountTitle = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbQR)).BeginInit();
            this.SuspendLayout();
            // 
            // txtCurrentCodes
            // 
            this.txtCurrentCodes.Location = new System.Drawing.Point(346, 293);
            this.txtCurrentCodes.Multiline = true;
            this.txtCurrentCodes.Name = "txtCurrentCodes";
            this.txtCurrentCodes.ReadOnly = true;
            this.txtCurrentCodes.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtCurrentCodes.Size = new System.Drawing.Size(243, 105);
            this.txtCurrentCodes.TabIndex = 24;
            // 
            // btnTest
            // 
            this.btnTest.Location = new System.Drawing.Point(405, 227);
            this.btnTest.Name = "btnTest";
            this.btnTest.Size = new System.Drawing.Size(173, 27);
            this.btnTest.TabIndex = 23;
            this.btnTest.Text = "Test Two-Factor Code";
            this.btnTest.UseVisualStyleBackColor = true;
            this.btnTest.Click += new System.EventHandler(this.btnTest_Click);
            // 
            // txtCode
            // 
            this.txtCode.Location = new System.Drawing.Point(405, 189);
            this.txtCode.Name = "txtCode";
            this.txtCode.Size = new System.Drawing.Size(124, 20);
            this.txtCode.TabIndex = 22;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(339, 192);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 21;
            this.label3.Text = "Test Code:";
            // 
            // txtSetupCode
            // 
            this.txtSetupCode.Location = new System.Drawing.Point(346, 77);
            this.txtSetupCode.Multiline = true;
            this.txtSetupCode.Name = "txtSetupCode";
            this.txtSetupCode.ReadOnly = true;
            this.txtSetupCode.Size = new System.Drawing.Size(243, 105);
            this.txtSetupCode.TabIndex = 20;
            // 
            // btnGetCurrentCode
            // 
            this.btnGetCurrentCode.Location = new System.Drawing.Point(405, 260);
            this.btnGetCurrentCode.Name = "btnGetCurrentCode";
            this.btnGetCurrentCode.Size = new System.Drawing.Size(173, 27);
            this.btnGetCurrentCode.TabIndex = 19;
            this.btnGetCurrentCode.Text = "Get Current";
            this.btnGetCurrentCode.UseVisualStyleBackColor = true;
            this.btnGetCurrentCode.Click += new System.EventHandler(this.btnGetCurrentCode_Click);
            // 
            // btnSetup
            // 
            this.btnSetup.Location = new System.Drawing.Point(346, 25);
            this.btnSetup.Name = "btnSetup";
            this.btnSetup.Size = new System.Drawing.Size(243, 46);
            this.btnSetup.TabIndex = 18;
            this.btnSetup.Text = "Generate Setup / Get QR Code";
            this.btnSetup.UseVisualStyleBackColor = true;
            this.btnSetup.Click += new System.EventHandler(this.btnSetup_Click);
            // 
            // pbQR
            // 
            this.pbQR.BackColor = System.Drawing.Color.White;
            this.pbQR.Location = new System.Drawing.Point(43, 77);
            this.pbQR.Name = "pbQR";
            this.pbQR.Size = new System.Drawing.Size(213, 191);
            this.pbQR.TabIndex = 17;
            this.pbQR.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "Secret Key:";
            // 
            // txtSecretKey
            // 
            this.txtSecretKey.Location = new System.Drawing.Point(101, 51);
            this.txtSecretKey.Name = "txtSecretKey";
            this.txtSecretKey.Size = new System.Drawing.Size(155, 20);
            this.txtSecretKey.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Account Title:";
            // 
            // txtAccountTitle
            // 
            this.txtAccountTitle.Location = new System.Drawing.Point(101, 25);
            this.txtAccountTitle.Name = "txtAccountTitle";
            this.txtAccountTitle.Size = new System.Drawing.Size(155, 20);
            this.txtAccountTitle.TabIndex = 13;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(627, 421);
            this.Controls.Add(this.txtCurrentCodes);
            this.Controls.Add(this.btnTest);
            this.Controls.Add(this.txtCode);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtSetupCode);
            this.Controls.Add(this.btnGetCurrentCode);
            this.Controls.Add(this.btnSetup);
            this.Controls.Add(this.pbQR);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtSecretKey);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtAccountTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Google Authenticator / Two Factor Authenticator";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbQR)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCurrentCodes;
        private System.Windows.Forms.Button btnTest;
        private System.Windows.Forms.TextBox txtCode;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSetupCode;
        private System.Windows.Forms.Button btnGetCurrentCode;
        private System.Windows.Forms.Button btnSetup;
        private System.Windows.Forms.PictureBox pbQR;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSecretKey;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtAccountTitle;

    }
}

