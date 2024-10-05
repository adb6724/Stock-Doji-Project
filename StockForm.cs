using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projectAntonioBrown
{
    public partial class StockSelection : Form // defines base pre-instances as null
    {
        candlestickreader candlestickreader = null;
        List<candlestick> listofCandlesticks = null;
        public StockSelection() // constructor
        {
            InitializeComponent();
            candlestickreader = new candlestickreader(); // create new candlestickreader instance
            dataGridView1.DataSource = listofCandlesticks = new List<candlestick>(512); // initialize data grid view wiht empty list of them
        }

        private void StockSelection_Load(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e) // event handler for the pressed button
        {

            string period = String.Empty; //figure out the period to load based on which radio button is selected
            if (Daily.Checked) { period = "Day"; }
            else if (Weekly.Checked) { period = "Week"; }
            else if (Monthly.Checked) { period = "Month"; }

            else { period = "Day"; }

            ChartLoader chart = new ChartLoader();

            listofCandlesticks = candlestickreader.readStock(comboBox1.Text, period, startdatepicker.Value, enddatepicker.Value); //load stock data for ticker and period between shown star/end dates
            dataGridView1.DataSource = listofCandlesticks; //set the source of data for the data grid view to the loaded candlestick list

            chart.chart1.DataSource = listofCandlesticks;

            chart.Show();

        }

        private void label1_Click(object sender, EventArgs e) // event handler for the label
        {

        }

        private void Weekly_CheckedChanged(object sender, EventArgs e) // event handler for week checker
        {
            comboBox1.Items.Clear();
            comboBox1.Items.Add("AAPL-Week.csv");
            comboBox1.Items.Add("GOOGL-Week.csv");
            comboBox1.Items.Add("IBM-Week.csv");
            comboBox1.Items.Add("META-Week.csv");
            comboBox1.Items.Add("MSFT-Week.csv");
        }

        private void Form1_Load_1(object sender, EventArgs e) // event handler for form loader
        {

        }

        private void Daily_CheckedChanged(object sender, EventArgs e) // event handler for daily checker
        {
            comboBox1.Items.Clear();
            comboBox1.Items.Add("AAPL-Day.csv");
            comboBox1.Items.Add("GOOGL-Day.csv");
            comboBox1.Items.Add("IBM-Day.csv");
            comboBox1.Items.Add("META-Day.csv");
            comboBox1.Items.Add("MSFT-Day.csv");
        }

        private void Monthly_CheckedChanged(object sender, EventArgs e) // event handler for month checker
        {
            comboBox1.Items.Clear();
            comboBox1.Items.Add("AAPL-Month.csv");
            comboBox1.Items.Add("GOOGL-Month.csv");
            comboBox1.Items.Add("IBM-Month.csv");
            comboBox1.Items.Add("META-Month.csv");
            comboBox1.Items.Add("MSFT-Month.csv");
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e) //event handler for combo box
        {

        }
    }
}
