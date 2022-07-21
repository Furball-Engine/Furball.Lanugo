using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Furball.Lanugo {

    public unsafe struct Direct3D8 {
        delegate int GetDeviceCapsDelegate(Direct3D8* d3d8, uint adapter, D3DDEVTYPE deviceType, void* pCaps);

        [DllImport("d3d8", CallingConvention = CallingConvention.Winapi, CharSet = CharSet.Ansi, ExactSpelling = true)]
        private static extern Direct3D8* Direct3DCreate8(uint sdkVersion);

        public void** LpVtbl;

        private static Direct3D8* _d3d8;

        public static void CreateDirect3D8() {
            Direct3D8* d3d8 = Direct3D8.Direct3DCreate8(120);

            _d3d8 = d3d8;
        }

        public static D3DCAPS8 GetDeviceCaps(uint adapter, D3DDEVTYPE deviceType) {
            D3DCAPS8 caps = new D3DCAPS8();

            GetDeviceCapsDelegate functionDelegate = Marshal.GetDelegateForFunctionPointer<GetDeviceCapsDelegate>((IntPtr)_d3d8->LpVtbl[13]);

            functionDelegate(_d3d8, adapter, deviceType, &caps);

            return caps;
        }
    }
}