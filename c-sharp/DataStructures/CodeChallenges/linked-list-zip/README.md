# Zip Linked Lists

Given 2 linked lists, return a single linked list with nodes zipped together, or alternating between the nodes.

## Whiteboard Process

![Zip Linked Lists](./linkedlistzip.jpg)

## Aproach and Efficiency

Make a while loop that will loop while the current head of both lists is null, set the current.Next to equal the current of the second linked list. Reapeat this until there are no more nodes to be zippered.
