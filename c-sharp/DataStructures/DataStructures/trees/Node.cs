using System;
namespace CodeChallenges.trees
{
  public class Node<T>
  {
    public Node(T v)
    {
      this.Value = v;
    }

    public T Value { get; set; }
    public Node<T> Left { get; set; }
    public Node<T> Right { get; set; }
  }
}
