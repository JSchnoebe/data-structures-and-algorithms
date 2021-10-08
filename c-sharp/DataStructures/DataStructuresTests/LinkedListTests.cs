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
  }
}
