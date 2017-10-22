using DbUp;
using System;
using System.Reflection;

namespace BookStore.Database.Launcher
{
    class Program
    {
        static string identityConnectionString =   @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=BookStore.IdentityServer;Integrated Security=True;";
        static string bookConnectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=BookStore.Book;Integrated Security=True;";
        static string purchaseConnectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=BookStore.Purchase;Integrated Security=True;";

        static Assembly identityServerAssembly = Assembly.Load("BookStore.Database.IdentityServer");
        static Assembly bookAssembly = Assembly.Load("BookStore.Database.Book");
        static Assembly purchaseAssembly = Assembly.Load("BookStore.Database.Purchase");

        static void Main(string[] args)
        {
            RunMigrations(identityConnectionString, identityServerAssembly);
            RunMigrations(bookConnectionString, bookAssembly);
            RunMigrations(purchaseConnectionString, purchaseAssembly);
        }

        static void RunMigrations (string connectionString, Assembly assemblyWithScripts)
        {
            EnsureDatabase.For.SqlDatabase(connectionString);

            var upgrader =
                DeployChanges.To
                    .SqlDatabase(connectionString)
                    .WithScriptsEmbeddedInAssembly(assemblyWithScripts)
                    .LogToConsole()
                    .Build();

            var result = upgrader.PerformUpgrade();

            if (!result.Successful)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(result.Error);
                Console.ResetColor();
#if DEBUG
                Console.WriteLine("Press any key to continue ...");
                Console.ReadKey();
#endif
            }

#if DEBUG
            Console.WriteLine("Press any key to continue ...");
            Console.ReadKey();
#endif
        }
    }
}
