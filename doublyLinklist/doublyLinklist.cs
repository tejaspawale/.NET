namespace TflDLL;

public class DoublyLinklist
{
    Node head = null;
    Node current = null;
    public void InsertAtFront(int data)
    {
        Node newNode = new Node(data);

        if (head == null)
        {
            head = newNode;

        }
        else
        {
            newNode.next = head;
            head.prev = newNode;
            newNode.prev = null;
            head = newNode;
        }
    }

    public void InsertAtEnd(int data)
    {

        Node newNode = new Node(data);

        current = head;
        while(current.next!= null)
        {
            current = current.next;
        }
        current.next = newNode;
    }

    public void Display()
    {
        Node current = head;

        while (current != null)
        {
            Console.Write(current.data + " ");
            current = current.next;
        }

        Console.WriteLine();
    }







}