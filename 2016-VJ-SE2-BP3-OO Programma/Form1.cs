using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using _2016_VJ_SE2_BP3_OO_Programma.Betaalwijze;

namespace _2016_VJ_SE2_BP3_OO_Programma
{
    public partial class Form1 : Form
    {
        private readonly Garage _garage = new Garage();

        public Form1()
        {
            InitializeComponent();
        }

        private void RefreshData()
        {
            txtZoneCode.Text = _garage.ZoneCode.ToString();
            txtPlaatsenTotaal.Text = _garage.PlaatsenTotaal.ToString();
            txtPlaatsenBezet.Text = _garage.PlaatsenBezet.ToString();
            txtUurPrijs.Text = _garage.UurPrijs.ToString("0.00");

            lstOpeningstijden.Items.Clear();
            _garage.Openingstijden.ForEach(openingstijd => lstOpeningstijden.Items.Add(openingstijd));

            lstParkeerders.Items.Clear();
            List<Parkeerder> bezoekers = _garage.Bezoekers.Where(parkeerder => parkeerder.VertrekTijd == null).ToList();
            bezoekers.Sort(new ParkeerderSorteerder());
            bezoekers.ForEach(parkeerder => lstParkeerders.Items.Add(parkeerder));

            txtInkomsten.Text = _garage.Inkomsten().ToString("0.00");
        }

        private void btnLaadConfiguratie_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            DialogResult result = dialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                try
                {
                    _garage.LaadConfiguratie(dialog.FileName);

                    RefreshData();
                }
                catch (Exception)
                {
                    MessageBox.Show("Het opgegeven bestand is ongeldig.");
                }
            }
        }

        private void btnInrijden_Click(object sender, EventArgs e)
        {
            string kenteken = txtKenteken.Text;
            string dag = cmbAankomstDag.Text;
            decimal uur = nudAankomstUur.Value;
            decimal minuut = nudAankomstMinuut.Value;

            if (kenteken != "")
            {
                if (!_garage.NieuweParkeerder(kenteken, new Time(dag, uur, minuut)))
                {
                    MessageBox.Show("Kan bezoeker niet toevoegen.");
                }
            }
            else
            {
                MessageBox.Show("Voer een kenteken in.");
            }

            RefreshData();
        }

        private void btnVertrek_Click(object sender, EventArgs e)
        {
            string kenteken = txtKenteken.Text;
            string dag = cmbAankomstDag.Text;
            decimal uur = nudAankomstUur.Value;
            decimal minuut = nudAankomstMinuut.Value;

            IBetaalwijze betaalwijze = null;
            if (radUurkaart.Checked)
            {
                betaalwijze = new Uurkaart(_garage);
            }
            else if (radVrijeUitrijkaart.Checked)
            {
                betaalwijze = new Vrijkaart();
            }
            else if (radParkeerApp.Checked)
            {
                betaalwijze = new ParkeerApp(_garage);
            }

            if (kenteken != "" && betaalwijze != null)
            {
                try
                {
                    Parkeerder parkeerder = _garage.ParkeerderVertrekt(kenteken, new Time(dag, uur, minuut), betaalwijze);

                    MessageBox.Show(
                        $"Kenteken: {parkeerder.Kenteken}\n" +
                        $"Aankomst: {parkeerder.AankomstTijd}\n" +
                        $"Vertrek: {parkeerder.VertrekTijd}\n" +
                        $"Betaalwijze: {betaalwijze.GetType().Name}\n" +
                        $"Bedrag: {parkeerder.Betaling.ToString("0.00")}");
                }
                catch (OngeldigVertrekException ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Voer een kenteken en betaalwijze in.");
            }

            RefreshData();
        }
    }
}