using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstCSWinApplication
{
    class PrinterEnumToStr<T>: IPrinterEnumerable<T>
    {
        StringBuilder strBRes;

        public string ResultStr => strBRes.ToString();
        
        public PrinterEnumToStr()
        {
            strBRes = new StringBuilder();
        }

        public void PrintEnumerable(IEnumerable<T> objEnum)
        {
            strBRes.Clear();

            foreach(T obj in objEnum)
            {
                strBRes.Append(obj.ToString() + " ");    
            }

            strBRes.Remove(strBRes.Length - 1, 1);
        }
    }
}
