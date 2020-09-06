namespace LoveTrips.Core.Model
{
    public class Tip : BaseModel
    {
        public double subTotal { get; set; }
        public int generosity { get; set; }
        public override string ToString()
        {
            return subTotal.ToString();
        }
    }
}
