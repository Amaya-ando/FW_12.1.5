namespace FW_12._1._5
{
    class Program
    {
        public static void Main(string[] args)
        {
            List<User> users = new List<User>()
            {
                new User() { Login = "Maxon1995", Name = "Максим", IsPremiun = false },
                new User() { Login = "Agent007cool", Name = "Роман", IsPremiun = true },
            };

            Console.WriteLine("Уточните ваш логин, пожалуйста..");

            while (true)
            {
                var login = Console.ReadLine();
                bool checkbox = true;

                foreach (var user in users)
                {
                    if (user.Login == login)
                    {
                        if (user.IsPremiun)
                        {
                            Console.WriteLine($"Привет, {user.Name}! У вас премиум подписка, поздравляю! ");
                            checkbox = false;
                            break;
                        }
                        else
                        {
                            Console.WriteLine($"Привет, {user.Name}! \nУ вас отсутствует премиум подписка, пожалуйста, ознакомьтесь с нашими партнерами: ");
                            ShowAds();
                            checkbox = false;
                            break;
                        }

                    }
                }

                if (checkbox)
                {
                    Console.WriteLine("Данный логин отсутствует, попробуйте еще раз..");
                }
                else
                {
                    break;
                }
            }

            Console.ReadKey();
        }
        public static void ShowAds()
        {
            Console.WriteLine("Посетите наш новый сайт с бесплатными играми free.games.for.a.fool.com");
            // Остановка на 1 с
            Thread.Sleep(1000);

            Console.WriteLine("Купите подписку на МыКомбо и слушайте музыку везде и всегда.");
            // Остановка на 2 с
            Thread.Sleep(2000);

            Console.WriteLine("Оформите премиум-подписку на наш сервис, чтобы не видеть рекламу.");
            // Остановка на 3 с
            Thread.Sleep(3000);
        }
    }

    class User
    {

        public string Login { get; set; }
        public string Name { get; set; }
        public bool IsPremiun { get; set; }

    }
}

