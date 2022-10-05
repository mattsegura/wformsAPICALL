using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public static string textPassedForm1;
        public Form1()
        {
            InitializeComponent();
        }

        #region UI events
        private void button1_Click(object sender, EventArgs e)
        {
            // debugOutput(textBox1.Text);
            deserialiseJSON(textBox1.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = string.Empty; 
        }


        #endregion

        #region json functions 


        private void deserialiseJSON(string strJSON)
        {
            try
            {
                // during runtime, don't check the static type check of the JSON data
                // .. if we were to remove the dynamic then we could reference any data


                var cleanJSON = strJSON.Replace("[", string.Empty).Replace("]", string.Empty);
                var jParson = JsonConvert.DeserializeObject<jsonParse>(cleanJSON);
                
                // var jsonOutput = jParson.ToString(); // print out the json data 
                debugOutput("ETH PRICE: " + jParson.price_usd.ToString());
                debugOutput("ETH 24/HR VOLUME: " + jParson.volume24.ToString());



                // debugOutput("Here's is the ETH price: " + jParson.price_usd); // print out price 
                // debugOutput("Here's is the 24/HR volume: " + jParson.volume24); // print out volume 

            }
            catch (Exception ex)
            {
                debugOutput("we had a problem: " + ex.Message.ToString());
            }
        }
        #endregion 
        #region Debug Output 

        private void debugOutput(string strDebugText)
        {
            try
            {
                // whatever string we pass into the debug window 
                System.Diagnostics.Debug.Write(strDebugText + Environment.NewLine);
                textBox2.Text = textBox2.Text + strDebugText + Environment.NewLine;
                textBox2.SelectionStart = textBox2.TextLength;
                textBox2.ScrollToCaret();
            }
            catch(Exception ex)
            {
                // when throwing an exception write out to the DEBUG text window
                System.Diagnostics.Debug.Write(ex.Message.ToString() + Environment.NewLine);
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
    #endregion
} 