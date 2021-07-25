namespace VehicleManagement.Domain.Entities
{
    public class User : Entity 
    {
        public User() { }

        public User(string username, string password, string role)
        {
            Username = username;
            Password = password;
            Role = role;
        }
        
        public string Username { get; private set; }
        public string Password { get; private set; }
        public string Role { get; private set; }
    }
}