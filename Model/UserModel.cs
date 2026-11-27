namespace Model
{
    public class UserModel
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public string Role { get; set; }
        public string FullName { get; set; }
        public bool IsActive { get; set; } = true;

        public void Clear()
        {
            Username = null;
            Password = null;
            Role = null;
            FullName = null;
        }
    }
}
