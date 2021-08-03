namespace Domain.Contracts
{
    public class UserResponse
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Username { get; set; }

        public int RolId { get; set; }

        public string RolName { get; set; }
    }
}
