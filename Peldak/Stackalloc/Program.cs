using BenchmarkDotNet.Running;
using System;
using System.Diagnostics;

namespace Stackalloc
{
    class Program
    {

        public void Pelda()
        {
            Span<int> pelda = stackalloc int[100]; //stack-en allokálás
            Span<int> slice = pelda[1..12]; //slice
        }

        static void Main(string[] args)
        {
            BenchmarkSwitcher.FromAssembly(typeof(Program).Assembly).Run(args);
        }
    }
}
