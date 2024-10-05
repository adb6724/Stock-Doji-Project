using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projectAntonioBrown
{
    internal class EngulfingBullishCandlestick_Recognizer : aRecognizor // constructor for aRecognizer for the recognizer/pattern EngulfingBullish
    {
        public EngulfingBullishCandlestick_Recognizer() : base("Bullish Engulfing Pattern", 2) { } // describes where the Bullish Engufing pattern will display in the chart using "2"

        protected override bool patternMatchedSubset(List<candlestick> Lcs)
        {
            candlestick pcs = Lcs[0];
            candlestick cs = Lcs[1];
            return pcs.isBearish && cs.isBullish && pcs.High < cs.topPrice && pcs.Low < cs.bottomPrice;
        }

    }
    internal class EngulfingBearishCandlestick_Recognizer : aRecognizor // constructor for aRecognizer for the recognizer/pattern EngulfingBearish
    {
        public EngulfingBearishCandlestick_Recognizer() : base("Bearish Engulfing Pattern", 2) { } // describes where the Bearish Engulfing pattern will display in the chart using "2"

        protected override bool patternMatchedSubset(List<candlestick> Lcs)
        {
            candlestick pcs = Lcs[0];
            candlestick cs = Lcs[1];
            return pcs.isBullish && cs.isBearish && pcs.High < cs.topPrice && pcs.Low < cs.bottomPrice;
        }
    }
}