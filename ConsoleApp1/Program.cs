using System;
using System.Linq;
using NHibernate.Cfg;
using NHibernate.Linq;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            var configuration = new Configuration();
            configuration.Configure();
            var factory = configuration.BuildSessionFactory();
            var session = factory.OpenSession();

            Console.Write("Informe o nome do contato: ");
            var name = Console.ReadLine();

            Console.Write("Informe o E-mail: ");
            var email = Console.ReadLine();

            var contact = new Contact { Name = name, Email = email };
            session.SaveOrUpdate(contact);
            session.Flush();

            Console.WriteLine("Perquisa de Contatos: ");
            Console.Write("Informe o Nome:");
            var search = Console.ReadLine();

            var contacts = session.Query<Contact>()
                .Where(p => p.Name.Contains(search))
                .ToList();

            contacts.ForEach(x =>
            {
                Console.WriteLine($"{x.Name}: {x.Email}");
            });

            Console.ReadLine();

            session.Close();
        }
    }
}
