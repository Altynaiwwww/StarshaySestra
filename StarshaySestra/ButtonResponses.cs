using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Telegram.Bot;
using Telegram.Bot.Types;
using Telegram.Bot.Types.ReplyMarkups;
using Telegram.Bots;
using Telegram.Bots.Http;

namespace StarshaySestra
{
    public static class ButtonResponses
    {
        public static async Task ShowSOSResponse(ITelegramBotClient botClient, ChatId chatId)
        {
            var SOS = new ReplyKeyboardMarkup(new KeyboardButton[][]
                        {
                          new KeyboardButton[]
                          {
                           new KeyboardButton("Психолог"),
                          },
                          new KeyboardButton[]
                          {
                          new KeyboardButton("Юрист"),
                          },
                          new KeyboardButton[]
                          {
                            new KeyboardButton("Гинеколог")
                          },
                          new KeyboardButton[]
                          {
                            new KeyboardButton("Шелтер(это предоставление убежища)"),
                          },
                          new KeyboardButton[]
                          {
                            new KeyboardButton("Терапевт")
                          },
                          new KeyboardButton[]
                          {
                            new KeyboardButton("Телефон доверия:")
                          },
                          new KeyboardButton[]
                          {
                            new KeyboardButton("Назад")
                          }
                        });

            await botClient.SendTextMessageAsync(chatId: chatId, text: TextConstants.MainDisclaimer,
              replyMarkup: SOS);
        }


        public static async Task ShowButtonParents(ITelegramBotClient botClient, ChatId chatId) 
        {
            var parents = new ReplyKeyboardMarkup(new KeyboardButton[][]
                           {
                            new KeyboardButton[]
                            {
                             new KeyboardButton("Cложные отношения с родителями"),
                            },
                            new KeyboardButton[]
                            {
                             new KeyboardButton("Родители и развод"),
                            },
                            new KeyboardButton[]
                            {
                            new KeyboardButton("Назад")
                            }


                           });
            await botClient.SendTextMessageAsync(chatId:chatId, text: TextConstants.ParentsRelationships,
              replyMarkup: parents);
        }

        public static async Task ShowInstagramResponse(ITelegramBotClient botClient, ChatId chatId) 
        {
            var socials = new ReplyKeyboardMarkup(new KeyboardButton[][]
                           {
                            new KeyboardButton[]
                            {
                              new KeyboardButton("Безопасность в сети"),
                            },
                            new KeyboardButton []
                            {
                              new KeyboardButton("Инста как фильтр"),
                            },
                            new KeyboardButton []
                            {
                              new KeyboardButton("Назад")
                            }

                           });
            await botClient.SendTextMessageAsync(chatId: chatId, text:TextConstants.Insagram,
             replyMarkup: socials);

        }
        public static async Task ShowSexResponse(ITelegramBotClient botClient, ChatId chatId) 
        {
            var sex = new ReplyKeyboardMarkup(new KeyboardButton[][]
                         {
                           new KeyboardButton[]
                           {
                             new KeyboardButton("Методы защиты")
                           },
                           new KeyboardButton[]
                           {
                             new KeyboardButton("Половое образование"),
                           },
                           new KeyboardButton[]
                           {
                             new KeyboardButton("Месячные"),
                           },
                           new KeyboardButton[]
                           {
                             new KeyboardButton("Назад")
                           }


                         });
            await botClient.SendTextMessageAsync(chatId: chatId, text: TextConstants.Seks,
                       replyMarkup: sex);
            
        }

        public static async Task ShowAbuseReponse(ITelegramBotClient botClient, ChatId chatId) 
        {
            var abuse = new ReplyKeyboardMarkup(new KeyboardButton[][]
    {
                            new KeyboardButton[]
                            {
                            new KeyboardButton("Виды насилие"),
                            },
                            new KeyboardButton[]
                            {
                             new KeyboardButton("Душевное состояние"),
                            },
                            new KeyboardButton[]
                            {
                            new KeyboardButton("Назад")
                            }
    });
            await botClient.SendTextMessageAsync(chatId: chatId, text:TextConstants.Seks, 
          replyMarkup: abuse);

        }


        public static async Task ShowButtonBack(ITelegramBotClient botClient, ChatId chatId) 
        {
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
                              });

            await botClient.SendTextMessageAsync(chatId:chatId, text: "Вы вернулись в главное меню",
          replyMarkup: mainMenu);
        }

       

    }
}
