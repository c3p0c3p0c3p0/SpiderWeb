using System;
using tdwscraper;
using Telegram.Bot;

namespace telegramBot
{
    public class TGBot
    {
        static TelegramBotClient Bot = new TelegramBotClient("");

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
                Scrape scraper = new Scrape();
                if (e.Message.Text.Equals("!sticky"))
                {
                    scraper.GetPostType(1);
                }

                if (e.Message.Text.Equals("!top"))
                {
                    scraper.GetPostType(2);
                }

                if (e.Message.Text.Equals("!rising"))
                {
                    scraper.GetPostType(3);
                }

                if (e.Message.Text.Equals("!new"))
                {
                    scraper.GetPostType(4);
                }

            }
        }

    }
}
