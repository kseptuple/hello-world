using System;
using System.Runtime.InteropServices;

namespace HelloWorld
{
    class Program
    {
        static unsafe void Main(string[] args)
        {
            Console.WriteLine(new string((char*)GCHandle.Alloc(new long[] { 30399761347838056, 33495659670405231, 28147961535004783 }, GCHandleType.Pinned).AddrOfPinnedObject().ToPointer()));
            Console.ReadKey();
        }
    }
}
