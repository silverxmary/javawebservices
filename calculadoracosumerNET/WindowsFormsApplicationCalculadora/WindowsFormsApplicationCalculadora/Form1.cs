using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApplicationCalculadora.MisServiciosWeb;

namespace WindowsFormsApplicationCalculadora
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int num1 = Convert.ToInt32(textBoxNum1.Text);
            int num2 = Convert.ToInt32(textBoxNum2.Text);
            HolaMundoWebServiceClient clienteWS = new HolaMundoWebServiceClient();
            int total = clienteWS.sumar(num1,num2);

            textBoxTotal.Text = total.ToString();
        }
    }
}
