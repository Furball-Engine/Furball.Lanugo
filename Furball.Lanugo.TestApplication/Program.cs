using System;
using System.Runtime.InteropServices;
using System.Text;
using Furball.Lanugo.Helpers;

namespace Furball.Lanugo.TestApplication {
    class Program {
        static unsafe void Main(string[] args) {
            Direct3D8.CreateDirect3D8();
            Direct3D8.GetAdapterCount(out uint adapterCount);
            Direct3D8.GetAdapterModeCount(0, out uint adapterModeCount);
            Direct3D8.EnumAdapterModes(0, 0, out D3DDISPLAYMODE displayMode);
            Direct3D8.GetAdapterIdentifer(0, 0, out D3DADAPTER_IDENTIFIER8 adapterIdentifer);
            Direct3D8.GetDeviceCaps(0, D3DDEVTYPE.Hardware, out D3DCAPS8 deviceCaps);
            Direct3D8.GetAdapterDisplayMode(0, out D3DDISPLAYMODE adapterDisplayMode);

            int supportsDisplayAndBackBuffer = Direct3D8.CheckDeviceType(0, D3DDEVTYPE.Hardware, D3DFORMAT.D3DFMT_A8R8G8B8, D3DFORMAT.D3DFMT_A8R8G8B8, true);
            int supportsSurface = Direct3D8.CheckDeviceFormat(0, D3DDEVTYPE.Hardware, D3DFORMAT.D3DFMT_A8R8G8B8, 1, D3DRESOURCETYPE.D3DRTYPE_SURFACE, D3DFORMAT.D3DFMT_X8R8G8B8);
            int supportsMultisample2x = Direct3D8.CheckDeviceMultisampleType(0, D3DDEVTYPE.Hardware, D3DFORMAT.D3DFMT_X8R8G8B8, true, D3DMULTISAMPLE_TYPE.D3DMULTISAMPLE_2_SAMPLES);
            int supportsDepthStencil = Direct3D8.CheckDepthStencilMatch(0, D3DDEVTYPE.Hardware, D3DFORMAT.D3DFMT_A8R8G8B8, D3DFORMAT.D3DFMT_X8R8G8B8, D3DFORMAT.D3DFMT_D16);

            IntPtr monitorHandle = Direct3D8.GetAdapterMonitor(0);

            string driver = PtrHelpers.ToStringASCII(adapterIdentifer.Driver, 512);
            string description = PtrHelpers.ToStringASCII(adapterIdentifer.Description, 512);

            D3DPRESENT_PARAMETERS presentParameters = new D3DPRESENT_PARAMETERS {
                BackBufferWidth        = 640,
                BackBufferHeight       = 480,
                BackBufferFormat       = D3DFORMAT.D3DFMT_A8R8G8B8,
                SwapEffect             = D3DSWAPEFFECT.D3DSWAPEFFECT_DISCARD,
                Windowed               = 1,
                AutoDepthStencilFormat = D3DFORMAT.D3DFMT_D16,
                EnableAutoDepthStencil = 1,
            };

            IDirect3DDevice8* devicePtr = null;

            Direct3D8.CreateDevice(0, D3DDEVTYPE.Hardware, IntPtr.Zero, 64, &presentParameters, ref devicePtr);
        }
    }
}
