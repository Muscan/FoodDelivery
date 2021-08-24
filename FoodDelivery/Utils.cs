using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace FoodDelivery
{
    class Utils
    {
        //Functie care verifica daca Radio buttons sunt selectate

        public static bool IsChecked(RadioButton rdo1, RadioButton rdo2, RadioButton rdo3)
        {
            if (rdo1.Checked == false && rdo2.Checked == false && rdo3.Checked == false)
            {
                return false;
            }
            return true;
        }

        public static bool IsZonaLivrare(ComboBox option)
        {
            if(option.SelectedIndex != -1)
            {
                return true;
            }
            return false;
        }

        public static void AlertaAfisare(String alert)
        {
            MessageBox.Show($"Camp obligatoriu: {alert}");
        }

        public static void ResetareButoane(RadioButton rdo1, RadioButton rdo2, RadioButton rdo3)
        {
            rdo1.Checked = false;
            rdo2.Checked = false;
            rdo3.Checked = false;
        }

        public static void ResetareCombo(ComboBox option)
        {
            option.SelectedIndex = -1;
        }

        public static void ResetareLabel(Label lbl)
        {
            lbl.Text = "";
            lbl.Visible = false;
        }
       
        public static void SetMenu(Meniu meniu1, Meniu meniu2, Meniu meniu3)
        {
            meniu1.TitluMeniu = "Big Menu";
            meniu1.PretMeniu = 33.21;
            meniu1.CaloriesMenu = 1555;

            meniu2.TitluMeniu = "Mediu Menu";
            meniu2.PretMeniu = 11.21;
            meniu2.CaloriesMenu = 155;

            meniu3.TitluMeniu = "Small Menu";
            meniu3.PretMeniu = 9.99;
            meniu3.CaloriesMenu = 34;


        }

        public static void SetExtra(Extra extra1, Extra extra2, Extra extra3)
        {
            extra1.NumeExtra = "Pikant";
            extra1.PretExtra = 2.1;
            extra1.CompozitieExtra = "Piper + chilli";

            extra2.NumeExtra = "Dulce";
            extra2.PretExtra = 5.1;
            extra2.CompozitieExtra = "Miere + zahar";

            extra3.NumeExtra = "Legume";
            extra3.PretExtra = 3.11;
            extra3.CompozitieExtra = "Rosii, salata";
        }

        public static void SetLivrare(ZonaLivrare zona1, ZonaLivrare zona2, ZonaLivrare zona3)
        {
            zona1.NumeZona = "Cisnadie";
            zona1.Pret = 12.51;
            zona1.Distanta = 10;

            zona2.NumeZona = "Cristian";
            zona2.Pret = 40;
            zona2.Distanta = 30;


            zona3.NumeZona = "Bruckenthal";
            zona3.Pret = 100;
            zona3.Distanta = 1.99;


        }

        public static void SetRdoBtnMeniu(RadioButton rdo, Meniu meniu)
        {
            rdo.Text = meniu.TitluMeniu + "\nPret: " + meniu.PretMeniu + "\nCalories: "+meniu.CaloriesMenu;
        }

        public static void SetRdoBtnExtra(RadioButton rdo, Extra extra)
        {
            rdo.Text = extra.NumeExtra + "\nPret: " + extra.PretExtra + "\nCompozitie extra: " + extra.CompozitieExtra;
        }

        public static void SetZonaLivrare(ComboBox cmb, ZonaLivrare zonaLivrare)
        {
             cmb.Items.Add (zonaLivrare.NumeZona + " Pret: " + zonaLivrare.Pret +" Distanta: " +zonaLivrare.Distanta);
        }

        public static double PretMeniu(RadioButton rdo, Meniu meniu)
        {
            if (rdo.Checked == true)
                return meniu.PretMeniu;
            return 0;
        }

        public static double PretExtra(RadioButton rdo, Extra extra)
        {
            if (rdo.Checked == true)
                return extra.PretExtra;
            return 0;
        }

        public static double PretLivrare(ComboBox cmd, ZonaLivrare zona1, ZonaLivrare zona2, ZonaLivrare zona3)
        {
            switch(cmd.SelectedIndex)
            {
                case 0:
                    return zona1.Pret;
                case 1:
                    return zona2.Pret;
                case 2:
                    return zona3.Pret;
            }
            return 0;
        }

    }
}
