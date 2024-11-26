using LinkedListApp;

SLinkedList list = new SLinkedList();
list.AddFront(1);
list.AddFront(2);
list.AddFront(3);
list.AddFront(4);
list.AddFront(5);
list.AddBack(6);
list.AddBack(7);
list.AddBack(8);
list.AddBack(9);
list.AddBack(10);
list.AddAt(-1, 0);
list.AddAt(-2, 11);
list.AddAt(-3,5);
list.AddAt(-4, 34);
list.Print();