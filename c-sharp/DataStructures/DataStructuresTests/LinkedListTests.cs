using System;
using Xunit;

using DataStructures;

namespace DataStructuresTests
{
  public class LinkedListTests
  {
    [Fact]
    public void Empty_List_has_null_Head()
    {

      //Arrange
      LinkedList list = new LinkedList();

      //Act
      Node head = list.Head;

      //Assert
      Assert.Null(head);
    }

    [Fact]
    public void Insert_adds_Node_with_Value_at_Head()
    {
      LinkedList list = new LinkedList();

      list.Insert(1);

      //Make sure we have a Head node
      Assert.NotNull(list.Head);

      //Make sure the Head node has the inserted Value
      Assert.Equal(1, list.Head.Value);

      //Make sure the Head node does not have a Next
      Assert.Null(list.Head.Next);
    }
  }
}
