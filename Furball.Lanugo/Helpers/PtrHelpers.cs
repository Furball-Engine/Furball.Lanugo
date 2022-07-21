using System;
using System.Runtime.InteropServices;
using System.Text;

namespace Furball.Lanugo.Helpers {
    public static class PtrHelpers {
        public static unsafe string ToStringASCII(byte* ptr, uint length) {
            byte[] arr = new byte[length];
            Marshal.Copy((IntPtr)ptr, arr, 0, 512);

            return Encoding.ASCII.GetString(arr);
        }
    }
}
