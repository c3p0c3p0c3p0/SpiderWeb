using System;
using Telegram.Bot;
using Telegram.Bot.Args;
using Telegram.Bot.Types;
using Telegram.Bot.Types.Enums;
using Telegram.Bot.Types.ReplyMarkups;

namespace Awesome
{
    class Program
    {
        static ITelegramBotClient botClient;

        static void Main()
        {
            botClient = new TelegramBotClient("1433082577:AAFtoVW7Tq4aqZj4oN7K1uMt5i_rC4kXRIw");

            var me = botClient.GetMeAsync().Result;
            Console.WriteLine(
              $"Spider Bot v0.1.0 \nUserId: {me.Id} \nand registered name is {me.FirstName}."
            );

            botClient.OnMessage += Bot_OnMessage;
            botClient.StartReceiving();

            Console.WriteLine("Press any key to exit");
            Console.ReadKey();

            botClient.StopReceiving();
        }

        static async void Bot_OnMessage(object sender, MessageEventArgs e)
        {
            Message message = await botClient.SendTextMessageAsync(
              chatId: e.Message.Chat, // or a chat id: 123456789
              text: "Trying *all the parameters* of `sendMessage` method",
              parseMode: ParseMode.Markdown,
              disableNotification: true,
              replyToMessageId: e.Message.MessageId,
              replyMarkup: new InlineKeyboardMarkup(InlineKeyboardButton.WithUrl(
                "Check sendMessage method",
                "https://core.telegram.org/bots/api#sendmessage"
              ))
            );

            Console.WriteLine(
                $"{message.From.FirstName} sent message {message.MessageId} " +
                $"to chat {message.Chat.Id} at {message.Date}. " +
                $"It is a reply to message {message.ReplyToMessage.MessageId} " +
                $"and has {message.Entities.Length} message entities.");
        }
    }
}
