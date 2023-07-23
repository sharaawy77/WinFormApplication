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
    public partial class homefrm : Form
    {
        public homefrm()
        {
            InitializeComponent();
        }

        private void homefrm_Load(object sender, EventArgs e)
        {

        }
        protected override void OnPaint(PaintEventArgs e)
        {
            string str = "welcome";
            var strlen = e.Graphics.MeasureString(str, this.Font);
            Font font = new Font(this.Font.FontFamily, 40);
            e.Graphics.DrawString(str, font, Brushes.Black,
                ((this.ClientSize.Width - (strlen.Width/2)) / 2),
                ((this.ClientSize.Height - (strlen.Height/2)) / 2)

                );
            base.OnPaint(e);
        }
    }
}
