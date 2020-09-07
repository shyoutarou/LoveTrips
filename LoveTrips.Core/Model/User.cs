namespace LoveTrips.Core.Model
{
    public class User : BaseModel
    {
        public int UserId { get; set; }

        public string UserName { get; set; }

        public string SurName { get; set; }

        public string Email { get; set; }

        public string Password { get; set; }

        public override string ToString()
        {
            return UserName + " " + SurName;
        }
    }
}
