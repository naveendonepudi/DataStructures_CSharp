namespace DataStructures_CSharp.DynamicArray
{
    public class DynamicArray<T>
    {
        public T[] array;
        public int Length;
        public int Capacity;

        // Initialize the array with a certain capacity
        public DynamicArray(int capacity)
        {
            if (capacity < 0) throw new ArgumentException("Illegal Capacity: " + capacity);
            this.Capacity = capacity;
            this.array = new T[capacity];
        }

        // Given an array make it a dynamic array!
        public DynamicArray(T[] _array)
        {
            if (array == null) throw new NullReferenceException("Array cannot be null");
            this.array = _array;
            Capacity = Length = _array.Length;
        }

        // Returns the size of the array
        public int Size()
        {
            return this.array.Length;
        }

        // Returns true/false on whether the array is empty
        public bool isEmpty()
        {
            return Length <= 0;
        }

        // To get/set values without method call overhead you can do
        // array_obj.arr[index] instead, you can gain about 10x the speed!
        public T Get(int index)
        {
            return this.array[index];
        }

        public void Set(int index, T elem)
        {
            this.array[index] = elem;
        }

        // Add an element to this dynamic array
        public void add(T elem)
        {
            if (Length + 1 >= Capacity)
            {
                if (Capacity == 0) Capacity = 1;
                else Capacity = Capacity++; // incrementing the array
                Array.Resize<T>(ref this.array, Capacity);
            }
            this.array[Length++] = elem;
        }

        // Removes the element at the specified index in this list.
        // If possible, avoid calling this method as it take O(n) time
        // to remove an element (since you have to reconstruct the array!)
        public void removeAt(int rm_index)
        {
            //System.arraycopy(arr, rm_index + 1, arr, rm_index, len - rm_index - 1);
            Array.Copy(this.array, this.array, Length - 1);
            --Length;
            --Capacity;
        }

        // Search and remove an element if it is found in the array
        // If possible, avoid calling this method as it take O(n) time
        public bool remove(T elem)
        {
            for (int i = 0; i < Length; i++)
            {
                if (array != null && this.array.Length > 0 && this.array[i].Equals(elem))
                {
                    removeAt(i);
                    return true;
                }
            }
            return false;
        }

        // Reverse the contents of this array
        public void reverse()
        {
            for (int i = 0; i < Length / 2; i++)
            {
                T tmp = this.array[i];
                this.array[i] = this.array[Length - i - 1];
                this.array[Length - i - 1] = tmp;
            }
        }

        // Perform a binary search on this array to find an element in O(log(n)) time
        // Make sure this array is sorted! Returns a value < 0 if item is not found
        public int binarySearch(T key)
        {
            int index = Array.BinarySearch<T>(this.array, key);
            if (index < 0) index = -index - 1; // If not found this will tell you where to insert
            return index;
        }

        // Sort this array
        public void sort()
        {
            Array.Sort(this.array);
        }
    }
}
