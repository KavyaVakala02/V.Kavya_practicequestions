using System;
using System.IO;

namespace practicequestions
{
    class Report : IPrintable, ISerializable
    {
        public string Title { get; set; }
        public string Content { get; set; }

        public Report(string title, string content)
        {
            Title = title;
            Content = content;
        }

        public void Print()
        {
            Console.WriteLine($"Report Title: {Title}\nContent: {Content}");
        }

        public void SaveToFile(string filename)
        {
            File.WriteAllText(filename, $"Title: {Title}\nContent: {Content}");
            Console.WriteLine($"Report saved to {filename}");
        }
    }
}
