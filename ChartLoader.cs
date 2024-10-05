using projectAntonioBrown;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolTip;

namespace projectAntonioBrown 
{
    public partial class ChartLoader : Form // defines chartloader in the form
    {
        List<candlestick> candlesticks = new List<candlestick>();

        public ChartLoader() // constructed the chart and its properties and contents
        {
            InitializeComponent();
            initializeRecognizer();
            chart1.Series["OHLC"].XValueMember = "Date";
            chart1.Series["OHLC"].YValuesPerPoint = 4;

            chart1.Series["OHLC"].YValueMembers = "High, Low, Open, Close";

            chart1.ChartAreas["OHLC"].AxisX.MajorGrid.LineWidth = 0;
            chart1.ChartAreas["OHLC"].AxisY.MajorGrid.LineWidth = 0;

            chart1.Series["OHLC"].CustomProperties = "PriceUpColor=Green, PriceDownColor=Red";

        }

        private void upDateChart()
        {
            // Get the chart's data source and cast it to a List<aCandlestick>
            var dataSource = chart1.DataSource as List<candlestick>;

            if (dataSource != null)
            {
                // Assign the chart's data source to the candlesticks list
                candlesticks = dataSource;

                // Calculate the Y-axis maximum and minimum values
                double maxY = candlesticks.Max(cs => cs.High);
                double minY = candlesticks.Min(cs => cs.Low);
                double padding = 0.10 * (maxY - minY);

                // Set the Y-axis maximum and minimum values
                chart1.ChartAreas["OHLC"].AxisY.Maximum = maxY + padding;
                chart1.ChartAreas["OHLC"].AxisY.Minimum = minY - padding;
            }



        }





        // creates a list of type aRecognizor called recognizors
        List<aRecognizor> recognizors = new List<aRecognizor>(32);
        private List<aRecognizor> initializeRecognizer()
        {
            // initially sets local variable recognizor to null
            aRecognizor recognizor = null;
            // assigns the local variable to the name of the class that is wanted to be added to the combobox and then adds it to the list recongizors
            recognizor = new Recognizer_Bullish();
            recognizors.Add(recognizor);

            recognizor = new Recognizer_Bearish();
            recognizors.Add(recognizor);

            recognizor = new Recognizer_Neutral();
            recognizors.Add(recognizor);

            recognizor = new Recognizer_Doji();
            recognizors.Add(recognizor);

            recognizor = new Recognizer_NeutralDoji();
            recognizors.Add(recognizor);

            recognizor = new Recognizer_DragonFly();
            recognizors.Add(recognizor);

            recognizor = new Recognizer_GravestoneDoji();
            recognizors.Add(recognizor);

            recognizor = new Recognizer_Hammer();
            recognizors.Add(recognizor);

            recognizor = new Recognizer_BearishHammer();
            recognizors.Add(recognizor);

            recognizor = new Recognizer_invertedHammer();
            recognizors.Add(recognizor);

            recognizor = new Recognizer_bearishInvertedHammer();
            recognizors.Add(recognizor);

            recognizor = new Recognizer_blackMarubozu();
            recognizors.Add(recognizor);

            recognizor = new Recognizer_whiteMarubozu();
            recognizors.Add(recognizor);

            recognizor = new EngulfingBullishCandlestick_Recognizer();
            recognizors.Add(recognizor);

            recognizor = new EngulfingBearishCandlestick_Recognizer();
            recognizors.Add(recognizor);


            // clears any existing items in the comboBox
            comboBox1.Items.Clear();
            // for each class in recongizors we take the pattern name in the base and adds that pattern name to the combo box
            foreach (aRecognizor r in recognizors)
            {
                comboBox1.Items.Add(r.patternName);
            }
            comboBox1.Enabled = true;
            // returns the list of classes recognizors
            return recognizors;

        }



        private void chart1_Click(object sender, EventArgs e) // event handler for chart1_click
        {

        }

        private void button1_Click_1(object sender, EventArgs e) // event handler for button1_Click_1; describes every option of the combo box and removes the existing trend if another trend is selected
        {
           
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // calls the upDateChart method
            upDateChart();
            // makes a local variable called recognizors equal to the class at the selectedIndex in the recognizors 
            aRecognizor recognizor = recognizors[comboBox1.SelectedIndex];

            // makes a list of ints called retcon equal to the list of indexes that are returned
            List<int> retcon = recognizor.recongize(candlesticks);
            chart1.Annotations.Clear();
            foreach (int i in retcon)
            {

                // makes new rectangle annotation called ra which makes an undeerstanding for pattern creation
                RectangleAnnotation ra = new RectangleAnnotation();
                ra.Text = recognizor.patternName;
                ra.AnchorDataPoint = chart1.Series["OHLC"].Points[i];
                chart1.Annotations.Add(ra);
            }
        }
    }
}


