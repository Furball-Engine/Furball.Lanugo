using System;

namespace Furball.Lanugo.TestApplication {
    class Program {
        static unsafe void Main(string[] args) {
            Direct3D8.CreateDirect3D8();

            D3DCAPS8 deviceCaps = Direct3D8.GetDeviceCaps(0, D3DDEVTYPE.Hardware);

            Console.WriteLine("Max Tex height: " + deviceCaps.MaxTextureHeight);
        }
    }
}
