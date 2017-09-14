using System;

namespace Algorithm
{
    class MySLList<T>
    {
        private int count = 0;
        private Node head = null;
        private Node tail = null;

        public int Count
        {
            get
            {
                return count;
            }
        }

        public MySLList<T> AddNode(T data)
        {
            Node node = new Node();
            node.data = data;
            node.nextNode = null;

            if(head == null)
            {
                head = node;
                tail = node;
            }
            else
            {
                tail.nextNode = node;
                tail = node;
            }
            count++;

            return this;
        }

        public T GetNodeDataAt(int index)
        {
            Node curruntNode = head;

            try
            {
                if (curruntNode == null)
                    throw new Exception("저장된 데이터가 없습니다.");
                if (index >= count)
                    throw new Exception("인덱스 범위를 초과합니다. (범위 : " + (count - 1) + "), 입력값 : " + index);

                while (curruntNode != null && --index >= 0)
                {
                    curruntNode = curruntNode.nextNode;
                }

                return curruntNode.data;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return default(T);
            }           
        }

        public MySLList<T> RemoveNode(int index)
        {
            Node curruntNode = head;

            try
            {
                if (curruntNode == null)
                    throw new Exception("저장된 데이터가 없습니다.");
                if (index >= count)
                    throw new Exception("인덱스 범위를 초과합니다. (범위 : " + (count - 1) + "), 입력값 : " + index);
                if (index == 0)
                {
                    head = curruntNode.nextNode;
                    return this;
                }

                while (--index >= 1)
                {
                    curruntNode = curruntNode.nextNode;
                }

                curruntNode.nextNode = curruntNode.nextNode.nextNode;
                count--;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            return this;
        }

        public MySLList<T> InsertNode(int index, T data)
        {
            Node curruntNode = head;
            Node node = new Node();
            node.data = data;

            try
            {
                if (index >= count)
                    throw new Exception("인덱스 범위를 초과합니다. (범위 : " + (count - 1) + "), 입력값 : " + index);
                if (index == 0)
                {
                    if (curruntNode != null)
                    {
                        node.nextNode = curruntNode;
                    }
                    head = node;

                    return this;
                }

                while (curruntNode != null && --index >= 1)
                {
                    curruntNode = curruntNode.nextNode;
                }

                node.nextNode = curruntNode.nextNode;
                curruntNode.nextNode = node;
                count++;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            return this;
        }

        public MySLList<T> DeleteAll()
        {
            head = null;
            count = 0;

            return this;
        }

        private class Node
        {
            public T data { set; get; }
            public Node nextNode { set; get; }
        }
    }
}
