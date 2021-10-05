using Newtonsoft.Json;
using System.IO;

namespace JsonReaderExample
{
    public class EmployeeJsonRepository : JsonFileRepository<Employee>
    {
        public EmployeeJsonRepository(TextReader reader) : base(reader)
        {
        }

        public override Employee ReadOneItem(JsonTextReader reader)
        {
            Employee e = new Employee();

            reader.Read();
            e.Id = (int)reader.ReadAsInt32();

            reader.Read();
            e.Name = reader.ReadAsString();

            reader.Read();
            e.Email = reader.ReadAsString();
            
            return e;
        }
    }
}
