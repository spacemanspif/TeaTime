using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeaTime
{
    class Program
    {
        static void Main(string[] args)
        {
        }

        public class CommSetting
        {
            public static int CommPort = 0;
            public static Int64 CommBaudRate = 0;
            public static Int64 ComeTimeOut = 0;
            public static GsmCommMain comm;

            public CommSetting()
            { 
            
            }
        }
    }
}
