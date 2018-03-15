using System;
using System.Globalization;

namespace WeavingCalculator
{
    public class Converters
    {
        public string LengthConverter(string valueIn, string cfrom, string cto)
        {
            // Index in arrays are inches. feets. yards, centmeters, meters
            double[] inches = { 1d, 0.0833d, 0.0278d, 2.54d, 0.0254d };
            double[] feets =  { 12d, 1d, 0.33d, 30.48d, 0.3048d };
            double[] yards =  { 36d, 3d, 1d, 91.44d, 0.91d};
            double[] centimeters = { 0.394d, 0.033d, 0.0109d, 1d, 0.01d };
            double[] meters = { 39.37d, 3.28d, 1.090d, 100d, 1d };

            double _valueIn = double.Parse(valueIn, CultureInfo.InvariantCulture);
            int index = 0;
            double faktor = 0d;

            switch (cto)
            {
                case "in": index = 0; break;
                case "ft": index = 1; break;
                case "yd": index = 2; break;
                case "cm": index = 3; break;
                case "m": index = 4; break;
            }

            switch (cfrom)
            {
                case "in": faktor = inches[index]; break;
                case "ft": faktor = feets[index]; break;
                case "yd": faktor = yards[index]; break;
                case "cm": faktor = centimeters[index]; break;
                case "m": faktor = meters[index]; break;    
            }

            double valueOut = _valueIn * faktor;

            return valueOut.ToString(CultureInfo.InvariantCulture);
        }

        public string WeightConverter(string valueIn, string cfrom, string cTo)
        {
            // Index in arrays are ounces, pounds, stones, grams, kilograms
            double[] ounces = { 1d, 0.0625d, 0.0045d, 28.35d, 0.02835d };
            double[] pounds = { 16d, 1d, 0.0714d, 453.59d, 0.4535d };
            double[] stones = { 224d, 14d, 1d, 6350.3d, 6.3503d };
            double[] grams = { 0.035d, 0.0022d, 0.0002d, 1d, 0.001d };
            double[] kilograms = { 35.274d, 2.205d, 0.1575d, 1000d, 1d };

            double _valueIn = double.Parse(valueIn, CultureInfo.InvariantCulture);
            int index = 0;
            double faktor = 0d;

            switch (cTo)
            {
                case "oz": index = 0; break;
                case "lb": index = 1; break;
                case "st": index = 2; break;
                case "gr": index = 3; break;
                case "kg": index = 4; break;
            }

            switch (cfrom)
            {
                case "oz": faktor = ounces[index]; break;
                case "lb": faktor = pounds[index]; break;
                case "st": faktor = stones[index]; break;
                case "gr": faktor = grams[index]; break;
                case "kg": faktor = kilograms[index]; break;
            }

            double valueOut = _valueIn * faktor;

            return valueOut.ToString(CultureInfo.InvariantCulture);
        }
    }
}
