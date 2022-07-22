using System;

namespace Furball.Lanugo.Scripts {
    public class GenerateIntPtrs {
        public static void Generate(string data) {
            string[] split = data.Split("\r\n");

            for (var i = 0; i < split.Length; i++) {
                string function = split[i];

                Console.WriteLine($"\tpublic IntPtr {function}Ptr => (IntPtr) this.Vtbl[{i}];");
            }
        }
    }
}
