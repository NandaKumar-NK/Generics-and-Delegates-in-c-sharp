using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic_Deleigate
{
    internal class GenUse<T>where T : Exception
    {

        /*private T exceptObj;
        public GenUse(T exceptObj)
        {
            this.exceptObj = exceptObj;
        }

        public T disp()
        {
           return exceptObj;
        }*/

        /*private T[] arr;
        public GenUse(int size)
        {
            arr = new T[size];
        }

        public T getarr(int index)
        {
            return arr[index];
        }

        public void setarr(int index, T value)
        {
            arr[index] = value;
        }
        */
        /*private T number;

        public GenUse(T number)
        {
            this.Number = number;
        }

        public T Number { get => number; set => number = value; }*/
    }
}
