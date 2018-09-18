using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Library;


namespace OutputViewer
{
    class Program
    {
        static void Main(string[] args)
        {
            StandardCatalog standardCatalog = new StandardCatalog();
            ISaveable saveable = new StandardCatalog();
            IPersistable persistable = new StandardCatalog();

            Console.WriteLine("Standard Implementation");
            Console.WriteLine("Concrete Class:  {0}", standardCatalog.Save());
            Console.WriteLine("ISaveable:       {0}", saveable.Save());
            Console.WriteLine("IPersistable:    {0}", persistable.Save());
            Console.WriteLine();

            Console.WriteLine("Concrete Class:           {0}", standardCatalog.Save());
            Console.WriteLine("(ISaveable)Catalog:       {0}", ((ISaveable)saveable).Save());
            Console.WriteLine("(IPersistable)Catalog:    {0}", ((IPersistable)persistable).Save());
            Console.WriteLine();

            Console.WriteLine("==========================================================");

            ExplicitCatalog explicitCatalog = new ExplicitCatalog();
            saveable = new ExplicitCatalog();
            persistable = new ExplicitCatalog();

            Console.WriteLine("Explicit Implementation");
            Console.WriteLine("Concrete Class:  {0}", explicitCatalog.Save());
            Console.WriteLine("ISaveable:       {0}", saveable.Save());
            Console.WriteLine("IPersistable:    {0}", persistable.Save());
            Console.WriteLine();

            Console.WriteLine("Concrete Class:           {0}", explicitCatalog.Save());
            Console.WriteLine("(ISaveable)Catalog:       {0}", ((ISaveable)explicitCatalog).Save());
            Console.WriteLine("(IPersistable)Catalog:    {0}", ((IPersistable)explicitCatalog).Save());
            Console.WriteLine();
        }
    }
}
