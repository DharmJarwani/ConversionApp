using System;
using System.Text;
using System.Windows.Forms;

namespace ConversionApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void PerformConversions(byte[] byteArray)
        {
            string hexOutput = BitConverter.ToString(byteArray).Replace("-", ""); // Hexadecimal
            string base64Output = Convert.ToBase64String(byteArray); // Base64 -

            richTextBox2.Text = string.Join(", ", byteArray); // Byte Array
            richTextBox3.Text = hexOutput; // Hexadecimal
            richTextBox4.Text = base64Output; // Base64 - 
        }

        private byte[] ParseByteArray(string input)
        {
            string[] byteStrings = input.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries);
            byte[] byteArray = new byte[byteStrings.Length];

            for (int i = 0; i < byteStrings.Length; i++)
            {
                byteArray[i] = Convert.ToByte(byteStrings[i].Trim());
            }

            return byteArray;
        }

        private bool IsHexadecimal(string input)
        {
            return System.Text.RegularExpressions.Regex.IsMatch(input, "^[0-9A-Fa-f]+$");
        }

        private bool IsBase64(string input)
        {
            try
            {
                Convert.FromBase64String(input);
                return true;
            }
            catch
            {
                return false;
            }
        }

        private byte[] HexStringToByteArray(string hex)
        {
            hex = hex.Replace(" ", ""); // Remove any spaces

            if (hex.Length % 2 != 0)
                throw new FormatException("Hexadecimal string length must be even.");

            byte[] byteArray = new byte[hex.Length / 2];

            for (int i = 0; i < byteArray.Length; i++)
            {
                byteArray[i] = Convert.ToByte(hex.Substring(i * 2, 2), 16);
            }

            return byteArray;
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            richTextBox1.Clear();
            richTextBox2.Clear();
            richTextBox3.Clear();
            richTextBox4.Clear();
            richTextBox5.Clear();
            richTextBox6.Clear();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            string inputData = richTextBox1.Text.Trim();

            // Detect the data type and perform conversions
            if (inputData.Contains(","))
            {
                // Byte Array input (comma-separated UInt8 values)
                byte[] byteArray = ParseByteArray(inputData);
                PerformConversions(byteArray);
            }
            else if (IsHexadecimal(inputData))
            {
                // Hexadecimal input
                byte[] byteArray = HexStringToByteArray(inputData);
                PerformConversions(byteArray);
            }
            else if (IsBase64(inputData))
            {
                if (string.IsNullOrEmpty(inputData))
                {
                    richTextBox5.Clear();
                    richTextBox6.Clear();
                }
                else
                {
                    // Base64 input
                    byte[] byteArray = Convert.FromBase64String(inputData);
                    PerformConversions(byteArray);
                }

            }
            else
            {
                MessageBox.Show("Invalid input format. Please enter valid data.");
            }
        }

        private void richTextBox6_TextChanged(object sender, EventArgs e)
        {
            string data = richTextBox6.Text;

            if (string.IsNullOrWhiteSpace(data))
            {
                // Clear richTextBox5 and do not show the message
                richTextBox5.Clear();
            }
            else if (uint.TryParse(data, out uint fileSizeDecimal))
            {
                byte[] littleEndianBytes = BitConverter.GetBytes(fileSizeDecimal);

                string byteString = string.Join(", ", littleEndianBytes);

                richTextBox5.Text = byteString;
            }
            else
            {
                // Handle the case where the input is not a proper decimal format
                MessageBox.Show("Please enter a valid decimal value, for example: 12345", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
