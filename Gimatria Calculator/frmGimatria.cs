using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gimatria
{
    public partial class frmGimatria : Form
    {
        public frmGimatria()
        {
            InitializeComponent();
        }

        SortedList<char, HebCharachter> hebcharslist = new SortedList<char, HebCharachter>
            {
                { Convert.ToChar(1488), new HebCharachter (1, 1) },
                { Convert.ToChar(1489), new HebCharachter (2, 2) },
                { Convert.ToChar(1490), new HebCharachter (3, 3) },
                { Convert.ToChar(1491), new HebCharachter (4, 4) },
                { Convert.ToChar(1492), new HebCharachter (5, 5) },
                { Convert.ToChar(1493), new HebCharachter (6, 6) },
                { Convert.ToChar(1494), new HebCharachter (7, 7) },
                { Convert.ToChar(1495), new HebCharachter (8, 8) },
                { Convert.ToChar(1496), new HebCharachter (9, 9) },
                { Convert.ToChar(1497), new HebCharachter (10, 1) },
                { Convert.ToChar(1499), new HebCharachter (20, 2) }, //Kaf
                { Convert.ToChar(1500), new HebCharachter (30, 3) },
                { Convert.ToChar(1502), new HebCharachter (40, 4) }, //mam
                { Convert.ToChar(1504), new HebCharachter (50, 5) }, //nien
                { Convert.ToChar(1505), new HebCharachter (60, 6) },
                { Convert.ToChar(1506), new HebCharachter (70, 7) },
                { Convert.ToChar(1508), new HebCharachter (80, 8) }, //pah
                { Convert.ToChar(1510), new HebCharachter (90, 9) }, //tzadik
                { Convert.ToChar(1511), new HebCharachter (100, 1) },
                { Convert.ToChar(1512), new HebCharachter (200, 2) },
                { Convert.ToChar(1513), new HebCharachter (300, 3) },
                { Convert.ToChar(1514), new HebCharachter (400, 4) },
                { Convert.ToChar(1498), new HebCharachter (20, 2) }, //final Kaf
                { Convert.ToChar(1501), new HebCharachter (40, 4) }, //final mam
                { Convert.ToChar(1503), new HebCharachter (50, 5) }, //final nien
                { Convert.ToChar(1507), new HebCharachter (80, 8) }, //final pah
                { Convert.ToChar(1509), new HebCharachter (90, 9) }  //final tzadik
                };

        private void txtGimatriaInput_TextChanged(object sender, EventArgs e)
        {
            int misparGadol = 0;
            int misparKatan = 0;

            foreach (var curChar in txtGimatriaInput.Text)
            {
                if (curChar < Convert.ToChar(1488) || curChar > Convert.ToChar(1514))
                    continue;

                misparGadol += hebcharslist[curChar].MisparGadol;
                misparKatan += hebcharslist[curChar].MisparKatan;
            }
            lblTextOutput.Text = txtGimatriaInput.Text;
            lblMisparGadol.Text = misparGadol.ToString();
            lblMisparKatan.Text = misparKatan.ToString();
        }
    }
}
