using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace İdareDeskstop
{
    public partial class ÇağırmaEkranı : Form
    {
        public List<İdareciler> idareciler;

        public ÇağırmaEkranı(List<İdareciler> idareciler)
        {
            InitializeComponent();

            this.idareciler = idareciler;
        }

        private void ÇağırmaEkranı_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
