using System;

namespace Furball.Lanugo {

    public enum D3DDEVTYPE : uint {
        Hardware  = 1,
        Reference = 2,
        Software  = 3,
    }

    public enum D3DFORMAT : uint {
        D3DFMT_UNKNOWN = 0,

        D3DFMT_R8G8B8   = 20,
        D3DFMT_A8R8G8B8 = 21,
        D3DFMT_X8R8G8B8 = 22,
        D3DFMT_R5G6B5   = 23,
        D3DFMT_X1R5G5B5 = 24,
        D3DFMT_A1R5G5B5 = 25,
        D3DFMT_A4R4G4B4 = 26,
        D3DFMT_R3G3B2   = 27,
        D3DFMT_A8       = 28,
        D3DFMT_A8R3G3B2 = 29,
        D3DFMT_X4R4G4B4 = 30,

        D3DFMT_A8P8 = 40,
        D3DFMT_P8   = 41,

        D3DFMT_L8   = 50,
        D3DFMT_A8L8 = 51,
        D3DFMT_A4L4 = 52,

        D3DFMT_V8U8      = 60,
        D3DFMT_L6V5U5    = 61,
        D3DFMT_X8L8V8U8  = 62,
        D3DFMT_Q8W8V8U8  = 63,
        D3DFMT_V16U16    = 64,
        D3DFMT_W11V11U10 = 65,

        D3DFMT_UYVY = 1498831189,
        D3DFMT_YUY2 = 844715353,
        D3DFMT_DXT1 = 827611204,
        D3DFMT_DXT2 = 844388420,
        D3DFMT_DXT3 = 861165636,
        D3DFMT_DXT4 = 877942852,
        D3DFMT_DXT5 = 894720068,

        D3DFMT_D16_LOCKABLE = 70,
        D3DFMT_D32          = 71,
        D3DFMT_D15S1        = 73,
        D3DFMT_D24S8        = 75,
        D3DFMT_D16          = 80,
        D3DFMT_D24X8        = 77,
        D3DFMT_D24X4S4      = 79,

        D3DFMT_VERTEXDATA = 100,
        D3DFMT_INDEX16    = 101,
        D3DFMT_INDEX32    = 102,
    }

    public enum D3DRESOURCETYPE : uint {
        D3DRTYPE_SURFACE       = 1,
        D3DRTYPE_VOLUME        = 2,
        D3DRTYPE_TEXTURE       = 3,
        D3DRTYPE_VOLUMETEXTURE = 4,
        D3DRTYPE_CUBETEXTURE   = 5,
        D3DRTYPE_VERTEXBUFFER  = 6,
        D3DRTYPE_INDEXBUFFER   = 7,
    }

    public enum D3DMULTISAMPLE_TYPE : uint {
        D3DMULTISAMPLE_NONE       =  0,
        D3DMULTISAMPLE_2_SAMPLES  =  2,
        D3DMULTISAMPLE_3_SAMPLES  =  3,
        D3DMULTISAMPLE_4_SAMPLES  =  4,
        D3DMULTISAMPLE_5_SAMPLES  =  5,
        D3DMULTISAMPLE_6_SAMPLES  =  6,
        D3DMULTISAMPLE_7_SAMPLES  =  7,
        D3DMULTISAMPLE_8_SAMPLES  =  8,
        D3DMULTISAMPLE_9_SAMPLES  =  9,
        D3DMULTISAMPLE_10_SAMPLES = 10,
        D3DMULTISAMPLE_11_SAMPLES = 11,
        D3DMULTISAMPLE_12_SAMPLES = 12,
        D3DMULTISAMPLE_13_SAMPLES = 13,
        D3DMULTISAMPLE_14_SAMPLES = 14,
        D3DMULTISAMPLE_15_SAMPLES = 15,
        D3DMULTISAMPLE_16_SAMPLES = 16,
    }

    public enum D3DSWAPEFFECT : uint {
        D3DSWAPEFFECT_DISCARD    = 1,
        D3DSWAPEFFECT_FLIP       = 2,
        D3DSWAPEFFECT_COPY       = 3,
        D3DSWAPEFFECT_COPY_VSYNC = 4,
    }

    public enum D3DRESULT : uint {
        D3D_OK                           = 0x00000000,
        D3DERR_WRONGTEXTUREFORMAT        = 0x88760818,
        D3DERR_UNSUPPORTEDCOLOROPERATION = 0x88760819,
        D3DERR_UNSUPPORTEDCOLORARG       = 0x8876081a,
        D3DERR_UNSUPPORTEDALPHAOPERATION = 0x8876081b,
        D3DERR_UNSUPPORTEDALPHAARG       = 0x8876081c,
        D3DERR_TOOMANYOPERATIONS         = 0x8876081d,
        D3DERR_CONFLICTINGTEXTUREFILTER  = 0x8876081e,
        D3DERR_UNSUPPORTEDFACTORVALUE    = 0x8876081f,
        D3DERR_CONFLICTINGRENDERSTATE    = 0x88760821,
        D3DERR_UNSUPPORTEDTEXTUREFILTER  = 0x88760822,
        D3DERR_CONFLICTINGTEXTUREPALETTE = 0x88760826,
        D3DERR_DRIVERINTERNALERROR       = 0x88760827,
        D3DERR_NOTFOUND                  = 0x88760866,
        D3DERR_MOREDATA                  = 0x88760867,
        D3DERR_DEVICELOST                = 0x88760868,
        D3DERR_DEVICENOTRESET            = 0x88760869,
        D3DERR_NOTAVAILABLE              = 0x8876086a,
        D3DERR_OUTOFVIDEOMEMORY          = 0x8876017c,
        D3DERR_INVALIDDEVICE             = 0x8876086b,
        D3DERR_INVALIDCALL               = 0x8876086c,
        D3DERR_DRIVERINVALIDCALL         = 0x8876086d,
    }
    [Flags]
    public enum D3DCAPS_ENUM : uint {
        D3DCAPS_READ_SCANLINE
    }
    [Flags]
    public enum D3DCAPS2_ENUM : uint {
        D3DCAPS2_NO2DDURING3DSCENE = 0x00000002,
        D3DCAPS2_FULLSCREENGAMMA   = 0x00020000,
        D3DCAPS2_CANRENDERWINDOWED = 0x00080000,
        D3DCAPS2_CANCALIBRATEGAMMA = 0x00100000,
        D3DCAPS2_RESERVED          = 0x02000000,
    }
    [Flags]
    public enum D3DCAPS3_ENUM : uint {
        D3DCAPS3_RESERVED = 0x8000001f
    }
    [Flags]
    public enum D3DPRESENT_INTERVAL : uint {
        D3DPRESENT_INTERVAL_DEFAULT   = 0x00000000,
        D3DPRESENT_INTERVAL_ONE       = 0x00000001,
        D3DPRESENT_INTERVAL_TWO       = 0x00000002,
        D3DPRESENT_INTERVAL_THREE     = 0x00000004,
        D3DPRESENT_INTERVAL_FOUR      = 0x00000008,
        D3DPRESENT_INTERVAL_IMMEDIATE = 0x80000000,
    }
    [Flags]
    public enum D3DCURSORCAPS : uint {
        /// <summary>
        /// Driver supports HW color cursor in at least hi-res modes, Height more than 400
        /// </summary>
        D3DCURSORCAPS_COLOR  = 0x00000001,
        /// <summary>
        /// Driver supports HW cursor also in low-res modes Height less than 400
        /// </summary>
        D3DCURSORCAPS_LOWRES = 0x00000002,
    }
    [Flags]
    public enum D3DDEVCAPS : uint {
        /// <summary>
        /// Device can use execute buffers from system memory
        /// </summary>
        D3DDEVCAPS_EXECUTESYSTEMMEMORY = 0x00000010,
        /// <summary>
        /// Device can use execute buffers from video memory
        /// </summary>
        D3DDEVCAPS_EXECUTEVIDEOMEMORY = 0x00000020,
        /// <summary>
        /// Device can use TL buffers from system memory
        /// </summary>
        D3DDEVCAPS_TLVERTEXSYSTEMMEMORY = 0x00000040,
        /// <summary>
        /// Device can use TL buffers from video memory
        /// </summary>
        D3DDEVCAPS_TLVERTEXVIDEOMEMORY = 0x00000080,
        /// <summary>
        /// Device can texture from system memory
        /// </summary>
        D3DDEVCAPS_TEXTURESYSTEMMEMORY = 0x00000100,
        /// <summary>
        /// Device can texture from device memory
        /// </summary>
        D3DDEVCAPS_TEXTUREVIDEOMEMORY = 0x00000200,
        /// <summary>
        /// Device can draw TLVERTEX primitives
        /// </summary>
        D3DDEVCAPS_DRAWPRIMTLVERTEX = 0x00000400,
        /// <summary>
        /// Device can render without waiting for flip to complete
        /// </summary>
        D3DDEVCAPS_CANRENDERAFTERFLIP = 0x00000800,
        /// <summary>
        /// Device can texture from nonlocal video memory
        /// </summary>
        D3DDEVCAPS_TEXTURENONLOCALVIDMEM = 0x00001000,
        /// <summary>
        /// Device can support DrawPrimitives2
        /// </summary>
        D3DDEVCAPS_DRAWPRIMITIVES2 = 0x00002000,
        /// <summary>
        /// Device is texturing from separate memory pools
        /// </summary>
        D3DDEVCAPS_SEPARATETEXTUREMEMORIES = 0x00004000,
        /// <summary>
        /// Device can support Extended DrawPrimitives2 i.e. DX7 compliant driver
        /// </summary>
        D3DDEVCAPS_DRAWPRIMITIVES2EX = 0x00008000,
        /// <summary>
        /// Device can support transformation and lighting in hardware and DRAWPRIMITIVES2EX must be also
        /// </summary>
        D3DDEVCAPS_HWTRANSFORMANDLIGHT = 0x00010000,
        /// <summary>
        /// Device supports a Tex Blt from system memory to non-local vidmem
        /// </summary>
        D3DDEVCAPS_CANBLTSYSTONONLOCAL = 0x00020000,
        /// <summary>
        /// Device has HW acceleration for rasterization
        /// </summary>
        D3DDEVCAPS_HWRASTERIZATION = 0x00080000,
        /// <summary>
        /// Device supports D3DCREATE_PUREDEVICE
        /// </summary>
        D3DDEVCAPS_PUREDEVICE = 0x00100000,
        /// <summary>
        /// Device supports quintic Beziers and BSplines
        /// </summary>
        D3DDEVCAPS_QUINTICRTPATCHES = 0x00200000,
        /// <summary>
        /// Device supports Rect and Tri patches
        /// </summary>
        D3DDEVCAPS_RTPATCHES = 0x00400000,
        /// <summary>
        /// Indicates that RT Patches may be drawn efficiently using handle 0
        /// </summary>
        D3DDEVCAPS_RTPATCHHANDLEZERO = 0x00800000,
        /// <summary>
        /// Device supports N-Patches
        /// </summary>
        D3DDEVCAPS_NPATCHES = 0x01000000,
    }
    [Flags]
    public enum D3DPRIMITIVEMISCCAPS : uint {
        D3DPMISCCAPS_MASKZ            = 0x00000002,
        D3DPMISCCAPS_LINEPATTERNREP   = 0x00000004,
        D3DPMISCCAPS_CULLNONE         = 0x00000010,
        D3DPMISCCAPS_CULLCW           = 0x00000020,
        D3DPMISCCAPS_CULLCCW          = 0x00000040,
        D3DPMISCCAPS_COLORWRITEENABLE = 0x00000080,
        /// <summary>
        /// Device correctly clips scaled points to clip planes
        /// </summary>
        D3DPMISCCAPS_CLIPPLANESCALEDPOINTS = 0x00000100,
        /// <summary>
        /// device will clip post-transformed vertex primitives
        /// </summary>
        D3DPMISCCAPS_CLIPTLVERTS = 0x00000200,
        /// <summary>
        /// device supports D3DTA_TEMP for temporary register
        /// </summary>
        D3DPMISCCAPS_TSSARGTEMP = 0x00000400,
        /// <summary>
        /// device supports D3DRS_BLENDOP
        /// </summary>
        D3DPMISCCAPS_BLENDOP = 0x00000800,
    }
    [Flags]
    public enum D3DLINECAPS : uint {
        D3DLINECAPS_TEXTURE  = 0x00000001,
        D3DLINECAPS_ZTEST    = 0x00000002,
        D3DLINECAPS_BLEND    = 0x00000004,
        D3DLINECAPS_ALPHACMP = 0x00000008,
        D3DLINECAPS_FOG      = 0x00000010,
    }
    [Flags]
    public enum D3DRASTERCAPS : uint {
        D3DPRASTERCAPS_DITHER         = 0x00000001,
        D3DPRASTERCAPS_PAT            = 0x00000008,
        D3DPRASTERCAPS_ZTEST          = 0x00000010,
        D3DPRASTERCAPS_FOGVERTEX      = 0x00000080,
        D3DPRASTERCAPS_FOGTABLE       = 0x00000100,
        D3DPRASTERCAPS_ANTIALIASEDGES = 0x00001000,
        D3DPRASTERCAPS_MIPMAPLODBIAS  = 0x00002000,
        D3DPRASTERCAPS_ZBIAS          = 0x00004000,
        D3DPRASTERCAPS_ZBUFFERLESSHSR = 0x00008000,
        D3DPRASTERCAPS_FOGRANGE       = 0x00010000,
        D3DPRASTERCAPS_ANISOTROPY     = 0x00020000,
        D3DPRASTERCAPS_WBUFFER        = 0x00040000,
        D3DPRASTERCAPS_WFOG           = 0x00100000,
        D3DPRASTERCAPS_ZFOG           = 0x00200000,
        /// <summary>
        /// Device iterates colors perspective correct
        /// </summary>
        D3DPRASTERCAPS_COLORPERSPECTIVE = 0x00400000,
        D3DPRASTERCAPS_STRETCHBLTMULTISAMPLE = 0x00800000,
    }

    [Flags]
    public enum D3DPCMPCAPS : uint {
        D3DPCMPCAPS_NEVER        = 0x00000001,
        D3DPCMPCAPS_LESS         = 0x00000002,
        D3DPCMPCAPS_EQUAL        = 0x00000004,
        D3DPCMPCAPS_LESSEQUAL    = 0x00000008,
        D3DPCMPCAPS_GREATER      = 0x00000010,
        D3DPCMPCAPS_NOTEQUAL     = 0x00000020,
        D3DPCMPCAPS_GREATEREQUAL = 0x00000040,
        D3DPCMPCAPS_ALWAYS       = 0x00000080,
    }
    [Flags]
    public enum D3DPBLENDCAPS : uint {
        D3DPBLENDCAPS_ZERO            = 0x00000001,
        D3DPBLENDCAPS_ONE             = 0x00000002,
        D3DPBLENDCAPS_SRCCOLOR        = 0x00000004,
        D3DPBLENDCAPS_INVSRCCOLOR     = 0x00000008,
        D3DPBLENDCAPS_SRCALPHA        = 0x00000010,
        D3DPBLENDCAPS_INVSRCALPHA     = 0x00000020,
        D3DPBLENDCAPS_DESTALPHA       = 0x00000040,
        D3DPBLENDCAPS_INVDESTALPHA    = 0x00000080,
        D3DPBLENDCAPS_DESTCOLOR       = 0x00000100,
        D3DPBLENDCAPS_INVDESTCOLOR    = 0x00000200,
        D3DPBLENDCAPS_SRCALPHASAT     = 0x00000400,
        D3DPBLENDCAPS_BOTHSRCALPHA    = 0x00000800,
        D3DPBLENDCAPS_BOTHINVSRCALPHA = 0x00001000,
    }
    [Flags]
    public enum D3DPSHADECAPS : uint {
        D3DPSHADECAPS_COLORGOURAUDRGB    = 0x00000008,
        D3DPSHADECAPS_SPECULARGOURAUDRGB = 0x00000200,
        D3DPSHADECAPS_ALPHAGOURAUDBLEND  = 0x00004000,
        D3DPSHADECAPS_FOGGOURAUD         = 0x00080000,
    }
    [Flags]
    public enum D3DTEXTURECAPS : uint {
        /// <summary>
        /// Perspective-correct texturing is supported
        /// </summary>
        D3DPTEXTURECAPS_PERSPECTIVE = 0x00000001,
        /// <summary>
        /// Power-of-2 texture dimensions are required - applies to non-Cube/Volume textures only.
        /// </summary>
        D3DPTEXTURECAPS_POW2 = 0x00000002,
        /// <summary>
        /// Alpha in texture pixels is supported
        /// </summary>
        D3DPTEXTURECAPS_ALPHA = 0x00000004,
        /// <summary>
        /// Only square textures are supported
        /// </summary>
        D3DPTEXTURECAPS_SQUAREONLY = 0x00000020,
        /// <summary>
        /// Texture indices are not scaled by the texture size prior to interpolation
        /// </summary>
        D3DPTEXTURECAPS_TEXREPEATNOTSCALEDBYSIZE = 0x00000040,
        /// <summary>
        /// Device can draw alpha from texture palettes
        /// </summary>
        D3DPTEXTURECAPS_ALPHAPALETTE = 0x00000080,
        /// <summary>
        /// Device can use non-POW2 textures if:
        /// 1) D3DTEXTURE_ADDRESS is set to CLAMP for this texture's stage
        /// 2) D3DRS_WRAP(N) is zero for this texture's coordinates
        /// 3) mip mapping is not enabled (use magnification filter only)
        /// </summary>
        D3DPTEXTURECAPS_NONPOW2CONDITIONAL = 0x00000100,
        /// <summary>
        /// Device can do D3DTTFF_PROJECTED
        /// </summary>
        D3DPTEXTURECAPS_PROJECTED = 0x00000400,
        /// <summary>
        /// Device can do cubemap textures
        /// </summary>
        D3DPTEXTURECAPS_CUBEMAP = 0x00000800,
        /// <summary>
        /// Device can do volume textures
        /// </summary>
        D3DPTEXTURECAPS_VOLUMEMAP = 0x00002000,
        /// <summary>
        /// Device can do mipmapped textures
        /// </summary>
        D3DPTEXTURECAPS_MIPMAP = 0x00004000,
        /// <summary>
        /// Device can do mipmapped volume textures
        /// </summary>
        D3DPTEXTURECAPS_MIPVOLUMEMAP = 0x00008000,
        /// <summary>
        /// Device can do mipmapped cube maps
        /// </summary>
        D3DPTEXTURECAPS_MIPCUBEMAP = 0x00010000,
        /// <summary>
        /// Device requires that cubemaps be power-of-2 dimension
        /// </summary>
        D3DPTEXTURECAPS_CUBEMAP_POW2 = 0x00020000,
        /// <summary>
        /// Device requires that volume maps be power-of-2 dimension
        /// </summary>
        D3DPTEXTURECAPS_VOLUMEMAP_POW2 = 0x00040000,
    }
    [Flags]
    public enum D3DTEXTUREFILTERCAPS : uint {
        D3DPTFILTERCAPS_MINFPOINT         = 0x00000100,
        D3DPTFILTERCAPS_MINFLINEAR        = 0x00000200,
        D3DPTFILTERCAPS_MINFANISOTROPIC   = 0x00000400,
        D3DPTFILTERCAPS_MIPFPOINT         = 0x00010000,
        D3DPTFILTERCAPS_MIPFLINEAR        = 0x00020000,
        D3DPTFILTERCAPS_MAGFPOINT         = 0x01000000,
        D3DPTFILTERCAPS_MAGFLINEAR        = 0x02000000,
        D3DPTFILTERCAPS_MAGFANISOTROPIC   = 0x04000000,
        D3DPTFILTERCAPS_MAGFAFLATCUBIC    = 0x08000000,
        D3DPTFILTERCAPS_MAGFGAUSSIANCUBIC = 0x10000000,
    }
    [Flags]
    public enum D3DTEXTUREADDRESSCAPS : uint {
        D3DPTADDRESSCAPS_WRAP          = 0x00000001,
        D3DPTADDRESSCAPS_MIRROR        = 0x00000002,
        D3DPTADDRESSCAPS_CLAMP         = 0x00000004,
        D3DPTADDRESSCAPS_BORDER        = 0x00000008,
        D3DPTADDRESSCAPS_INDEPENDENTUV = 0x00000010,
        D3DPTADDRESSCAPS_MIRRORONCE    = 0x00000020,
    }
    [Flags]
    public enum D3DSTENCILCAPS : uint {
        D3DSTENCILCAPS_KEEP    = 0x00000001,
        D3DSTENCILCAPS_ZERO    = 0x00000002,
        D3DSTENCILCAPS_REPLACE = 0x00000004,
        D3DSTENCILCAPS_INCRSAT = 0x00000008,
        D3DSTENCILCAPS_DECRSAT = 0x00000010,
        D3DSTENCILCAPS_INVERT  = 0x00000020,
        D3DSTENCILCAPS_INCR    = 0x00000040,
        D3DSTENCILCAPS_DECR    = 0x00000080,
    }
    [Flags]
    public enum D3DTEXTUREOPCAPS : uint {
        D3DTEXOPCAPS_DISABLE                   = 0x00000001,
        D3DTEXOPCAPS_SELECTARG1                = 0x00000002,
        D3DTEXOPCAPS_SELECTARG2                = 0x00000004,
        D3DTEXOPCAPS_MODULATE                  = 0x00000008,
        D3DTEXOPCAPS_MODULATE2X                = 0x00000010,
        D3DTEXOPCAPS_MODULATE4X                = 0x00000020,
        D3DTEXOPCAPS_ADD                       = 0x00000040,
        D3DTEXOPCAPS_ADDSIGNED                 = 0x00000080,
        D3DTEXOPCAPS_ADDSIGNED2X               = 0x00000100,
        D3DTEXOPCAPS_SUBTRACT                  = 0x00000200,
        D3DTEXOPCAPS_ADDSMOOTH                 = 0x00000400,
        D3DTEXOPCAPS_BLENDDIFFUSEALPHA         = 0x00000800,
        D3DTEXOPCAPS_BLENDTEXTUREALPHA         = 0x00001000,
        D3DTEXOPCAPS_BLENDFACTORALPHA          = 0x00002000,
        D3DTEXOPCAPS_BLENDTEXTUREALPHAPM       = 0x00004000,
        D3DTEXOPCAPS_BLENDCURRENTALPHA         = 0x00008000,
        D3DTEXOPCAPS_PREMODULATE               = 0x00010000,
        D3DTEXOPCAPS_MODULATEALPHA_ADDCOLOR    = 0x00020000,
        D3DTEXOPCAPS_MODULATECOLOR_ADDALPHA    = 0x00040000,
        D3DTEXOPCAPS_MODULATEINVALPHA_ADDCOLOR = 0x00080000,
        D3DTEXOPCAPS_MODULATEINVCOLOR_ADDALPHA = 0x00100000,
        D3DTEXOPCAPS_BUMPENVMAP                = 0x00200000,
        D3DTEXOPCAPS_BUMPENVMAPLUMINANCE       = 0x00400000,
        D3DTEXOPCAPS_DOTPRODUCT3               = 0x00800000,
        D3DTEXOPCAPS_MULTIPLYADD               = 0x01000000,
        D3DTEXOPCAPS_LERP                      = 0x02000000,
    }
    [Flags]
    public enum D3DFVFCAPS : uint {
        /// <summary>
        /// mask for texture coordinate count field
        /// </summary>
        D3DFVFCAPS_TEXCOORDCOUNTMASK = 0x0000ffff,
        /// <summary>
        /// Device prefers that vertex elements not be stripped
        /// </summary>
        D3DFVFCAPS_DONOTSTRIPELEMENTS = 0x00080000,
        /// <summary>
        /// Device can receive point size
        /// </summary>
        D3DFVFCAPS_PSIZE = 0x00100000,
    }
    [Flags]
    public enum D3DVERTEXPROCESSINGCAPS : uint {
        /// <summary>
        /// device can do texgen
        /// </summary>
        D3DVTXPCAPS_TEXGEN = 0x00000001,
        /// <summary>
        /// device can do DX7-level colormaterialsource ops
        /// </summary>
        D3DVTXPCAPS_MATERIALSOURCE7 = 0x00000002,
        /// <summary>
        /// device can do directional lights
        /// </summary>
        D3DVTXPCAPS_DIRECTIONALLIGHTS = 0x00000008,
        /// <summary>
        /// device can do positional lights (includes point and spot)
        /// </summary>
        D3DVTXPCAPS_POSITIONALLIGHTS = 0x00000010,
        /// <summary>
        /// device can do local viewer
        /// </summary>
        D3DVTXPCAPS_LOCALVIEWER = 0x00000020,
        /// <summary>
        /// device can do vertex tweening
        /// </summary>
        D3DVTXPCAPS_TWEENING = 0x00000040,
        /// <summary>
        /// device does not support D3DVSDT_UBYTE4
        /// </summary>
        D3DVTXPCAPS_NO_VSDT_UBYTE4 = 0x00000080,
    }

    public enum D3DPRESENT_PARAMETERS_FLAGS : uint {
        D3DPRESENTFLAG_LOCKABLE_BACKBUFFER = 1,
    }

    public enum D3DCREATEFLAGS : uint {
        D3DCREATE_FPU_PRESERVE              = 0x00000002,
        D3DCREATE_MULTITHREADED             = 0x00000004,
        D3DCREATE_PUREDEVICE                = 0x00000010,
        D3DCREATE_SOFTWARE_VERTEXPROCESSING = 0x00000020,
        D3DCREATE_HARDWARE_VERTEXPROCESSING = 0x00000040,
        D3DCREATE_MIXED_VERTEXPROCESSING    = 0x00000080,
    }

    public enum D3DFORMATCHECKUSAGE : uint {
        D3DUSAGE_RENDERTARGET = 1,
        D3DUSAGE_DEPTHSTENCIL = 2
    }
}