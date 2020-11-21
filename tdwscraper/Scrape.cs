using System;
using System.Collections.Generic;
using System.Text;

namespace tdwscraper
{
    public class Scrape
    {

        public void GetPostType(int choice)
        {
            switch (choice)
            {
                case 1:
                    GetPosts("https://thedonald.win/");
                    break;
                case 2:
                    GetPosts("https://thedonald.win/new");
                    break;
                case 3:
                    GetPosts("https://thedonald.win/rising");
                    break;
                case 4:
                    GetPosts("https://thedonald.win/top");
                    break;
            }
        }

        public void GetPosts(string url)
        {
            HtmlAgilityPack.HtmlWeb web = new HtmlAgilityPack.HtmlWeb();
            HtmlAgilityPack.HtmlDocument doc = web.Load(url);
            foreach (var item in doc.DocumentNode.SelectNodes("//*[contains(@class, 'post')]"))
            {
                Console.Write("------------------------------------------------");
                Console.WriteLine(item.InnerText);
                Console.Write("------------------------------------------------");
            }
        }

    }
}
