using System;
using Telegram.Bot;
using Telegram.Bot.Args;

namespace telegramBot
{
    public class TGBot
    {
        static TelegramBotClient Bot = new TelegramBotClient("1433082577:AAFtoVW7Tq4aqZj4oN7K1uMt5i_rC4kXRIw");

        static void Main(string[] args)
        {
            Bot.StartReceiving();
            Bot.OnMessage += Bot_OnMessage;
            Console.ReadLine();
        }

        private static void Bot_OnMessage(object sender, Telegram.Bot.Args.MessageEventArgs e)
        {
            if (e.Message.Type == Telegram.Bot.Types.Enums.MessageType.Text)
            {
                TGBot bot = new TGBot();
                if (e.Message.Text.Equals("!sticky"))
                {
                    bot.GetPostType(1);
                }

                if (e.Message.Text.Equals("!new"))
                {
                    bot.GetPostType(2);
                }

                if (e.Message.Text.Equals("!rising"))
                {
                    bot.GetPostType(3);
                }

                if (e.Message.Text.Equals("!top"))
                {
                    bot.GetPostType(4);
                }

            }
        }

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
            bool isRunning = true;
            while (isRunning)
            {
                foreach (var item in doc.DocumentNode.SelectNodes("//*[contains(@class, 'post')]"))
                {
                    Console.Write("------------------------------------------------");
                    Console.WriteLine(item.InnerText);
                    Console.Write("------------------------------------------------");
                }
            }

        }

    }
}
