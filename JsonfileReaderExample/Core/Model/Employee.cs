namespace JsonReaderExample
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }

        public override string ToString()
        {
            return $"Id: {Id,4}, Name: {Name, -30}, Email: {Email}";
        }
    }
}
