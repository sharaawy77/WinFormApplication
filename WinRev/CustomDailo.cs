using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinRev
{
    public partial class CustomDailo : Form
    {
        public CustomDailo()
        {
            InitializeComponent();
        }
        public string customtext
        {
            get
            {
                return this.txtdial.Text;
            }
            set { this.txtdial.Text = value; }
        }
    }
}
