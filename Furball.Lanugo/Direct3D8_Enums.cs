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
}