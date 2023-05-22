

using StarshaySestra.StarshaySestraDAL.Entity;
using Telegram.Bot;
using Telegram.Bot.Exceptions;
using Telegram.Bot.Polling;
using Telegram.Bot.Types;
using Telegram.Bots;
using Telegram.Bots.Http;
using Telegram.Bots.Types;

namespace Bot
{
    public class Program
    {
       static TelegramBotClient botClient = new TelegramBotClient("6239769324:AAE8BbkP2v0d4dyNbx45UEkvBOuBmNdSs7g"); 
        static async Task Main()
        {
            var cancellationTokenSource = new CancellationTokenSource();
           
             
                var token = new CancellationTokenSource();
                var canceltoken = token.Token;
                var reOpt = new ReceiverOptions { AllowedUpdates = { } };
                
                await botClient.ReceiveAsync(OnMessage, ErrorMessage,reOpt,canceltoken);

        }
        
       
        private static async Task OnMessage(ITelegramBotClient botClient, Update update, CancellationToken cancellationToken)
        {
            if (update.Message is Message message)
            {
                await botClient.SendTextMessageAsync(message.Chat.Id, "Привет, Айым же ");
            }

        }

        private static async Task ErrorMessage(ITelegramBotClient botClient, Exception exception, CancellationToken cancellationToken)
        {
            if (exception is ApiRequestException  reguestException)
            {
                await botClient.SendTextMessageAsync("Something go wrong ",exception.Message.ToString());
            }
        }


        private static async Task Button1(object sender, EventArgs e) 
        {
            botClient.StartReceiving();
           
        }

        private static async Task Button2(object sender, EventArgs e)
        {
            botClient.StopReceiving();

        }

    }
}

