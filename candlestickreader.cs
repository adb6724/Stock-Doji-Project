using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projectAntonioBrown
{
    internal class candlestickreader // constructor for candlestickreader
    {
        const string dataFolder = "Stock Data"; // holds candlestick class instances
        public List<candlestick> listofCandlesticks = null; // constructor ininitalizing candlestick with a max of 256
        public candlestickreader()
        {
            listofCandlesticks = new List<candlestick>(256);
        }
        // Reads csv file stock data and displays a list of data
        public List<candlestick> ReadlistofCandlesticks(string csvFilename, DateTime startdatepicker, DateTime enddatepicker)
        {
            char[] separators = new char[] { '-', ',', '"', '/' }; // characters used as separators in the csv stock data file
            String[] lines = System.IO.File.ReadAllLines(csvFilename); // reads csv stock data into an array of strings

            string header = lines[0]; // contains the header / first line of csv file

            if (header == "Date,Open,High,Low,Close,Adj Close,Volume") //use first line to make sure file is correct
            {
                listofCandlesticks = new List<candlestick>(lines.Length - 1); // initializes candlesticks with lines in csv file minus one
                for (int l = 1; l < lines.Length; l++) // loops lines in the csv file
                {
                    String line = lines[l].Trim(); // grabs csv file lines and removes white space
                    String[] subStrings = line.Split(separators, StringSplitOptions.RemoveEmptyEntries); // splits line into subsstrings "RemoveEmptyEntries" removes empty entries

                    int year = int.Parse(subStrings[2]); // parses year, month, and day and makes DateTime
                    int month = int.Parse(subStrings[1]);
                    int day = int.Parse(subStrings[0]);

                    DateTime date = new DateTime(year, day, month);

                    if (date.CompareTo(startdatepicker) >= 0 && date.CompareTo(enddatepicker) < 0) // checks if date is within start and end dates
                    {
                        double open = double.Parse(subStrings[3]); // parses open, high, low, close, volume values from left over substrings
                        double high = double.Parse(subStrings[4]);
                        double low = double.Parse(subStrings[5]);
                        double close = double.Parse(subStrings[6]);
                        long volume = long.Parse(subStrings[8]);

                        open = Math.Round(open, 2); // rounds open, high, low, close to two decimal places
                        high = Math.Round(high, 2);
                        low = Math.Round(low, 2);
                        close = Math.Round(close, 2);

                        candlestick acandlestick = new candlestick(date, open, high, low, close, volume); // constructs candlestick object with parsed data and puts it in the list of candlesticks

                        listofCandlesticks.Add(acandlestick);

                    }

                }
            }
            return listofCandlesticks; //return listofCandlesticks
        }
        internal List<candlestick> readStock(string ticker, string period, DateTime startdate, DateTime enddate) // declares method "readStock returns list of candlestick objects
        {
            string csvFilename = dataFolder + @"\" + ticker; // reads stock data from csv file on a ticker, period, startdate and enddate
            listofCandlesticks = ReadlistofCandlesticks(csvFilename, startdate, enddate); // filepath constructed from ticker/period and the file is read using ReadlistofCandlesticks
            return listofCandlesticks; // list is stored in listofCandlesticks variable and is returned
        }
    }
}

