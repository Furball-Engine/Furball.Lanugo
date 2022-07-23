using System;
using System.Drawing;
using System.Numerics;

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

    public struct D3DDEVICE_CREATION_PARAMETERS {
        public uint       AdapterOrdinal;
        public D3DDEVTYPE DeviceType;
        public IntPtr     FocusWindow;
        public uint       BehaviourFlags;
    }

    public struct RECT {
        public uint Left, Top, Right, Bottom;
    }

    public struct D3DRECT {
        public uint X1, Y1, X2, Y2;
    }

    public struct D3DPOINT {
        public uint X, Y;
    }

    public unsafe struct D3DRGNDATA {
        public       uint    Size;
        public       uint    Type;
        public       uint    Count;
        public       uint    RgnSize;
        public       D3DRECT Bound;
        public fixed char    Buffer[1];
    }

    public struct D3DRASTER_STATUS {
        public int  InVBlank;
        public uint ScanLine;
    }

    public unsafe struct D3DGAMMARAMP {
        public fixed ushort Red[256];
        public fixed ushort Green[256];
        public fixed ushort Blue[256];
    }

    public struct D3DVIEWPORT8 {
        public uint  X,    Y, Width, Height;
        public float MinZ, MaxZ;
    }

    public struct D3DCOLOR {
        public uint ColorValue;

        public static D3DCOLOR FromArgb(int a, int r, int g, int b) {
            return new D3DCOLOR {
                ColorValue = (uint) ( ((a & 0xff) << 24) + ((r & 0xff) << 16) + ((g & 0xff) << 8) + (b & 0xff) )
            };
        }
    }

    public struct D3DCOLORVALUE {
        public float R, G, B, A;
    }

    public struct D3DMATERIAL8 {
        /// <summary>
        /// Diffuse color RGBA
        /// </summary>
        public D3DCOLORVALUE Diffuse;
        /// <summary>
        /// Ambient color RGB
        /// </summary>
        public D3DCOLORVALUE Ambient;
        /// <summary>
        /// Specular 'shininess
        /// </summary>
        public D3DCOLORVALUE Specular;
        /// <summary>
        /// Emissive color RGB
        /// </summary>
        public D3DCOLORVALUE Emissive;
        /// <summary>
        /// Sharpness if specular highlight
        /// </summary>
        public float Power;
    }

    public struct D3DLIGHT8 {
        /// <summary>
        /// Type of light source
        /// </summary>
        public D3DLIGHTTYPE Type;
        /// <summary>
        /// Diffuse color of the light
        /// </summary>
        public D3DCOLORVALUE Diffuse;
        /// <summary>
        /// Specular color of the light
        /// </summary>
        public D3DCOLORVALUE Specular;
        /// <summary>
        /// Ambient color of the light
        /// </summary>
        public D3DCOLORVALUE Ambient;
        /// <summary>
        /// Position in World Space
        /// </summary>
        public Vector3 Position;
        /// <summary>
        /// Direction in World Space
        /// </summary>
        public Vector3 Direction;
        /// <summary>
        /// Cutoff Range
        /// </summary>
        public float Range;
        /// <summary>
        /// Falloff
        /// </summary>
        public float Falloff;
        /// <summary>
        /// Constant Attenuation
        /// </summary>
        public float Attenuation0;
        /// <summary>
        /// Linear Attenuation
        /// </summary>
        public float Attenuation1;
        /// <summary>
        /// Quadratic Attenuation
        /// </summary>
        public float Attenuation2;
        /// <summary>
        /// Inner angle of spotlight cone
        /// </summary>
        public float Theta;
        /// <summary>
        /// Outer angle of spotlight cone
        /// </summary>
        public float Phi;
    }

    public struct D3DCLIPSTATUS8 {
        public uint ClipUnion, ClipIntersection;
    }

    public struct D3DPALETTEENTRY {
        public byte Red, Green, Blue, Flags;
    }

    public struct D3DRECTPATCH_INFO {
        public uint         StartVertexOffsetWidth;
        public uint         StartVertexOffsetHeight;
        public uint         Width;
        public uint         Height;
        public uint         Stride;
        public D3DBASISTYPE Basis;
        public D3DORDERTYPE Order;
    }

    public struct D3DTRIPATCH_INFO {
        public uint         StartVertexOffset;
        public uint         NumVerticies;
        public D3DBASISTYPE Basis;
        public D3DORDERTYPE Order;
    }

    public struct D3DLINEPATTERN {
        public ushort RepeatFactor, LinePattern;
    }


}