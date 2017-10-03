using DbUp;
using System;
using System.Reflection;

namespace BookStore.Database.Launcher
{
    class Program
    {
        static string _identityDatabaseConnectionString = 
            @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=BookStore.IdentityServer;Integrated Security=True;";

        static int Main(string[] args)
        {
            EnsureDatabase.For.SqlDatabase(_identityDatabaseConnectionString);

            var upgrader =
                DeployChanges.To
                    .SqlDatabase(_identityDatabaseConnectionString)
                    .WithScriptsEmbeddedInAssembly(Assembly.GetExecutingAssembly())
                    .LogToConsole()
                    .Build();

            var result = upgrader.PerformUpgrade();

            if (!result.Successful)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(result.Error);
                Console.ResetColor();
#if DEBUG
                Console.ReadLine();
#endif
                return -1;
            }

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Success!");
            Console.ResetColor();
            Console.ReadKey();
            return 0;
        }
    }
}
