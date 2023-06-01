

using Telegram.Bot.Types.ReplyMarkups;
using Telegram.Bots.Types;

namespace StarshaySestra
{
    public static class History
    {
        public static List<HistoryItem> histories;

        public static void AddAction(HistoryItem histories)
        {
            histories.Add(histories);
        }

        public static void RemoveLastAction()
        {
            if (histories.Count > 0)
            {
                histories.RemoveAt(histories.Count - 1);

            }
        }


      
    }

  
}
