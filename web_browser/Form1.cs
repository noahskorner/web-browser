using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace web_browser
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void btnGo_Click(object sender, EventArgs e)
		{
			webBrowser1.Navigate(txtUrl.Text); //navigate to URL
		}

		private void addButton_Click(object sender, EventArgs e)
		{
			if(op1.Text != "" && op2.Text != "") //check to see if user has inputted anything
			{
				float operand1 = float.Parse(op1.Text); //store op1 as float
				float operand2 = float.Parse(op2.Text); //store op2 as float
				float result = operand1 + operand2; //perform operation

				resultLbl.Text = result.ToString(); //change result label
			}
		}

		private void subButton_Click(object sender, EventArgs e)
		{
			if (op1.Text != "" && op2.Text != "") //check to see if user has inputted anything
			{
				float operand1 = float.Parse(op1.Text); //store op1 as float
				float operand2 = float.Parse(op2.Text); //store op2 as float
				float result = operand1 - operand2; //perform operation

				resultLbl.Text = result.ToString(); //change result label
			}
		}

		private void multButton_Click(object sender, EventArgs e)
		{
			if (op1.Text != "" && op2.Text != "") //check to see if user has inputted anything
			{
				float operand1 = float.Parse(op1.Text); //store op1 as float
				float operand2 = float.Parse(op2.Text); //store op2 as float
				float result = operand1 * operand2; //perform operation

				resultLbl.Text = result.ToString(); //change result label
			}
		}

		private void divButton_Click(object sender, EventArgs e)
		{
			if (op1.Text != "" && op2.Text != "") //check to see if user has inputted anything
			{
				float operand1 = float.Parse(op1.Text); //store op1 as float
				float operand2 = float.Parse(op2.Text); //store op2 as float
				float result = operand1 / operand2; //perform operation

				resultLbl.Text = result.ToString(); //change result label
			}
		}

		private void encryptButton_Click(object sender, EventArgs e)
		{
			if(decryptTextBox.Text != "") //if user has inputted a string yet
			{
				String str = decryptTextBox.Text; //store string
				decryptTextBox.Text = ""; //clear text box

				EncryptionService.ServiceClient proxy = new EncryptionService.ServiceClient(); //open the client
				String encryptedStr = proxy.Encrypt(str); //encrypt the string

				encryptLbl.Text = encryptedStr; //display the encrypted string

				proxy.Close(); //close the client
			}
		}

		private void decryptButton_Click(object sender, EventArgs e)
		{
			if (encryptLbl.Text != "Encrypted Text") //if text has been encrypted yet
			{
				String str = encryptLbl.Text; //store string
				encryptLbl.Text = "Encrypted Text"; //reset label

				EncryptionService.ServiceClient proxy = new EncryptionService.ServiceClient(); //open the client
				String decryptedStr = proxy.Decrypt(str); //decrypt the string

				decryptTextBox.Text = decryptedStr; //display the decrypted string

				proxy.Close(); //close the client
			}
		}
	}
}
