using System;
using System.Collections.Generic;
using System.Text;

namespace Valify_my_question
{
    class Class1:IDisposable
    {
        public void DoSomething()
        {
            Console.WriteLine("Do some thing....");
        }
        public void Dispose()
        {
            Console.WriteLine("及时释放资源");
        }
    }
}
