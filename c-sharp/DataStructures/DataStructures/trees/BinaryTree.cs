using System;
using System.Collections.Generic;
using CodeChallenges.trees;
using DataStructures.trees;
namespace DataStructures.trees
{
  public class BinaryTree<T>
  {
    public Node<T> Root { get; set; }

    public IEnumerable<T> PreOrder()
    {

      return PreOrder(Root, new List<T>());
    }


    private IEnumerable<T> PreOrder(Node<T> root, List<T> results)
    {
      if (Root.Left != null)
        PreOrder(Root.Left, results);

      if (Root.Right != null)
        PreOrder(Root.Right, results);

      return results;
    }
  }
}
