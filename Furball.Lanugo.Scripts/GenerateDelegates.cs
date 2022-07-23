using System;
using System.Collections.Generic;
using System.Drawing;
using System.Numerics;

namespace Furball.Lanugo.Scripts {
    public class GenerateDelegates {
        public static void Generate(string data) {
            string[] split = data.Split("\r\n");

            Dictionary<string, string> cToCsType = new Dictionary<string, string>() {
                { "REFIID"                        , "Guid" },
                { "UINT"                          , "uint" },
                { "BOOL"                          , "int" },
                { "DWORD"                         , "int" },
                { "DWORD*"                        , "int*" },
                { "void*"                         , "void*" },
                { "UINT*"                         , "uint*" },
                { "float*"                        , "float*" },
                { "BOOL*"                         , "int*" },
                { "void**"                        , "void**" },
                { "HWND"                          , "IntPtr" },
                { "float"                         , "float" },
                { "IDirect3D8**"                  , "IDirect3D8**" },
                { "IDirect3DSurface8*"            , "IDirect3DSurface8*" },
                { "IDirect3DSurface8**"           , "IDirect3DSurface8**" },
                { "IDirect3DBaseTexture8**"       , "IDirect3DBaseTexture8**" },
                { "IDirect3DBaseTexture8*"        , "IDirect3DBaseTexture8*" },
                { "IDirect3DTexture8**"           , "IDirect3DTexture8**" },
                { "IDirect3DTexture8*"            , "IDirect3DTexture8*" },
                { "IDirect3DVolumeTexture8**"     , "IDirect3DVolumeTexture8**" },
                { "IDirect3DVolumeTexture8*"      , "IDirect3DVolumeTexture8*" },
                { "IDirect3DCubeTexture8**"       , "IDirect3DCubeTexture8**" },
                { "IDirect3DCubeTexture8*"        , "IDirect3DCubeTexture8*" },
                { "IDirect3DVertexBuffer8**"      , "IDirect3DVertexBuffer8**" },
                { "IDirect3DVertexBuffer8*"       , "IDirect3DVertexBuffer8*" },
                { "IDirect3DIndexBuffer8**"       , "IDirect3DIndexBuffer8**" },
                { "IDirect3DIndexBuffer8*"        , "IDirect3DIndexBuffer8*" },
                { "IDirect3DSwapChain8**"         , "IDirect3DSwapChain8**" },
                { "D3DFORMAT"                     , "D3DFORMAT" },
                { "D3DDISPLAYMODE*"               , "D3DDISPLAYMODE*" },
                { "D3DPRESENT_PARAMETERS*"        , "D3DPRESENT_PARAMETERS*" },
                { "D3DCAPS8*"                     , "D3DCAPS8*" },
                { "D3DDEVICE_CREATION_PARAMETERS" , "D3DDEVICE_CREATION_PARAMETERS" },
                { "D3DPRIMITIVETYPE"              , "D3DPRIMITIVETYPE" },
                { "D3DPOOL"                       , "D3DPOOL" },
                { "RECT*"                         , "RECT*" },
                { "D3DRECT*"                      , "D3DRECT*" },
                { "RGNDATA*"                      , "D3DRGNDATA*" },
                { "D3DBACKBUFFER_TYPE"            , "D3DBACKBUFFER_TYPE" },
                { "D3DRASTER_STATUS*"             , "D3DRASTER_STATUS*" },
                { "D3DGAMMARAMP*"                 , "D3DGAMMARAMP*" },
                { "D3DMULTISAMPLE_TYPE"           , "D3DMULTISAMPLE_TYPE" },
                { "POINT*"                        , "D3DPOINT*" },
                { "D3DTRANSFORMSTATETYPE"         , "D3DTRANSFORMSTATETYPE" },
                { "D3DMATRIX*"                    , "Matrix4x4*" },
                { "D3DVIEWPORT8*"                 , "D3DVIEWPORT8*" },
                { "D3DCOLOR"                      , "D3DCOLOR" },
                { "D3DMATERIAL8*"                 , "D3DMATERIAL8*" },
                { "D3DLIGHT8*"                    , "D3DLIGHT8*" },
                { "D3DRENDERSTATETYPE"            , "D3DRENDERSTATETYPE" },
                { "D3DSTATEBLOCKTYPE"             , "D3DSTATEBLOCKTYPE" },
                { "D3DCLIPSTATUS8*"               , "D3DCLIPSTATUS8*" },
                { "D3DTEXTURESTAGESTATETYPE"      , "D3DTEXTURESTAGESTATETYPE" },
                { "PALETTEENTRY*"                 , "D3DPALETTEENTRY*" },
                { "D3DRECTPATCH_INFO*"            , "D3DRECTPATCH_INFO*" },
                { "D3DTRIPATCH_INFO*"             , "D3DTRIPATCH_INFO*" },
            };

            foreach (string function in split) {
                if(function == "")
                    continue;

                string[] functionSplit = function.Split("=");

                string functionDefinition = functionSplit[0].Trim();
                string functionSignature  = functionSplit[1].Trim();

                string[] functionNameSplit = functionDefinition.Split(" ");

                string functionReturn = functionNameSplit[0];
                string functionName = functionNameSplit[1];

                string argumentBox = "";

                if (functionSignature != "") {
                    foreach (string arg in functionSignature.Trim().Split(",")) {
                        string[] splitArg = arg.Split(" ");

                        string argType = splitArg[0];
                        string argName = splitArg[1];

                        if (!cToCsType.ContainsKey(argType)) {
                            Console.WriteLine(argType);
                            continue;
                        }

                        argType = cToCsType[argType];

                        argumentBox += $"{argType} {argName}, ";
                    }
                }

                argumentBox = argumentBox.Trim().TrimEnd(',');

                Console.WriteLine("\t" + "delegate " + functionReturn + " " + functionName + "Delegate(" + argumentBox + ");");
            }
        }
    }
}
