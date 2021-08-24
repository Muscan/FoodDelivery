using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static FoodDelivery.Utils;
namespace FoodDelivery
{
    public partial class Form1 : Form
    {
        private Meniu meniu1 = new Meniu();
        private Meniu meniu2 = new Meniu();
        private Meniu meniu3 = new Meniu();
        private Extra extra1 = new Extra();
        private Extra extra2 = new Extra();
        private Extra extra3 = new Extra();
        private ZonaLivrare zona1 = new ZonaLivrare();
        private ZonaLivrare zona2 = new ZonaLivrare();
        private ZonaLivrare zona3 = new ZonaLivrare();
        public Form1()
        {
            InitializeComponent();
            SetMenu(meniu1, meniu2, meniu3);
            SetExtra(extra1, extra2, extra3);
            SetLivrare(zona1, zona2, zona3);

            SetRdoBtnMeniu(rdoBtn1, meniu1);
            SetRdoBtnMeniu(rdoBtn2, meniu2);
            SetRdoBtnMeniu(rdoBtn3, meniu3);

            SetRdoBtnExtra(rdoBtn4, extra1);
            SetRdoBtnExtra(rdoBtn5, extra2);
            SetRdoBtnExtra(rdoBtn6, extra3);

            SetZonaLivrare(cmBoxArea, zona1);
            SetZonaLivrare(cmBoxArea, zona2);
            SetZonaLivrare(cmBoxArea, zona3);
        }

        private void btnComanda_Click(object sender, EventArgs e)
        {
            if (IsChecked(rdoBtn1, rdoBtn2, rdoBtn3) == false)
            {
                AlertaAfisare(grpMenu.Text);
            }
            else if (IsChecked(rdoBtn4, rdoBtn5, rdoBtn6) == false)
            {
                AlertaAfisare(grpExtra.Text);
            }
            else if (IsZonaLivrare(cmBoxArea) == false)
            {
                AlertaAfisare(cmBoxArea.Text);
            }
            else
            {
                double sum = 0;

                sum += PretMeniu(rdoBtn1, meniu1);
                sum += PretMeniu(rdoBtn2, meniu2);
                sum += PretMeniu(rdoBtn3, meniu3);

                sum += PretExtra(rdoBtn4, extra1);
                sum += PretExtra(rdoBtn5, extra2);
                sum += PretExtra(rdoBtn6, extra3);

                sum += PretLivrare(cmBoxArea, zona1, zona2, zona3);

                lblFinal.Text = "Pret total: " + sum;
                lblFinal.Visible = true;
            }
        }

        private void btnAnuleaza_Click(object sender, EventArgs e)
        {
            ResetareButoane(rdoBtn1, rdoBtn2, rdoBtn3);
            ResetareButoane(rdoBtn4, rdoBtn5, rdoBtn6);
            ResetareCombo(cmBoxArea);
            ResetareLabel(lblFinal);
        }
    }
}
