using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyFirstCSWinApplication
{
    class ConvertorCollectionsUtils
    {
        internal static void FillDictionary<T, Key>(Dictionary<Key, T> dic, T [] elements, Key [] keys)
        {
            if (elements.Length != keys.Length) throw new Exception("Ошибка при инициализации словаря!");

            for(int i = elements.Length; --i>=0;)
            {
                dic.Add(keys[i], elements[i]);
            }
        }
    }
}
