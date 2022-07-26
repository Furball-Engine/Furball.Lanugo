using System;
using System.Numerics;
using Furball.Lanugo.Helpers;
using Furball.Lanugo.LanugoEx;
using Silk.NET.Windowing;

namespace Furball.Lanugo.TestApplication {
    public unsafe class Application {
        private D3DCAPS8               _deviceCapabilities;
        private D3DADAPTER_IDENTIFIER8 _deviceIdentifier;

        private IDirect3DDevice8       _device;
        private IDirect3DVertexBuffer8 _vertexBuffer;
        private IDirect3DVertexBuffer8 _vertexBuffer2;
        private uint                   _vertexBufferStride;

        struct TestVertex {
            public Vector4  Position;
            public D3DCOLOR Color;
        }

        private IWindow _window;

        public unsafe Application() {
            IDirect3D8.GetAdapterCount(out uint adapterCount);

            if (adapterCount == 0) {
                throw new Exception("No Direct3D8 Devices found!");
            }

            IDirect3D8.GetDeviceCaps(0, D3DDEVTYPE.Hardware, out this._deviceCapabilities);
            IDirect3D8.GetAdapterIdentifer(0, false, out D3DADAPTER_IDENTIFIER8 adapterIdentifer);

            string driver = PtrHelpers.ToStringASCII(adapterIdentifer.Driver,           512);
            string description = PtrHelpers.ToStringASCII(adapterIdentifer.Description, 512);

            this._deviceIdentifier = adapterIdentifer;

            Console.WriteLine($"[Direct3D8] Running on {driver}");
            Console.WriteLine($"[Direct3D8] Adapter Description: {description}");

            D3DRESULT supportsDisplayAndBackBuffer = IDirect3D8.CheckDeviceType(0, D3DDEVTYPE.Hardware, D3DFORMAT.D3DFMT_X8R8G8B8, D3DFORMAT.D3DFMT_A8R8G8B8, true);
            D3DRESULT supportsSurface = IDirect3D8.CheckDeviceFormat(0, D3DDEVTYPE.Hardware, D3DFORMAT.D3DFMT_X8R8G8B8, D3DFORMATCHECKUSAGE.D3DUSAGE_RENDERTARGET, D3DRESOURCETYPE.D3DRTYPE_SURFACE, D3DFORMAT.D3DFMT_A8R8G8B8);

            if (supportsDisplayAndBackBuffer != D3DRESULT.D3D_OK || supportsSurface != D3DRESULT.D3D_OK) {
                //TODO: make a sort of detector for which format does work
                throw new Exception("Your device does not support the formats expected by the test application!");
            }

            WindowOptions options = WindowOptions.Default;
            options.VSync                   = false;
            //options.ShouldSwapAutomatically = false;
            options.API                     = GraphicsAPI.None;


            this._window = Window.Create(options);

            this._window.Load += Initialize;
            this._window.Render += Draw;

            this._window.Run();
        }

        private unsafe void Initialize() {
            D3DPRESENT_PARAMETERS presentParameters = new D3DPRESENT_PARAMETERS {
                BackBufferWidth  = 1280,
                BackBufferHeight = 720,
                BackBufferFormat = D3DFORMAT.D3DFMT_A8R8G8B8,
                SwapEffect       = D3DSWAPEFFECT.D3DSWAPEFFECT_DISCARD,
                Windowed         = true,
            };

            D3DRESULT result = IDirect3D8.CreateDevice(0, D3DDEVTYPE.Hardware, this._window.Native.Win32.Value.Hwnd, D3DCREATEFLAGS.D3DCREATE_HARDWARE_VERTEXPROCESSING , &presentParameters, out this._device);

            this._device.GetAvailableTextureMem(out uint textureMemory);

            Console.WriteLine($"[Direct3D8] Available Texture Memory: {textureMemory}");

            if (result != D3DRESULT.D3D_OK) {
                throw new Exception("Direct3D8 Device creation failed!");
            }

            int fvfSize = sizeof(D3DCOLOR) + sizeof(Vector4);

            this._device.CreateVertexBuffer((uint) fvfSize * 3, D3DBUFFERUSAGE.D3DUSAGE_DEFAULT, D3DFVF.D3DFVF_DIFFUSE | D3DFVF.D3DFVF_XYZRHW, D3DPOOL.D3DPOOL_MANAGED, out this._vertexBuffer);
            this._device.CreateVertexBuffer((uint) fvfSize * 3, D3DBUFFERUSAGE.D3DUSAGE_DEFAULT, D3DFVF.D3DFVF_DIFFUSE | D3DFVF.D3DFVF_XYZRHW, D3DPOOL.D3DPOOL_MANAGED, out this._vertexBuffer2);

            TestVertex[] verticies = new TestVertex[] {
                new TestVertex {
                    Position = new Vector4(0, 0, 0, 1),
                    Color = D3DCOLOR.FromArgb(255, 255, 0, 0),
                },
                new TestVertex {
                    Position = new Vector4(1280, 0, 0, 1),
                    Color    = D3DCOLOR.FromArgb(255, 0, 255, 0),
                },
                new TestVertex {
                    Position = new Vector4(1280 / 2, 720, 0, 1),
                    Color    = D3DCOLOR.FromArgb(255, 0, 0, 255),
                },
            };

            TestVertex[] verticies2 = new TestVertex[] {
                new TestVertex {
                    Position = new Vector4(0, 0, 0, 1),
                    Color    = D3DCOLOR.FromArgb(255, 255, 0, 0),
                },
                new TestVertex {
                    Position = new Vector4(1280, 0, 0, 1),
                    Color    = D3DCOLOR.FromArgb(255, 0, 255, 0),
                },
                new TestVertex {
                    Position = new Vector4(1280, 720, 0, 1),
                    Color    = D3DCOLOR.FromArgb(255, 255, 0, 255),
                },
            };

            this._vertexBufferStride = (uint)fvfSize;

            this._vertexBuffer.UpdateEx(verticies);
            this._vertexBuffer2.UpdateEx(verticies2);
        }

        private double _frameDelta;
        private int _frames;

        private void Draw(double delta) {
            this._frameDelta += delta;
            this._frames++;

            if (this._frameDelta >= 1.0) {
                Console.WriteLine($"FPS: {this._frames}");

                this._frameDelta = 0;
                this._frames     = 0;
            }

            this._device.Clear(D3DCLEAR.D3DCLEAR_TARGET | D3DCLEAR.D3DCLEAR_STENCIL | D3DCLEAR.D3DCLEAR_ZBUFFER, D3DCOLOR.FromArgb(255, 0, 0, 0));

            this._device.BeginScene();

            this._device.SetVertexShader(D3DFVF.D3DFVF_DIFFUSE | D3DFVF.D3DFVF_XYZRHW);

            this._device.SetStreamSource(0, this._vertexBuffer, this._vertexBufferStride);
            this._device.DrawPrimitive(D3DPRIMITIVETYPE.D3DPT_TRIANGLELIST, 0, 3);

            this._device.SetStreamSource(0, this._vertexBuffer2, this._vertexBufferStride);
            this._device.DrawPrimitive(D3DPRIMITIVETYPE.D3DPT_TRIANGLELIST, 0, 3);

            this._device.EndScene();

            this._device.Present();
        }
    }
}
