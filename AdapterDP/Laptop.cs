namespace AdapterDP
{
    public class Laptop
    {

        private string _name { get; set; }

        public Laptop(string name)
        {
            _name = name;
        }

        public string getName()
        {
            return _name;
        }
    }
}
