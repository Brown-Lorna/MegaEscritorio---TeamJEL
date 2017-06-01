using System;
using System.Windows.Forms;

namespace L3MegaEscritorio
{
    enum DesktopMaterial
    {
        Pine,
        Laminate,
        Oak,
        Cherry,
        Walnut,
        Ipe
    };

    public partial class Form1 : Form
    {
        int deskSurfaceArea;
        int orderTimePrice;
        int deskPriceQuote;
        int numOfDrawers;
        DesktopMaterial material;
        int materialCost;
        int rushOrderDays;
        int width;
        int depth;

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

            try
            {
                // Get input from NumericUpDown.
                width = (int)deskWidth.Value;
                depth = (int)deskDepth.Value;

                // Get input from ComboBoxes.
                numOfDrawers = Int32.Parse(numberOfDrawers.Text);
                // Error because of the Enum
                material = surfaceMaterial.SelectedItem;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Invalid Input");
            }

            // Calculate the surface area.
            deskSurfaceArea = width * depth;

            // Calculate the surface area overage, if any.
            if (deskSurfaceArea > 1000)
            {
                surfaceOverageInches = deskSurfaceArea - surfaceBaseArea;
            }
            else
            {
                surfaceOverageInches = 0;
            }

            if (material == DesktopMaterial.Pine)
            {
                materialCost = pinePrice;
               // material = "Pine";
            }
            else if (material == DesktopMaterial.Laminate)
            {
                materialCost = laminatePrice;
               // material = "Laminate";
            }
            else if (material == DesktopMaterial.Oak)
            {
                materialCost = oakPrice;
              //  material = "Oak";
            }
            else if (material == DesktopMaterial.Cherry)
            {
                materialCost = cherryPrice;
              //  material = "Cherry";
            }
            else if (material == DesktopMaterial.Walnut)
            {
                materialCost = walnutPrice;
             //   material = "Walnut";
            }
            else if (material == DesktopMaterial.Ipe)
            {
                materialCost = ipePrice;
              //  material = "Ipe";
            }
            else
            {
            }

            if (dayThree.Checked)
            {
                if (deskSurfaceArea < 1000) orderTimePrice = 60;
                else if ((deskSurfaceArea >= 1001) && (deskSurfaceArea <= 1999)) orderTimePrice = 70;
                else orderTimePrice = 80;
                rushOrderDays = 3;
            }
            else if (dayFive.Checked)
            {
                if (deskSurfaceArea < 1000) orderTimePrice = 40;
                else if ((deskSurfaceArea >= 1000) && (deskSurfaceArea <= 1999)) orderTimePrice = 50;
                else orderTimePrice = 60;
                rushOrderDays = 5;
            }
            else if (daySeven.Checked)
            {
                if (deskSurfaceArea < 1000) orderTimePrice = 30;
                else if ((deskSurfaceArea >= 1001) && (deskSurfaceArea <= 1999)) orderTimePrice = 30;
                else orderTimePrice = 40;
                rushOrderDays = 7;
            }
            else if (dayFourteen.Checked)
            {
                orderTimePrice = 0;
                rushOrderDays = 14;
            }
            else
            {

            }


            // Calculate the basic desk price. 
            int surfaceOverageCost = surfaceOverageInches * SurfaceOveragePrice;
            int basicDeskPrice = deskBasePrice + surfaceOverageCost;
            int drawerOptionPrice = numOfDrawers * pricePerDrawer;

            deskPriceQuote = (basicDeskPrice + drawerOptionPrice + materialCost + orderTimePrice);

            // Temporary code while trying to fix the program.
            MessageBox.Show("Desk Quote is $" + deskPriceQuote);

            Desk newDesk = new Desk(width, depth, numOfDrawers, material, rushOrderDays, deskPriceQuote);
            // Console.WriteLine(newDesk);

            DeskQuote newDeskQuote = new DeskQuote();

            // Error possibly from the Enum
            newDeskQuote.WriteQuote(width, depth, numOfDrawers, material, rushOrderDays, deskPriceQuote);
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

        private void DayThreeChanged(object sender, EventArgs e)
        {

        }

        private void DayFiveChanged(object sender, EventArgs e)
        {

        }

        private void DaySevenChanged(object sender, EventArgs e)
        {

        }

        private void DayFourteenChanged(object sender, EventArgs e)
        {

        }
    }
}

