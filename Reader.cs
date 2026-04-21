using System;

class Reader
{
    public string Name { get; set; }
    public string InterestedTopic { get; set; }

    public Reader(string name, string topic)
    {
        Name = name;
        InterestedTopic = topic;
    }

    // Method to receive news
    public void ReceiveNews(string topic, string news)
    {
        if (topic == InterestedTopic)
        {
            Console.WriteLine($"{Name} received {topic} news: {news}");
        }
    }
}