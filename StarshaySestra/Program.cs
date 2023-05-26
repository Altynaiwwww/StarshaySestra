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

namespace Bot
{
    public class Program
    {
       static TelegramBotClient botClient = new TelegramBotClient("6239769324:AAE8BbkP2v0d4dyNbx45UEkvBOuBmNdSs7g");

        private enum BotState 
        {
          MainMenu,
          Sos,
          Suicide,
          Sex,
          WhoAmI,
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
                
                await botClient.ReceiveAsync(OnMessage, HandleErrorAsync, reOpt,canceltoken);

        }


        private BotState curentState = BotState.MainMenu;
        private static async Task OnMessage(ITelegramBotClient botClient,Update update,
          CancellationToken cancellationToken )
        {
            if (update.Type ==Telegram.Bot.Types.Enums.UpdateType.Message)
            {
                var message = update.Message;
                var user = update.ToString();
                if (message.Text.ToLower() == "/start") 
                {
                    await botClient.SendTextMessageAsync(update.Message.Chat.Id, "Дисклеймер");
                   
                   // await botClient.HandleUpdateAsync(update, cancellationToken);

                }

                await botClient.HandleUpdateAsync(update, cancellationToken);


                //string userNickname = message.From.Username;
                //string greeting = $"Hiii {userNickname}";

                //  await botClient.SendTextMessageAsync(message.Chat.Id);
                // await botClient.HandleUpdateAsync(update, cancellationToken);

            }


        }

       
        public static async Task HandleErrorAsync(ITelegramBotClient botClient, Exception exception,
            CancellationToken cancellationToken)
        {
            
            Console.WriteLine(Newtonsoft.Json.JsonConvert.SerializeObject(exception));
        }

    }
}

