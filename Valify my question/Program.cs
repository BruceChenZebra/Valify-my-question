using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.IO.IsolatedStorage;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;

namespace Valify_my_question
{
    class Program
    {
        static void Main(string[] args)
        {
            //Class1 a = new Class1();
            //a.DoSomething();
            //a.Dispose();
            using (Class1 caryClass = new Class1())

            {
                //string str = @"\\\\10.48.212.48\\Bruce\\Chen";
                //str.Replace("\\\\", "\\");
                //Console.WriteLine(str);
                //Console.ReadKey();


                //string str = @"\\\\fasdfa\\sdf192.168.0.2asdfasdf";
                //Match m = Regex.Match(str, @"\d{1,3}.\d{1,3}.\d{1,3}.\d{1,3}");
                //Console.WriteLine(m.Value);
                //Console.ReadKey();
                string path = @"D:\desktop\draft\EF teacher.txt";
                byte[] bytsize = new byte[1024 * 1024 * 5];
                using (FileStream stream = new FileStream(path, FileMode.OpenOrCreate, FileAccess.ReadWrite))
                {
                    while (true)
                    {

                        //StreamReader r = new StreamReader(path, Encoding.Default);
                        //string str;
                        //str = r.ReadToEnd();
                        //Console.WriteLine(str);

                        int r = stream.Read(bytsize, 0, bytsize.Length);
                        //如果读取到的字节数为0，说明已到达文件结尾，则退出while循
                        if (r == 0)
                        {
                            break;
                        }
                        string str = Encoding.Default.GetString(bytsize, 0, r);
                        Console.WriteLine(str);
                    }
                    stream.Close();
                }


            }
        }
    }
}


