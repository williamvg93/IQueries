using Newtonsoft;
using System.Linq;
using IQueries.entities;
internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        /* int?[] args2 */
        LinqQueries queries = new LinqQueries();
/*         PrintData(queries.AllCollection());
        PrintData(queries.SearName());
        PrintData(queries.ShearcNameYear()); 
        PrintData(queries.ShearcNamePages());
        Console.WriteLine(queries.IfStatusNoNuLL());
        Console.WriteLine(queries.GetBooks2005()); */
        if (queries.GetBooks2005())
        {
            PrintData(queries.GetBookByYear(2005));
        } else {
            Console.WriteLine("There are no books published in that year");
        }


        
        /* PrintData(queries.GetDataByQuery("PublishedDate")); */

    }
    private static void PrintData(IEnumerable<Book> books) {
        int data = 0;
        Console.Clear();
        Console.ForegroundColor = ConsoleColor.DarkBlue;
        Console.WriteLine("{0,-70} {1,7} {2,20}", "Title", "# Page", "Publication Date");
        Console.WriteLine();
        foreach (Book book in books)
        {
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            data += 1;
            Console.WriteLine("{0,-70} {1,7} {2,20}", book.Title, book.PageCount, book.PublishedDate.ToShortDateString());
        }
    }

    private static void PrintDataGroup(IEnumerable<IGrouping<int,Book>> books){

    }

/*     private static void PrintDataBookYear(IEnumerable<Book> books) {
        int data = 0;
        Console.Clear();
        Console.ForegroundColor = ConsoleColor.DarkBlue;
        Console.WriteLine("{0,-70} {1,7} {2,20}", "Title", "# Page", "Publication Date");
        Console.WriteLine();
        foreach (Book book in books)
        {
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            data += 1;
            Console.WriteLine("{0,-70} {1,7} {2,20}", book.Title, book.PageCount, book.PublishedDate.ToShortDateString());
        }
    } */
    

}