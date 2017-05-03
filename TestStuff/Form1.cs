using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestStuff
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private const string BEARER_AUTH = "Bearer ";
        
        private void button2_Click(object sender, EventArgs e)
        {
            payload.Text = TokenValidator.GetPayload(token.Text, discoveryUrl.Text);
        }
    }
}
