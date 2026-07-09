using LinkedList.List;
using LinkedList.UIManager;

class Program
{

    public static void Main(string[] args)
    {
        linkedlist linked = new linkedlist();
        UIManager uiManager = new UIManager();
        // Add Node at End
        int choice;
        do
        {
             uiManager.ShowMenu();

             choice= uiManager.AcceptChoice();
             switch(choice)
            {
                case 1:
                    {
                    int data=uiManager.AcceptData();
                    int loc=uiManager.AcceptLocation();
                    linked.Insert(data,loc);
                    break;
                        
                    }

                case 2:
                    {
                        int olddata = uiManager.AcceptData();
                        int newdata = uiManager.AcceptData();
                        linked.Update(olddata,newdata);
                        break;

                    }

                case 3:
                    {
                        int data = uiManager.AcceptData();
                        linked.Delete(data);
                        break;
                    }

                

                case 4:
                    {
                        linked.Display();
                        break;

                    }
                case 5:{
                    int data = uiManager.AcceptData();
                        linked.AddNodeFirst(data);
                        break;
                    
                    }
                case 6:
                    {
                        uiManager.ExitApplication();
                        break;

                    }


            }
        } while(choice!=6);

       
     

  
    }

}