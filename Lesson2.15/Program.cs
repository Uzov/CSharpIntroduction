/*
Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
6 -> да
7 -> да
1 -> нет

Список литературы:
https://metanit.com/sharp/tutorial/
https://zetcode.com/csharp/httpclient/
https://www.c-sharpcorner.com/UploadFile/manas1/string-to-datetime-conversion-in-C-Sharp/
 */

using System.Globalization;
using System.Net.Http.Headers;

internal class Program
{
    //Асинхронный метод Main имеет в определении перед возвращаемым типом модификатор async,
    //его возвращаемым типом является Task, и в теле метода определено выражение await.
    //Main не возвращает никакого объекта Task, однако поскольку в теле метода применяется
    //выражение await, то в качестве возвращаемого типа можно использовать тип Task.
    private static async Task Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine("Введите дату в формате dd-MM-yyyy:");
            //string? searchDate = Console.ReadLine()!;
            string searchDate = "04-04-2023";
            CultureInfo provider = CultureInfo.InvariantCulture;
            //Обработка исключения на правильный ввод даты 
            try
            {
                DateTime dateTime = DateTime.ParseExact(searchDate, "dd-MM-yyyy", provider);
                int year = dateTime.Date.Year; //год
                int month = dateTime.Date.Month; // месяц
                int date = dateTime.Date.Day; // число
            //client - экземпляр класса HttpClient().
            using (var client = new HttpClient())
            {
                //Добавляем параметры в заголовок http.
                client.BaseAddress = new Uri("http://xmlcalendar.ru/data/ru/");
                client.DefaultRequestHeaders.Add("User-Agent", "C# console program");
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                var url = $"{Convert.ToString(year)}/calendar.json";
                //Делаем асинхронный http запрос, тип запроса get (получить реурс).
                HttpResponseMessage response = await client.GetAsync(url);
                //Обработка исключения на успешность http запроса.
                try
                {
                    response.EnsureSuccessStatusCode();
                        string json = await response.Content.ReadAsStringAsync();
                    Console.WriteLine(json);
                }
                catch (HttpRequestException)
                {
                    Console.WriteLine("Ошибка. Не удалось получить HTTP ответ!"); ;
                }
            }
            }
            catch (FormatException)
            {
                Console.WriteLine("Ошибка. Неверный формат даты!");
            }
            Console.WriteLine("Нажмите любую клавишу или введите 'q' и нажмите Enter для выхода.");
            if (Console.ReadLine() == "q") break;
        }
    }
}