using System;

class NewsAgency
{
    
    public delegate void NewsHandler(string topic, string news);
    public event NewsHandler OnNewsPublished;

    public void Publish(string topic, string news)
    {
        Console.WriteLine($"\n[NewsAgency] Publishing {topic} news: {news}");
        OnNewsPublished?.Invoke(topic, news);
    }
}