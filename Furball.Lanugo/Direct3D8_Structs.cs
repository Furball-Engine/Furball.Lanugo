using System;

namespace Furball.Lanugo {

    public struct Guid {
        public              uint   Data1;
        public              ushort Data2;
        public              ushort Data3;
        public unsafe fixed byte   Data4[8];
    }

    public struct D3DCAPS8 {
        public D3DDEVTYPE DeviceType;
        public uint       AdapterOrdinal;

        /* Caps from DX7 Draw */
        public D3DCAPS_ENUM        Caps;
        public D3DCAPS2_ENUM       Caps2;
        public D3DCAPS3_ENUM       Caps3;
        public D3DPRESENT_INTERVAL PresentationIntervals;

        /* Cursor Caps */
        public D3DCURSORCAPS CursorCaps;

        /* 3D Device Caps */
        public D3DDEVCAPS DevCaps;

        public D3DPRIMITIVEMISCCAPS  PrimitiveMiscCaps;
        public D3DRASTERCAPS         RasterCaps;
        public D3DPCMPCAPS           ZCmpCaps;
        public D3DPBLENDCAPS         SrcBlendCaps;
        public D3DPBLENDCAPS         DestBlendCaps;
        public D3DPCMPCAPS           AlphaCmpCaps;
        public D3DPSHADECAPS         ShadeCaps;
        public D3DTEXTURECAPS        TextureCaps;
        public D3DTEXTUREFILTERCAPS  TextureFilterCaps;
        public D3DTEXTUREFILTERCAPS  CubeTextureFilterCaps;
        public D3DTEXTUREFILTERCAPS  VolumeTextureFilterCaps;
        public D3DTEXTUREADDRESSCAPS TextureAddressCaps;
        public D3DTEXTUREFILTERCAPS  VolumeTextureAddressCaps;

        public D3DLINECAPS LineCaps;// D3DLINECAPS

        public uint MaxTextureWidth;
        public uint MaxTextureHeight;
        public uint MaxVolumeExtent;

        public uint  MaxTextureRepeat;
        public uint  MaxTextureAspectRatio;
        public uint  MaxAnisotropy;
        public float MaxVertexW;

        public float GuardBandLeft;
        public float GuardBandTop;
        public float GuardBandRight;
        public float GuardBandBottom;

        public float          ExtentsAdjust;
        public D3DSTENCILCAPS StencilCaps;

        public D3DFVFCAPS       FVFCaps;
        public D3DTEXTUREOPCAPS TextureOpCaps;
        public uint             MaxTextureBlendStages;
        public uint             MaxSimultaneousTextures;

        public uint VertexProcessingCaps;
        public uint MaxActiveLights;
        public uint MaxUserClipPlanes;
        public uint MaxVertexBlendMatrices;
        public uint MaxVertexBlendMatrixIndex;

        public float MaxPointSize;

        /// <summary>
        /// max number of primitives per DrawPrimitive call
        /// </summary>
        public uint MaxPrimitiveCount;
        public uint MaxVertexIndex;
        public uint MaxStreams;
        /// <summary>
        /// max stride for SetStreamSource
        /// </summary>
        public uint MaxStreamStride;

        public uint VertexShaderVersion;
        /// <summary>
        /// number of vertex shader constant registers
        /// </summary>
        public uint MaxVertexShaderConst;

        public uint  PixelShaderVersion;
        /// <summary>
        /// max value of pixel shader arithmetic component
        /// </summary>
        public float MaxPixelShaderValue;
    }

    public struct LargeInteger {
        public uint LowPart;
        public int  HighPart;
    }

    public struct D3DADAPTER_IDENTIFIER8 {
        public unsafe fixed byte         Driver[512];
        public unsafe fixed byte         Description[512];
        public              LargeInteger DriverVersion;
        public              uint         VendorId;
        public              uint         DeviceId;
        public              uint         SubSysId;
        public              uint         Revision;
        public              Guid         DeviceIdentifier;
        public              uint         WHQLLevel;
    }

    public struct D3DDISPLAYMODE {
        public uint      Width;
        public uint      Height;
        public uint      RefreshRate;
        public D3DFORMAT Format;
    }

    public struct D3DPRESENT_PARAMETERS {
        public uint      BackBufferWidth;
        public uint      BackBufferHeight;
        public D3DFORMAT BackBufferFormat;
        public uint      BackBufferCount;

        public D3DMULTISAMPLE_TYPE MultiSampleType;

        public D3DSWAPEFFECT               SwapEffect;
        public IntPtr                      hDeviceWindow;
        public int                         Windowed;
        public int                         EnableAutoDepthStencil;
        public D3DFORMAT                   AutoDepthStencilFormat;
        public D3DPRESENT_PARAMETERS_FLAGS Flags;

        public uint FullScreen_RefreshRateInHz;
        public uint FullScreen_PresentationInterval;
    }
}