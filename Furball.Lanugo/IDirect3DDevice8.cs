using System;
using System.Collections.Generic;
using System.Numerics;
using System.Runtime.InteropServices;
using Silk.NET.Core;

namespace Furball.Lanugo {
    public unsafe class IDirect3DDevice8 {
        internal VirtualTableStruct* StructPointer;

        #region Delegates

        internal delegate int QueryInterfaceDelegate(VirtualTableStruct* device, Guid riid, void** ppvObj);

        internal delegate uint AddRefDelegate(VirtualTableStruct* device);

        internal delegate uint ReleaseDelegate(VirtualTableStruct* device);

        internal delegate int TestCooperativeLevelDelegate(VirtualTableStruct* device);

        internal delegate uint GetAvailableTextureMemDelegate(VirtualTableStruct* device);

        internal delegate int ResourceManagerDiscardBytesDelegate(VirtualTableStruct* device, int bytes);

        internal delegate int GetDirect3DDelegate(VirtualTableStruct* device, IDirect3D8** ppD3D8);

        internal delegate int GetDeviceCapsDelegate(VirtualTableStruct* device, D3DCAPS8* pCaps);

        internal delegate int GetDisplayModeDelegate(VirtualTableStruct* device, D3DDISPLAYMODE* pMode);

        internal delegate int GetCreationParametersDelegate(VirtualTableStruct* device, D3DDEVICE_CREATION_PARAMETERS* pParameters);

        internal delegate int SetCursorPropertiesDelegate(VirtualTableStruct* device, uint xHotSpot, uint yHotSpot, VirtualTableStruct* pCursorBitmap);

        internal delegate void SetCursorPositionDelegate(VirtualTableStruct* device, uint xScreenSpace, uint yScreenSpace, int flags);

        internal delegate Bool32 ShowCursorDelegate(VirtualTableStruct* device, int bShow);

        internal delegate int CreateAdditionalSwapChainDelegate(VirtualTableStruct* device, void* pPresentationParameters, IDirect3DSwapChain8** pSwapChain);

        internal delegate int ResetDelegate(VirtualTableStruct* device, void* pPresentationParameters);

        internal delegate int PresentDelegate(VirtualTableStruct* device, RECT* pSourceRect, RECT* pDestRect, IntPtr hDestWindowOverride, void* pDirtyRegion);

        internal delegate int GetBackBufferDelegate(VirtualTableStruct* device, uint backBuffer, D3DBACKBUFFER_TYPE type, VirtualTableStruct** ppBackBuffer);

        internal delegate int GetRasterStatusDelegate(VirtualTableStruct* device, D3DRASTER_STATUS* pRasterStatus);

        internal delegate void SetGammaRampDelegate(VirtualTableStruct* device, int flags, D3DGAMMARAMP* pRamp);

        internal delegate void GetGammaRampDelegate(VirtualTableStruct* device, D3DGAMMARAMP* pRamp);

        internal delegate int CreateTextureDelegate(VirtualTableStruct* device, uint width, uint height, uint levels, int usage, D3DFORMAT format, D3DPOOL pool, IDirect3DTexture8** ppTexture);

        internal delegate int CreateVolumeTextureDelegate(VirtualTableStruct* device, uint width, uint height, uint depth, uint levels, int usage, D3DFORMAT format, D3DPOOL pool, IDirect3DVolumeTexture8** ppVolumeTexture);

        internal delegate int CreateCubeTextureDelegate(VirtualTableStruct* device, uint edgeLength, uint levels, int usage, D3DFORMAT format, D3DPOOL pool, IDirect3DCubeTexture8** ppCubeTexture);

        internal delegate int CreateVertexBufferDelegate(VirtualTableStruct* device, uint length, int usage, int fvf, D3DPOOL pool, VirtualTableStruct** ppVertexBuffer);

        internal delegate int CreateIndexBufferDelegate(VirtualTableStruct* device, uint length, int usage, D3DFORMAT format, D3DPOOL pool, IDirect3DIndexBuffer8** ppIndexBuffer);

        internal delegate int CreateRenderTargetDelegate(VirtualTableStruct* device, uint width, uint height, D3DFORMAT format, D3DMULTISAMPLE_TYPE multiSample, int lockable, VirtualTableStruct** ppSurface);

        internal delegate int CreateDepthStencilSurfaceDelegate(VirtualTableStruct* device, uint width, uint height, D3DFORMAT format, D3DMULTISAMPLE_TYPE multiSample, VirtualTableStruct** ppSurface);

        internal delegate int CreateImageSurfaceDelegate(VirtualTableStruct* device, uint width, uint height, D3DFORMAT format, VirtualTableStruct** ppSurface);

        internal delegate int CopyRectsDelegate(VirtualTableStruct* device, VirtualTableStruct* pSourceSurface, RECT* pSourceRectsArray, uint cRects, VirtualTableStruct* pDestinationSurface, D3DPOINT* pDestPointsArray);

        internal delegate int UpdateTextureDelegate(VirtualTableStruct* device, IDirect3DBaseTexture8* pSourceTexture, IDirect3DBaseTexture8* pDestinationTexture);

        internal delegate int GetFrontBufferDelegate(VirtualTableStruct* device, VirtualTableStruct* pDestSurface);

        internal delegate int SetRenderTargetDelegate(VirtualTableStruct* device, VirtualTableStruct* pRenderTarget, VirtualTableStruct* pNewZStencil);

        internal delegate int GetRenderTargetDelegate(VirtualTableStruct* device, VirtualTableStruct** ppRenderTarget);

        internal delegate int GetDepthStencilSurfaceDelegate(VirtualTableStruct* device, VirtualTableStruct** ppZStencilSurface);

        internal delegate int BeginSceneDelegate(VirtualTableStruct* device);

        internal delegate int EndSceneDelegate(VirtualTableStruct* device);

        internal delegate int ClearDelegate(VirtualTableStruct* device, int count, D3DRECT* pRects, D3DCLEAR flags, D3DCOLOR color, float z, int stencil);

        internal delegate int SetTransformDelegate(VirtualTableStruct* device, D3DTRANSFORMSTATETYPE state, Matrix4x4* pMatrix);

        internal delegate int GetTransformDelegate(VirtualTableStruct* device, D3DTRANSFORMSTATETYPE state, Matrix4x4* pMatrix);

        internal delegate int MultiplyTransformDelegate(VirtualTableStruct* device, D3DTRANSFORMSTATETYPE state, Matrix4x4* pMatrix);

        internal delegate int SetViewportDelegate(VirtualTableStruct* device, D3DVIEWPORT8* pViewport);

        internal delegate int GetViewportDelegate(VirtualTableStruct* device, D3DVIEWPORT8* pViewport);

        internal delegate int SetMaterialDelegate(VirtualTableStruct* device, D3DMATERIAL8* pMaterial);

        internal delegate int GetMaterialDelegate(VirtualTableStruct* device, D3DMATERIAL8* pMaterial);

        internal delegate int SetLightDelegate(VirtualTableStruct* device, int index, D3DLIGHT8* light);

        internal delegate int GetLightDelegate(VirtualTableStruct* device, int index, D3DLIGHT8* light);

        internal delegate int LightEnableDelegate(VirtualTableStruct* device, int index, int enable);

        internal delegate int GetLightEnableDelegate(VirtualTableStruct* device, int index, int* pEnable);

        internal delegate int SetClipPlaneDelegate(VirtualTableStruct* device, int index, float* pPlane);

        internal delegate int GetClipPlaneDelegate(VirtualTableStruct* device, int index, float* pPlane);

        internal delegate int SetRenderStateDelegate(VirtualTableStruct* device, D3DRENDERSTATETYPE state, int value);

        internal delegate int GetRenderStateDelegate(VirtualTableStruct* device, D3DRENDERSTATETYPE state, int* pValue);

        internal delegate int BeginStateBlockDelegate(VirtualTableStruct* device);

        internal delegate int EndStateBlockDelegate(VirtualTableStruct* device, int* pToken);

        internal delegate int ApplyStateBlockDelegate(VirtualTableStruct* device, int token);

        internal delegate int CaptureStateBlockDelegate(VirtualTableStruct* device, int token);

        internal delegate int DeleteStateBlockDelegate(VirtualTableStruct* device, int token);

        internal delegate int CreateStateBlockDelegate(VirtualTableStruct* device, D3DSTATEBLOCKTYPE type, int* pToken);

        internal delegate int SetClipStatusDelegate(VirtualTableStruct* device, D3DCLIPSTATUS8* pClipStatus);

        internal delegate int GetClipStatusDelegate(VirtualTableStruct* device, D3DCLIPSTATUS8* pClipStatus);

        internal delegate int GetTextureDelegate(VirtualTableStruct* device, int stage, IDirect3DBaseTexture8** ppTexture);

        internal delegate int SetTextureDelegate(VirtualTableStruct* device, int stage, IDirect3DBaseTexture8* pTexture);

        internal delegate int GetTextureStageStateDelegate(VirtualTableStruct* device, int stage, D3DTEXTURESTAGESTATETYPE type, int* pValue);

        internal delegate int SetTextureStageStateDelegate(VirtualTableStruct* device, int stage, D3DTEXTURESTAGESTATETYPE type, int value);

        internal delegate int ValidateDeviceDelegate(VirtualTableStruct* device, int* pNumPasses);

        internal delegate int GetInfoDelegate(VirtualTableStruct* device, int devInfoId, void* pDevInfoStruct, int devInfoStructSize);

        internal delegate int SetPaletteEntriesDelegate(VirtualTableStruct* device, uint paletteNumber, D3DPALETTEENTRY* pEntries);

        internal delegate int GetPaletteEntriesDelegate(VirtualTableStruct* device, uint paletteNumber, D3DPALETTEENTRY* pEntries);

        internal delegate int SetCurrentTexturePaletteDelegate(VirtualTableStruct* device, uint paletteNumber);

        internal delegate int GetCurrentTexturePaletteDelegate(VirtualTableStruct* device, uint* paletteNumber);

        internal delegate int DrawPrimitiveDelegate(VirtualTableStruct* device, D3DPRIMITIVETYPE primitiveType, uint startVertex, uint primitiveCount);

        internal delegate int DrawIndexedPrimitiveDelegate(VirtualTableStruct* device, D3DPRIMITIVETYPE primitiveType, uint minIndex, uint numVertices, uint startIndex, uint primCount);

        internal delegate int DrawPrimitiveUserPointerDelegate(VirtualTableStruct* device, D3DPRIMITIVETYPE primitiveType, uint primitiveCount, void* pVertexStreamZeroData, uint vertexStreamZeroStride);

        internal delegate int DrawIndexedPrimitiveUserPointerDelegate(VirtualTableStruct* device, D3DPRIMITIVETYPE primitiveType, uint minVertexIndex, uint numVertexIndices, uint primitiveCount, void* pIndexData, D3DFORMAT indexDataFormat, void* pVertexStreamZeroData, uint vertexStreamZeroStride);

        internal delegate int ProcessVerticesDelegate(VirtualTableStruct* device, uint srcStartIndex, uint destIndex, uint vertexCount, VirtualTableStruct* pDestBuffer, int flags);

        internal delegate int CreateVertexShaderDelegate(VirtualTableStruct* device, int* pDeclaration, int* pFunction, int* pHandle, int usage);

        internal delegate int SetVertexShaderDelegate(VirtualTableStruct* device, int handle);

        internal delegate int GetVertexShaderDelegate(VirtualTableStruct* device, int* pHandle);

        internal delegate int DeleteVertexShaderDelegate(VirtualTableStruct* device, int handle);

        internal delegate int SetVertexShaderConstantDelegate(VirtualTableStruct* device, int register, void* pConstantData, int constantCount);

        internal delegate int GetVertexShaderConstantDelegate(VirtualTableStruct* device, int register, void* pConstantData, int constantCount);

        internal delegate int GetVertexShaderDeclarationDelegate(VirtualTableStruct* device, int handle, void* pData, int* pSizeOfData);

        internal delegate int GetVertexShaderFunctionDelegate(VirtualTableStruct* device, int handle, void* pData, int* pSizeOfData);

        internal delegate int SetStreamSourceDelegate(VirtualTableStruct* device, uint streamNumber, VirtualTableStruct* pStreamData, uint stride);

        internal delegate int GetStreamSourceDelegate(VirtualTableStruct* device, uint streamNumber, VirtualTableStruct** ppStreamData, uint* pStride);

        internal delegate int SetIndicesDelegate(VirtualTableStruct* device, IDirect3DIndexBuffer8* pIndexData, uint baseVertexIndex);

        internal delegate int GetIndicesDelegate(VirtualTableStruct* device, IDirect3DIndexBuffer8** ppIndexData, uint* pBaseVertexIndex);

        internal delegate int CreatePixelShaderDelegate(VirtualTableStruct* device, int* pFunction, int* pHandle);

        internal delegate int SetPixelShaderDelegate(VirtualTableStruct* device, int handle);

        internal delegate int GetPixelShaderDelegate(VirtualTableStruct* device, int* pHandle);

        internal delegate int DeletePixelShaderDelegate(VirtualTableStruct* device, int handle);

        internal delegate int SetPixelShaderConstantDelegate(VirtualTableStruct* device, int register, void* pConstantData, int constantCount);

        internal delegate int GetPixelShaderConstantDelegate(VirtualTableStruct* device, int register, void* pConstantData, int constantCount);

        internal delegate int GetPixelShaderFunctionDelegate(VirtualTableStruct* device, int handle, void* pData, int* pSizeOfData);

        internal delegate int DrawRectPatchDelegate(VirtualTableStruct* device, uint handle, float* pNumSegs, D3DRECTPATCH_INFO* pRectPatchInfo);

        internal delegate int DrawTriPatchDelegate(VirtualTableStruct* device, uint handle, float* pNumSegs, D3DTRIPATCH_INFO* pTriPatchInfo);

        internal delegate int DeletePatchDelegate(VirtualTableStruct* device, uint handle);

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

        public IDirect3DDevice8(VirtualTableStruct* devicePointer) {
            this.StructPointer = devicePointer;

            #region Delegate Initialization

            if (DeletePatchDelegateFunction == null) {
                QueryInterfaceDelegateFunction                  = Marshal.GetDelegateForFunctionPointer<QueryInterfaceDelegate>((IntPtr)this.StructPointer->Vtbl[0]);
                AddRefDelegateFunction                          = Marshal.GetDelegateForFunctionPointer<AddRefDelegate>((IntPtr)this.StructPointer->Vtbl[1]);
                ReleaseDelegateFunction                         = Marshal.GetDelegateForFunctionPointer<ReleaseDelegate>((IntPtr)this.StructPointer->Vtbl[2]);
                TestCooperativeLevelDelegateFunction            = Marshal.GetDelegateForFunctionPointer<TestCooperativeLevelDelegate>((IntPtr)this.StructPointer->Vtbl[3]);
                GetAvailableTextureMemDelegateFunction          = Marshal.GetDelegateForFunctionPointer<GetAvailableTextureMemDelegate>((IntPtr)this.StructPointer->Vtbl[4]);
                ResourceManagerDiscardBytesDelegateFunction     = Marshal.GetDelegateForFunctionPointer<ResourceManagerDiscardBytesDelegate>((IntPtr)this.StructPointer->Vtbl[5]);
                GetDirect3DDelegateFunction                     = Marshal.GetDelegateForFunctionPointer<GetDirect3DDelegate>((IntPtr)this.StructPointer->Vtbl[6]);
                GetDeviceCapsDelegateFunction                   = Marshal.GetDelegateForFunctionPointer<GetDeviceCapsDelegate>((IntPtr)this.StructPointer->Vtbl[7]);
                GetDisplayModeDelegateFunction                  = Marshal.GetDelegateForFunctionPointer<GetDisplayModeDelegate>((IntPtr)this.StructPointer->Vtbl[8]);
                GetCreationParametersDelegateFunction           = Marshal.GetDelegateForFunctionPointer<GetCreationParametersDelegate>((IntPtr)this.StructPointer->Vtbl[9]);
                SetCursorPropertiesDelegateFunction             = Marshal.GetDelegateForFunctionPointer<SetCursorPropertiesDelegate>((IntPtr)this.StructPointer->Vtbl[10]);
                SetCursorPositionDelegateFunction               = Marshal.GetDelegateForFunctionPointer<SetCursorPositionDelegate>((IntPtr)this.StructPointer->Vtbl[11]);
                ShowCursorDelegateFunction                      = Marshal.GetDelegateForFunctionPointer<ShowCursorDelegate>((IntPtr)this.StructPointer->Vtbl[12]);
                CreateAdditionalSwapChainDelegateFunction       = Marshal.GetDelegateForFunctionPointer<CreateAdditionalSwapChainDelegate>((IntPtr)this.StructPointer->Vtbl[13]);
                ResetDelegateFunction                           = Marshal.GetDelegateForFunctionPointer<ResetDelegate>((IntPtr)this.StructPointer->Vtbl[14]);
                PresentDelegateFunction                         = Marshal.GetDelegateForFunctionPointer<PresentDelegate>((IntPtr)this.StructPointer->Vtbl[15]);
                GetBackBufferDelegateFunction                   = Marshal.GetDelegateForFunctionPointer<GetBackBufferDelegate>((IntPtr)this.StructPointer->Vtbl[16]);
                GetRasterStatusDelegateFunction                 = Marshal.GetDelegateForFunctionPointer<GetRasterStatusDelegate>((IntPtr)this.StructPointer->Vtbl[17]);
                SetGammaRampDelegateFunction                    = Marshal.GetDelegateForFunctionPointer<SetGammaRampDelegate>((IntPtr)this.StructPointer->Vtbl[18]);
                GetGammaRampDelegateFunction                    = Marshal.GetDelegateForFunctionPointer<GetGammaRampDelegate>((IntPtr)this.StructPointer->Vtbl[19]);
                CreateTextureDelegateFunction                   = Marshal.GetDelegateForFunctionPointer<CreateTextureDelegate>((IntPtr)this.StructPointer->Vtbl[20]);
                CreateVolumeTextureDelegateFunction             = Marshal.GetDelegateForFunctionPointer<CreateVolumeTextureDelegate>((IntPtr)this.StructPointer->Vtbl[21]);
                CreateCubeTextureDelegateFunction               = Marshal.GetDelegateForFunctionPointer<CreateCubeTextureDelegate>((IntPtr)this.StructPointer->Vtbl[22]);
                CreateVertexBufferDelegateFunction              = Marshal.GetDelegateForFunctionPointer<CreateVertexBufferDelegate>((IntPtr)this.StructPointer->Vtbl[23]);
                CreateIndexBufferDelegateFunction               = Marshal.GetDelegateForFunctionPointer<CreateIndexBufferDelegate>((IntPtr)this.StructPointer->Vtbl[24]);
                CreateRenderTargetDelegateFunction              = Marshal.GetDelegateForFunctionPointer<CreateRenderTargetDelegate>((IntPtr)this.StructPointer->Vtbl[25]);
                CreateDepthStencilSurfaceDelegateFunction       = Marshal.GetDelegateForFunctionPointer<CreateDepthStencilSurfaceDelegate>((IntPtr)this.StructPointer->Vtbl[26]);
                CreateImageSurfaceDelegateFunction              = Marshal.GetDelegateForFunctionPointer<CreateImageSurfaceDelegate>((IntPtr)this.StructPointer->Vtbl[27]);
                CopyRectsDelegateFunction                       = Marshal.GetDelegateForFunctionPointer<CopyRectsDelegate>((IntPtr)this.StructPointer->Vtbl[28]);
                UpdateTextureDelegateFunction                   = Marshal.GetDelegateForFunctionPointer<UpdateTextureDelegate>((IntPtr)this.StructPointer->Vtbl[29]);
                GetFrontBufferDelegateFunction                  = Marshal.GetDelegateForFunctionPointer<GetFrontBufferDelegate>((IntPtr)this.StructPointer->Vtbl[30]);
                SetRenderTargetDelegateFunction                 = Marshal.GetDelegateForFunctionPointer<SetRenderTargetDelegate>((IntPtr)this.StructPointer->Vtbl[31]);
                GetRenderTargetDelegateFunction                 = Marshal.GetDelegateForFunctionPointer<GetRenderTargetDelegate>((IntPtr)this.StructPointer->Vtbl[32]);
                GetDepthStencilSurfaceDelegateFunction          = Marshal.GetDelegateForFunctionPointer<GetDepthStencilSurfaceDelegate>((IntPtr)this.StructPointer->Vtbl[33]);
                BeginSceneDelegateFunction                      = Marshal.GetDelegateForFunctionPointer<BeginSceneDelegate>((IntPtr)this.StructPointer->Vtbl[34]);
                EndSceneDelegateFunction                        = Marshal.GetDelegateForFunctionPointer<EndSceneDelegate>((IntPtr)this.StructPointer->Vtbl[35]);
                ClearDelegateFunction                           = Marshal.GetDelegateForFunctionPointer<ClearDelegate>((IntPtr)this.StructPointer->Vtbl[36]);
                SetTransformDelegateFunction                    = Marshal.GetDelegateForFunctionPointer<SetTransformDelegate>((IntPtr)this.StructPointer->Vtbl[37]);
                GetTransformDelegateFunction                    = Marshal.GetDelegateForFunctionPointer<GetTransformDelegate>((IntPtr)this.StructPointer->Vtbl[38]);
                MultiplyTransformDelegateFunction               = Marshal.GetDelegateForFunctionPointer<MultiplyTransformDelegate>((IntPtr)this.StructPointer->Vtbl[39]);
                SetViewportDelegateFunction                     = Marshal.GetDelegateForFunctionPointer<SetViewportDelegate>((IntPtr)this.StructPointer->Vtbl[40]);
                GetViewportDelegateFunction                     = Marshal.GetDelegateForFunctionPointer<GetViewportDelegate>((IntPtr)this.StructPointer->Vtbl[41]);
                SetMaterialDelegateFunction                     = Marshal.GetDelegateForFunctionPointer<SetMaterialDelegate>((IntPtr)this.StructPointer->Vtbl[42]);
                GetMaterialDelegateFunction                     = Marshal.GetDelegateForFunctionPointer<GetMaterialDelegate>((IntPtr)this.StructPointer->Vtbl[43]);
                SetLightDelegateFunction                        = Marshal.GetDelegateForFunctionPointer<SetLightDelegate>((IntPtr)this.StructPointer->Vtbl[44]);
                GetLightDelegateFunction                        = Marshal.GetDelegateForFunctionPointer<GetLightDelegate>((IntPtr)this.StructPointer->Vtbl[45]);
                LightEnableDelegateFunction                     = Marshal.GetDelegateForFunctionPointer<LightEnableDelegate>((IntPtr)this.StructPointer->Vtbl[46]);
                GetLightEnableDelegateFunction                  = Marshal.GetDelegateForFunctionPointer<GetLightEnableDelegate>((IntPtr)this.StructPointer->Vtbl[47]);
                SetClipPlaneDelegateFunction                    = Marshal.GetDelegateForFunctionPointer<SetClipPlaneDelegate>((IntPtr)this.StructPointer->Vtbl[48]);
                GetClipPlaneDelegateFunction                    = Marshal.GetDelegateForFunctionPointer<GetClipPlaneDelegate>((IntPtr)this.StructPointer->Vtbl[49]);
                SetRenderStateDelegateFunction                  = Marshal.GetDelegateForFunctionPointer<SetRenderStateDelegate>((IntPtr)this.StructPointer->Vtbl[50]);
                GetRenderStateDelegateFunction                  = Marshal.GetDelegateForFunctionPointer<GetRenderStateDelegate>((IntPtr)this.StructPointer->Vtbl[51]);
                BeginStateBlockDelegateFunction                 = Marshal.GetDelegateForFunctionPointer<BeginStateBlockDelegate>((IntPtr)this.StructPointer->Vtbl[52]);
                EndStateBlockDelegateFunction                   = Marshal.GetDelegateForFunctionPointer<EndStateBlockDelegate>((IntPtr)this.StructPointer->Vtbl[53]);
                ApplyStateBlockDelegateFunction                 = Marshal.GetDelegateForFunctionPointer<ApplyStateBlockDelegate>((IntPtr)this.StructPointer->Vtbl[54]);
                CaptureStateBlockDelegateFunction               = Marshal.GetDelegateForFunctionPointer<CaptureStateBlockDelegate>((IntPtr)this.StructPointer->Vtbl[55]);
                DeleteStateBlockDelegateFunction                = Marshal.GetDelegateForFunctionPointer<DeleteStateBlockDelegate>((IntPtr)this.StructPointer->Vtbl[56]);
                CreateStateBlockDelegateFunction                = Marshal.GetDelegateForFunctionPointer<CreateStateBlockDelegate>((IntPtr)this.StructPointer->Vtbl[57]);
                SetClipStatusDelegateFunction                   = Marshal.GetDelegateForFunctionPointer<SetClipStatusDelegate>((IntPtr)this.StructPointer->Vtbl[58]);
                GetClipStatusDelegateFunction                   = Marshal.GetDelegateForFunctionPointer<GetClipStatusDelegate>((IntPtr)this.StructPointer->Vtbl[59]);
                GetTextureDelegateFunction                      = Marshal.GetDelegateForFunctionPointer<GetTextureDelegate>((IntPtr)this.StructPointer->Vtbl[60]);
                SetTextureDelegateFunction                      = Marshal.GetDelegateForFunctionPointer<SetTextureDelegate>((IntPtr)this.StructPointer->Vtbl[61]);
                GetTextureStageStateDelegateFunction            = Marshal.GetDelegateForFunctionPointer<GetTextureStageStateDelegate>((IntPtr)this.StructPointer->Vtbl[62]);
                SetTextureStageStateDelegateFunction            = Marshal.GetDelegateForFunctionPointer<SetTextureStageStateDelegate>((IntPtr)this.StructPointer->Vtbl[63]);
                ValidateDeviceDelegateFunction                  = Marshal.GetDelegateForFunctionPointer<ValidateDeviceDelegate>((IntPtr)this.StructPointer->Vtbl[64]);
                GetInfoDelegateFunction                         = Marshal.GetDelegateForFunctionPointer<GetInfoDelegate>((IntPtr)this.StructPointer->Vtbl[65]);
                SetPaletteEntriesDelegateFunction               = Marshal.GetDelegateForFunctionPointer<SetPaletteEntriesDelegate>((IntPtr)this.StructPointer->Vtbl[66]);
                GetPaletteEntriesDelegateFunction               = Marshal.GetDelegateForFunctionPointer<GetPaletteEntriesDelegate>((IntPtr)this.StructPointer->Vtbl[67]);
                SetCurrentTexturePaletteDelegateFunction        = Marshal.GetDelegateForFunctionPointer<SetCurrentTexturePaletteDelegate>((IntPtr)this.StructPointer->Vtbl[68]);
                GetCurrentTexturePaletteDelegateFunction        = Marshal.GetDelegateForFunctionPointer<GetCurrentTexturePaletteDelegate>((IntPtr)this.StructPointer->Vtbl[69]);
                DrawPrimitiveDelegateFunction                   = Marshal.GetDelegateForFunctionPointer<DrawPrimitiveDelegate>((IntPtr)this.StructPointer->Vtbl[70]);
                DrawIndexedPrimitiveDelegateFunction            = Marshal.GetDelegateForFunctionPointer<DrawIndexedPrimitiveDelegate>((IntPtr)this.StructPointer->Vtbl[71]);
                DrawPrimitiveUserPointerDelegateFunction        = Marshal.GetDelegateForFunctionPointer<DrawPrimitiveUserPointerDelegate>((IntPtr)this.StructPointer->Vtbl[72]);
                DrawIndexedPrimitiveUserPointerDelegateFunction = Marshal.GetDelegateForFunctionPointer<DrawIndexedPrimitiveUserPointerDelegate>((IntPtr)this.StructPointer->Vtbl[73]);
                ProcessVerticesDelegateFunction                 = Marshal.GetDelegateForFunctionPointer<ProcessVerticesDelegate>((IntPtr)this.StructPointer->Vtbl[74]);
                CreateVertexShaderDelegateFunction              = Marshal.GetDelegateForFunctionPointer<CreateVertexShaderDelegate>((IntPtr)this.StructPointer->Vtbl[75]);
                SetVertexShaderDelegateFunction                 = Marshal.GetDelegateForFunctionPointer<SetVertexShaderDelegate>((IntPtr)this.StructPointer->Vtbl[76]);
                GetVertexShaderDelegateFunction                 = Marshal.GetDelegateForFunctionPointer<GetVertexShaderDelegate>((IntPtr)this.StructPointer->Vtbl[77]);
                DeleteVertexShaderDelegateFunction              = Marshal.GetDelegateForFunctionPointer<DeleteVertexShaderDelegate>((IntPtr)this.StructPointer->Vtbl[78]);
                SetVertexShaderConstantDelegateFunction         = Marshal.GetDelegateForFunctionPointer<SetVertexShaderConstantDelegate>((IntPtr)this.StructPointer->Vtbl[79]);
                GetVertexShaderConstantDelegateFunction         = Marshal.GetDelegateForFunctionPointer<GetVertexShaderConstantDelegate>((IntPtr)this.StructPointer->Vtbl[80]);
                GetVertexShaderDeclarationDelegateFunction      = Marshal.GetDelegateForFunctionPointer<GetVertexShaderDeclarationDelegate>((IntPtr)this.StructPointer->Vtbl[81]);
                GetVertexShaderFunctionDelegateFunction         = Marshal.GetDelegateForFunctionPointer<GetVertexShaderFunctionDelegate>((IntPtr)this.StructPointer->Vtbl[82]);
                SetStreamSourceDelegateFunction                 = Marshal.GetDelegateForFunctionPointer<SetStreamSourceDelegate>((IntPtr)this.StructPointer->Vtbl[83]);
                GetStreamSourceDelegateFunction                 = Marshal.GetDelegateForFunctionPointer<GetStreamSourceDelegate>((IntPtr)this.StructPointer->Vtbl[84]);
                SetIndicesDelegateFunction                      = Marshal.GetDelegateForFunctionPointer<SetIndicesDelegate>((IntPtr)this.StructPointer->Vtbl[85]);
                GetIndicesDelegateFunction                      = Marshal.GetDelegateForFunctionPointer<GetIndicesDelegate>((IntPtr)this.StructPointer->Vtbl[86]);
                CreatePixelShaderDelegateFunction               = Marshal.GetDelegateForFunctionPointer<CreatePixelShaderDelegate>((IntPtr)this.StructPointer->Vtbl[87]);
                SetPixelShaderDelegateFunction                  = Marshal.GetDelegateForFunctionPointer<SetPixelShaderDelegate>((IntPtr)this.StructPointer->Vtbl[88]);
                GetPixelShaderDelegateFunction                  = Marshal.GetDelegateForFunctionPointer<GetPixelShaderDelegate>((IntPtr)this.StructPointer->Vtbl[89]);
                DeletePixelShaderDelegateFunction               = Marshal.GetDelegateForFunctionPointer<DeletePixelShaderDelegate>((IntPtr)this.StructPointer->Vtbl[90]);
                SetPixelShaderConstantDelegateFunction          = Marshal.GetDelegateForFunctionPointer<SetPixelShaderConstantDelegate>((IntPtr)this.StructPointer->Vtbl[91]);
                GetPixelShaderConstantDelegateFunction          = Marshal.GetDelegateForFunctionPointer<GetPixelShaderConstantDelegate>((IntPtr)this.StructPointer->Vtbl[92]);
                GetPixelShaderFunctionDelegateFunction          = Marshal.GetDelegateForFunctionPointer<GetPixelShaderFunctionDelegate>((IntPtr)this.StructPointer->Vtbl[93]);
                DrawRectPatchDelegateFunction                   = Marshal.GetDelegateForFunctionPointer<DrawRectPatchDelegate>((IntPtr)this.StructPointer->Vtbl[94]);
                DrawTriPatchDelegateFunction                    = Marshal.GetDelegateForFunctionPointer<DrawTriPatchDelegate>((IntPtr)this.StructPointer->Vtbl[95]);
                DeletePatchDelegateFunction                     = Marshal.GetDelegateForFunctionPointer<DeletePatchDelegate>((IntPtr)this.StructPointer->Vtbl[96]);
            }

            #endregion

        }

        public D3DRESULT Clear(D3DRECT[] rects, D3DCLEAR clearTarget, D3DCOLOR clearColor, float z, int stencil) {
            int count = rects.Length;

            fixed (D3DRECT* ptrRects = rects) {
                int ret = ClearDelegateFunction(this.StructPointer, count, ptrRects, clearTarget, clearColor, z, stencil);

                return (D3DRESULT)ret;
            }
        }

        public D3DRESULT Clear(D3DCLEAR clearTarget, D3DCOLOR clearColor, float z = 0, int stencil = 0) => (D3DRESULT)ClearDelegateFunction(this.StructPointer, 0, null, clearTarget, clearColor, z, stencil);

        public D3DRESULT Present(RECT sourceRect, RECT destRect, IntPtr windowOverride) => (D3DRESULT)PresentDelegateFunction(this.StructPointer, &sourceRect, &destRect, windowOverride, null);

        public D3DRESULT Present(IntPtr windowOverride) => (D3DRESULT)PresentDelegateFunction(this.StructPointer, null, null, windowOverride, null);

        public D3DRESULT Present() => (D3DRESULT)PresentDelegateFunction(this.StructPointer, null, null, IntPtr.Zero, null);

        public D3DRESULT BeginScene() => (D3DRESULT)BeginSceneDelegateFunction(this.StructPointer);

        public D3DRESULT EndScene() => (D3DRESULT)EndSceneDelegateFunction(this.StructPointer);

        public D3DRESULT ApplyStateBlock(int token) => (D3DRESULT)ApplyStateBlockDelegateFunction(this.StructPointer, token);

        public D3DRESULT BeginStateBlock() => (D3DRESULT)BeginStateBlockDelegateFunction(this.StructPointer);

        public D3DRESULT EndStateBlock(out int token) {
            int ptrToken;

            int ret = EndStateBlockDelegateFunction(this.StructPointer, &ptrToken);

            token = ptrToken;

            return (D3DRESULT)ret;
        }

        public D3DRESULT CaptureStateBlock(int token) => (D3DRESULT)CaptureStateBlockDelegateFunction(this.StructPointer, token);

        public D3DRESULT CreateStateBlock(D3DSTATEBLOCKTYPE type, out int token) {
            int ptrToken;

            int ret = CreateStateBlockDelegateFunction(this.StructPointer, type, &ptrToken);

            token = ptrToken;

            return (D3DRESULT)ret;
        }

        public uint GetAvailableTextureMem() => GetAvailableTextureMemDelegateFunction(this.StructPointer);

        public void GetAvailableTextureMem(out uint textureMemory) {
            textureMemory = this.GetAvailableTextureMem();
        }

        public D3DRESULT GetDeviceCaps(out D3DCAPS8 deviceCaps) {
            D3DCAPS8 caps = new D3DCAPS8();

            int ret = GetDeviceCapsDelegateFunction(this.StructPointer, &caps);

            deviceCaps = caps;

            return (D3DRESULT)ret;
        }

        public D3DRESULT GetDisplayMode(out D3DDISPLAYMODE displayMode) {
            D3DDISPLAYMODE outDisplayMode;

            int ret = GetDisplayModeDelegateFunction(this.StructPointer, &outDisplayMode);

            displayMode = outDisplayMode;

            return (D3DRESULT)ret;
        }

        public void GetGammaRamp(out D3DGAMMARAMP gammaRamp) {
            D3DGAMMARAMP outGammaRamp;

            GetGammaRampDelegateFunction(this.StructPointer, &outGammaRamp);

            gammaRamp = outGammaRamp;
        }

        public D3DRESULT GetLight(int index, out D3DLIGHT8 light) {
            D3DLIGHT8 ptrLight;

            int ret = GetLightDelegateFunction(this.StructPointer, index, &ptrLight);

            light = ptrLight;

            return (D3DRESULT)ret;
        }

        public D3DRESULT GetLightEnable(int index, out bool enabled) {
            int ptrEnabled;

            int ret = GetLightEnableDelegateFunction(this.StructPointer, index, &ptrEnabled);

            enabled = ptrEnabled == 1;

            return (D3DRESULT)ret;
        }

        public D3DRESULT GetMaterial(out D3DMATERIAL8 material) {
            D3DMATERIAL8 ptrMaterial;

            int ret = GetMaterialDelegateFunction(this.StructPointer, &ptrMaterial);

            material = ptrMaterial;

            return (D3DRESULT)ret;
        }

        public D3DRESULT GetPaletteEntries(uint paletteNumber, out D3DPALETTEENTRY paletteEntry) {
            D3DPALETTEENTRY ptrEntry;

            int ret = GetPaletteEntriesDelegateFunction(this.StructPointer, paletteNumber, &ptrEntry);

            paletteEntry = ptrEntry;

            return (D3DRESULT)ret;
        }

        public D3DRESULT CreateVertexBuffer(uint size, D3DBUFFERUSAGE usage, D3DFVF bufferFormat, D3DPOOL pool, out IDirect3DVertexBuffer8 buffer) {
            VirtualTableStruct* ptrBuffer;

            int ret = CreateVertexBufferDelegateFunction(this.StructPointer, size, (int)usage, (int)bufferFormat, pool, &ptrBuffer);

            buffer = new IDirect3DVertexBuffer8(ptrBuffer);

            return (D3DRESULT)ret;
        }

        public D3DRESULT SetStreamSource(uint streamNumber, IDirect3DVertexBuffer8 data, uint stride) => (D3DRESULT)SetStreamSourceDelegateFunction(this.StructPointer, streamNumber, data.BufferPointer, stride);

        public D3DRESULT DrawPrimitive(D3DPRIMITIVETYPE primitiveType, uint startVertex, uint primitiveCount) => (D3DRESULT)DrawPrimitiveDelegateFunction(this.StructPointer, primitiveType, startVertex, primitiveCount);

        public D3DRESULT SetVertexShader(int handle) => (D3DRESULT)SetVertexShaderDelegateFunction(this.StructPointer, handle);

        public D3DRESULT SetVertexShader(D3DFVF bufferFormat) => (D3DRESULT)SetVertexShaderDelegateFunction(this.StructPointer, (int)bufferFormat);

        public D3DRESULT TestCooperativeLevel() => (D3DRESULT)TestCooperativeLevelDelegateFunction(this.StructPointer);

        public D3DRESULT ResourceManagerDiscardBytes(int bytes) => (D3DRESULT)ResourceManagerDiscardBytesDelegateFunction(this.StructPointer, bytes);

        public D3DRESULT GetDirect3D(out IDirect3D8* direct3D8) {
            IDirect3D8* ptrD3d;

            int ret = GetDirect3DDelegateFunction(this.StructPointer, &ptrD3d);

            direct3D8 = ptrD3d;

            return (D3DRESULT)ret;
        }

        public D3DRESULT GetCreationParameters(out D3DDEVICE_CREATION_PARAMETERS parameters) {
            D3DDEVICE_CREATION_PARAMETERS ptrParameters = default;

            int ret = GetCreationParametersDelegateFunction(this.StructPointer, &ptrParameters);

            parameters = ptrParameters;

            return (D3DRESULT)ret;
        }

        public D3DRESULT SetCursorProperties(uint xHotSpot, uint yHotSpot, IDirect3DSurface8 cursorBitmap) => (D3DRESULT)SetCursorPropertiesDelegateFunction(this.StructPointer, xHotSpot, yHotSpot, cursorBitmap.SurfacePointer);

        public void SetCursorPosition(uint x, uint y, int flags) { SetCursorPositionDelegateFunction(this.StructPointer, x, y, flags); }
    }
}
