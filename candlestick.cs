using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projectAntonioBrown
{
    internal class candlestick
    {
        // Retreives chart data and sets values for the variables Date, Open, Close, High, Low, and Volume for the base pattern, then does it for each of the special patterns
        public DateTime Date { get; set; }

        public double Open { get; set; }

        public double Close { get; set; }

        public double High { get; set; }

        public double Low { get; set; }

        public long Volume { get; set; }

        public double range { get; private set; }

        public double body { get; private set; }

        public double topPrice { get; private set; }
        public double bottomPrice { get; private set; }
        public double UpperTail { get; private set; }
        public double LowerTail { get; private set; }


        public static DataTable Datasource { get; internal set; }

        public Boolean isBullish { get; private set; }
        public Boolean isBearish { get; private set; }
        public Boolean isNeutral { get; private set; }


        public Boolean isDoji { get; private set; }
        public Boolean isGravestoneDoji { get; private set; }
        public Boolean isNeutralDoji { get; private set; }
        public Boolean isDragonflyDoji { get; private set; }
        public Boolean isLongLeggedDoji { get; private set; }

        public Boolean isHammer { get; private set; }
        public Boolean isBullishHammer { get; private set; }
        public Boolean isBearishHammer { get; private set; }
        public Boolean isInvertedHammer { get; private set; }
        public Boolean isBullishInvertedHammer { get; private set; }
        public Boolean isBearishInvertedHammer { get; private set; }
        public Boolean isMarubozu { get; private set; }
        public Boolean isWhiteMarubozu { get; private set; }
        public Boolean isBlackMarubozu { get; private set; }

        // Below lines creates specific tolerances and properties for the different patters that the chart will be using, they also describes the math used for the respective patterns
        public Boolean dojiTest(double bodyTolerance = 0.1) 
        {
            return body <= bodyTolerance * range;
        }

        public Boolean dragonflyDoji(double bodyTolerance = 0.1, double toptolerance = .15)
        {
            return dojiTest(bodyTolerance) && UpperTail <= range * toptolerance;
        }
        public Boolean neutralDojiTest(double bodyTolerance = 0.1)
        {
            return dojiTest(bodyTolerance) && isDragonflyDoji == false && isGravestoneDoji == false;
        }
        public Boolean gravestoneDojiTest(double bodyTolerance = 0.1, double bottomtolerance = .15)
        {
            return dojiTest(bodyTolerance) && LowerTail<= range * bottomtolerance;
        }
        public Boolean hammerTest(double minbodytolerance = .15, double maxbodyTolerance = 0.4, double toptolerance = 0.1)
        {
            return body > range * minbodytolerance && body < range * maxbodyTolerance && UpperTail < range * toptolerance;
        }
        public Boolean bullishHammerTest(double minbodytolerance = .15, double maxbodyTolerance = 0.4, double toptolerance = 0.1)
        {
            return hammerTest(minbodytolerance,maxbodyTolerance, toptolerance) && isBullish == true;
        }
        public Boolean bearishHammerTest(double minbodytolerance = .15, double maxbodyTolerance = 0.4, double toptolerance = 0.1)
        {
            return hammerTest(minbodytolerance, maxbodyTolerance, toptolerance) && isBearish == true;
        }
        public Boolean invertedHammerTest(double minbodytolerance = .15, double maxbodyTolerance = 0.4, double bottomtolerance = 0.1)
        {
            return body > range * minbodytolerance && body < range * maxbodyTolerance && LowerTail < range * bottomtolerance;
        }
        public Boolean bullishInvertedHammerTest(double minbodytolerance = .15, double maxbodyTolerance = 0.4, double bottomtolerance = 0.1)
        {
            return invertedHammerTest(minbodytolerance, maxbodyTolerance, bottomtolerance) && isBullish == true;
        }
        public Boolean bearishInvertedHammerTest(double minbodytolerance = .15, double maxbodyTolerance = 0.4, double bottomtolerance = 0.1)
        {
            return invertedHammerTest(minbodytolerance, maxbodyTolerance, bottomtolerance) && isBearish == true;
        }
        public Boolean marubozuTest(double bodyTolerance = 0.1)
        {
            return body > range * (1 - bodyTolerance);
        }
        public Boolean whiteMarubozuTest(double bodyTolerance = 0.1)
        {
            return marubozuTest(bodyTolerance) && isBullish == true;
        }
        public Boolean blackMarubozuTest(double bodyTolerance = 0.1)
        {
            return marubozuTest(bodyTolerance) && isBearish == true;
        }
        public candlestick() // constructs candlestick with what it completes
        {
            // Sets base values for Date, Open, Close, High, Low, and Volume variables
            Date = DateTime.Now;
            Open = 0; Close = 0; High = 0; Low = 0; Volume = 0;

        }

        public candlestick(DateTime date, double open, double high, double low, double close, long volume) // setting up values to be used by the program from the chart data
        {
            // Lets information in chart to be used by program
            Date = date;
            Open = open;
            Close = close;
            High = high;
            Low = low;
            Volume = volume;

            computeProperties();
        }
        private void computePatterns() // event handler for pattern tests and displays
        {
            isBullish = Close > Open;
            isBearish = Open > Close;
            isNeutral = Open == Close;

            isDoji = dojiTest();
            isDragonflyDoji = dragonflyDoji();
            isGravestoneDoji = gravestoneDojiTest();
            isNeutralDoji = neutralDojiTest();

            isHammer = hammerTest();
            isBullishHammer = bullishHammerTest();
            isBearishHammer = bearishHammerTest();
            isInvertedHammer = invertedHammerTest();
            isBullishInvertedHammer = bullishInvertedHammerTest();
            isBearishInvertedHammer = bearishInvertedHammerTest();

            isMarubozu = marubozuTest();
            isWhiteMarubozu = whiteMarubozuTest();
            isBlackMarubozu = blackMarubozuTest();





        }
        private void computeProperties() // event handler for basic chart patterns in the chart area
        {
            range = High - Low;
            body = Math.Max(Open, Close) - Math.Min(Close, Open);
            topPrice = Math.Max(Open, Close);
            bottomPrice = Math.Min(Open, Close);
            UpperTail = High - topPrice;
            LowerTail = bottomPrice - Low;

            computePatterns();
        }
    }
}
