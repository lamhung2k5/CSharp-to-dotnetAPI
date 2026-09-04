public class Program
{
    public static void Main(string[] args)
    {
        try
        {
            //Tạo một ActionHistory.
            ActionHistory action = new ActionHistory("Chrome");

            //Thêm ít nhất ba thao tác.
            action.AddAction("access youtube");
            action.AddAction("access mail");
            action.AddAction("access facebook");

            //Hiển thị toàn bộ lịch sử.
            Console.WriteLine("==Display Action==");

            action.DisplayActions();

            //Xem thao tác gần nhất bằng ViewLastAction(). 
            Console.WriteLine("==test TryPeek()==");

            int countBefore = action.GetActionCount();

            string? currentAction = action.ViewLastAction();

            int countAfter = action.GetActionCount();

            //Xác nhận TryPeek() không làm giảm Count.
            if(countAfter == countBefore)
            {
                Console.WriteLine("TryPeek() is not change the Stack.");
            }

            Console.WriteLine("==view last action==");

            //Kiểm tra null trước khi hiển thị.
            if (currentAction == null)
            {
                Console.WriteLine("There is no current action.");
            }
            else
            {
                Console.WriteLine($"current action: {currentAction}");
            }

            //Hoàn tác một thao tác bằng UndoLastAction().
            Console.WriteLine("==test TryPop()==");

            int countBeforePop = action.GetActionCount();

            string? UndoAction = action.UndoLastAction();

            int countAfterPop = action.GetActionCount();

            //Xác nhận TryPop() làm Count giảm đúng một.
            if (countAfterPop == countBefore - 1)
            {
                Console.WriteLine("TryPop() remove exactly one action.");
            }

            //Hiển thị lịch sử sau khi hoàn tác.
            Console.WriteLine("==Display actions after remove==");

            action.DisplayActions();

            //Tiếp tục hoàn tác cho đến khi Stack rỗng.
            while(true)
            {
                string? actionRemove = action.UndoLastAction();

                if(actionRemove == null)
                {
                    break;
                }

                Console.WriteLine($"Next action is removed: {actionRemove}");
            }

            //Thử hoàn tác thêm một lần khi Stack đã rỗng.
            //Hiển thị thông báo phù hợp.
            if(action.UndoLastAction() == null) 
            {
                Console.WriteLine("there is no action to remove");
            }
        }
        catch(ArgumentException e)
        {
            Console.WriteLine($"error: {e.Message}");
        }
        catch(Exception e) 
        {
            Console.WriteLine($"error: {e.Message}");
        }
    }
}
