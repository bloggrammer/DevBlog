using System;
using System.IO;

public class SiteGenerator
{
    public static void Main()
    {
        DeleteOldPages();
        GeneratePages();
    }
    private static void DeleteOldPages(){
        string[] htmlFiles = Directory.GetFiles("wwwroot", "*.html", SearchOption.AllDirectories);
        foreach(var file in htmlFiles)
            File.Delete(file);

         Console.WriteLine("Pages Deleted Successfully...");
    }
    private static void GeneratePages()
    {
        string[] includePaths = Directory.GetFiles(Path.Combine("dev", "include"), "*.shtml", SearchOption.AllDirectories);
        string[] contentPaths = Directory.GetFiles(Path.Combine("dev","content"), "*.html", SearchOption.AllDirectories);
        foreach (var html in contentPaths)
        {
            var htmlString = File.ReadAllText(html);
            if (string.IsNullOrWhiteSpace(htmlString)) continue;
            var htmlName = Path.GetFileName(html);
            foreach (string path in includePaths)
            {
                var fileName = Path.GetFileName(path);
                var tag = "<!--#include virtual=\"include/"+fileName+"\" -->";

                if (htmlString.Contains(tag))
                {
                    var inject = File.ReadAllText(path);
                    htmlString = htmlString.Replace(tag, inject);
                }
            }
            File.WriteAllText(Path.Combine("wwwroot", htmlName), htmlString);
        }

        Console.WriteLine("Pages Generated Successfully...");
    }
}