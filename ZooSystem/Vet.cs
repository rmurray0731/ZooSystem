namespace ZooSystem
{
    class Vet
    {
        string name;
        string userName;
        string password;

        public void SetName(string name)
        {
            this.name = name;
        }

        public string GetName() { return name; }

        public void SetUserName(string userName) { this.userName = userName; }

        public string GetUserName() { return userName; }

        public void SetPassword(string password) { this.password = password; }

        public string GetPassword() { return password; }
    }
}
