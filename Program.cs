using System;

class Program
{
    static void Main()
    {
        NewsAgency agency = new NewsAgency();

        Reader r1 = new Reader("Aman", "Sports");
        Reader r2 = new Reader("Sai", "Politics");
        Reader r3 = new Reader("Raj", "Entertainment");

        agency.OnNewsPublished += r1.ReceiveNews;
        agency.OnNewsPublished += r2.ReceiveNews;
        agency.OnNewsPublished += r3.ReceiveNews;

        agency.Publish("Sports", "India won the match!");
        agency.Publish("Politics", "New policy announced.");
        agency.Publish("Entertainment", "New movie released!");

        Console.ReadLine();
    }
}