using System;
using DataStructures.trees;
namespace DataStructures.trees
{
  public class BinaryTree<T>
  {
    public Node<T> Root { get; set; }

    public IEnumerable<T> PreOrder()
    {
      // Option 1
      return PreOrder(Root);

      List<T> results = new List<T>();
      PreOrder(Root, results);
      return results;
    }
    private IEnumerable<T> PreOrder(Node root, List<T> results) { }
  }
}
