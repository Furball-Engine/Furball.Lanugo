using System;
using System.Runtime.InteropServices;
using System.Text;
using Furball.Lanugo.Helpers;
using Silk.NET.Windowing;
using Silk.NET.Windowing.Sdl;

namespace Furball.Lanugo.TestApplication {
    class Program {
        static unsafe void Main(string[] args) {
            Direct3D8.CreateDirect3D8();

            Direct3D8.GetAdapterModeCount(0, out uint adapterModeCount);
            Direct3D8.EnumAdapterModes(0, 0, out D3DDISPLAYMODE displayMode);
            Direct3D8.GetAdapterDisplayMode(0, out D3DDISPLAYMODE adapterDisplayMode);

            D3DRESULT supportsMultisample2x = Direct3D8.CheckDeviceMultisampleType(0, D3DDEVTYPE.Hardware, D3DFORMAT.D3DFMT_X8R8G8B8, true, D3DMULTISAMPLE_TYPE.D3DMULTISAMPLE_2_SAMPLES);
            D3DRESULT supportsDepthStencil = Direct3D8.CheckDepthStencilMatch(0, D3DDEVTYPE.Hardware, D3DFORMAT.D3DFMT_A8R8G8B8, D3DFORMAT.D3DFMT_X8R8G8B8, D3DFORMAT.D3DFMT_D16);

            IntPtr monitorHandle = Direct3D8.GetAdapterMonitor(0);

            new Application();
        }
    }
}
