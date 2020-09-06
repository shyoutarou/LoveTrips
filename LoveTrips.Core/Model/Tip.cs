namespace LoveTrips.Core.Model
{
    public class Tip : BaseModel
    {
        public double subTotal { get; set; }
        public int generosity { get; set; }
        public override string ToString()
        {
            extra_tip = 10;
            if(generosity < 50) extra_tip = 2;
            return (extra_tip + (subTotal * generosity / 100.0)).ToString();
        }
    }
}
