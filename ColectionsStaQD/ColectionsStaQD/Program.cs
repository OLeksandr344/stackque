using ColectionsStaQD;
using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {       
        Stack<Document> documentStack = new Stack<Document>();
        Document.AddDocumentToStack(documentStack, new Document("Document1"));
        Document.AddDocumentToStack(documentStack, new Document("Document2"));
        Document.AddDocumentToStack(documentStack, new Document("Document3"));
        Document.PrintTopDocumentInfo(documentStack);
        Document.RemoveTopDocument(documentStack);
        Document.PrintTopDocumentInfo(documentStack);

        Queue<Order> orderQueue = new Queue<Order>();
        Order.AddOrderToQueue(orderQueue, new Order("Order1"));
        Order.AddOrderToQueue(orderQueue, new Order("Order2"));
        Order.AddOrderToQueue(orderQueue, new Order("Order3"));
        Order.PrintOldestOrderInfo(orderQueue);
        Order.RemoveOldestOrder(orderQueue);
        Order.PrintOldestOrderInfo(orderQueue);

        Dictionary<int, Book> bookCatalog = new Dictionary<int, Book>();
        Book.AddBookToCatalog(bookCatalog, new Book(1, "Book1", "Author1", 2022));
        Book.AddBookToCatalog(bookCatalog, new Book(2, "Book2", "Author2", 2020));
        Book.AddBookToCatalog(bookCatalog, new Book(3, "Book3", "Author3", 2018));
        Book.PrintBookInfo(bookCatalog, 2);
        Book.RemoveBookFromCatalog(bookCatalog, 1);

    }

    
}


