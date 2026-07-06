namespace TflDLL;
public class Program{

    public static void Main(string[] args){
DoublyLinklist dll = new DoublyLinklist();

dll.InsertAtFront(5);
dll.InsertAtFront(10);
dll.InsertAtEnd(15);
dll.Display();
}
}