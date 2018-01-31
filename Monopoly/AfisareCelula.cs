using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Monopoly
{
    public partial class AfisareCelula : Form
    {
        public AfisareCelula()
        {
            InitializeComponent();
        }

        public AfisareCelula(Image imagine)
        {
            InitializeComponent();
            imagineCelula.BackgroundImage = imagine;
            Show();
        }
    }
}
