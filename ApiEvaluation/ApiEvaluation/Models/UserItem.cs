namespace ApiEvaluation.Models
{
    public class UserItem
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public string Email { get; set; }

        public int Phone { get; set; }

        public UserType Status { get; set; }  
    }
}
