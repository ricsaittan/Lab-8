public class LinkedList<T>
{
    public Node<T>? Head { get; private set; }
    public Node<T>? Tail { get; private set; }
    public int Count { get; private set; }
    public LinkedList()
    {
        Head = null;
        Tail = null;
        Count = 0; 
    }
    //Method that adds a node in the first index
    public void AddFirst(T data)
    {
        Node<T> newNode = new Node<T>(data);
        if (Head == null) 
        {
            Head = newNode;
            Tail = newNode;
        }
        else
        {
            newNode.Next = Head;
            Head = newNode;
        }
        Count++;
    }
    //Adds a node at the end of the index
    public void AddLast(T data)
    {
        Node<T>? newNode = new Node<T>(data);
        if (Head == null) 
        {
            Head = newNode;
        }
        else 
        {
            Tail.Next = newNode;
        }
        Tail = newNode;
        Count++; 
    }
    //Removes the first index of the node and replaces it with the next
    public void RemoveFirst()
    {
        if (Head != null) 
        {
            Head = Head.Next;
            if (Head == null) 
            {
                Tail = null;
            }
            Count--; 
        }
        else
        {
            Console.WriteLine("List is already empty.");
        }
    }
    //Removes the last index of the node and replaces it with the one before
    public void RemoveLast()
    { 
        if (Head == null)
        { 
            Console.WriteLine("List is already empty.");
            return;
        }
        if (Head.Next == null) 
        {  
            Head = null;
            Tail = null;
        } 
        else
        { 
            Node<T> current = Head;
            while (current.Next.Next != null)
            { 
                current = current.Next;
            }
            current.Next = null; 
            Tail = current; 
        }
        Count--;
    }
    //Gets the specific node given the index
    public void GetValue(int index)
    {
        if (Head == null)
        {
            Console.WriteLine("List is empty.");
        }
        else if (index > Count || index < 0)
        {
            Console.WriteLine("Number is outside of index");
        }
        else if (index == 0)
        {
            Node<T> current = Head;
            Console.WriteLine($"Index 0 is {current.Data}");
        }
        else
        {
            Node<T> current = Head;
            for (int i = 0; i < index; i++)
            {
                current = current.Next;
            }
            Console.WriteLine($"Index {index} is {current.Data}");
        }
    }
}
