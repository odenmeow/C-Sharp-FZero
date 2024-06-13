using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CH2_1
{
    // 這邊  internal 可以不寫，預設就是internal可見而已。
    internal class Hello
    {
        public static void Main()
        {
            // 新增物件方式 可以化簡為 Bike b = new();
            String hello = "Hello, Oni";
            Console.WriteLine(hello);
        }
    }
}
