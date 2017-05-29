using System;
using System.Windows.Forms;

namespace L3MegaEscritorio
{
    public partial class Form1 : Form
    {
        int deskSurfaceArea;
        int orderTimePrice;
        int deskPriceQuote;
        string material;
        int materialCost;
        int orderDays;

        // These integers store the current prices for various desk options.
        int surfaceBaseArea = 1000;
        int SurfaceOveragePrice = 1;
        int pricePerDrawer = 50;
        int deskBasePrice = 200;

        // These are the different surface materials prices.
        int oakPrice = 200;
        int laminatePrice = 100;
        int pinePrice = 50;
        int cherryPrice = 225;
        int walnutPrice = 250;
        int ipePrice = 300;

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

              if (surfaceMaterial.SelectedValue == "Pine")
              {
                  materialCost = pinePrice;
                  material = "Pine";
              }
              else if (surfaceMaterial.SelectedValue == "Laminate")
              {
                  materialCost = laminatePrice;
                  material = "Laminate";
              }
              else if (surfaceMaterial.SelectedValue == "Oak")
              {
                  materialCost = oakPrice;
                  material = "Oak";
              } 

            if (dayThree.Checked)
            {
                if (deskSurfaceArea < 1000) orderTimePrice = 60;
                else if ((deskSurfaceArea >= 1001) && (deskSurfaceArea <= 1999)) orderTimePrice = 70;
                else orderTimePrice = 80;
                orderDays = 3;
            }  
            else if (dayFive.Checked)
            {
                if (deskSurfaceArea < 1000) orderTimePrice = 40;
                else if ((deskSurfaceArea >= 1000) && (deskSurfaceArea <= 1999)) orderTimePrice = 50;
                else orderTimePrice = 60;
                orderDays = 5;
            }
            else if (daySeven.Checked)
            {
                if (deskSurfaceArea < 1000) orderTimePrice = 30;
                else if ((deskSurfaceArea >= 1001) && (deskSurfaceArea <= 1999)) orderTimePrice = 30;
                else orderTimePrice = 40;
                orderDays = 7;
            }
            else if (dayFourteen.Checked)
            {
                orderTimePrice = 0;
                orderDays = 14;
            }
            else
            {

            }


            // Calculate the basic desk price. 
            int surfaceOverageCost = surfaceOverageInches * SurfaceOveragePrice;
            int basicDeskPrice = deskBasePrice + surfaceOverageCost;
            int drawerOptionPrice = numOfDrawers * pricePerDrawer;

            int deskPriceQuote = (basicDeskPrice + drawerOptionPrice + materialCost + orderTimePrice);

            // Temporary code while trying to fix the program.
            MessageBox.Show("Desk Quote is $" + deskPriceQuote);

   //     Desk newDesk = new Desk(deskWidth, deskDepth, numberOfDrawers, surfaceMaterial, orderDays, deskPriceQuote);
    //    Console.WriteLine(newDesk);
        }

        private void PrepareQuote_Click(object sender, EventArgs e)
        {
            if (!AvoidErrors())
                return;
            PrepareTheQuote();
        }

        public bool AvoidErrors()
        {
            if ((numberOfDrawers.Text == "") || (surfaceMaterial.Text == ""))
               {
              noticeInstructions.Text = ("You must make a selection from each category.");
              return false;
              }
            return true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void dayThreeChanged(object sender, EventArgs e)
        {
        }

        private void dayFiveChanged(object sender, EventArgs e)
        {
        }

        private void daySevenChanged(object sender, EventArgs e)
        {
        }

        private void dayFourteenChanged(object sender, EventArgs e)
        {
        }
    }
}
