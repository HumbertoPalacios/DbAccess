using OOPDEMO.Demo1;
using OOPDEMO.Demo3;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPDEMO
{
    class Program
    {
        static void Main(string[] args)
        {
            //ClassTester ct = new ClassTester();
            //ct.Test();
            //Console.ReadLine();

            DataTest dt = new DataTest();
            dt.TestReadAll();
            dt.TestReadOne();
        }
    }
}
