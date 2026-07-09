namespace TflDLL;
public class Program{

public static void Main(string[] args){
DoublyLinklist dll = new DoublyLinklist();

// dll.InsertAtFront(5);
// dll.InsertAtFront(10);
// dll.InsertAtEnd(15);
// dll.update(5,10);
// dll.update(10,5);
dll.insertAnyWhere(28);
dll.insertAnyWhere(30);
dll.insertAnyWhere(2);
dll.insertAnyWhere(0);
//dll.delete(15);
dll.DisplayTail();
dll.DisplayStart();
}
}