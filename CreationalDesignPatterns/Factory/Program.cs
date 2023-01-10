using CreationalDesignPatterns.Factory;

Console.WriteLine("Digite o sistema operacional desejado: windows ou web ?");
string os = Console.ReadLine() ?? "";

ApplicationInitializer Application = new ApplicationInitializer(os);

Application?.Dialog?.Render();