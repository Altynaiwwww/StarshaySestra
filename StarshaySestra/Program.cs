using Telegram.Bot;
using Telegram.Bot.Polling;
using Update = Telegram.Bot.Types.Update;
using Telegram.Bot.Types.ReplyMarkups;
using InlineKeyboardMarkup = Telegram.Bot.Types.ReplyMarkups.InlineKeyboardMarkup;
using StarshaySestra;

namespace Bot
{
    public class Program
    {
        static TelegramBotClient botClient = new TelegramBotClient("6001135410:AAEAAbRYcmfvDkL82xT7BIeuOuvwamhF3N4");
       
        static async Task Main()
        {
            var cancellationTokenSource = new CancellationTokenSource();


            var token = new CancellationTokenSource();
            var canceltoken = token.Token;
            var reOpt = new ReceiverOptions { AllowedUpdates = { } };


            await botClient.ReceiveAsync(OnMessage, ErrorAsync, reOpt, canceltoken);

        }

        private static Task ErrorAsync(ITelegramBotClient botClient, Exception exception, CancellationToken cancellationToken)
        {
           
            Console.WriteLine($"Ошибка при выполнении команды: {exception.Message}");

           
            return Task.CompletedTask;
        }

        static async Task HandleCallbackQuery(Update update, TelegramBotClient botClient)
        {
            var callbackQuery1 = update.CallbackQuery;


            switch (callbackQuery1.Data)
            {
                case "soglasen":
                    var mainMenu = new ReplyKeyboardMarkup(
                        new[]
                        {
                                           new[]
                                           {
                                              new KeyboardButton("SOS"),
                                           },
                                           new[]
                                           {
                                               new KeyboardButton("Секс"),
                                           },
                                           new[]
                                           {
                                            new KeyboardButton("Как распознать арбузера?")
                                           },
                                           new[]
                                           {
                                           new KeyboardButton("Соц.сети и массовое информация ")
                                           },
                                           new[]
                                           {
                                            new KeyboardButton("Отношения с родителями "),
                                           }



                        }
                          );

                    await botClient.SendTextMessageAsync(
                  chatId: callbackQuery1.Message.Chat.Id,
                  text: "Выберите то что  вас интересует ",
                  replyMarkup: mainMenu,
                  parseMode: Telegram.Bot.Types.Enums.ParseMode.Html
                  );
                    break;
                default:

                    break;
            }

        }

        

        private static async Task OnMessage(ITelegramBotClient botClient, Update update,
          CancellationToken cancellationToken)
        {
            if (update.Type == Telegram.Bot.Types.Enums.UpdateType.Message)
            {
                var message = update.Message;
                var user = update.ToString();
                if (message.Text.ToLower() == "/start")
                {

                    await botClient.SendTextMessageAsync(update.Message.Chat.Id, "📍Наша философия создания бота для сестер основана на поддержке, информации и вдохновении🫂. Мы стремимся предоставить девушкам ресурс, который поможет им навигироваться через сложности взросления, предоставлять информацию и поддержку на различных этапах и аспектах их жизни🫶🏻. Мы верим в силу сестринской солидарности и стремимся создать пространство, где девушки могут общаться, делиться опытом и расти вместе. Наш бот - это электронная брошюра, которая стоит рядом с каждой сестрой, помогая ей стать сильной, уверенной и успешной женщиной❤️.");
                    Thread.Sleep(10000);


                    InlineKeyboardMarkup keyboardMarkupStart = new InlineKeyboardMarkup
                        (InlineKeyboardButton.WithCallbackData(text: "Согласие", callbackData: "soglasen"));

                    await botClient.SendTextMessageAsync(update.Message.Chat.Id, "ДИСКЛЕЙМЕР\r\n  📍Данный бот с целью помочь вам в вашем " +
                        "запросе.\r\nОднако, пожалуйста, имейте в виду, что это - всего лишь программное обеспечение,\r\nи" +
                        " не может гарантировать 100% точность или полноту ответов на \r\nваши вопросы. Мы извиняемся за " +
                        "любые ошибки или упущения в информации, \r\nпредоставленной этим ботом. \r\n",
                        replyMarkup: keyboardMarkupStart, cancellationToken: cancellationToken);

                }

            }
            if (update.Type == Telegram.Bot.Types.Enums.UpdateType.CallbackQuery)
            {
                await HandleCallbackQuery(update, (TelegramBotClient)botClient);
            }



            if (update.Type == Telegram.Bot.Types.Enums.UpdateType.Message)
            {
                var message = update.Message;
                var callbackData = update.CallbackQuery;


                switch (message.Text)
                {
                    case "SOS":
                        await ButtonResponses.ShowSOSResponse(botClient, message.Chat.Id);
                        break;


                    case "Отношения с родителями":
                        await ButtonResponses.ShowButtonParents(botClient, message.Chat.Id);
                        break;


                    case "Соц.сети и массовое информация":
                        await ButtonResponses.ShowInstagramResponse(botClient, message.Chat.Id);
                        break;


                    case "Секс":
                        await ButtonResponses.ShowSexResponse(botClient, message.Chat.Id);
                        break;


                    case "Как распознать арбузера?":
                        await ButtonResponses.ShowAbuseReponse(botClient, message.Chat.Id);
                        break;


                }

            }



            if (update.Type == Telegram.Bot.Types.Enums.UpdateType.Message)
            {
                var message = update.Message;
                var callbackData = update.CallbackQuery;

                switch (message.Text)
                {

                    case "Cложные отношения с родителями":
                        await botClient.SendTextMessageAsync(chatId: message.Chat.Id, text: ResponseToUser.ComplexRelationship);

                        Thread.Sleep(5000);

                        await botClient.SendTextMessageAsync(chatId: message.Chat.Id, text: ResponseToUser.ComplexRelationship1);

                        break;


                    case "Родители и развод":
                        await botClient.SendTextMessageAsync(chatId: message.Chat.Id, text: ResponseToUser.Divorce);
                        break;

                    case "Безопасность в сети":
                        await botClient.SendTextMessageAsync(chatId: message.Chat.Id, text: ResponseToUser.Safe);
                        break;

                    case "Инста как фильтр":
                        await botClient.SendTextMessageAsync(chatId: message.Chat.Id, text:ResponseToUser.Filtr);
                        break;


                    case "Методы защиты":
                        await botClient.SendTextMessageAsync(chatId: message.Chat.Id, text: ResponseToUser.Protected);
                        break;



                    case "Половое образование":
                        await botClient.SendTextMessageAsync(chatId: message.Chat.Id, text:ResponseToUser.SexEducation );
                        Thread.Sleep(10000);

                        await botClient.SendTextMessageAsync(chatId: message.Chat.Id, text: ResponseToUser.SexEducation1);
                        Thread.Sleep(10000);

                        await botClient.SendTextMessageAsync(chatId: message.Chat.Id, text: ResponseToUser.SexEducation2);


                        break;

                    case "Месячные":
                        await botClient.SendTextMessageAsync(chatId: message.Chat.Id, text:ResponseToUser.Period );
                        Thread.Sleep(5000);

                        await botClient.SendTextMessageAsync(chatId: message.Chat.Id, text:ResponseToUser.Period1 );
                        break;

                    case "Виды насилие":
                        await botClient.SendTextMessageAsync(chatId: message.Chat.Id, text:ResponseToUser.SortOfAbuse);                 
                            break;

                    case "Душевное состояние":
                        await botClient.SendTextMessageAsync(chatId: message.Chat.Id, text:ResponseToUser.Soulmate);
                        break;
                    default:
                        break;

                }

            }


            if (update.Type == Telegram.Bot.Types.Enums.UpdateType.Message)
            {
                var message = update.Message;
                var callbackData = update.CallbackQuery;

                switch (message.Text)
                {
                    case "Психолог":
                        await botClient.ForwardMessageAsync(5757636931, update.Message.Chat.Id,
                            update.Message.MessageId);
                        break;
                    case "Терапевт":
                        await botClient.ForwardMessageAsync(1052213789, update.Message.Chat.Id, update.Message.MessageId);

                        break;


                    case "Гинеколог":
                        await botClient.ForwardMessageAsync(1020296599, update.Message.Chat.Id, update.Message.MessageId);

                        break;

                    case "Юрист":
                        await botClient.ForwardMessageAsync(1358080376, update.Message.Chat.Id, update.Message.MessageId);

                        break;

                    case "Шелтер(это предоставление убежища)":
                        await botClient.ForwardMessageAsync(1095898322, update.Message.Chat.Id, update.Message.MessageId);

                        break;
                }
            }


            if (update.Type == Telegram.Bot.Types.Enums.UpdateType.Message)
            {
                var message = update.Message;
                var callbackData = update.CallbackQuery;
                switch (message.Text)
                {
                    case "Назад":
                       await ButtonResponses.ShowButtonBack(botClient, message.Chat.Id);
                        break;
                    default:

                        break;


                }

            }



            if (update.Type == Telegram.Bot.Types.Enums.UpdateType.Message) 
            {
                var message = update.Message;
                var callbackData = update.CallbackQuery;
                switch (message.Text) 
                {
                    case "Телефон доверия:":
                        await botClient.SendTextMessageAsync(chatId: message.Chat.Id, text:TextConstants.Phone );
                        break;
                }
            }

        }
    }
}






