using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyDienThoai
{
    public partial class frmInBang : Form
    {
        public frmInBang()
        {
            InitializeComponent();
        }

        private void crystalReportViewer2_Load(object sender, EventArgs e)
        {

        }

        private void frmInBang_Load(object sender, EventArgs e)
        {
            Cry cry = new Cry();
            crystalReportViewer2.ReportSource = cry;
        }
    }
}
