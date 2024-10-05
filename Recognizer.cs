using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projectAntonioBrown
{

    internal abstract class aRecognizor // class constructing the recognizer for the program
    {

        public string patternName { get; set; } // grabs the name for the pattern and impliments it inot the chart

        public int patternSize { get; set; } // grabs the size of the chart using basic whole numbers (i.e. 1,2...)

        protected abstract bool patternMatchedSubset(List<candlestick> subsetOfCandlestick);

        public List<int> recongize(List<candlestick> candlesticks) // tells recognizer to recognize the data from the candlesticks anf creates the pattern on the chart 
        {

            List<int> result = new List<int>(candlesticks.Count / 8);

            int offset = patternSize - 1;
            for (int i = offset; i < candlesticks.Count; i++)
            {
                List<candlestick> subset = candlesticks.GetRange(i - offset, patternSize);

                if (patternMatchedSubset(subset))
                {
                    result.Add(i);
                }
            }

            return result;
        }

        public aRecognizor(string pName, int pSize) => (patternName, patternSize) = (pName, pSize); // constructs aRecognizer with its properties and values that fit the chart's needs



    }
}