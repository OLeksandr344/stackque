using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ColectionsStaQD
{
    public class Document
    {
        public string Title { get; set; }
        public Document(string title)
        {
            Title = title;
        }
        public static void AddDocumentToStack(Stack<Document> stack, Document document)
        {
            stack.Push(document);
        }

        public static Document RemoveTopDocument(Stack<Document> stack)
        {
            Document removedDocument = stack.Pop();
            return removedDocument;
        }

        public static void PrintTopDocumentInfo(Stack<Document> stack)
        {
            Document topDocument = stack.Peek();
            Console.WriteLine(topDocument.Title);
        }

    }
    public class Order
    {
        public string Name { get; set; }
        public Order(string orderName)
        {
            Name = orderName;
        }
        public static void AddOrderToQueue(Queue<Order> queue, Order order)
        {
            queue.Enqueue(order);
        }
        public static void RemoveOldestOrder(Queue<Order> queue)
        {
            Order removedOrder = queue.Dequeue();
        }
        public static Order GetOldestOrderInfo(Queue<Order> queue)
        {
            Order oldestOrder = queue.Peek();
            return oldestOrder;
        }
        public static void PrintOldestOrderInfo(Queue<Order> queue)
        {
            Order oldestOrder = queue.Peek();
            Console.WriteLine($"Oldest order: {oldestOrder.Name}");
        }
    }
    public class Book
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public int Year { get; set; }

        public  Book(int id, string title, string author, int year)
        {
            Id = id;
            Title = title;
            Author = author;
            Year = year;
        }
        public static void AddBookToCatalog(Dictionary<int, Book> catalog, Book book)
        {
            catalog.Add(book.Id, book);
        }

        public static void RemoveBookFromCatalog(Dictionary<int, Book> catalog, int bookId)
        {
             catalog.Remove(bookId);      
        }

        public static void PrintBookInfo(Dictionary<int, Book> catalog, int bookId)
        {
            Book book = catalog[bookId];
            Console.WriteLine($"Book Information:\nID: {book.Id}\nTitle: {book.Title}\nAuthor: {book.Author}\nYear: {book.Year}");
        }
    }
}


