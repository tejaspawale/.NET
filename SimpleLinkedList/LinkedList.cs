using LinkedList.CreateNode;

namespace LinkedList.List
{
    public class linkedlist
    {
        Node head = null;


        public void AddNodeEnd(int data)
        {
            Node node = new Node(data);
           
                Node p = head;
                while (p.next != null)
                {
                    p = p.next;
                }

                p.next = node;

            
        }

        public void AddNodeMiddle(int data,int loc)
        {
            Node node = new Node(data);
           
                Node p = head;
                int traverseIndex=1;
                while (traverseIndex != loc-1)
                {
                    p = p.next;
                    traverseIndex++;
                }
                if(p.next==null)
                {
                    AddNodeEnd(data);
                }
                else
                {
                    node.next= p.next;
                    p.next=node;
                }

            
        }

        public void AddNodeFirst(int data)
        {
            Node node = new Node(data);
            node.next = head;
            head = node;
        }

        public void Display()
        {
            Node p = head;
            while (p != null)
            {
                Console.Write(p.data + "-->");
                p = p.next;
            }
        }

        public void DeleteFromEnd()
        {
            Node current = head;
            while (current.next.next != null)
            {
                current = current.next;
            }
            current.next = null;

        }

        public void DeleteFromFirst()
        {
            head = head.next;

        }

        public void DeleteFromMiddle(int data)
        {
            Node current = head;
            while (current.next.data != data)
            {
                current = current.next;
            }
            if(current.next.data == null)
            {
                DeleteFromEnd();
            }
            else
            {
                current.next = current.next.next;
            }

        }


       public void Delete(int data)
        {
            if(head.data==data)
            {
                DeleteFromFirst();
            }
            else
            {
                DeleteFromMiddle(data);
            }
        }


        public void Insert(int data,int loc)
        {
            if (head==null || loc==1)
            {
                AddNodeFirst(data);
            }
            else
            {
                AddNodeMiddle(data,loc);
            }
        }


        public void Update(int olddata, int newdata)
        {
            Node current = head;
            while (current.data != olddata)
            {
                current = current.next;
            }
            current.data = newdata;
        }

    }

}