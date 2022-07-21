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
        public uint Caps;
        public uint Caps2;
        public uint Caps3;
        public uint PresentationIntervals;

        /* Cursor Caps */
        public uint CursorCaps;

        /* 3D Device Caps */
        public uint DevCaps;

        public uint PrimitiveMiscCaps;
        public uint RasterCaps;
        public uint ZCmpCaps;
        public uint SrcBlendCaps;
        public uint DestBlendCaps;
        public uint AlphaCmpCaps;
        public uint ShadeCaps;
        public uint TextureCaps;
        public uint TextureFilterCaps;// D3DPTFILTERCAPS for IDirect3DTexture8's
        public uint CubeTextureFilterCaps;// D3DPTFILTERCAPS for IDirect3DCubeTexture8's
        public uint VolumeTextureFilterCaps;// D3DPTFILTERCAPS for IDirect3DVolumeTexture8's
        public uint TextureAddressCaps;// D3DPTADDRESSCAPS for IDirect3DTexture8's
        public uint VolumeTextureAddressCaps;// D3DPTADDRESSCAPS for IDirect3DVolumeTexture8's

        public uint LineCaps;// D3DLINECAPS

        public uint MaxTextureWidth, MaxTextureHeight;
        public uint MaxVolumeExtent;

        public uint  MaxTextureRepeat;
        public uint  MaxTextureAspectRatio;
        public uint  MaxAnisotropy;
        public float MaxVertexW;

        public float GuardBandLeft;
        public float GuardBandTop;
        public float GuardBandRight;
        public float GuardBandBottom;

        public float ExtentsAdjust;
        public uint  StencilCaps;

        public uint FVFCaps;
        public uint TextureOpCaps;
        public uint MaxTextureBlendStages;
        public uint MaxSimultaneousTextures;

        public uint VertexProcessingCaps;
        public uint MaxActiveLights;
        public uint MaxUserClipPlanes;
        public uint MaxVertexBlendMatrices;
        public uint MaxVertexBlendMatrixIndex;

        public float MaxPointSize;

        public uint MaxPrimitiveCount;// max number of primitives per DrawPrimitive call
        public uint MaxVertexIndex;
        public uint MaxStreams;
        public uint MaxStreamStride;// max stride for SetStreamSource

        public uint VertexShaderVersion;
        public uint MaxVertexShaderConst;// number of vertex shader constant registers

        public uint  PixelShaderVersion;
        public float MaxPixelShaderValue;// max value of pixel shader arithmetic component
    }
}