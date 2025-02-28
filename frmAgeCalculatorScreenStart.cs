using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Age_Calculator_Project
{
    public partial class frmAgeCalculatorScreenStart : Form
    {
        public frmAgeCalculatorScreenStart()
        {
            InitializeComponent();
        }

        private void frmAgeCalculatorScreenStart_Load(object sender, EventArgs e)
        {

        }

        //----------------------------------------------//

        private void btnStartAgeCalculator_Click(object sender, EventArgs e)
        {
            Form frm = new frmAgeCalculatorScreen();
            frm.ShowDialog();
        }
    }
}