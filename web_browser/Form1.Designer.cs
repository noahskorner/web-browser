namespace web_browser
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
			this.webBrowser1 = new System.Windows.Forms.WebBrowser();
			this.txtUrl = new System.Windows.Forms.TextBox();
			this.btnGo = new System.Windows.Forms.Button();
			this.addButton = new System.Windows.Forms.Button();
			this.op1 = new System.Windows.Forms.TextBox();
			this.op2 = new System.Windows.Forms.TextBox();
			this.subButton = new System.Windows.Forms.Button();
			this.multButton = new System.Windows.Forms.Button();
			this.divButton = new System.Windows.Forms.Button();
			this.resultLbl = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.decryptTextBox = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.encryptLbl = new System.Windows.Forms.Label();
			this.encryptButton = new System.Windows.Forms.Button();
			this.decryptButton = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// webBrowser1
			// 
			this.webBrowser1.Location = new System.Drawing.Point(12, 12);
			this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
			this.webBrowser1.Name = "webBrowser1";
			this.webBrowser1.Size = new System.Drawing.Size(680, 469);
			this.webBrowser1.TabIndex = 0;
			// 
			// txtUrl
			// 
			this.txtUrl.Location = new System.Drawing.Point(12, 487);
			this.txtUrl.Name = "txtUrl";
			this.txtUrl.Size = new System.Drawing.Size(599, 20);
			this.txtUrl.TabIndex = 1;
			this.txtUrl.Text = "http://";
			// 
			// btnGo
			// 
			this.btnGo.Location = new System.Drawing.Point(617, 487);
			this.btnGo.Name = "btnGo";
			this.btnGo.Size = new System.Drawing.Size(75, 23);
			this.btnGo.TabIndex = 2;
			this.btnGo.Text = "Go";
			this.btnGo.UseVisualStyleBackColor = true;
			this.btnGo.Click += new System.EventHandler(this.btnGo_Click);
			// 
			// addButton
			// 
			this.addButton.Location = new System.Drawing.Point(13, 555);
			this.addButton.Name = "addButton";
			this.addButton.Size = new System.Drawing.Size(24, 23);
			this.addButton.TabIndex = 3;
			this.addButton.Text = "+";
			this.addButton.UseVisualStyleBackColor = true;
			this.addButton.Click += new System.EventHandler(this.addButton_Click);
			// 
			// op1
			// 
			this.op1.Location = new System.Drawing.Point(13, 529);
			this.op1.Name = "op1";
			this.op1.Size = new System.Drawing.Size(54, 20);
			this.op1.TabIndex = 4;
			// 
			// op2
			// 
			this.op2.Location = new System.Drawing.Point(73, 529);
			this.op2.Name = "op2";
			this.op2.Size = new System.Drawing.Size(54, 20);
			this.op2.TabIndex = 5;
			// 
			// subButton
			// 
			this.subButton.Location = new System.Drawing.Point(43, 555);
			this.subButton.Name = "subButton";
			this.subButton.Size = new System.Drawing.Size(24, 23);
			this.subButton.TabIndex = 6;
			this.subButton.Text = "-";
			this.subButton.UseVisualStyleBackColor = true;
			this.subButton.Click += new System.EventHandler(this.subButton_Click);
			// 
			// multButton
			// 
			this.multButton.Location = new System.Drawing.Point(73, 555);
			this.multButton.Name = "multButton";
			this.multButton.Size = new System.Drawing.Size(24, 23);
			this.multButton.TabIndex = 7;
			this.multButton.Text = "*";
			this.multButton.UseVisualStyleBackColor = true;
			this.multButton.Click += new System.EventHandler(this.multButton_Click);
			// 
			// divButton
			// 
			this.divButton.Location = new System.Drawing.Point(103, 555);
			this.divButton.Name = "divButton";
			this.divButton.Size = new System.Drawing.Size(24, 23);
			this.divButton.TabIndex = 8;
			this.divButton.Text = "/";
			this.divButton.UseVisualStyleBackColor = true;
			this.divButton.Click += new System.EventHandler(this.divButton_Click);
			// 
			// resultLbl
			// 
			this.resultLbl.AutoSize = true;
			this.resultLbl.Location = new System.Drawing.Point(50, 581);
			this.resultLbl.Name = "resultLbl";
			this.resultLbl.Size = new System.Drawing.Size(37, 13);
			this.resultLbl.TabIndex = 9;
			this.resultLbl.Text = "Result";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(43, 513);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(54, 13);
			this.label1.TabIndex = 10;
			this.label1.Text = "Calculator";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(205, 512);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(137, 13);
			this.label2.TabIndex = 11;
			this.label2.Text = "Text Encryption/Decryption";
			// 
			// decryptTextBox
			// 
			this.decryptTextBox.Location = new System.Drawing.Point(270, 529);
			this.decryptTextBox.Name = "decryptTextBox";
			this.decryptTextBox.Size = new System.Drawing.Size(341, 20);
			this.decryptTextBox.TabIndex = 12;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(205, 532);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(59, 13);
			this.label3.TabIndex = 13;
			this.label3.Text = "Enter Text:";
			// 
			// encryptLbl
			// 
			this.encryptLbl.AutoSize = true;
			this.encryptLbl.Location = new System.Drawing.Point(267, 560);
			this.encryptLbl.Name = "encryptLbl";
			this.encryptLbl.Size = new System.Drawing.Size(79, 13);
			this.encryptLbl.TabIndex = 14;
			this.encryptLbl.Text = "Encrypted Text";
			// 
			// encryptButton
			// 
			this.encryptButton.Location = new System.Drawing.Point(616, 529);
			this.encryptButton.Name = "encryptButton";
			this.encryptButton.Size = new System.Drawing.Size(75, 23);
			this.encryptButton.TabIndex = 15;
			this.encryptButton.Text = "Encrypt";
			this.encryptButton.UseVisualStyleBackColor = true;
			this.encryptButton.Click += new System.EventHandler(this.encryptButton_Click);
			// 
			// decryptButton
			// 
			this.decryptButton.Location = new System.Drawing.Point(616, 555);
			this.decryptButton.Name = "decryptButton";
			this.decryptButton.Size = new System.Drawing.Size(75, 23);
			this.decryptButton.TabIndex = 16;
			this.decryptButton.Text = "Decrypt";
			this.decryptButton.UseVisualStyleBackColor = true;
			this.decryptButton.Click += new System.EventHandler(this.decryptButton_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(704, 601);
			this.Controls.Add(this.decryptButton);
			this.Controls.Add(this.encryptButton);
			this.Controls.Add(this.encryptLbl);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.decryptTextBox);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.resultLbl);
			this.Controls.Add(this.divButton);
			this.Controls.Add(this.multButton);
			this.Controls.Add(this.subButton);
			this.Controls.Add(this.op2);
			this.Controls.Add(this.op1);
			this.Controls.Add(this.addButton);
			this.Controls.Add(this.btnGo);
			this.Controls.Add(this.txtUrl);
			this.Controls.Add(this.webBrowser1);
			this.Name = "Form1";
			this.Text = "Form1";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.WebBrowser webBrowser1;
		private System.Windows.Forms.TextBox txtUrl;
		private System.Windows.Forms.Button btnGo;
		private System.Windows.Forms.Button addButton;
		private System.Windows.Forms.TextBox op1;
		private System.Windows.Forms.TextBox op2;
		private System.Windows.Forms.Button subButton;
		private System.Windows.Forms.Button multButton;
		private System.Windows.Forms.Button divButton;
		private System.Windows.Forms.Label resultLbl;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox decryptTextBox;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label encryptLbl;
		private System.Windows.Forms.Button encryptButton;
		private System.Windows.Forms.Button decryptButton;
	}
}

