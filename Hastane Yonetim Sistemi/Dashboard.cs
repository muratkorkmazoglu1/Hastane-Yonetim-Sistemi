using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hastane_Yonetim_Sistemi
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void btnAddPatient_Click(object sender, EventArgs e)
        {
            labellndecator1.ForeColor = System.Drawing.Color.Red;
            labellndecator2.ForeColor = System.Drawing.Color.Black;
            labellndecator3.ForeColor = System.Drawing.Color.Black;
            labellndecator4.ForeColor = System.Drawing.Color.Black;

            panel1.Visible = true;



        }

        private void btnAddDiagnosis_Click(object sender, EventArgs e)
        {
            labellndecator2.ForeColor = System.Drawing.Color.Red;
            labellndecator1.ForeColor = System.Drawing.Color.Black;
            labellndecator3.ForeColor = System.Drawing.Color.Black;
            labellndecator4.ForeColor = System.Drawing.Color.Black;
        }

        private void btnFullHistory_Click(object sender, EventArgs e)
        {
            labellndecator3.ForeColor = System.Drawing.Color.Red;
            labellndecator2.ForeColor = System.Drawing.Color.Black;
            labellndecator1.ForeColor = System.Drawing.Color.Black;
            labellndecator4.ForeColor = System.Drawing.Color.Black;
        }

        private void btnHospital_Click(object sender, EventArgs e)
        {
            labellndecator4.ForeColor = System.Drawing.Color.Red;
            labellndecator2.ForeColor = System.Drawing.Color.Black;
            labellndecator3.ForeColor = System.Drawing.Color.Black;
            labellndecator1.ForeColor = System.Drawing.Color.Black;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            panel1.Visible = false;
        }
    }
}
