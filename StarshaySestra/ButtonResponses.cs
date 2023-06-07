using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Telegram.Bot;
using Telegram.Bot.Types;
using Telegram.Bot.Types.ReplyMarkups;
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
                           new KeyboardButton("Адвокат"),
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
    }
}
