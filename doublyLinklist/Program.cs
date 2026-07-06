namespace TflDLL;
public class Program{

    public static void Main(string[] args){
DoublyLinklist dll = new DoublyLinklist();

dll.InsertAtFront(5);
dll.InsertAtFront(10);
dll.InsertAtEnd(15);
dll.update(5,10);
dll.update(10,5);
// dll.insertAnyWhere(5);
// dll.insertAnyWhere(10);
// dll.insertAnyWhere(15);
// dll.insertAnyWhere(0);
dll.delete(15);
dll.Display();
}
}