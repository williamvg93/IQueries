using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Linq;
using Newtonsoft;

namespace IQueries.entities
{
    public class LinqQueries
    {

        List<Book> bookList = new List<Book>();

        public LinqQueries(){
            using(StreamReader reader = new StreamReader("books.json")){
                string json = reader.ReadToEnd();
                this.bookList = System.Text.Json.JsonSerializer.Deserialize<List<Book>>(json, new System.Text.Json.JsonSerializerOptions(){PropertyNameCaseInsensitive = true}) ?? new List<Book>();
            }
        }

        public IEnumerable<Book> AllCollection(){
            return bookList;
        }

/*         public IEnumerable<Book> GetDataByQuery(string paginas){
            return bookList.Where(book => book.paginas.Year < 2000);
        }
 */
        public IEnumerable<Book> GetBookByYear(int year){
            return bookList.Where(book => book.PublishedDate.Year == year);
            /* return from book in bookList where book.PublishedDate.Year > 2000 select book; */
        }

        public IEnumerable<Book> GetBookAfterYear(int year){
            return bookList.Where(book => book.PublishedDate.Year > year);
        }
        public IEnumerable<Book> GetBookBeforeYear(int year){
            return bookList.Where(book => book.PublishedDate.Year < year);
        }

        public IEnumerable<Book> ShearcNameYear(){
            return bookList.Where(book => book.PublishedDate.Year > 2005 && book.Title.Contains("Android"));
            /* return from book in bookList where book.PublishedDate.Year > 2000 select book; */
        }

        public IEnumerable<Book> ShearcNamePages(){
            return bookList.Where(book => book.PageCount > 250 && book.Title.Contains("Action"));
            /* return from book in bookList where book.PublishedDate.Year > 2000 select book; */
        }

        public IEnumerable<Book> SearName(){
            return bookList.Where(book => book.Title.Contains("Android"));
            /* return from book in bookList where book.PublishedDate.Year > 2000 select book; */
        }

        public bool IfStatusNoNuLL(){
            return bookList.All(book => book.Status != String.Empty);
        }
        public bool GetBooks2005(){
            return bookList.Any(book => book.PublishedDate.Year == 2005);
        }
        
    }
}