namespace TFLcll;

public class CircularLinklist
{
    private Node head;
    public void Insert(int data)
    {

        Node newNode = new Node(data);
        if(head == null)
        {
            head =newNode;
            head.next= head;
            return;
        }

        if (data <= head.data)
        {
            Node last =head;

            while (last.next != head)
            {
                last=last.next;

            }
            newNode.next=head;
            last.next=newNode;
            head=newNode;
            return;
        }

        Node current =head;
        while(current.next!=head && current.next.data < data)
        {
            current=current.next;
        }

        newNode.next = current.next;
        current.next = newNode;

    }

    public void Display()
    {
        Node current = head;
        do
        {
            Console.Write(current.data +"-->");
            current =current.next;
        }
        while (current != head);

        Console.WriteLine();
    }
    public void Update(int oldData, int newData)
    {
        Node current = head;
        do
        {
            if (current.data == oldData)
            {
                current.data = newData;
                Console.WriteLine(" Data Found");
                return;
            }

            current = current.next;
        }
        while(current != head);

        Console.WriteLine("Data not Found");
    }
}