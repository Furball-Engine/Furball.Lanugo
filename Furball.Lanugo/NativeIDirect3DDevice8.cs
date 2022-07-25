using System;
using System.Collections.Generic;
using System.Numerics;
using System.Runtime.InteropServices;
using Silk.NET.Core;

namespace Furball.Lanugo {
    public unsafe class IDirect3DDevice8 {
        internal NativeIDirect3DDevice8* DevicePointer;

        #region Delegates

        internal delegate int  QueryInterfaceDelegate(NativeIDirect3DDevice8* device, Guid riid, void** ppvObj);
        internal delegate uint AddRefDelegate(NativeIDirect3DDevice8* device);
        internal delegate uint ReleaseDelegate(NativeIDirect3DDevice8* device);
        internal delegate int  TestCooperativeLevelDelegate(NativeIDirect3DDevice8* device);
        internal delegate uint GetAvailableTextureMemDelegate(NativeIDirect3DDevice8* device);
        internal delegate int  ResourceManagerDiscardBytesDelegate(NativeIDirect3DDevice8* device, int bytes);
        internal delegate int  GetDirect3DDelegate(NativeIDirect3DDevice8* device, IDirect3D8** ppD3D8);
        internal delegate int  GetDeviceCapsDelegate(NativeIDirect3DDevice8* device, D3DCAPS8* pCaps);
        internal delegate int  GetDisplayModeDelegate(NativeIDirect3DDevice8* device, D3DDISPLAYMODE* pMode);
        internal delegate int  GetCreationParametersDelegate(NativeIDirect3DDevice8* device, D3DDEVICE_CREATION_PARAMETERS* pParameters);
        internal delegate int  SetCursorPropertiesDelegate(NativeIDirect3DDevice8* device, uint xHotSpot, uint yHotSpot, IDirect3DSurface8* pCursorBitmap);
        internal delegate void SetCursorPositionDelegate(NativeIDirect3DDevice8* device, uint xScreenSpace, uint yScreenSpace, int flags);
        internal delegate Bool32 ShowCursorDelegate(NativeIDirect3DDevice8* device, int bShow);
        internal delegate int  CreateAdditionalSwapChainDelegate(NativeIDirect3DDevice8* device, void* pPresentationParameters, IDirect3DSwapChain8** pSwapChain);
        internal delegate int  ResetDelegate(NativeIDirect3DDevice8* device, void* pPresentationParameters);
        internal delegate int  PresentDelegate(NativeIDirect3DDevice8* device, RECT* pSourceRect, RECT* pDestRect, IntPtr hDestWindowOverride, void* pDirtyRegion);
        internal delegate int  GetBackBufferDelegate(NativeIDirect3DDevice8* device, uint backBuffer, D3DBACKBUFFER_TYPE type, IDirect3DSurface8** ppBackBuffer);
        internal delegate int  GetRasterStatusDelegate(NativeIDirect3DDevice8* device, D3DRASTER_STATUS* pRasterStatus);
        internal delegate void SetGammaRampDelegate(NativeIDirect3DDevice8* device, int flags, D3DGAMMARAMP* pRamp);
        internal delegate void GetGammaRampDelegate(NativeIDirect3DDevice8* device, D3DGAMMARAMP* pRamp);
        internal delegate int  CreateTextureDelegate(NativeIDirect3DDevice8* device, uint width, uint height, uint levels, int usage, D3DFORMAT format, D3DPOOL pool, IDirect3DTexture8** ppTexture);
        internal delegate int  CreateVolumeTextureDelegate(NativeIDirect3DDevice8* device, uint width, uint height, uint depth, uint levels, int usage, D3DFORMAT format, D3DPOOL pool, IDirect3DVolumeTexture8** ppVolumeTexture);
        internal delegate int  CreateCubeTextureDelegate(NativeIDirect3DDevice8* device, uint edgeLength, uint levels, int usage, D3DFORMAT format, D3DPOOL pool, IDirect3DCubeTexture8** ppCubeTexture);
        internal delegate int  CreateVertexBufferDelegate(NativeIDirect3DDevice8* device, uint length, int usage, int fvf, D3DPOOL pool, NativeIDirect3DVertexBuffer8** ppVertexBuffer);
        internal delegate int  CreateIndexBufferDelegate(NativeIDirect3DDevice8* device, uint length, int usage, D3DFORMAT format, D3DPOOL pool, IDirect3DIndexBuffer8** ppIndexBuffer);
        internal delegate int  CreateRenderTargetDelegate(NativeIDirect3DDevice8* device, uint width, uint height, D3DFORMAT format, D3DMULTISAMPLE_TYPE multiSample, int lockable, IDirect3DSurface8** ppSurface);
        internal delegate int  CreateDepthStencilSurfaceDelegate(NativeIDirect3DDevice8* device, uint width, uint height, D3DFORMAT format, D3DMULTISAMPLE_TYPE multiSample, IDirect3DSurface8** ppSurface);
        internal delegate int  CreateImageSurfaceDelegate(NativeIDirect3DDevice8* device, uint width, uint height, D3DFORMAT format, IDirect3DSurface8** ppSurface);
        internal delegate int  CopyRectsDelegate(NativeIDirect3DDevice8* device, IDirect3DSurface8* pSourceSurface, RECT* pSourceRectsArray, uint cRects, IDirect3DSurface8* pDestinationSurface, D3DPOINT* pDestPointsArray);
        internal delegate int  UpdateTextureDelegate(NativeIDirect3DDevice8* device, IDirect3DBaseTexture8* pSourceTexture, IDirect3DBaseTexture8* pDestinationTexture);
        internal delegate int  GetFrontBufferDelegate(NativeIDirect3DDevice8* device, IDirect3DSurface8* pDestSurface);
        internal delegate int  SetRenderTargetDelegate(NativeIDirect3DDevice8* device, IDirect3DSurface8* pRenderTarget, IDirect3DSurface8* pNewZStencil);
        internal delegate int  GetRenderTargetDelegate(NativeIDirect3DDevice8* device, IDirect3DSurface8** ppRenderTarget);
        internal delegate int  GetDepthStencilSurfaceDelegate(NativeIDirect3DDevice8* device, IDirect3DSurface8** ppZStencilSurface);
        internal delegate int  BeginSceneDelegate(NativeIDirect3DDevice8* device);
        internal delegate int  EndSceneDelegate(NativeIDirect3DDevice8* device);
        internal delegate int  ClearDelegate(NativeIDirect3DDevice8* device, int count, D3DRECT* pRects, D3DCLEAR flags, D3DCOLOR color, float z, int stencil);
        internal delegate int  SetTransformDelegate(NativeIDirect3DDevice8* device, D3DTRANSFORMSTATETYPE state, Matrix4x4* pMatrix);
        internal delegate int  GetTransformDelegate(NativeIDirect3DDevice8* device, D3DTRANSFORMSTATETYPE state, Matrix4x4* pMatrix);
        internal delegate int  MultiplyTransformDelegate(NativeIDirect3DDevice8* device, D3DTRANSFORMSTATETYPE state, Matrix4x4* pMatrix);
        internal delegate int  SetViewportDelegate(NativeIDirect3DDevice8* device, D3DVIEWPORT8* pViewport);
        internal delegate int  GetViewportDelegate(NativeIDirect3DDevice8* device, D3DVIEWPORT8* pViewport);
        internal delegate int  SetMaterialDelegate(NativeIDirect3DDevice8* device, D3DMATERIAL8* pMaterial);
        internal delegate int  GetMaterialDelegate(NativeIDirect3DDevice8* device, D3DMATERIAL8* pMaterial);
        internal delegate int  SetLightDelegate(NativeIDirect3DDevice8* device, int index, D3DLIGHT8* light);
        internal delegate int  GetLightDelegate(NativeIDirect3DDevice8* device, int index, D3DLIGHT8* light);
        internal delegate int  LightEnableDelegate(NativeIDirect3DDevice8* device, int index, int enable);
        internal delegate int  GetLightEnableDelegate(NativeIDirect3DDevice8* device, int index, int* pEnable);
        internal delegate int  SetClipPlaneDelegate(NativeIDirect3DDevice8* device, int index, float* pPlane);
        internal delegate int  GetClipPlaneDelegate(NativeIDirect3DDevice8* device, int index, float* pPlane);
        internal delegate int  SetRenderStateDelegate(NativeIDirect3DDevice8* device, D3DRENDERSTATETYPE state, int value);
        internal delegate int  GetRenderStateDelegate(NativeIDirect3DDevice8* device, D3DRENDERSTATETYPE state, int* pValue);
        internal delegate int  BeginStateBlockDelegate(NativeIDirect3DDevice8* device);
        internal delegate int  EndStateBlockDelegate(NativeIDirect3DDevice8* device, int* pToken);
        internal delegate int  ApplyStateBlockDelegate(NativeIDirect3DDevice8* device, int token);
        internal delegate int  CaptureStateBlockDelegate(NativeIDirect3DDevice8* device, int token);
        internal delegate int  DeleteStateBlockDelegate(NativeIDirect3DDevice8* device, int token);
        internal delegate int  CreateStateBlockDelegate(NativeIDirect3DDevice8* device, D3DSTATEBLOCKTYPE type, int* pToken);
        internal delegate int  SetClipStatusDelegate(NativeIDirect3DDevice8* device, D3DCLIPSTATUS8* pClipStatus);
        internal delegate int  GetClipStatusDelegate(NativeIDirect3DDevice8* device, D3DCLIPSTATUS8* pClipStatus);
        internal delegate int  GetTextureDelegate(NativeIDirect3DDevice8* device, int stage, IDirect3DBaseTexture8** ppTexture);
        internal delegate int  SetTextureDelegate(NativeIDirect3DDevice8* device, int stage, IDirect3DBaseTexture8* pTexture);
        internal delegate int  GetTextureStageStateDelegate(NativeIDirect3DDevice8* device, int stage, D3DTEXTURESTAGESTATETYPE type, int* pValue);
        internal delegate int  SetTextureStageStateDelegate(NativeIDirect3DDevice8* device, int stage, D3DTEXTURESTAGESTATETYPE type, int value);
        internal delegate int  ValidateDeviceDelegate(NativeIDirect3DDevice8* device, int* pNumPasses);
        internal delegate int  GetInfoDelegate(NativeIDirect3DDevice8* device, int devInfoId, void* pDevInfoStruct, int devInfoStructSize);
        internal delegate int  SetPaletteEntriesDelegate(NativeIDirect3DDevice8* device, uint paletteNumber, D3DPALETTEENTRY* pEntries);
        internal delegate int  GetPaletteEntriesDelegate(NativeIDirect3DDevice8* device, uint paletteNumber, D3DPALETTEENTRY* pEntries);
        internal delegate int  SetCurrentTexturePaletteDelegate(NativeIDirect3DDevice8* device, uint paletteNumber);
        internal delegate int  GetCurrentTexturePaletteDelegate(NativeIDirect3DDevice8* device, uint* paletteNumber);
        internal delegate int  DrawPrimitiveDelegate(NativeIDirect3DDevice8* device, D3DPRIMITIVETYPE primitiveType, uint startVertex, uint primitiveCount);
        internal delegate int  DrawIndexedPrimitiveDelegate(NativeIDirect3DDevice8* device, D3DPRIMITIVETYPE primitiveType, uint minIndex, uint numVertices, uint startIndex, uint primCount);
        internal delegate int  DrawPrimitiveUserPointerDelegate(NativeIDirect3DDevice8* device, D3DPRIMITIVETYPE primitiveType, uint primitiveCount, void* pVertexStreamZeroData, uint vertexStreamZeroStride);
        internal delegate int  DrawIndexedPrimitiveUserPointerDelegate(NativeIDirect3DDevice8* device, D3DPRIMITIVETYPE primitiveType, uint minVertexIndex, uint numVertexIndices, uint primitiveCount, void* pIndexData, D3DFORMAT indexDataFormat, void* pVertexStreamZeroData, uint vertexStreamZeroStride);
        internal delegate int  ProcessVerticesDelegate(NativeIDirect3DDevice8* device, uint srcStartIndex, uint destIndex, uint vertexCount, NativeIDirect3DVertexBuffer8* pDestBuffer, int flags);
        internal delegate int  CreateVertexShaderDelegate(NativeIDirect3DDevice8* device, int* pDeclaration, int* pFunction, int* pHandle, int usage);
        internal delegate int  SetVertexShaderDelegate(NativeIDirect3DDevice8* device, int handle);
        internal delegate int  GetVertexShaderDelegate(NativeIDirect3DDevice8* device, int* pHandle);
        internal delegate int  DeleteVertexShaderDelegate(NativeIDirect3DDevice8* device, int handle);
        internal delegate int  SetVertexShaderConstantDelegate(NativeIDirect3DDevice8* device, int register, void* pConstantData, int constantCount);
        internal delegate int  GetVertexShaderConstantDelegate(NativeIDirect3DDevice8* device, int register, void* pConstantData, int constantCount);
        internal delegate int  GetVertexShaderDeclarationDelegate(NativeIDirect3DDevice8* device, int handle, void* pData, int* pSizeOfData);
        internal delegate int  GetVertexShaderFunctionDelegate(NativeIDirect3DDevice8* device, int handle, void* pData, int* pSizeOfData);
        internal delegate int  SetStreamSourceDelegate(NativeIDirect3DDevice8* device, uint streamNumber, NativeIDirect3DVertexBuffer8* pStreamData, uint stride);
        internal delegate int  GetStreamSourceDelegate(NativeIDirect3DDevice8* device, uint streamNumber, NativeIDirect3DVertexBuffer8** ppStreamData, uint* pStride);
        internal delegate int  SetIndicesDelegate(NativeIDirect3DDevice8* device, IDirect3DIndexBuffer8* pIndexData, uint baseVertexIndex);
        internal delegate int  GetIndicesDelegate(NativeIDirect3DDevice8* device, IDirect3DIndexBuffer8** ppIndexData, uint* pBaseVertexIndex);
        internal delegate int  CreatePixelShaderDelegate(NativeIDirect3DDevice8* device, int* pFunction, int* pHandle);
        internal delegate int  SetPixelShaderDelegate(NativeIDirect3DDevice8* device, int handle);
        internal delegate int  GetPixelShaderDelegate(NativeIDirect3DDevice8* device, int* pHandle);
        internal delegate int  DeletePixelShaderDelegate(NativeIDirect3DDevice8* device, int handle);
        internal delegate int  SetPixelShaderConstantDelegate(NativeIDirect3DDevice8* device, int register, void* pConstantData, int constantCount);
        internal delegate int  GetPixelShaderConstantDelegate(NativeIDirect3DDevice8* device, int register, void* pConstantData, int constantCount);
        internal delegate int  GetPixelShaderFunctionDelegate(NativeIDirect3DDevice8* device, int handle, void* pData, int* pSizeOfData);
        internal delegate int  DrawRectPatchDelegate(NativeIDirect3DDevice8* device, uint handle, float* pNumSegs, D3DRECTPATCH_INFO* pRectPatchInfo);
        internal delegate int  DrawTriPatchDelegate(NativeIDirect3DDevice8* device, uint handle, float* pNumSegs, D3DTRIPATCH_INFO* pTriPatchInfo);
        internal delegate int  DeletePatchDelegate(NativeIDirect3DDevice8* device, uint handle);

        internal static QueryInterfaceDelegate                  QueryInterfaceDelegateFunction;
        internal static AddRefDelegate                          AddRefDelegateFunction;
        internal static ReleaseDelegate                         ReleaseDelegateFunction;
        internal static TestCooperativeLevelDelegate            TestCooperativeLevelDelegateFunction;
        internal static GetAvailableTextureMemDelegate          GetAvailableTextureMemDelegateFunction;
        internal static ResourceManagerDiscardBytesDelegate     ResourceManagerDiscardBytesDelegateFunction;
        internal static GetDirect3DDelegate                     GetDirect3DDelegateFunction;
        internal static GetDeviceCapsDelegate                   GetDeviceCapsDelegateFunction;
        internal static GetDisplayModeDelegate                  GetDisplayModeDelegateFunction;
        internal static GetCreationParametersDelegate           GetCreationParametersDelegateFunction;
        internal static SetCursorPropertiesDelegate             SetCursorPropertiesDelegateFunction;
        internal static SetCursorPositionDelegate               SetCursorPositionDelegateFunction;
        internal static ShowCursorDelegate                      ShowCursorDelegateFunction;
        internal static CreateAdditionalSwapChainDelegate       CreateAdditionalSwapChainDelegateFunction;
        internal static ResetDelegate                           ResetDelegateFunction;
        internal static PresentDelegate                         PresentDelegateFunction;
        internal static GetBackBufferDelegate                   GetBackBufferDelegateFunction;
        internal static GetRasterStatusDelegate                 GetRasterStatusDelegateFunction;
        internal static SetGammaRampDelegate                    SetGammaRampDelegateFunction;
        internal static GetGammaRampDelegate                    GetGammaRampDelegateFunction;
        internal static CreateTextureDelegate                   CreateTextureDelegateFunction;
        internal static CreateVolumeTextureDelegate             CreateVolumeTextureDelegateFunction;
        internal static CreateCubeTextureDelegate               CreateCubeTextureDelegateFunction;
        internal static CreateVertexBufferDelegate              CreateVertexBufferDelegateFunction;
        internal static CreateIndexBufferDelegate               CreateIndexBufferDelegateFunction;
        internal static CreateRenderTargetDelegate              CreateRenderTargetDelegateFunction;
        internal static CreateDepthStencilSurfaceDelegate       CreateDepthStencilSurfaceDelegateFunction;
        internal static CreateImageSurfaceDelegate              CreateImageSurfaceDelegateFunction;
        internal static CopyRectsDelegate                       CopyRectsDelegateFunction;
        internal static UpdateTextureDelegate                   UpdateTextureDelegateFunction;
        internal static GetFrontBufferDelegate                  GetFrontBufferDelegateFunction;
        internal static SetRenderTargetDelegate                 SetRenderTargetDelegateFunction;
        internal static GetRenderTargetDelegate                 GetRenderTargetDelegateFunction;
        internal static GetDepthStencilSurfaceDelegate          GetDepthStencilSurfaceDelegateFunction;
        internal static BeginSceneDelegate                      BeginSceneDelegateFunction;
        internal static EndSceneDelegate                        EndSceneDelegateFunction;
        internal static ClearDelegate                           ClearDelegateFunction;
        internal static SetTransformDelegate                    SetTransformDelegateFunction;
        internal static GetTransformDelegate                    GetTransformDelegateFunction;
        internal static MultiplyTransformDelegate               MultiplyTransformDelegateFunction;
        internal static SetViewportDelegate                     SetViewportDelegateFunction;
        internal static GetViewportDelegate                     GetViewportDelegateFunction;
        internal static SetMaterialDelegate                     SetMaterialDelegateFunction;
        internal static GetMaterialDelegate                     GetMaterialDelegateFunction;
        internal static SetLightDelegate                        SetLightDelegateFunction;
        internal static GetLightDelegate                        GetLightDelegateFunction;
        internal static LightEnableDelegate                     LightEnableDelegateFunction;
        internal static GetLightEnableDelegate                  GetLightEnableDelegateFunction;
        internal static SetClipPlaneDelegate                    SetClipPlaneDelegateFunction;
        internal static GetClipPlaneDelegate                    GetClipPlaneDelegateFunction;
        internal static SetRenderStateDelegate                  SetRenderStateDelegateFunction;
        internal static GetRenderStateDelegate                  GetRenderStateDelegateFunction;
        internal static BeginStateBlockDelegate                 BeginStateBlockDelegateFunction;
        internal static EndStateBlockDelegate                   EndStateBlockDelegateFunction;
        internal static ApplyStateBlockDelegate                 ApplyStateBlockDelegateFunction;
        internal static CaptureStateBlockDelegate               CaptureStateBlockDelegateFunction;
        internal static DeleteStateBlockDelegate                DeleteStateBlockDelegateFunction;
        internal static CreateStateBlockDelegate                CreateStateBlockDelegateFunction;
        internal static SetClipStatusDelegate                   SetClipStatusDelegateFunction;
        internal static GetClipStatusDelegate                   GetClipStatusDelegateFunction;
        internal static GetTextureDelegate                      GetTextureDelegateFunction;
        internal static SetTextureDelegate                      SetTextureDelegateFunction;
        internal static GetTextureStageStateDelegate            GetTextureStageStateDelegateFunction;
        internal static SetTextureStageStateDelegate            SetTextureStageStateDelegateFunction;
        internal static ValidateDeviceDelegate                  ValidateDeviceDelegateFunction;
        internal static GetInfoDelegate                         GetInfoDelegateFunction;
        internal static SetPaletteEntriesDelegate               SetPaletteEntriesDelegateFunction;
        internal static GetPaletteEntriesDelegate               GetPaletteEntriesDelegateFunction;
        internal static SetCurrentTexturePaletteDelegate        SetCurrentTexturePaletteDelegateFunction;
        internal static GetCurrentTexturePaletteDelegate        GetCurrentTexturePaletteDelegateFunction;
        internal static DrawPrimitiveDelegate                   DrawPrimitiveDelegateFunction;
        internal static DrawIndexedPrimitiveDelegate            DrawIndexedPrimitiveDelegateFunction;
        internal static DrawPrimitiveUserPointerDelegate        DrawPrimitiveUserPointerDelegateFunction;
        internal static DrawIndexedPrimitiveUserPointerDelegate DrawIndexedPrimitiveUserPointerDelegateFunction;
        internal static ProcessVerticesDelegate                 ProcessVerticesDelegateFunction;
        internal static CreateVertexShaderDelegate              CreateVertexShaderDelegateFunction;
        internal static SetVertexShaderDelegate                 SetVertexShaderDelegateFunction;
        internal static GetVertexShaderDelegate                 GetVertexShaderDelegateFunction;
        internal static DeleteVertexShaderDelegate              DeleteVertexShaderDelegateFunction;
        internal static SetVertexShaderConstantDelegate         SetVertexShaderConstantDelegateFunction;
        internal static GetVertexShaderConstantDelegate         GetVertexShaderConstantDelegateFunction;
        internal static GetVertexShaderDeclarationDelegate      GetVertexShaderDeclarationDelegateFunction;
        internal static GetVertexShaderFunctionDelegate         GetVertexShaderFunctionDelegateFunction;
        internal static SetStreamSourceDelegate                 SetStreamSourceDelegateFunction;
        internal static GetStreamSourceDelegate                 GetStreamSourceDelegateFunction;
        internal static SetIndicesDelegate                      SetIndicesDelegateFunction;
        internal static GetIndicesDelegate                      GetIndicesDelegateFunction;
        internal static CreatePixelShaderDelegate               CreatePixelShaderDelegateFunction;
        internal static SetPixelShaderDelegate                  SetPixelShaderDelegateFunction;
        internal static GetPixelShaderDelegate                  GetPixelShaderDelegateFunction;
        internal static DeletePixelShaderDelegate               DeletePixelShaderDelegateFunction;
        internal static SetPixelShaderConstantDelegate          SetPixelShaderConstantDelegateFunction;
        internal static GetPixelShaderConstantDelegate          GetPixelShaderConstantDelegateFunction;
        internal static GetPixelShaderFunctionDelegate          GetPixelShaderFunctionDelegateFunction;
        internal static DrawRectPatchDelegate                   DrawRectPatchDelegateFunction;
        internal static DrawTriPatchDelegate                    DrawTriPatchDelegateFunction;
        internal static DeletePatchDelegate                     DeletePatchDelegateFunction;

        #endregion

        public IDirect3DDevice8(NativeIDirect3DDevice8* devicePointer) {
            this.DevicePointer = devicePointer;

            if (DeletePatchDelegateFunction == null) {
                QueryInterfaceDelegateFunction                  = Marshal.GetDelegateForFunctionPointer<QueryInterfaceDelegate>((IntPtr)this.DevicePointer->Vtbl[0]);
                AddRefDelegateFunction                          = Marshal.GetDelegateForFunctionPointer<AddRefDelegate>((IntPtr)this.DevicePointer->Vtbl[1]);
                ReleaseDelegateFunction                         = Marshal.GetDelegateForFunctionPointer<ReleaseDelegate>((IntPtr)this.DevicePointer->Vtbl[2]);
                TestCooperativeLevelDelegateFunction            = Marshal.GetDelegateForFunctionPointer<TestCooperativeLevelDelegate>((IntPtr)this.DevicePointer->Vtbl[3]);
                GetAvailableTextureMemDelegateFunction          = Marshal.GetDelegateForFunctionPointer<GetAvailableTextureMemDelegate>((IntPtr)this.DevicePointer->Vtbl[4]);
                ResourceManagerDiscardBytesDelegateFunction     = Marshal.GetDelegateForFunctionPointer<ResourceManagerDiscardBytesDelegate>((IntPtr)this.DevicePointer->Vtbl[5]);
                GetDirect3DDelegateFunction                     = Marshal.GetDelegateForFunctionPointer<GetDirect3DDelegate>((IntPtr)this.DevicePointer->Vtbl[6]);
                GetDeviceCapsDelegateFunction                   = Marshal.GetDelegateForFunctionPointer<GetDeviceCapsDelegate>((IntPtr)this.DevicePointer->Vtbl[7]);
                GetDisplayModeDelegateFunction                  = Marshal.GetDelegateForFunctionPointer<GetDisplayModeDelegate>((IntPtr)this.DevicePointer->Vtbl[8]);
                GetCreationParametersDelegateFunction           = Marshal.GetDelegateForFunctionPointer<GetCreationParametersDelegate>((IntPtr)this.DevicePointer->Vtbl[9]);
                SetCursorPropertiesDelegateFunction             = Marshal.GetDelegateForFunctionPointer<SetCursorPropertiesDelegate>((IntPtr)this.DevicePointer->Vtbl[10]);
                SetCursorPositionDelegateFunction               = Marshal.GetDelegateForFunctionPointer<SetCursorPositionDelegate>((IntPtr)this.DevicePointer->Vtbl[11]);
                ShowCursorDelegateFunction                      = Marshal.GetDelegateForFunctionPointer<ShowCursorDelegate>((IntPtr)this.DevicePointer->Vtbl[12]);
                CreateAdditionalSwapChainDelegateFunction       = Marshal.GetDelegateForFunctionPointer<CreateAdditionalSwapChainDelegate>((IntPtr)this.DevicePointer->Vtbl[13]);
                ResetDelegateFunction                           = Marshal.GetDelegateForFunctionPointer<ResetDelegate>((IntPtr)this.DevicePointer->Vtbl[14]);
                PresentDelegateFunction                         = Marshal.GetDelegateForFunctionPointer<PresentDelegate>((IntPtr)this.DevicePointer->Vtbl[15]);
                GetBackBufferDelegateFunction                   = Marshal.GetDelegateForFunctionPointer<GetBackBufferDelegate>((IntPtr)this.DevicePointer->Vtbl[16]);
                GetRasterStatusDelegateFunction                 = Marshal.GetDelegateForFunctionPointer<GetRasterStatusDelegate>((IntPtr)this.DevicePointer->Vtbl[17]);
                SetGammaRampDelegateFunction                    = Marshal.GetDelegateForFunctionPointer<SetGammaRampDelegate>((IntPtr)this.DevicePointer->Vtbl[18]);
                GetGammaRampDelegateFunction                    = Marshal.GetDelegateForFunctionPointer<GetGammaRampDelegate>((IntPtr)this.DevicePointer->Vtbl[19]);
                CreateTextureDelegateFunction                   = Marshal.GetDelegateForFunctionPointer<CreateTextureDelegate>((IntPtr)this.DevicePointer->Vtbl[20]);
                CreateVolumeTextureDelegateFunction             = Marshal.GetDelegateForFunctionPointer<CreateVolumeTextureDelegate>((IntPtr)this.DevicePointer->Vtbl[21]);
                CreateCubeTextureDelegateFunction               = Marshal.GetDelegateForFunctionPointer<CreateCubeTextureDelegate>((IntPtr)this.DevicePointer->Vtbl[22]);
                CreateVertexBufferDelegateFunction              = Marshal.GetDelegateForFunctionPointer<CreateVertexBufferDelegate>((IntPtr)this.DevicePointer->Vtbl[23]);
                CreateIndexBufferDelegateFunction               = Marshal.GetDelegateForFunctionPointer<CreateIndexBufferDelegate>((IntPtr)this.DevicePointer->Vtbl[24]);
                CreateRenderTargetDelegateFunction              = Marshal.GetDelegateForFunctionPointer<CreateRenderTargetDelegate>((IntPtr)this.DevicePointer->Vtbl[25]);
                CreateDepthStencilSurfaceDelegateFunction       = Marshal.GetDelegateForFunctionPointer<CreateDepthStencilSurfaceDelegate>((IntPtr)this.DevicePointer->Vtbl[26]);
                CreateImageSurfaceDelegateFunction              = Marshal.GetDelegateForFunctionPointer<CreateImageSurfaceDelegate>((IntPtr)this.DevicePointer->Vtbl[27]);
                CopyRectsDelegateFunction                       = Marshal.GetDelegateForFunctionPointer<CopyRectsDelegate>((IntPtr)this.DevicePointer->Vtbl[28]);
                UpdateTextureDelegateFunction                   = Marshal.GetDelegateForFunctionPointer<UpdateTextureDelegate>((IntPtr)this.DevicePointer->Vtbl[29]);
                GetFrontBufferDelegateFunction                  = Marshal.GetDelegateForFunctionPointer<GetFrontBufferDelegate>((IntPtr)this.DevicePointer->Vtbl[30]);
                SetRenderTargetDelegateFunction                 = Marshal.GetDelegateForFunctionPointer<SetRenderTargetDelegate>((IntPtr)this.DevicePointer->Vtbl[31]);
                GetRenderTargetDelegateFunction                 = Marshal.GetDelegateForFunctionPointer<GetRenderTargetDelegate>((IntPtr)this.DevicePointer->Vtbl[32]);
                GetDepthStencilSurfaceDelegateFunction          = Marshal.GetDelegateForFunctionPointer<GetDepthStencilSurfaceDelegate>((IntPtr)this.DevicePointer->Vtbl[33]);
                BeginSceneDelegateFunction                      = Marshal.GetDelegateForFunctionPointer<BeginSceneDelegate>((IntPtr)this.DevicePointer->Vtbl[34]);
                EndSceneDelegateFunction                        = Marshal.GetDelegateForFunctionPointer<EndSceneDelegate>((IntPtr)this.DevicePointer->Vtbl[35]);
                ClearDelegateFunction                           = Marshal.GetDelegateForFunctionPointer<ClearDelegate>((IntPtr)this.DevicePointer->Vtbl[36]);
                SetTransformDelegateFunction                    = Marshal.GetDelegateForFunctionPointer<SetTransformDelegate>((IntPtr)this.DevicePointer->Vtbl[37]);
                GetTransformDelegateFunction                    = Marshal.GetDelegateForFunctionPointer<GetTransformDelegate>((IntPtr)this.DevicePointer->Vtbl[38]);
                MultiplyTransformDelegateFunction               = Marshal.GetDelegateForFunctionPointer<MultiplyTransformDelegate>((IntPtr)this.DevicePointer->Vtbl[39]);
                SetViewportDelegateFunction                     = Marshal.GetDelegateForFunctionPointer<SetViewportDelegate>((IntPtr)this.DevicePointer->Vtbl[40]);
                GetViewportDelegateFunction                     = Marshal.GetDelegateForFunctionPointer<GetViewportDelegate>((IntPtr)this.DevicePointer->Vtbl[41]);
                SetMaterialDelegateFunction                     = Marshal.GetDelegateForFunctionPointer<SetMaterialDelegate>((IntPtr)this.DevicePointer->Vtbl[42]);
                GetMaterialDelegateFunction                     = Marshal.GetDelegateForFunctionPointer<GetMaterialDelegate>((IntPtr)this.DevicePointer->Vtbl[43]);
                SetLightDelegateFunction                        = Marshal.GetDelegateForFunctionPointer<SetLightDelegate>((IntPtr)this.DevicePointer->Vtbl[44]);
                GetLightDelegateFunction                        = Marshal.GetDelegateForFunctionPointer<GetLightDelegate>((IntPtr)this.DevicePointer->Vtbl[45]);
                LightEnableDelegateFunction                     = Marshal.GetDelegateForFunctionPointer<LightEnableDelegate>((IntPtr)this.DevicePointer->Vtbl[46]);
                GetLightEnableDelegateFunction                  = Marshal.GetDelegateForFunctionPointer<GetLightEnableDelegate>((IntPtr)this.DevicePointer->Vtbl[47]);
                SetClipPlaneDelegateFunction                    = Marshal.GetDelegateForFunctionPointer<SetClipPlaneDelegate>((IntPtr)this.DevicePointer->Vtbl[48]);
                GetClipPlaneDelegateFunction                    = Marshal.GetDelegateForFunctionPointer<GetClipPlaneDelegate>((IntPtr)this.DevicePointer->Vtbl[49]);
                SetRenderStateDelegateFunction                  = Marshal.GetDelegateForFunctionPointer<SetRenderStateDelegate>((IntPtr)this.DevicePointer->Vtbl[50]);
                GetRenderStateDelegateFunction                  = Marshal.GetDelegateForFunctionPointer<GetRenderStateDelegate>((IntPtr)this.DevicePointer->Vtbl[51]);
                BeginStateBlockDelegateFunction                 = Marshal.GetDelegateForFunctionPointer<BeginStateBlockDelegate>((IntPtr)this.DevicePointer->Vtbl[52]);
                EndStateBlockDelegateFunction                   = Marshal.GetDelegateForFunctionPointer<EndStateBlockDelegate>((IntPtr)this.DevicePointer->Vtbl[53]);
                ApplyStateBlockDelegateFunction                 = Marshal.GetDelegateForFunctionPointer<ApplyStateBlockDelegate>((IntPtr)this.DevicePointer->Vtbl[54]);
                CaptureStateBlockDelegateFunction               = Marshal.GetDelegateForFunctionPointer<CaptureStateBlockDelegate>((IntPtr)this.DevicePointer->Vtbl[55]);
                DeleteStateBlockDelegateFunction                = Marshal.GetDelegateForFunctionPointer<DeleteStateBlockDelegate>((IntPtr)this.DevicePointer->Vtbl[56]);
                CreateStateBlockDelegateFunction                = Marshal.GetDelegateForFunctionPointer<CreateStateBlockDelegate>((IntPtr)this.DevicePointer->Vtbl[57]);
                SetClipStatusDelegateFunction                   = Marshal.GetDelegateForFunctionPointer<SetClipStatusDelegate>((IntPtr)this.DevicePointer->Vtbl[58]);
                GetClipStatusDelegateFunction                   = Marshal.GetDelegateForFunctionPointer<GetClipStatusDelegate>((IntPtr)this.DevicePointer->Vtbl[59]);
                GetTextureDelegateFunction                      = Marshal.GetDelegateForFunctionPointer<GetTextureDelegate>((IntPtr)this.DevicePointer->Vtbl[60]);
                SetTextureDelegateFunction                      = Marshal.GetDelegateForFunctionPointer<SetTextureDelegate>((IntPtr)this.DevicePointer->Vtbl[61]);
                GetTextureStageStateDelegateFunction            = Marshal.GetDelegateForFunctionPointer<GetTextureStageStateDelegate>((IntPtr)this.DevicePointer->Vtbl[62]);
                SetTextureStageStateDelegateFunction            = Marshal.GetDelegateForFunctionPointer<SetTextureStageStateDelegate>((IntPtr)this.DevicePointer->Vtbl[63]);
                ValidateDeviceDelegateFunction                  = Marshal.GetDelegateForFunctionPointer<ValidateDeviceDelegate>((IntPtr)this.DevicePointer->Vtbl[64]);
                GetInfoDelegateFunction                         = Marshal.GetDelegateForFunctionPointer<GetInfoDelegate>((IntPtr)this.DevicePointer->Vtbl[65]);
                SetPaletteEntriesDelegateFunction               = Marshal.GetDelegateForFunctionPointer<SetPaletteEntriesDelegate>((IntPtr)this.DevicePointer->Vtbl[66]);
                GetPaletteEntriesDelegateFunction               = Marshal.GetDelegateForFunctionPointer<GetPaletteEntriesDelegate>((IntPtr)this.DevicePointer->Vtbl[67]);
                SetCurrentTexturePaletteDelegateFunction        = Marshal.GetDelegateForFunctionPointer<SetCurrentTexturePaletteDelegate>((IntPtr)this.DevicePointer->Vtbl[68]);
                GetCurrentTexturePaletteDelegateFunction        = Marshal.GetDelegateForFunctionPointer<GetCurrentTexturePaletteDelegate>((IntPtr)this.DevicePointer->Vtbl[69]);
                DrawPrimitiveDelegateFunction                   = Marshal.GetDelegateForFunctionPointer<DrawPrimitiveDelegate>((IntPtr)this.DevicePointer->Vtbl[70]);
                DrawIndexedPrimitiveDelegateFunction            = Marshal.GetDelegateForFunctionPointer<DrawIndexedPrimitiveDelegate>((IntPtr)this.DevicePointer->Vtbl[71]);
                DrawPrimitiveUserPointerDelegateFunction        = Marshal.GetDelegateForFunctionPointer<DrawPrimitiveUserPointerDelegate>((IntPtr)this.DevicePointer->Vtbl[72]);
                DrawIndexedPrimitiveUserPointerDelegateFunction = Marshal.GetDelegateForFunctionPointer<DrawIndexedPrimitiveUserPointerDelegate>((IntPtr)this.DevicePointer->Vtbl[73]);
                ProcessVerticesDelegateFunction                 = Marshal.GetDelegateForFunctionPointer<ProcessVerticesDelegate>((IntPtr)this.DevicePointer->Vtbl[74]);
                CreateVertexShaderDelegateFunction              = Marshal.GetDelegateForFunctionPointer<CreateVertexShaderDelegate>((IntPtr)this.DevicePointer->Vtbl[75]);
                SetVertexShaderDelegateFunction                 = Marshal.GetDelegateForFunctionPointer<SetVertexShaderDelegate>((IntPtr)this.DevicePointer->Vtbl[76]);
                GetVertexShaderDelegateFunction                 = Marshal.GetDelegateForFunctionPointer<GetVertexShaderDelegate>((IntPtr)this.DevicePointer->Vtbl[77]);
                DeleteVertexShaderDelegateFunction              = Marshal.GetDelegateForFunctionPointer<DeleteVertexShaderDelegate>((IntPtr)this.DevicePointer->Vtbl[78]);
                SetVertexShaderConstantDelegateFunction         = Marshal.GetDelegateForFunctionPointer<SetVertexShaderConstantDelegate>((IntPtr)this.DevicePointer->Vtbl[79]);
                GetVertexShaderConstantDelegateFunction         = Marshal.GetDelegateForFunctionPointer<GetVertexShaderConstantDelegate>((IntPtr)this.DevicePointer->Vtbl[80]);
                GetVertexShaderDeclarationDelegateFunction      = Marshal.GetDelegateForFunctionPointer<GetVertexShaderDeclarationDelegate>((IntPtr)this.DevicePointer->Vtbl[81]);
                GetVertexShaderFunctionDelegateFunction         = Marshal.GetDelegateForFunctionPointer<GetVertexShaderFunctionDelegate>((IntPtr)this.DevicePointer->Vtbl[82]);
                SetStreamSourceDelegateFunction                 = Marshal.GetDelegateForFunctionPointer<SetStreamSourceDelegate>((IntPtr)this.DevicePointer->Vtbl[83]);
                GetStreamSourceDelegateFunction                 = Marshal.GetDelegateForFunctionPointer<GetStreamSourceDelegate>((IntPtr)this.DevicePointer->Vtbl[84]);
                SetIndicesDelegateFunction                      = Marshal.GetDelegateForFunctionPointer<SetIndicesDelegate>((IntPtr)this.DevicePointer->Vtbl[85]);
                GetIndicesDelegateFunction                      = Marshal.GetDelegateForFunctionPointer<GetIndicesDelegate>((IntPtr)this.DevicePointer->Vtbl[86]);
                CreatePixelShaderDelegateFunction               = Marshal.GetDelegateForFunctionPointer<CreatePixelShaderDelegate>((IntPtr)this.DevicePointer->Vtbl[87]);
                SetPixelShaderDelegateFunction                  = Marshal.GetDelegateForFunctionPointer<SetPixelShaderDelegate>((IntPtr)this.DevicePointer->Vtbl[88]);
                GetPixelShaderDelegateFunction                  = Marshal.GetDelegateForFunctionPointer<GetPixelShaderDelegate>((IntPtr)this.DevicePointer->Vtbl[89]);
                DeletePixelShaderDelegateFunction               = Marshal.GetDelegateForFunctionPointer<DeletePixelShaderDelegate>((IntPtr)this.DevicePointer->Vtbl[90]);
                SetPixelShaderConstantDelegateFunction          = Marshal.GetDelegateForFunctionPointer<SetPixelShaderConstantDelegate>((IntPtr)this.DevicePointer->Vtbl[91]);
                GetPixelShaderConstantDelegateFunction          = Marshal.GetDelegateForFunctionPointer<GetPixelShaderConstantDelegate>((IntPtr)this.DevicePointer->Vtbl[92]);
                GetPixelShaderFunctionDelegateFunction          = Marshal.GetDelegateForFunctionPointer<GetPixelShaderFunctionDelegate>((IntPtr)this.DevicePointer->Vtbl[93]);
                DrawRectPatchDelegateFunction                   = Marshal.GetDelegateForFunctionPointer<DrawRectPatchDelegate>((IntPtr)this.DevicePointer->Vtbl[94]);
                DrawTriPatchDelegateFunction                    = Marshal.GetDelegateForFunctionPointer<DrawTriPatchDelegate>((IntPtr)this.DevicePointer->Vtbl[95]);
                DeletePatchDelegateFunction                     = Marshal.GetDelegateForFunctionPointer<DeletePatchDelegate>((IntPtr)this.DevicePointer->Vtbl[96]);
            }
        }

        public D3DRESULT Clear(D3DRECT[] rects, D3DCLEAR clearTarget, D3DCOLOR clearColor, float z, int stencil) {
            int count = rects.Length;

            fixed (D3DRECT* ptrRects = rects) {
                int ret = ClearDelegateFunction(DevicePointer, count, ptrRects, clearTarget, clearColor, z, stencil);

                return (D3DRESULT) ret;
            }
        }

        public D3DRESULT Clear(D3DCLEAR clearTarget, D3DCOLOR clearColor, float z = 0, int stencil = 0) => (D3DRESULT) ClearDelegateFunction(DevicePointer, 0, null, clearTarget, clearColor, z, stencil);

        public D3DRESULT Present(RECT sourceRect, RECT destRect, IntPtr windowOverride) => (D3DRESULT) PresentDelegateFunction(DevicePointer, &sourceRect, &destRect, windowOverride, null);

        public D3DRESULT Present(IntPtr windowOverride) => (D3DRESULT) PresentDelegateFunction(DevicePointer, null, null, windowOverride, null);

        public D3DRESULT Present() => (D3DRESULT) PresentDelegateFunction(DevicePointer, null, null, IntPtr.Zero, null);

        public D3DRESULT BeginScene() => (D3DRESULT) BeginSceneDelegateFunction(DevicePointer);

        public D3DRESULT EndScene() => (D3DRESULT) EndSceneDelegateFunction(DevicePointer);

        public D3DRESULT ApplyStateBlock(int token) => (D3DRESULT)ApplyStateBlockDelegateFunction(DevicePointer, token);

        public D3DRESULT BeginStateBlock() => (D3DRESULT) BeginStateBlockDelegateFunction(DevicePointer);

        public D3DRESULT EndStateBlock(out int token) {
            int ptrToken;

            int ret = EndStateBlockDelegateFunction(DevicePointer, &ptrToken);

            token = ptrToken;

            return (D3DRESULT) ret;
        }

        public D3DRESULT CaptureStateBlock(int token) => (D3DRESULT)CaptureStateBlockDelegateFunction(DevicePointer, token);

        public D3DRESULT CreateStateBlock(D3DSTATEBLOCKTYPE type, out int token) {
            int ptrToken;

            int ret = CreateStateBlockDelegateFunction(DevicePointer, type, &ptrToken);

            token = ptrToken;

            return (D3DRESULT) ret;
        }

        public uint GetAvailableTextureMem() => GetAvailableTextureMemDelegateFunction(DevicePointer);

        public void GetAvailableTextureMem(out uint textureMemory) {
            textureMemory = this.GetAvailableTextureMem();
        }

        public D3DRESULT GetDeviceCaps(out D3DCAPS8 deviceCaps) {
            D3DCAPS8 caps = new D3DCAPS8();

            int ret = GetDeviceCapsDelegateFunction(DevicePointer, &caps);

            deviceCaps = caps;

            return (D3DRESULT) ret;
        }

        public D3DRESULT GetDisplayMode(out D3DDISPLAYMODE displayMode) {
            D3DDISPLAYMODE outDisplayMode;

            int ret = GetDisplayModeDelegateFunction(DevicePointer, &outDisplayMode);

            displayMode = outDisplayMode;

            return (D3DRESULT) ret;
        }

        public void GetGammaRamp(out D3DGAMMARAMP gammaRamp) {
            D3DGAMMARAMP outGammaRamp;

            GetGammaRampDelegateFunction(DevicePointer, &outGammaRamp);

            gammaRamp = outGammaRamp;
        }

        public D3DRESULT GetLight(int index, out D3DLIGHT8 light) {
            D3DLIGHT8 ptrLight;

            int ret = GetLightDelegateFunction(DevicePointer, index, &ptrLight);

            light = ptrLight;

            return (D3DRESULT) ret;
        }

        public D3DRESULT GetLightEnable(int index, out bool enabled) {
            int ptrEnabled;

            int ret = GetLightEnableDelegateFunction(DevicePointer, index, &ptrEnabled);

            enabled = ptrEnabled == 1;

            return (D3DRESULT) ret;
        }

        public D3DRESULT GetMaterial(out D3DMATERIAL8 material) {
            D3DMATERIAL8 ptrMaterial;

            int ret = GetMaterialDelegateFunction(DevicePointer, &ptrMaterial);

            material = ptrMaterial;

            return (D3DRESULT) ret;
        }

        public D3DRESULT GetPaletteEntries(uint paletteNumber, out D3DPALETTEENTRY paletteEntry) {
            D3DPALETTEENTRY ptrEntry;

            int ret = GetPaletteEntriesDelegateFunction(DevicePointer, paletteNumber, &ptrEntry);

            paletteEntry = ptrEntry;

            return (D3DRESULT) ret;
        }

        public D3DRESULT CreateVertexBuffer(uint size, D3DBUFFERUSAGE usage, D3DFVF bufferFormat, D3DPOOL pool, out IDirect3DVertexBuffer8 buffer) {
            NativeIDirect3DVertexBuffer8* ptrBuffer;

            int ret = CreateVertexBufferDelegateFunction(DevicePointer, size, (int)usage, (int)bufferFormat, pool, &ptrBuffer);

            buffer = new IDirect3DVertexBuffer8(ptrBuffer);

            return (D3DRESULT) ret;
        }

        public D3DRESULT SetStreamSource(uint streamNumber, IDirect3DVertexBuffer8 data, uint stride) => (D3DRESULT)SetStreamSourceDelegateFunction(DevicePointer, streamNumber, data.BufferPointer, stride);

        public D3DRESULT DrawPrimitive(D3DPRIMITIVETYPE primitiveType, uint startVertex, uint primitiveCount) => (D3DRESULT)DrawPrimitiveDelegateFunction(DevicePointer, primitiveType, startVertex, primitiveCount);

        public D3DRESULT SetVertexShader(int handle) => (D3DRESULT)SetVertexShaderDelegateFunction(DevicePointer,          handle);
        public D3DRESULT SetVertexShader(D3DFVF bufferFormat) => (D3DRESULT)SetVertexShaderDelegateFunction(DevicePointer, (int) bufferFormat);
    }

    public unsafe struct NativeIDirect3DDevice8 {
        public void** Vtbl;
    }
}
