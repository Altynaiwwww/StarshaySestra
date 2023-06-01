
using Telegram.Bot.Types.ReplyMarkups;


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

        public void RemoveLastButton(HistoryItem histories)
        {
            if (userActions.Count > 0)
            {
                userActions.RemoveAt(userActions.Count - 1);
                
            }
        }

        internal void Add(HistoryItem histories)
        {
            throw new NotImplementedException();
        }

      

    }
}
