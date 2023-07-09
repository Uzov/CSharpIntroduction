Message mes;            // 2. Создаем переменную делегата
mes = Hello;            // 3. Присваиваем этой переменной адрес метода
mes();                  // 4. Вызываем метод

void Hello() => Console.WriteLine("Hello METANIT.COM");

delegate void Message();