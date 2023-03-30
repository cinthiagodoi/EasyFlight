using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;


namespace Aviacao
{
    public partial class AboutUS : Form
    {
        public AboutUS()
        {
            InitializeComponent();
            richTextBox1.ReadOnly = true;
            richTextBox1.BorderStyle = BorderStyle.None;
            richTextBox1.TabStop = false;
           
        }

   
        /// <summary>
        /// when click in the link call the method to open the webpage
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                VisitLinkLinkedin();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unable to open link that was clicked.");
            }
        }

        /// <summary>
        /// change de label color, and open the webpage
        /// </summary>
        private void VisitLinkLinkedin()
        {
           
            linkLabel1.LinkVisited = true;

            var ps = new ProcessStartInfo("https://www.linkedin.com/in/cinthia-godoi/")
            {
                UseShellExecute = true,
                Verb = "open"
            };
            Process.Start(ps);
        }

        /// <summary>
        /// change de label color, and open the webpage
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                VisitLinkGitHub();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unable to open link that was clicked.");
            }

        }

        /// <summary>
        /// change de label color, and open the webpage
        /// </summary>
        private void VisitLinkGitHub()
        {
            linkLabel1.LinkVisited = true;

            var ps = new ProcessStartInfo("https://github.com/cinthiagodoi")
            {
                UseShellExecute = true,
                Verb = "open"
            };
            Process.Start(ps);

        }
    }
}
