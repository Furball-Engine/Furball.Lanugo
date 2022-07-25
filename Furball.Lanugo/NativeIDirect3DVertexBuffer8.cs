using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace Furball.Lanugo {
    public unsafe class IDirect3DVertexBuffer8 {
        internal NativeIDirect3DVertexBuffer8* BufferPointer;

        internal delegate int  QueryInterfaceDelegate(NativeIDirect3DDevice8* device, Guid riid, void** ppvObj);
        internal delegate uint AddRefDelegate(NativeIDirect3DDevice8* device);
        internal delegate uint ReleaseDelegate(NativeIDirect3DDevice8* device);
        internal delegate int GetDeviceDelegate(void** retDevice);
        internal delegate int SetPrivateDataDelegate(Guid guid, void* data, int sizeOfData, int flags);
        internal delegate int GetPrivateDataDelegate(Guid guid, void* data, int sizeOfData);
        internal delegate int FreePrivateDataDelegate(Guid guid);
        internal delegate int SetPriorityDelegate(int newPriority);
        internal delegate int GetPriorityDelegate();
        internal delegate void PreLoadDelegate();
        internal delegate D3DRESOURCETYPE GetTypeDelegate();
        internal delegate int LockDelegate(NativeIDirect3DVertexBuffer8* buffer, uint offsetToLock, uint sizeToLock, byte** bufferPointer, D3DLOCK lockFlags);
        internal delegate int UnlockDelegate(NativeIDirect3DVertexBuffer8* buffer);
        internal delegate int GetDescDelegate(NativeIDirect3DVertexBuffer8* buffer, void* outVertexBufferDesc);


        internal static QueryInterfaceDelegate  QueryInterfaceDelegateFunction;
        internal static AddRefDelegate          AddRefDelegateFunction;
        internal static ReleaseDelegate         ReleaseDelegateFunction;
        internal static GetDeviceDelegate       GetDeviceFunction;
        internal static SetPrivateDataDelegate  SetPrivateDataFunction;
        internal static GetPrivateDataDelegate  GetPrivateDataFunction;
        internal static FreePrivateDataDelegate FreePrivateDataFunction;
        internal static SetPriorityDelegate     SetPriorityFunction;
        internal static GetPriorityDelegate     GetPriorityFunction;
        internal static PreLoadDelegate         PreLoadFunction;
        internal static GetTypeDelegate         GetTypeFunction;
        internal static LockDelegate            LockDelegateFunction;
        internal static UnlockDelegate          UnlockDelegateFunction;
        internal static GetDescDelegate         GetDescDelegateFunction;

        public IDirect3DVertexBuffer8(NativeIDirect3DVertexBuffer8* bufferPointer) {
            BufferPointer = bufferPointer;

            if (GetDescDelegateFunction == null) {
                QueryInterfaceDelegateFunction = Marshal.GetDelegateForFunctionPointer<QueryInterfaceDelegate>((IntPtr)this.BufferPointer->Vtbl[0]);
                AddRefDelegateFunction         = Marshal.GetDelegateForFunctionPointer<AddRefDelegate>((IntPtr)this.BufferPointer->Vtbl[1]);
                ReleaseDelegateFunction        = Marshal.GetDelegateForFunctionPointer<ReleaseDelegate>((IntPtr)this.BufferPointer->Vtbl[2]);
                GetDeviceFunction              = Marshal.GetDelegateForFunctionPointer<GetDeviceDelegate>((IntPtr)this.BufferPointer->Vtbl[3]);
                SetPrivateDataFunction         = Marshal.GetDelegateForFunctionPointer<SetPrivateDataDelegate>((IntPtr)this.BufferPointer->Vtbl[4]);
                GetPrivateDataFunction         = Marshal.GetDelegateForFunctionPointer<GetPrivateDataDelegate>((IntPtr)this.BufferPointer->Vtbl[5]);
                FreePrivateDataFunction        = Marshal.GetDelegateForFunctionPointer<FreePrivateDataDelegate>((IntPtr)this.BufferPointer->Vtbl[6]);
                SetPriorityFunction            = Marshal.GetDelegateForFunctionPointer<SetPriorityDelegate>((IntPtr)this.BufferPointer->Vtbl[7]);
                GetPriorityFunction            = Marshal.GetDelegateForFunctionPointer<GetPriorityDelegate>((IntPtr)this.BufferPointer->Vtbl[8]);
                PreLoadFunction                = Marshal.GetDelegateForFunctionPointer<PreLoadDelegate>((IntPtr)this.BufferPointer->Vtbl[9]);
                GetTypeFunction                = Marshal.GetDelegateForFunctionPointer<GetTypeDelegate>((IntPtr)this.BufferPointer->Vtbl[10]);
                LockDelegateFunction           = Marshal.GetDelegateForFunctionPointer<LockDelegate>((IntPtr)this.BufferPointer->Vtbl[11]);
                UnlockDelegateFunction         = Marshal.GetDelegateForFunctionPointer<UnlockDelegate>((IntPtr)this.BufferPointer->Vtbl[12]);
                GetDescDelegateFunction        = Marshal.GetDelegateForFunctionPointer<GetDescDelegate>((IntPtr)this.BufferPointer->Vtbl[13]);
            }
        }

        public D3DRESULT GetDesc(out D3DVERTEXBUFFERDESC bufferDesc) {
            D3DVERTEXBUFFERDESC ptrDesc;

            int ret = GetDescDelegateFunction(this.BufferPointer, &ptrDesc);

            bufferDesc = ptrDesc;

            return (D3DRESULT) ret;
        }

        public D3DRESULT Lock(uint offsetToLock, uint sizeToLock, D3DLOCK lockFlags, out byte* byteBuffer) {
            byte* ptrBuffer;

            int ret = LockDelegateFunction(BufferPointer, offsetToLock, sizeToLock, &ptrBuffer, lockFlags);

            byteBuffer = ptrBuffer;

            return (D3DRESULT) ret;
        }

        public D3DRESULT Unlock() => (D3DRESULT)UnlockDelegateFunction(BufferPointer);
    }

    public unsafe struct NativeIDirect3DVertexBuffer8 {
        public void** Vtbl;
    }
}
