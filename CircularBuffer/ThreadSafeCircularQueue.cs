using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircularBufferRealization
{
    public class ThreadSafeCircularQueue
    {
        private int maxQueueCount;
        private int elementCount=0;
        private int AddPointer = 0;
        private int PickPointer = 0;
        private int[] QueueArray;
        public int ElementCount
        {
            get { return elementCount; }
        }
        public ThreadSafeCircularQueue(int maxQueueCnt)
        {
            if (maxQueueCnt <= 0)
            {
                throw new ArgumentException();
            }
            maxQueueCount = maxQueueCnt;
            QueueArray = new int[maxQueueCount];
        }
        public void Add(int element)
        {
            QueueArray[AddPointer] = element;
            if (elementCount == maxQueueCount)
            {
                PickPointer = NextPointer(PickPointer);
            }
            else
            {
                elementCount++;
            }
            AddPointer = NextPointer(AddPointer);
        }

        public int? Pick()
        {
            if (elementCount == 0)
            {
                return null;
            }
            else
            {
                int element = QueueArray[PickPointer];
                PickPointer = NextPointer(PickPointer);
                elementCount--;
                return element;
            }
        }
        private int NextPointer(int pointer)
        {
            if (pointer < maxQueueCount-1)
            {
                return pointer + 1;
            }
            else 
            {
                return 0;
            }
        }
    }
}
