namespace DataStructures_CSharp.DoublyLinkedList
{
    public class DoublyLinkedList<T>
    {
        public DoublyLinkedList()
        {
            head = null;
        }
        private int size = 0;
        private Node<T>? head = null;
        private Node<T>? tail = null;

        public int Count()
        {
            return size;
        }

        public void Clear()
        {
            this.head = null;
            this.tail = null;
            this.size = 0;
        }

        // Add an element to the tail of the linked list, O(1)
        public void add(T elem)
        {
            addAtLast(elem);
        }

        private void addAtLast(T? elem)
        {
            if(isEmtpy())
                head = tail = new Node<T>(elem, null, null);
            else
            {
                tail = new Node<T>(elem, tail, null);
            }
        }

        public bool isEmtpy()
        {
            return size == 0;
        }
    }

    public class Node<T>
    {
        public T? data;
        public Node<T>? previous, next;
        public Node(T? data, Node<T>? previous, Node<T>? next)
        {
            this.data = data;
            this.previous = previous;
            this.next = next;
        }
    }
}
