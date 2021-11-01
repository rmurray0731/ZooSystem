namespace ZooSystem
{
    class Animal
    {
        string name;
        string type;
        int age;

        public void SetName(string name)
        {
            this.name = name;
        }

        public string GetName() { return name; }

        public void SetAnimalType(string ty) { type = ty; }

        public string GetAnimalType() { return type; }

        public void SetAge(int age) { this.age = age; }

        public int GetAge() { return age; }

    }
}
