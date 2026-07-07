namespace TflDLL;

public class DoublyLinklist
{
    Node head = null;
    Node current = null;

    Node last=null;


    public void InsertAtFront(int data)
    {
        Node newNode = new Node(data);

        if (head == null)
        {
            head = newNode;
            last = newNode;

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
        if(head == null)
        {
            head = newNode;
            last = newNode;
            return;
        }

        current = head;
        while (current.next != null)
        {
            current = current.next;
        }
        current.next = newNode;
        newNode.prev = current;
        last = newNode;
    }

    public void update(int oldData, int newData)
    {
        Node current = head;

        while (current != null)
        {
            if (current.data == oldData)
            {
                current.data = newData;
                break;
            }

            current = current.next;
        }
    }

    public void insertAnyWhere(int data)
    {
        Node newNode = new Node(data);
        current = head;
        if(head == null)
        {
            head = newNode;
            last = newNode;
        }

        while (current.next != null && current.next.data < data)
        {
            current = current.next;
        }
        if (data < head.data)
        {
            newNode.next = head;
            head.prev = newNode;
            head = newNode;
            return;
        }
        if (current.next == null)
        {
            InsertAtEnd(data);
        }
        else
        {
            newNode.next = current.next;
            current.next = newNode;
            newNode.prev = current;
            current.next.prev = newNode;
        }


    }


    public void delete(int data)

    {
        if (head == null)
        {
            return;
        }

        if (head.data == data)
        {
            if (head.next == null)
            {
                head = null;
                last = null;
            }
            else
            {
                head = head.next;
                head.prev = null;
            }
            return;
        }

        Node current = head;

        while (current != null)
        {
            if (current.data == data)
            {
                if (current.next == null)
                {
                    current.prev.next = null;
                    last = current.prev;
                }
                else
                {
                    current.prev.next = current.next;
                    current.next.prev = current.prev;
                }
                return;
            }
            current = current.next;


        }
    }

    public void DisplayStart()
    {
        Node current = head;

        while (current != null)
        {
            Console.Write(current.data + "-->");
            current = current.next;
        }

       Console.Write("null");
    }

    public void DisplayTail()
    {
        current = last;
        while(current!= null)
        {
            Console.Write(current.data + "-->");
            current = current.prev;
        }
        Console.Write("null");
    }
}