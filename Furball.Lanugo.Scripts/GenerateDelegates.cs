using System;
using System.Collections.Generic;

namespace Furball.Lanugo.Scripts {
    public class GenerateDelegates {
        public static void Generate(string data) {
            string[] split = data.Split("\r\n");

            Dictionary<string, string> cToCsType = new Dictionary<string, string>() {
                { "REFIID", "Guid" },
                { "UINT", "uint" },
                { "BOOL", "int" },
                { "DWORD", "int"},
                {"DWORD*", "int*"},
                {"void*", "void*"},
                {"UINT*", "uint*"},
                {"float*", "float*"},
                {"BOOL*", "int*"},
                {"void**", "void**"},
                {"IDirect3D8**", "IDirect3D8**"},
                {"HWND", "IntPtr"},
                {"float", "float"},
                {"D3DFORMAT", "D3DFORMAT"},

                {"D3DDISPLAYMODE*", "D3DDISPLAYMODE*"},
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

                        argumentBox += $"{argType} {argName},";
                    }
                }
            }
        }
    }
}
