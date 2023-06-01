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
                var  message = update.Message;
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
                                              new KeyboardButton("Отношения с родителями "),
                                              new KeyboardButton("Соц.сети и массовое информация ")
                                           },
                                           new[]
                                           {
                                               new KeyboardButton("Секс"),
                                               new KeyboardButton("Как распознать арбузера?")
                                           }
                            }
                              );

                        await botClient.SendTextMessageAsync(
                      chatId: callbackQuery1.Message.Chat.Id,
                      text: "Выберите тему",
                      replyMarkup: mainMenu,
                      parseMode: Telegram.Bot.Types.Enums.ParseMode.Html
                      );
                        break;
                    default:

                        break;
                }




            }


            // ReplyKeyboardMarkup keyboardButtonSOS = new ReplyKeyboardMarkup(KeyboardButton button);



            if (update.Type == Telegram.Bot.Types.Enums.UpdateType.Message)
            {
                var message = update.Message;
                var callbackData = update.CallbackQuery;


                switch (message.Text)
                {
                    case "SOS" :
                        var SOS = new ReplyKeyboardMarkup(new KeyboardButton[][]
                        {
                          new KeyboardButton[]
                          {
                           new KeyboardButton("Психолог"),
                          },
                          new KeyboardButton[]
                          {
                           new KeyboardButton("Адвокат"),
                           new KeyboardButton("Юрист"),

                          },
                          new KeyboardButton[]
                          {
                            new KeyboardButton("Гинеколог"),
                            new KeyboardButton("Шелтер"),
                            new KeyboardButton("Терапевт")
                          }

                        });

                        await botClient.SendTextMessageAsync(chatId: message.Chat.Id, text: "SOS",
                            replyMarkup: SOS);
                        break;


                    case "Отношения с родителями":
                        var parents = new ReplyKeyboardMarkup(new KeyboardButton[][] 
                        {
                            new KeyboardButton[]
                            {
                             new KeyboardButton("как сепарироватся"),
                            },
                            new KeyboardButton[]
                            {
                             new KeyboardButton("родители и развод"),

                            }

                        });
                        await botClient.SendTextMessageAsync(chatId: message.Chat.Id, text: "родители",
                          replyMarkup: parents);
                        break;


                    case "Соц.сети и массовое информация ":
                        var socials = new ReplyKeyboardMarkup(new KeyboardButton[][] 
                        {
                            new KeyboardButton[]
                            {
                             new KeyboardButton("безопасность"),
                             new KeyboardButton("инста как фильтр")
                            }
                        });
                        await botClient.SendTextMessageAsync(chatId: message.Chat.Id, text: "инста",
                         replyMarkup: socials);
                        break;


                    case "Секс":
                        var sex = new ReplyKeyboardMarkup(new KeyboardButton[][]
                        {
                           new KeyboardButton[]
                           {
                             new KeyboardButton("методы защиты")
                           },
                           new KeyboardButton[]
                           {
                             new KeyboardButton("половое образование")
                           },
                           new KeyboardButton[]
                           {
                             new KeyboardButton("месячные")
                           }


                        });
                        await botClient.SendTextMessageAsync(chatId: message.Chat.Id, text: "vtdtyfuiop",
                       replyMarkup: sex);
                        break;


                    case "Как распознать арбузера?":
                        var abuse = new ReplyKeyboardMarkup(new KeyboardButton[][] 
                        {
                            new KeyboardButton[]
                            {
                                new KeyboardButton("виды отношений"),
                                new KeyboardButton("душевное состояние")
                            }

                        });
                        await botClient.SendTextMessageAsync(chatId: message.Chat.Id, text: "fhngmv",
                      replyMarkup: abuse);
                        break;



                }



            }




        }

    }
}

  




