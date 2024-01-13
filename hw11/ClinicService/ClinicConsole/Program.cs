using ClinicService.Data;

namespace ClinicConsole
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Выберите:");

                Console.WriteLine("1. Вывод");
                Console.WriteLine("2. Удалить");
                Console.WriteLine("3. Добавить");
                Console.WriteLine("0. Выход");
                var choosen = Console.ReadLine();

                if (int.TryParse(choosen, out var choosenInt))
                {
                    switch (choosenInt)
                    {
                        case 0:
                            Console.WriteLine("\nBye!\n");
                            return;
                        case 1:
                            ShowAll();
                            break;
                        case 2:
                            Delete();
                            break;
                        case 3:
                            Add();
                            break;
                    }
                }
            }

        }

        private static void Add()
        {
            Console.WriteLine("Добавить! ");

            var newClient = new CreateClientRequest();

            Console.Write("Фамилия: ");
            newClient.SurName = Console.ReadLine();

            Console.Write("Имя: ");
            newClient.FirstName = Console.ReadLine();

            Console.Write("Отчество: ");
            newClient.Patronymic = Console.ReadLine();

            Console.Write("Дата рождения: ");
            newClient.Birthday = DateTime.Parse(Console.ReadLine()!);

            Console.Write("Документ: ");
            newClient.Document = Console.ReadLine();

            var clinicClient = new ClinicServiceClient("http://localhost:5036/", new HttpClient());

            var cnt = clinicClient.ClientCreateAsync(newClient).Result;
            Console.WriteLine("Добавлено: " + cnt);
        }

        private static void Delete()
        {
            Console.Write("Удалить! Id: ");
            var choosen = Console.ReadLine();

            if (int.TryParse(choosen, out var choosenInt))
            {
                var clinicClient = new ClinicServiceClient("http://localhost:5036/", new HttpClient());

                var cnt = clinicClient.ClientDeleteAsync(choosenInt).Result;
                Console.WriteLine("Удалено: " + cnt);
            }
        }

        private static void ShowAll()
        {
            var clinicClient = new ClinicServiceClient("http://localhost:5036/", new HttpClient());

            List<Client> clients = clinicClient.ClientGetAllAsync().Result.ToList();

            foreach (Client client in clients)
            {
                Console.WriteLine("Id: " + client.ClientId);
                Console.WriteLine("Фамилия: " + client.SurName);
                Console.WriteLine("Имя: " + client.FirstName);
                Console.WriteLine("Отчество: " + client.Patronymic);
                Console.WriteLine("Дата рождения: " + client.Birthday.DateTime);
                Console.WriteLine("Документ: " + client.Document);
                Console.WriteLine();
            }
        }
    }
}
