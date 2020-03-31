/*Tijdens een uitverkoop bij een stripwinkel bedraagt de prijs van elke strip 5 euro exclusief btw
*(hint: zoek dit tarief op voor België). In de winkel staan verschillende computers waarop de
*gebruiker hun aantal stripboeken kunnen ingeven.Het programma laat de berekeningen zien en
*het totaal te betalen bedrag.De gebruiker moet ook zijn voornaam ingeven.Ontwerp een
*consoletoepassing voor de klanten. De weergave moet er als volgt uitzien:
* 
*Welkom … !
*Eenheidsprijs exclusief btw … EUR
*Aantal …
*Subtotaal exclusief btw … EUR
* 
*Btw-tarief … %
*Btw bedrag … EUR
* 
*Totaal inclusief btw … EUR
*/
/* vraag    de prijs aan de gebruiker excl btw
 *          het aantal strips die de gebruiker wilt kopen
 * bereken  subtotaal excl btw (prijs per stuk excl btw * aantal strips)
 *          btw bedrag(subtotaal + 21% btw van subtotaal)
 *          totaal incl btw (subtotaal excl btw + btw bedrag)
 * toon     het totaal incl btw
 * 
 * 
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Stripwinkel56
{
    public partial class Form_stripwinkel : Form
    {
        public Form_stripwinkel()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox_Subtotaal_TextChanged(object sender, EventArgs e)
        {
            
            

        }

        private void button_Totberek_Click(object sender, EventArgs e)
        {
            decimal PrijsPerStrip = decimal.Parse(textBox_Eenheidsprijs.Text), Aantal = decimal.Parse(textBox_Aantal.Text),
            Subtotaal = 0;
            Subtotaal = PrijsPerStrip * Aantal;
            this.textBox_Subtotaal.Text = Subtotaal.ToString();
            decimal BedragExcl = PrijsPerStrip, somBedragincl;
            somBedragincl = PrijsPerStrip + BedragExcl / 100 * 21;
            this.textBox_BTWincl.Text = somBedragincl.ToString();
            decimal totaal = 0;
            totaal = somBedragincl * Aantal;
            this.textBox_TotaalBedrag.Text = totaal.ToString();


        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button_close_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
