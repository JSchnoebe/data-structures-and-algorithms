namespace DataStructures
{
  public partial class Program
  {
    class PseudoQueue
    {
      Stack s1 = new Stack();
      Stack s2 = new Stack();
      int v = int.MaxValue;

      Enqueue(v) {

        s1.push(v);
      }

      Dequeue()
      {
        if (s2.IsEmpty)
        {
          while (!s1.IsEmpty)
            s2.push(s1.pop())
        };
        return s2.pop();
      }
    }
  }
}
