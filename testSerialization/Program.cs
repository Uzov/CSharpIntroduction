using System.Text.Json;

namespace SerializeBasic
{
    public class listHolidays
    {
        public int year { get; set; }
        public listMonths[]? months { get; set; }
    }

    public class listMonths
    {
        public int month { get; set; }
        public string days { get; set; }
    }


    public class Program
    {
        public static void Main()
        {
            var listHolidays = new listHolidays
            {
                year = 2023,
                months = new[] { listMonths }
            };

            string jsonString = JsonSerializer.Serialize(listHolidays);

            Console.WriteLine(jsonString);
        }
    }
}