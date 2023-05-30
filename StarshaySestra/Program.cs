using Telegram.Bot;
using Telegram.Bot.Polling;
using Message = Telegram.Bot.Types.Message;
using Update = Telegram.Bot.Types.Update;

using System.Security.Cryptography.X509Certificates;
using StarshaySestra.Command;
using StarshaySestra.StarshaySestraDAL.Entity;
using Telegram.Bot.Types;
using User = Telegram.Bot.Types.User;
using Telegram.Bots.Types;
using Telegram.Bot.Types.ReplyMarkups;
using InlineKeyboardMarkup = Telegram.Bot.Types.ReplyMarkups.InlineKeyboardMarkup;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace Bot
{
    public class Program
    {
       static TelegramBotClient botClient = new TelegramBotClient("6239769324:AAE8BbkP2v0d4dyNbx45UEkvBOuBmNdSs7g");

        private enum BotState 
        {
          MainMenu,
          Sos,
          Sex,
          Period,
          SocialNetworks,
          DadAndMom
        }

        static async Task Main()
        {
            var cancellationTokenSource = new CancellationTokenSource();
           
             
                var token = new CancellationTokenSource();
                var canceltoken = token.Token;
                var reOpt = new ReceiverOptions { AllowedUpdates = { } };
                
                
                await botClient.ReceiveAsync(OnMessage, ErrorAsync, reOpt,canceltoken);

        }

        private static Task ErrorAsync(ITelegramBotClient arg1, Exception arg2, CancellationToken arg3)
        {
            throw new NotImplementedException();
        }




        const BotState curentState = BotState.MainMenu;
        private static async Task OnMessage(ITelegramBotClient botClient, Update update,
          CancellationToken cancellationToken)
        {
            if (update.Type == Telegram.Bot.Types.Enums.UpdateType.Message)
            {
                var message = update.Message;
                var user = update.ToString();
                if (message.Text.ToLower() == "/start")
                {
                    
                    InlineKeyboardMarkup keyboardMarkupStart = new InlineKeyboardMarkup
                        (InlineKeyboardButton.WithCallbackData(text: "Согласие", callbackData: "soglasen"));

                    await botClient.SendTextMessageAsync(update.Message.Chat.Id, "Дисклеймер, данный бот разработан любящими сестрами для своих сестренок," +
                        " ввиде не принужденного разговора о этапах взросление и понятий своего тела ",
                        replyMarkup: keyboardMarkupStart, cancellationToken: cancellationToken);

                }

            }
            if (update.Type == Telegram.Bot.Types.Enums.UpdateType.CallbackQuery)
            {
                await HandleCallbackQuery(update, (TelegramBotClient)botClient);
            }

           
            static async Task HandleCallbackQuery(Update update, TelegramBotClient botClient)
            {
                var callbackQuery = update.CallbackQuery;
                

               
                


                     switch (callbackQuery.Data)
                     {
                           case "soglasen":
                        var mainMenu = new ReplyKeyboardMarkup(
                            new[]
                            {
                                           new[]
                                           {
                                              new KeyboardButton("SOS"),
                                              new KeyboardButton("Отношения с родителями "),
                                              new KeyboardButton("Соц.сети и массовое информация ")
                                           },
                                           new[]
                                           {
                                               new KeyboardButton("Секс"),
                                               new KeyboardButton("Месячные"),
                                               new KeyboardButton("Как распознать арбузера?")
                                           }
                            }
                              );

                        await botClient.SendTextMessageAsync(
                      chatId: callbackQuery.Message.Chat.Id,
                      text: "Выберите тему",
                      replyMarkup: mainMenu,
                      parseMode: Telegram.Bot.Types.Enums.ParseMode.Html
                      );
                        break;
                       default:

                        break;
                     }

                //if () 
                //{
                
                
                //}

            }
        }

    }


  

}


