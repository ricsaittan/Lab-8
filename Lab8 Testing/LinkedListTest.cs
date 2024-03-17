using static LinkedList<string>;

[TestFixture]
public class LinkedListTesting
{
    private LinkedList<string> _LinkedList = new LinkedList<string>();
    [SetUp]
    public void Setup()
    {        
        LinkedList<string> _LinkedList = new LinkedList<string>();
    }

    [Test]
    public void Test1()
    {
        _LinkedList.AddFirst("Sam Sammerson");
        _LinkedList.AddFirst("Joe Schmoe");
        _LinkedList.AddFirst("John Smith");
        _LinkedList.AddFirst("Jane Doe");
        _LinkedList.AddFirst("Bob Bobberson");
    }
    [Test]
    public void Test2()
    {
        _LinkedList.AddLast("Dave Daverson");
    }
    [Test]
    public void Test3()
    {
        _LinkedList.RemoveFirst();
    }
    [Test]
    public void Test4()
    {
        _LinkedList.RemoveLast();
    }
    [Test]
    public void Test5()
    {
        _LinkedList.GetValue(3);
    }
    [Test]
    public void Test6()
    {
        Console.WriteLine(_LinkedList.Count);
    }
}