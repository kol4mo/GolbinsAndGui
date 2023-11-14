using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GolbinsAndGui
{
    public partial class Form1 : Form
    {
        Controller m_owner;
        public Form1()
        {
            InitializeComponent();
        }
        public void SetController(Controller controller)
        {
            m_owner = controller;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
