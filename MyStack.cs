using System;

namespace Algorithm
{
    class MyStack<T>
    {
        private int capacity;
        private int top = -1;
        private T[] data;

        // 스택의 최대용량
        public int Capcity { get { return capacity; } }
        // 스택의 현재 자료보유량
        public int ContentSize { get { return top + 1; } }

        public MyStack(int capacity)
        {
            this.capacity = capacity;
            data = new T[this.capacity];
        }

        public MyStack<T> Push(T data)
        {
            // 용량이상의 Push를 시행시 용량을 2배로 증가
            if(++top >= capacity)
            {
                capacity *= 2;
                Array.Resize(ref this.data, capacity);
            }
            this.data[top] = data;

            return this;
        }
        
        public T Pop()
        {
            T result;
            try
            {
                // 스택의 내부확인
                if (top == -1)
                {
                    throw new Exception("스택이 비어있습니다.");
                }

                // 결과값
                result = this.data[top--];

                // 수용된 내용이 극도로 적을경우 스택의 사이즈를 축소
                if(top < (int)(capacity / 4))
                {
                    capacity = (int)(capacity / 2);
                    Array.Resize(ref this.data, capacity);
                }

                return result;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return default(T);
            }
        }
    }
}
