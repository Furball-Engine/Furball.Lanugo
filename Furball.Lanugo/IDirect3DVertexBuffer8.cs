using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace Furball.Lanugo {
    public unsafe class IDirect3DVertexBuffer8_DelegateHolder {
        internal static Dictionary<IntPtr, IDirect3DVertexBuffer8_DelegateHolder> DelegateCaches = new();

        internal IDirect3DVertexBuffer8* BufferPointer;

        internal delegate int  QueryInterfaceDelegate(IDirect3DDevice8* device, Guid riid, void** ppvObj);
        internal delegate uint AddRefDelegate(IDirect3DDevice8* device);
        internal delegate uint ReleaseDelegate(IDirect3DDevice8* device);
        internal delegate int GetDeviceDelegate(void** retDevice);
        internal delegate int SetPrivateDataDelegate(Guid guid, void* data, int sizeOfData, int flags);
        internal delegate int GetPrivateDataDelegate(Guid guid, void* data, int sizeOfData);
        internal delegate int FreePrivateDataDelegate(Guid guid);
        internal delegate int SetPriorityDelegate(int newPriority);
        internal delegate int GetPriorityDelegate();
        internal delegate void PreLoadDelegate();
        internal delegate D3DRESOURCETYPE GetTypeDelegate();
        internal delegate int LockDelegate(IDirect3DVertexBuffer8* buffer, uint offsetToLock, uint sizeToLock, byte** bufferPointer, D3DLOCK lockFlags);
        internal delegate int UnlockDelegate(IDirect3DVertexBuffer8* buffer);
        internal delegate int GetDescDelegate(IDirect3DVertexBuffer8* buffer, void* outVertexBufferDesc);


        internal QueryInterfaceDelegate  QueryInterfaceDelegateFunction;
        internal AddRefDelegate          AddRefDelegateFunction;
        internal ReleaseDelegate         ReleaseDelegateFunction;
        internal GetDeviceDelegate       GetDeviceFunction;
        internal SetPrivateDataDelegate  SetPrivateDataFunction;
        internal GetPrivateDataDelegate  GetPrivateDataFunction;
        internal FreePrivateDataDelegate FreePrivateDataFunction;
        internal SetPriorityDelegate     SetPriorityFunction;
        internal GetPriorityDelegate     GetPriorityFunction;
        internal PreLoadDelegate         PreLoadFunction;
        internal GetTypeDelegate         GetTypeFunction;
        internal LockDelegate            LockDelegateFunction;
        internal UnlockDelegate          UnlockDelegateFunction;
        internal GetDescDelegate         GetDescDelegateFunction;

        public IDirect3DVertexBuffer8_DelegateHolder(void** vtbl, IDirect3DVertexBuffer8* buffer) {
            QueryInterfaceDelegateFunction = Marshal.GetDelegateForFunctionPointer<QueryInterfaceDelegate>((IntPtr)vtbl[0]);
            AddRefDelegateFunction         = Marshal.GetDelegateForFunctionPointer<AddRefDelegate>((IntPtr)vtbl[1]);
            ReleaseDelegateFunction        = Marshal.GetDelegateForFunctionPointer<ReleaseDelegate>((IntPtr)vtbl[2]);
            GetDeviceFunction              = Marshal.GetDelegateForFunctionPointer<GetDeviceDelegate>((IntPtr)vtbl[3]);
            SetPrivateDataFunction         = Marshal.GetDelegateForFunctionPointer<SetPrivateDataDelegate>((IntPtr)vtbl[4]);
            GetPrivateDataFunction         = Marshal.GetDelegateForFunctionPointer<GetPrivateDataDelegate>((IntPtr)vtbl[5]);
            FreePrivateDataFunction        = Marshal.GetDelegateForFunctionPointer<FreePrivateDataDelegate>((IntPtr)vtbl[6]);
            SetPriorityFunction            = Marshal.GetDelegateForFunctionPointer<SetPriorityDelegate>((IntPtr)vtbl[7]);
            GetPriorityFunction            = Marshal.GetDelegateForFunctionPointer<GetPriorityDelegate>((IntPtr)vtbl[8]);
            PreLoadFunction                = Marshal.GetDelegateForFunctionPointer<PreLoadDelegate>((IntPtr)vtbl[9]);
            GetTypeFunction                = Marshal.GetDelegateForFunctionPointer<GetTypeDelegate>((IntPtr)vtbl[10]);
            LockDelegateFunction           = Marshal.GetDelegateForFunctionPointer<LockDelegate>((IntPtr)vtbl[11]);
            UnlockDelegateFunction         = Marshal.GetDelegateForFunctionPointer<UnlockDelegate>((IntPtr)vtbl[12]);
            GetDescDelegateFunction        = Marshal.GetDelegateForFunctionPointer<GetDescDelegate>((IntPtr)vtbl[13]);

            this.BufferPointer = buffer;

            DelegateCaches.Add((IntPtr)vtbl, this);
        }
    }

    public unsafe struct IDirect3DVertexBuffer8 {
        public void** Vtbl;

        internal IntPtr Identifer => (IntPtr)Vtbl;
        internal IDirect3DVertexBuffer8_DelegateHolder Delegates => IDirect3DVertexBuffer8_DelegateHolder.DelegateCaches[Identifer];
        internal IDirect3DVertexBuffer8* BufferPointer => Delegates.BufferPointer;

        public D3DRESULT GetDesc(out D3DVERTEXBUFFERDESC bufferDesc) {
            D3DVERTEXBUFFERDESC ptrDesc;

            int ret = Delegates.GetDescDelegateFunction(this.BufferPointer, &ptrDesc);

            bufferDesc = ptrDesc;

            return (D3DRESULT) ret;
        }

        public D3DRESULT Lock(uint offsetToLock, uint sizeToLock, D3DLOCK lockFlags, out byte* byteBuffer) {
            byte* ptrBuffer;

            int ret = Delegates.LockDelegateFunction(BufferPointer, offsetToLock, sizeToLock, &ptrBuffer, lockFlags);

            byteBuffer = ptrBuffer;

            return (D3DRESULT) ret;
        }

        public D3DRESULT Unlock() => (D3DRESULT)Delegates.UnlockDelegateFunction(BufferPointer);
    }
}
