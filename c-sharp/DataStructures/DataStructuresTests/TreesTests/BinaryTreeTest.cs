using System;
using DataStructures.trees;
using DataStructures;
using Xunit;
using CodeChallenges.trees;
using System.Collections.Generic;

namespace DataStructures.TreesTests
{
  public class BinaryTreeTest
  {

    [Fact]
    public void Binary_Tree_Is_Empty()
    {
      //Arange
      BinaryTree<int> t = new BinaryTree<int>();

      //Act
      IEnumerable<int> result = t.PreOrder();

      //Assert
      Assert.Empty(result);
    }

    [Fact]
    public void Binary_Tree_Has_One_Root_Node()
    {
      //Arange
      BinaryTree<int> t = new BinaryTree<int>();
      t.Root = new Node<int>(1);

      //Act
      IEnumerable<int> result = t.PreOrder();

      //Assert
      Assert.Equal(new[] { 1 }, result);

    }

    [Fact]
    public void Root_Has_Left_And_Right_Child()
    {
      //Arange
      BinaryTree<int> t = new BinaryTree<int>();
      t.Root = new Node<int>(1);
      t.Root.Left = new Node<int>(2);
      t.Root.Right = new Node<int>(3);

      //Act
      IEnumerable<int> result = t.PreOrder();

      //Assert
      Assert.Equal(new[] { 1, 2, 3 }, result);

    }

  }
}
