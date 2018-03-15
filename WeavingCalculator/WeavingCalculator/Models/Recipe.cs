using System;
namespace WeavingCalculator.Models
{
    public class Recipe
    {
        // RecipeHeader
        public string RecipeId { get; set; }
        public string Status { get; set; }
        public string Name { get; set; }
        public DateTime Date { get; set; }
        public string Threading { get; set; }
        public int NoOfHarness { get; set; }  
        public int NoOfTreadles { get; set; }
        public string UnitType { get; set; }
        // Materials
        public string WarpMaterials { get; set; }
        public int WarpYardageLength { get; set; }
        public string WarpUnitWeight { get; set; }
        public string WarpUnitLength { get; set; }
        public string WeftMaterials { get; set; }
        public int WeftYardageLength { get; set; }
        public string WeftUnitWeight { get; set; }
        public string WeftUnitLength { get; set; }
        // Density
        public int WarpThreads { get; set; }
        public string WarpThreadsUnit { get; set; }
        public int WeftThreads { get; set; }
        public string WeftThreadsUnit { get; set; }
        public string Reed { get; set; }
        public int ThreadsInHeddle { get; set; }
        public int ThreadsInDents { get; set; }
        // Warp
        public string FinishedFabricWidth { get; set; }
        public string WidthShringLoomWaste { get; set; }
        public string WidthOfReed { get; set; }
        public int NumberOfThreads { get; set; }
        public int WidthSelvage { get; set; }
        public int WarpTotalNumberThreads { get; set; }
        public string FinishFabricLength { get; set; }
        public string LengthSampling { get; set; }
        public string LengthShrinkLoomWaste { get; set; }
        public string WeawingLength { get; set; }
        public string LengthTakeUp { get; set; }
        public string LengthThrump { get; set; }
        public string WarpTotalLength { get; set; }
        // Weft
        public int WeftTotalNumberThreads { get; set; }
        public int DrawInProcent { get; set; }
        public string DrawIn { get; set; }
        public string WeftTotalLength { get; set; }
        // Yarn Usage
        public string WarpWeight { get; set; }
        public string WeftWeight { get; set; }

        public Recipe()
        {
            
        }
    }
}
