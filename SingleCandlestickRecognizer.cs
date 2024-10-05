using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projectAntonioBrown
{
    internal class Recognizer_Bullish : aRecognizor // constructor for Bullish pattern for the recognizer; tells the program ot return values from the pattern
    {
        public Recognizer_Bullish() : base("Bullish", 1) { }
        protected override bool patternMatchedSubset(List<candlestick> subsetOfCandlesticks)
        {
            return subsetOfCandlesticks[0].isBullish;
        }
    }
    internal class Recognizer_Bearish : aRecognizor // constructor for Bearish pattern for the recognizer; tells the program ot return values from the pattern
    {
        public Recognizer_Bearish() : base("Bearish", 1) { }
        protected override bool patternMatchedSubset(List<candlestick> subsetOfCandlesticks)
        {
            return subsetOfCandlesticks[0].isBearish;
        }
    }
    internal class Recognizer_Neutral : aRecognizor // constructor for base Neutral pattern for the recognizer; tells the program ot return values from the pattern
    {
        public Recognizer_Neutral() : base("Neutral", 1) { }
        protected override bool patternMatchedSubset(List<candlestick> subsetOfCandlesticks)
        {
            return subsetOfCandlesticks[0].isNeutral;
        }
    }
    internal class Recognizer_Doji : aRecognizor // constructor for Bullish pattern for the recognizer; tells the program ot return values from the pattern
    {
        public Recognizer_Doji() : base("Doji", 1) { }
        protected override bool patternMatchedSubset(List<candlestick> subsetOfCandlesticks)
        {
            return subsetOfCandlesticks[0].isDoji;
        }
    }
    internal class Recognizer_DragonFly : aRecognizor // constructor for DragonFly pattern for the recognizer; tells the program ot return values from the pattern
    {
        public Recognizer_DragonFly() : base("Dragonfly", 1) { }
        protected override bool patternMatchedSubset(List<candlestick> subsetOfCandlesticks)
        {
            return subsetOfCandlesticks[0].isDragonflyDoji;
        }
    }
    internal class Recognizer_NeutralDoji : aRecognizor // constructor for NeutralDoji pattern for the recognizer; tells the program ot return values from the pattern
    {
        public Recognizer_NeutralDoji() : base("Neutral Doji", 1) { }
        protected override bool patternMatchedSubset(List<candlestick> subsetOfCandlesticks)
        {
            return subsetOfCandlesticks[0].isNeutralDoji;
        }
    }
    internal class Recognizer_GravestoneDoji : aRecognizor // constructor for GravestoneDoji pattern for the recognizer; tells the program ot return values from the pattern
    {
        public Recognizer_GravestoneDoji() : base("Gravestone Doji", 1) { }
        protected override bool patternMatchedSubset(List<candlestick> subsetOfCandlesticks)
        {
            return subsetOfCandlesticks[0].isGravestoneDoji;
        }
    }
    internal class Recognizer_LongLeggedDoji : aRecognizor // constructor for LongLeggedDoji pattern for the recognizer; tells the program ot return values from the pattern
    {
        public Recognizer_LongLeggedDoji() : base("LongLegged Doji", 1) { }
        protected override bool patternMatchedSubset(List<candlestick> subsetOfCandlesticks)
        {
            return subsetOfCandlesticks[0].isLongLeggedDoji;
        }
    }
    internal class Recognizer_Hammer : aRecognizor // constructor for Hammer chart pattern for the recognizer; tells the program ot return values from the pattern
    {
        public Recognizer_Hammer() : base("Hammer", 1) { }
        protected override bool patternMatchedSubset(List<candlestick> subsetOfCandlesticks)
        {
            return subsetOfCandlesticks[0].isHammer;
        }
    }
    internal class Recognizer_BullishHammer : aRecognizor // constructor for Bullish Hammer chart pattern for the recognizer; tells the program ot return values from the pattern
    {
        public Recognizer_BullishHammer() : base("Bullish Hammer", 1) { }
        protected override bool patternMatchedSubset(List<candlestick> subsetOfCandlesticks)
        {
            return subsetOfCandlesticks[0].isBullishHammer;
        }
    }
    internal class Recognizer_BearishHammer : aRecognizor // constructor for Bearish Hammer chart pattern for the recognizer; tells the program ot return values from the pattern
    {
        public Recognizer_BearishHammer() : base("Bearish Hammer", 1) { }
        protected override bool patternMatchedSubset(List<candlestick> subsetOfCandlesticks)
        {
            return subsetOfCandlesticks[0].isBearishHammer;
        }
    }
    internal class Recognizer_invertedHammer : aRecognizor // constructor for Inverted Hammer pattern for the recognizer; tells the program ot return values from the pattern
    {
        public Recognizer_invertedHammer() : base("Inverted Hammer", 1) { }
        protected override bool patternMatchedSubset(List<candlestick> subsetOfCandlesticks)
        {
            return subsetOfCandlesticks[0].isInvertedHammer;
        }
    }
    internal class Recognizer_bullishInvertedHammer : aRecognizor // constructor for Bullish Inverted Hammer chart pattern for the recognizer; tells the program ot return values from the pattern
    {
        public Recognizer_bullishInvertedHammer() : base("Bullish Inverted Hammer", 1) { }
        protected override bool patternMatchedSubset(List<candlestick> subsetOfCandlesticks)
        {
            return subsetOfCandlesticks[0].isBullishInvertedHammer;
        }
    }
    internal class Recognizer_bearishInvertedHammer : aRecognizor // constructor for Bearish Inverted Hammer chart pattern for the recognizer; tells the program ot return values from the pattern
    {
        public Recognizer_bearishInvertedHammer() : base("Bearish Inverted Hammer", 1) { }
        protected override bool patternMatchedSubset(List<candlestick> subsetOfCandlesticks)
        {
            return subsetOfCandlesticks[0].isBearishInvertedHammer;
        }
    }
    internal class Recognizer_Marubozu : aRecognizor // constructor for Marubozu pattern for the recognizer; tells the program ot return values from the pattern
    {
        public Recognizer_Marubozu() : base("Marubozu", 1) { }
        protected override bool patternMatchedSubset(List<candlestick> subsetOfCandlesticks)
        {
            return subsetOfCandlesticks[0].isMarubozu;
        }
    }
    internal class Recognizer_whiteMarubozu : aRecognizor // constructor for White Marubozu pattern for the recognizer; tells the program ot return values from the pattern
    {
        public Recognizer_whiteMarubozu() : base("White Marubozu", 1) { }
        protected override bool patternMatchedSubset(List<candlestick> subsetOfCandlesticks)
        {
            return subsetOfCandlesticks[0].isWhiteMarubozu;
        }
    }
    internal class Recognizer_blackMarubozu : aRecognizor // constructor for Black Marubozu pattern for the recognizer; tells the program ot return values from the pattern
    {
        public Recognizer_blackMarubozu() : base("Black Marubozu", 1) { }
        protected override bool patternMatchedSubset(List<candlestick> subsetOfCandlesticks)
        {
            return subsetOfCandlesticks[0].isBlackMarubozu;
        }
    }
}
