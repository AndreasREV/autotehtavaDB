using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Autokauppa.controller;
using Autokauppa.model;

namespace Autokauppa.view
{
    
    public partial class MainMenu : Form
    {
        Auto nykyinenAuto = new Auto();
        KaupanLogiikka registerHandler;
        Autonmerkki autoMakeList = new Autonmerkki();
        public MainMenu()
        {
            registerHandler = new KaupanLogiikka();
            InitializeComponent();
        }        
        private void MainMenu_Load(object sender, EventArgs e)
        {
            Merkkibox.DataSource = registerHandler.getAutoMakers();
            Merkkibox.DisplayMember = "Merkkinimi";
            Merkkibox.ValueMember = "Id";            
        }
        private void LisaaMallit(object sender, EventArgs e)
        {
            try
            {
                if (Merkkibox.SelectedValue is int)
                {
                    int nakki = (int)Merkkibox.SelectedValue;
                    Mallibox.DataSource = registerHandler.GetAutonmallits(nakki);
                    Mallibox.DisplayMember = "Mallinimi";
                    Mallibox.ValueMember = "Id";
                    colorbox.DataSource = registerHandler.GetVarits();
                    colorbox.DisplayMember = "Varin_nimi1";
                    colorbox.ValueMember = "ID1";
                    Fuelbox.DataSource = registerHandler.GetPolttoaines();
                    Fuelbox.DisplayMember = "Polttoaineen_nimi1";
                    Fuelbox.ValueMember = "ID1";
                }
            }
            catch
            {
                //tulee alussa kun merkkibox.valuemember ei ole määritetty
            }
        }
        private void testaaYhteyttäToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (registerHandler.TestDatabaseConnection())
            {
                MessageBox.Show("jotai tapahtui jee");
            }
            else
            {
                MessageBox.Show("jotai ei tapahtunut");
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            ClearBoxes(this);
        }
        void ClearBoxes(Control control)
        {
            foreach(Control c in control.Controls)
            {
                if (c is TextBox)
                {
                    ((TextBox)c).Clear();
                }
                if (c is ComboBox)
                {
                    ((ComboBox)c).ResetText();
                }
                else
                {
                    ClearBoxes(c);
                }
            }
        }
        private void Savebutton_Click(object sender, EventArgs e)
        {
            Auto pirssi = new Auto();
            pirssi.Hinta1 = Decimal.Parse(Hintabox.Text);
            pirssi.Moottorin_tilavuus1 = Decimal.Parse(Motorbox.Text);
            pirssi.Mittarilukema1 = int.Parse(Lukemabox.Text);
            pirssi.AutonmerkkiID1 = (int)Merkkibox.SelectedValue;
            pirssi.AutonmalliID1 = (int)Mallibox.SelectedValue;
            pirssi.VaritID1 = (int)colorbox.SelectedValue;
            pirssi.PolttoaineID1 = (int)Fuelbox.SelectedValue;
            pirssi.Rekisteri_Paivamaara1 = dateTimePicker1.Value;
            registerHandler.SaveAuto(pirssi);
            MessageBox.Show("Auto tallennettu!");
            ClearBoxes(this);
        }
        private void prvbtn_Click(object sender, EventArgs e)
        {
            nykyinenAuto = registerHandler.PreviousCars(nykyinenAuto.ID1);
            TulostaAuto(nykyinenAuto);
        }
        private void nextbtn_Click(object sender, EventArgs e)
        {            
            nykyinenAuto = registerHandler.NextCars(nykyinenAuto.ID1);
            TulostaAuto(nykyinenAuto);
        }
        private void TulostaAuto(Auto uusiAuto)
        {
            Merkkibox.SelectedValue = uusiAuto.AutonmerkkiID1;
            Mallibox.SelectedValue = uusiAuto.AutonmalliID1;
            colorbox.SelectedValue = uusiAuto.VaritID1;
            Fuelbox.SelectedValue = uusiAuto.PolttoaineID1;
            Hintabox.Text = uusiAuto.Hinta1.ToString();
            Motorbox.Text = uusiAuto.Moottorin_tilavuus1.ToString();
            dateTimePicker1.Text = uusiAuto.Rekisteri_Paivamaara1.ToString();
            Lukemabox.Text = uusiAuto.Mittarilukema1.ToString();           
        }
    }
}
