using System;
using System.Runtime.CompilerServices;

namespace Lib
{
    public class Interop
    {
        public static unsafe void Read<T>(IntPtr source, T[] values) where T : unmanaged
        {
            int count = values.Length;
            fixed (void* dstPtr = values)
            {
                Unsafe.CopyBlockUnaligned(dstPtr, (void*)source, (uint)(count * sizeof(T)));
            }
        }
    }
}
