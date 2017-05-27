using System;
using System.Windows.Forms;

namespace L3MegaEscritorio
{
    public partial class Form1 : Form
    {
        // This integer variable stores the number for the surface measurement.
        int deskSurfaceArea;

        // These integers store the current prices for various desk options.
        int surfaceBaseArea = 1000;
        int surfaceBasePrice = 200;
        int SurfaceOveragePrice = 1;
        int pricePerDrawer = 50;
        int deskBasePrice = 200;

        // These are the different surface materials prices.
        int oakPrice = 200;
        int laminatePrice = 100;
        int pinePrice = 50;

        // This DateTime is for the quote date.
        DateTime quoteDate = new DateTime();

        public DateTime GetQuoteDate()
        {
            return quoteDate;
        }

        public void SetQuoteDate(DateTime value)
        {
            quoteDateDisplay.Text = value.ToString();
        }

        // Display day month and year.
        private void DisplayQuoteDate()
        {
            DateTime quoteDate = DateTime.Now;
            quoteDateDisplay.Text = quoteDate.ToString("d MMMM yyyy");
        }

        public Form1()
        {
            InitializeComponent();
            DisplayQuoteDate();
        }

        // Calculate the cost of the desk.
        public void PrepareTheQuote()
        {
            int surfaceOverageInches;
            // Get input from ComboBox.
            int numOfDrawers = Int32.Parse(numberOfDrawers.Text);
            string surfMaterial = surfaceMaterial.Text;
            int daysRush = Int32.Parse(daysRushOrder.Text);

            // Cast the dimensions to ints and calculate the surface area.
            deskSurfaceArea = (int)deskWidth.Value * (int)deskDepth.Value;

            // Calculate the surface area overage, if any.
            if (deskSurfaceArea > 1000)
            {
                surfaceOverageInches = deskSurfaceArea - surfaceBaseArea;
            }
            else
            {
                surfaceOverageInches = 0;
            }

            // Calculate the basic desk price. 
            int surfaceOverageCost = surfaceOverageInches * SurfaceOveragePrice;
            int basicDeskPrice = deskBasePrice + surfaceOverageCost;
            int drawerOptionPrice = numOfDrawers * pricePerDrawer;

            int deskPriceQuote = basicDeskPrice;

            // Temporary code while trying to fix the program.
            MessageBox.Show("Desk Quote is $" + deskPriceQuote);
            prepareQuoteButton.Enabled = true;
        }

        private void PrepareQuote_Click(object sender, EventArgs e)
        {
            if (!avoidErrors())
                return;
            PrepareTheQuote();
            prepareQuoteButton.Enabled = false;
        }

        public bool avoidErrors()
        {
            if ((numberOfDrawers.Text == "") || (surfaceMaterial.Text == "") || (daysRushOrder.Text == ""))
               {
              noticeInstructions.Text = ("You must make a selection from each category.");
              prepareQuoteButton.Enabled = true;
              return false;
              }
            return true;
        }
    }
}
