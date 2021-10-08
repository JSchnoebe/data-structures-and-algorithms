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

      Assert.NotNull(list.Head);
      Assert.Equal(1, list.Head.Value);
    }
  }
}
