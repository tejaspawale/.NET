namespace TflDLL;
public class Program{

    public static void Main(string[] args){
DoublyLinklist dll = new DoublyLinklist();

dll.InsertAtFront(5);
dll.InsertAtFront(10);
dll.InsertAtEnd(15);
dll.update(5,10);
dll.update(10,5);
dll.insertAnyWhere(7);
dll.insertAnyWhere(20);
dll.insertAnyWhere(-1);
dll.insertAnyWhere(-2);
dll.Display();
}
}