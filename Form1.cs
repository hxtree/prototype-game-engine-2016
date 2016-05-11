using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Game
{
    public partial class ui : Form
    {
        public ui()
        {
            InitializeComponent();
        }

        private void ui_Load(object sender, EventArgs e)
        {
            character meeku = new character();

           meeku.life = 5;
           
            combat test = new combat();

            string testrun = ",";
            string testrun1 = "luck\n";

            long high = 0;
            long low = 0;
            long average = 0;

            long rollIncrease = 1;
            decimal trys = 2000m;

            for (int f = 2; f < 10; f++)
            {
                meeku.roll = f*rollIncrease;
                high = 0;
                low = 0;
                average = 0;
                meeku.luck = 0;
                for (int i = 0; i < trys; i++)
                {
                    testrun = meeku.roll.ToString() + "/" + meeku.luck.ToString() + ",";
                    average = average + meeku.luck;
                    if (meeku.luck > high) { high = meeku.luck; }
                    if (meeku.luck < low) { low = meeku.luck; }
                }
                testrun1 = testrun1 + (f * rollIncrease).ToString() + " average:" + (average / trys).ToString() + " low:" + low.ToString() + " high:" + high.ToString() + "\n";
            }
            MessageBox.Show(testrun1);

            testrun1 = "roll\n";

            int testrun2 = 0 ;
            for (int f = 2; f < 10; f++)
            {
                meeku.roll = f * rollIncrease;
                high = 0;
                low = 0;
                average = 0;
                meeku.luck = 0;
                for (int i = 0; i < trys; i++)
                {
                    testrun2 = Convert.ToInt32(meeku.roll);
                    average = average + testrun2;
                    if (testrun2 > high) { high = testrun2; }
                    if (testrun2 < low) { low = testrun2; }
                }
                decimal percent = ((average / trys)/(f * rollIncrease));
                testrun1 = testrun1 + (f * rollIncrease).ToString() + " Percent:" + percent.ToString() + " average:" + (average / trys).ToString() + " low:" + (low / f * rollIncrease).ToString() + " high:" + (high / f * rollIncrease).ToString() + "\n";
            }
            MessageBox.Show(testrun1);

            for (int f = 2; f < 6; f++)
            {
                testrun = "Luck\n";
                meeku.roll = f * rollIncrease;
                high = 0;
                low = 0;
                average = 0;
                meeku.luck = 0;
                for (int i = 0; i < trys; i++)
                {
                    testrun1 = meeku.roll.ToString();
                    testrun += ";" + meeku.luck.ToString();
                }
                MessageBox.Show(testrun);
            }

            for (int f = 2; f < 6; f++)
            {
                testrun = "Roll\n";
                meeku.roll = f* rollIncrease;
                high = 0;
                low = 0;
                average = 0;
                meeku.luck = 0;
                for (int i = 0; i < trys; i++)
                {
                    testrun1 = meeku.roll.ToString();
                    testrun += (Convert.ToDecimal(meeku.roll) / Convert.ToInt64(f * rollIncrease))+.00m+";";
                }
                MessageBox.Show(testrun);
            }
        }
    }
}
