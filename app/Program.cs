//#define HOSTED

#if HOSTED
using MyLib;
#endif

using System;

namespace app
{
    class Program
    {
        static void Main(string[] args)
        {
#if HOSTED
            MyClass.MyMethod1();
#endif
        }
    }
}
