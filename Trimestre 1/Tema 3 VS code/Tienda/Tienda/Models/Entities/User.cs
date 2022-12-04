namespace Models
{
    public class User
    {
        public int id_staff { get; set; }
        public string password { get; set; }
        public string role { get; set; }

        public User(int id_staff, string password, string role)
        {
            this.id_staff = id_staff;
            this.password = password;
            this.role = role;
        }
    }
}
