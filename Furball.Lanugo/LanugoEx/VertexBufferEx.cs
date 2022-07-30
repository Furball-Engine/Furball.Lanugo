using System;

namespace Furball.Lanugo.LanugoEx {
    public static class VertexBufferEx {
        public static unsafe D3DRESULT UpdateEx<T>(this IDirect3DVertexBuffer8 buffer, T[] data, uint offset = 0) where T : unmanaged {
            uint size = (uint)(sizeof(T) * data.Length);

            D3DRESULT lockResult = buffer.Lock(offset, size, 0, out byte* byteBuffer);

            if (lockResult != D3DRESULT.D3D_OK)
                return lockResult;

            fixed (void* vertexPtr = data) {
                Buffer.MemoryCopy(vertexPtr, byteBuffer, size, size);
            }

            D3DRESULT unlockResult = buffer.Unlock();

            return unlockResult;
        }
    }
}
