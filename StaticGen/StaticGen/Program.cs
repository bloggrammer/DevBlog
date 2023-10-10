using System.Collections.Generic;
using System.Net.Http;
using static System.Net.Mime.MediaTypeNames;

namespace StaticGen
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string bPath = "C:\\Users\\lenovo\\Documents\\Projects\\2023\\OCT\\www\\bloggrammer\\html";
            string tPath = "C:\\Users\\lenovo\\Documents\\Projects\\2023\\ME\\www\\techinterviewsolutions.net\\html";

            GenerateHTML(bPath);
            GenerateHTML(tPath);

            Replace(bPath, "http://localhost", "https://bloggrammer.com");
             Replace(tPath, "http://localhost", "https://techinterviewsolutions.net");
        }

        public static void Replace(string baseDirectory, string oldText, string newText)
        {
            var contentPaths = Directory.GetFiles(baseDirectory, "*.html", SearchOption.AllDirectories);
           
            ReplaceText(oldText, newText, contentPaths);
        }

        private static void ReplaceText(string oldContent, string newContent, string[] includePaths)
        {
            foreach (var includePath in includePaths)
            {
                string text = File.ReadAllText(includePath);
                text = text.Replace(oldContent, newContent);
                File.WriteAllText(includePath, text);
            }
        }
        private static void GenerateHTML(string contentDirectory)
        {
            var includePaths = Directory.GetFiles(contentDirectory, "*.shtml", SearchOption.AllDirectories);
            var contentPaths = Directory.GetFiles(contentDirectory, "*.html", SearchOption.AllDirectories);
            var map = new Dictionary<string, string>();

            foreach (var includePath in includePaths)
            {
                var htmlName = Path.GetFileName(includePath);
                var htmlString = File.ReadAllText(includePath);
                
                if (string.IsNullOrWhiteSpace(htmlString)) continue;

                foreach (var path in includePaths)
                {
                    var includeName = Path.GetFileName(path);

                    var tag = $"<!--#include file=\"/include/{includeName}\" -->";
                    var tag1 = $"<!--#include file=\"/include/static/{includeName}\" -->";
                    if (htmlString.Contains(tag))
                    {
                        var include = File.ReadAllText(path);
                        htmlString = htmlString.Replace(tag, include);
                    }else if (htmlString.Contains(tag))
                    {
                        var include = File.ReadAllText(path);
                        htmlString = htmlString.Replace(tag1, include);
                    }
                    if (map.ContainsKey(includePath))
                        map[includePath] = htmlString;
                    else if (!map.ContainsKey(path))
                        map.Add(path, htmlString);
                }
            }
            foreach (var contentPath in contentPaths)
            {
                var htmlString = File.ReadAllText(contentPath);
                if (string.IsNullOrWhiteSpace(htmlString)) continue;
                foreach (var path in map)
                {
                    var includeName = Path.GetFileName(path.Key);

                    var tag = $"<!--#include file=\"/include/{includeName}\" -->";
                    var tag1 = $"<!--#include file=\"/include/static/{includeName}\" -->";
                    if (htmlString.Contains(tag))
                    {
                        //var include = File.ReadAllText(path.Key);
                        htmlString = htmlString.Replace(tag, path.Value);
                    }
                    else if (htmlString.Contains(tag1))
                    {
                        htmlString = htmlString.Replace(tag1, path.Value);
                    }
                }
                File.WriteAllText(contentPath, htmlString);
            }
        }
    }
}