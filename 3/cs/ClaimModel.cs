using System;
using System.Linq;
namespace cs
{
    ///<summary>
    /// Fabric claim model class
    ///</summary>
    public class ClaimModel
    {
        ///<summary>
        /// The ID of the claim
        ///</summary>
        public string ClaimId { get; set; }
        
        ///<summary>
        /// The number of inches between the left edge of the fabric and the left edge of the rectangle.
        ///</summary>
        public int LeftEdge { get; set; }

        ///<summary>
        /// The number of inches between the top edge of the fabric and the top edge of the rectangle.
        ///</summary>
        public int TopEdge { get; set; }

        ///<summary>
        /// The width of the rectangle in inches.
        ///</summary>
        public int Width { get; set; }

        ///<summary>
        /// The height of the rectangle in inches.
        ///</summary>
        public int Height { get; set; }
        public ClaimModel() { }
        public ClaimModel(string row)
        {
            this.ClaimId = row.Substring(1, row.IndexOf('@') - 1).Trim();
            var LeftTopGroupPartial = row.Substring(row.IndexOf('@') + 1);
            var LeftTopGroup = LeftTopGroupPartial.Remove(LeftTopGroupPartial.IndexOf(":")).Trim().Split(",");
            this.LeftEdge = int.Parse(LeftTopGroup[0]);
            this.TopEdge = int.Parse(LeftTopGroup[1]);
            var dClaim = row.Substring(row.IndexOf(':')+2).Trim().Split("x");
            this.Width = int.Parse(dClaim[0]);
            this.Height = int.Parse(dClaim[1]);
        }
    }

    public static class ClaimModelExtension
    {
        public static void PrintProperties(this ClaimModel model)
        {
            Console.WriteLine($"Claim ID : {model.ClaimId}");
            Console.WriteLine($"Claim distance from left edge : {model.LeftEdge}");
            Console.WriteLine($"Claim distance from top edge : {model.TopEdge}");
            Console.WriteLine($"Claim width : {model.Width}");
            Console.WriteLine($"Claim height : {model.Height}");
        }
    }
}