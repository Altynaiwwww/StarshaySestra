
using Telegram.Bot;
using Telegram.Bot.Types;
using Telegram.Bot.Types.ReplyMarkups;
using Telegram.Bots.Http;
using Update = Telegram.Bot.Types.Update;

namespace StarshaySestra
{
    public class HistoryItem
    {
        public List<ReplyKeyboardMarkup> KeyboardButtons;

    
        List<HistoryItem> userActions = new List<HistoryItem>();
        
        public void AddButton(HistoryItem histories)
        {
            userActions.Add(histories);
        }

        public void AddButtonWithAction(HistoryItem histories)
        {
            userActions.Add(histories);
            histories.AddAction(userActions);
        }

        private void AddAction(List<HistoryItem> userActions)
        {
            throw new NotImplementedException();
        }

        public void RemoveLastButton(HistoryItem histories,Update update)
        {
            if (userActions.Count > 0)
            {
               

                if (update.Type == Telegram.Bot.Types.Enums.UpdateType.Message) 
                {
                    var message = update.Message;
                    var callbackData = update.CallbackQuery;

                    switch (message.Text)
                    {
                        case "Назад":
                            userActions.RemoveAt(userActions.Count - 1);
                            break;
                    }
                }

                
            }
        }

       

        public void SOSButton(ITelegramBotClient botClient, Update update, List<HistoryItem> histories)
        {
            //botClient.SendTextMessageAsync(chatId: update.Message.Chat.Id, text: "SOS");
            //userActions = "SOS";

        }
        public  void Add(HistoryItem histories)
        {
            throw new NotImplementedException();
        }



    }
}
