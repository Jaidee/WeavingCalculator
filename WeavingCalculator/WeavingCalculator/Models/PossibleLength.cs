using System;
namespace WeavingCalculator.Models
{
    public class PossibleLength
    {
        public string MaterialLength { get; set; }
        public string MaterialLengthUnit { get; set; }
        public string ReedWidth { get; set; }
        public string ReedWidthUnit { get; set; }
        public string DrawInProcent { get; set; }
        public string Threads { get; set; }
        public string ThreadsUnit { get; set; }

        public PossibleLength()
        {
        }
    }
}
