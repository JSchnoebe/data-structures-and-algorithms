using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures
{
  public class LinkedList
  {
    public Node Head { get; set; }

    public void Insert(int value)
    {
      Node newNode = new Node();
      newNode.Value = value;

      newNode.Next = Head;

      Head = newNode;
    }

    public void Append(int value)
    {
      Node newNode = new Node();
      newNode.Value = value;

      Node current = Head;

      while (current != null)
      {
        if (current.Next == null)
        {
          current.Next = newNode;
          break;
        }
          current = current.Next;
        }

    }

    public void InsertBefore(int value, int newValue)
    {
      Node newNode = new Node();
      newNode.Value = value;

      Node current = Head;

      while (current != null)
      {
        if (current.Next.Value == newValue)
        {
          current.Next = newNode;
          break;

        }
          current = current.Next;
      }
    }

    public void InsertAfter(int value, int newValue)
    {
      Node newNode = new Node();
      newNode.Value = value;

      Node current = Head;

      for (int i = 0; i < value; i++)
      {
        if (current.Next.Value == newValue)
        {
          current.Next = newNode;
          break;
        }
          current = current.Next;
        }
    }

    public int FindKthValue(int value)
    {
      Node current = Head;
      int length = 0;

      while(current != null)
      {
        current = current.Next;
        length++;
        
      }

      current = Head;

      for (int i = 0; i < length - value; i++)
      
        current = current.Next;
        return current.Value;
    }
  }
}