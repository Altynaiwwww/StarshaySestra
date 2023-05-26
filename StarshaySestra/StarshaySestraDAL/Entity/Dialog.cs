using StarshaySestra.Common;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace StarshaySestra.StarshaySestraDAL.Entity
{
    public class Dialog : BaseEntity   
    {
        public int DialogId{ get; set; }

        public Dialog(int dialogId)
        {
            DialogId = dialogId;
        }
    }
}
