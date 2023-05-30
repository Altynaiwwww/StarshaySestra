
using Telegram.Bot.Types.ReplyMarkups;
using Telegram.Bot;
using Telegram.Bot.Types;
using StarshaySestra.StarshaySestraDAL.Entity;
using NuGet.Protocol;
using Telegram.Bots.Types;
using Update = Telegram.Bot.Types.Update;

namespace StarshaySestra.Command
{
    //public static class InlineKeyboardCommand
    //{

    //    public static async Task HandleUpdateAsync(this ITelegramBotClient botClient, Update update,
    //        CancellationToken cancellationToken)
    //    {
    //        // Некоторые действия
    //        Console.WriteLine(Newtonsoft.Json.JsonConvert.SerializeObject(update));
    //        if (update.Type == Telegram.Bot.Types.Enums.UpdateType.Message)
    //        {
    //           // var agreement = new InlineKeyboardButton("договорились");

    //            //if ( == ) 
    //            //{
    //            //    SendInline(botClient: botClient, chatId: chatId, cancellationToken: cancellationToken);
                   
    //            //}

             
    //        }
    //    //    if (update.Type == Telegram.Bot.Types.Enums.UpdateType.CallbackQuery)
        //    {
        //        string codeOfButton = update.CallbackQuery.Data;
        //        if (codeOfButton == "post")
        //        {
        //            Console.WriteLine("Нажата Кнопка 1");

        //            string telegramMessage = "Вы нажали Кнопку 1";
        //            await botClient.SendTextMessageAsync(chatId: update.CallbackQuery.Message.Chat.Id, telegramMessage, parseMode: Telegram.Bot.Types.Enums.ParseMode.Html);
        //        }
        //        if (codeOfButton == "12")
        //        {
        //            Console.WriteLine("Нажата Кнопка 2");
        //            string telegramMessage = "Вы нажали Кнопку 2";
        //            // await botClient.SendTextMessageAsync(chatId: update.CallbackQuery.Message.Chat.Id, telegramMessage, parseMode: Telegram.Bot.Types.Enums.ParseMode.Html);

        //            InlineKeyboardMarkup inlineKeyBoard = new InlineKeyboardMarkup(
        //                new[]
        //                {
        //                    // first row
        //                    new[]
        //                    {
        //                        // first button in row
        //                        InlineKeyboardButton.WithCallbackData(text: "Кнопка 3", callbackData: "post3"),
        //                        // second button in row
        //                        InlineKeyboardButton.WithCallbackData(text: "Кнопка 4", callbackData: "post4"),
        //                    },

        //                });

        //            // await botClient.EditMessageCaptionAsync(chatId: update.CallbackQuery.Message.Chat.Id, caption: telegramMessage, messageId: update.CallbackQuery.Message.MessageId);
        //            await botClient.EditMessageTextAsync(update.CallbackQuery.Message.Chat.Id,
        //          update.CallbackQuery.Message.MessageId, telegramMessage,
        //          replyMarkup: inlineKeyBoard, parseMode: Telegram.Bot.Types.Enums.ParseMode.Html);
        //        }
        //    }
        //}

//        private static void   SendInline(ITelegramBotClient botClient, long chatId, CancellationToken cancellationToken)
//        {
//            Console.WriteLine(Newtonsoft.Json.JsonConvert.SerializeObject(chatId));

//        }
//    }
}
