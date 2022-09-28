using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CheckBoxKontrola
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnPosalji_Click(object sender, EventArgs e)
        {
            txtBx.AppendText("Odabrali ste :" + Environment.NewLine);

            if (chcBxDo.Checked)
            {
                txtBx.AppendText("Dorucak " + Environment.NewLine);
            }

            if (chcBxRu.Checked)
            {
                txtBx.AppendText("Rucak " + Environment.NewLine);
            }

            if (chcBxVe.Checked)
            {
                txtBx.AppendText("Vecera " + Environment.NewLine);
            }
        }

        private void chcBxHide_CheckedChanged(object sender, EventArgs e)
        {
     
                if (txtBx.Visible == false)
                {

                    txtBx.Visible = true;
                }

                else
                {
                    txtBx.Visible = false;
                }
            }
        }
    }

