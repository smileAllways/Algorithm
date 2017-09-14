using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm
{
    class Program
    {
        static void Main(string[] args)
        {
            
        }

        static void MySLL()
        {
            MySLList<int> mySLList = new MySLList<int>();

            mySLList.AddNode(0).AddNode(1).AddNode(2).AddNode(3).InsertNode(0, 4).InsertNode(3, 5).InsertNode(10, 6); // 맨 마지막 값은 범위초과
            for (int i = 0; i < mySLList.Count; i++)
            {
                Console.WriteLine("{0}번째 노드 : {1}", i, mySLList.GetNodeDataAt(i));
            }
            mySLList.GetNodeDataAt(mySLList.Count);  // 범위초과

            mySLList.RemoveNode(mySLList.Count - 1).RemoveNode(mySLList.Count); // 끝 노드삭제 후, 범위초과

            mySLList.DeleteAll().RemoveNode(0).GetNodeDataAt(0); // 값 삭제 후 범위초과

            Console.WriteLine("새로운 값 저장 : " + mySLList.AddNode(0).GetNodeDataAt(0));

            Console.ReadLine();
        }
    }
}
