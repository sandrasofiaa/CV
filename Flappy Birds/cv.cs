using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace Flappy_Birds
{
    public partial class cv : Form
    {
        public cv()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {

            {
                var myForm = new Form1();
                myForm.Show();
            }


        }

        private void button12_Click(object sender, EventArgs e)
        {


            string text = "Hej blivande arbetsgivare! \n\nVill du ha en driven, nyfiken och ganska kul praktikant?\nIsåfall Hej! \nMed mig som praktikant kan du förvänta dig ett\nstort engagemang och passion.\n\n" +
                "Med mina tidigare erfarenheter kring både\ndriva företag samt driva projekt är jag både en fena\npå att arbeta i team och självständigt.\n\n" +
                "Mina starkaste sidor:\nMålmedveten\nEnvis\nLättlärd\nHar hört att jag är rätt trevlig också ";


            buttonClickTxt.Text = text;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button11_Click(object sender, EventArgs e)
        {
            string text = "Nuvarande sysselsättning: \n-Studerar Objektorienterad systemutveckling \nvid NBI Handelsakademin.\n-Samt jobbar vid sidan av studierna med mindre uppdrag\ninom marknadsföring" +
                "\n\nKunskaper:\n-C# (touchat java och react)\n-Python\n-Git och Github\n-Databashantering\n\nTidigare erfarenheter:\n-Marknadsföringskonsult specialiserad\npå SOME 2018 och framåt\n-Make up artist 2015-2018";


            buttonClickTxt.Text = text;
        }

        
    }
}
