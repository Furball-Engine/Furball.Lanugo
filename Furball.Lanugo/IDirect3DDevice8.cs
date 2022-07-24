using System;
using System.Collections.Generic;
using System.Numerics;
using System.Runtime.InteropServices;

namespace Furball.Lanugo {
    internal unsafe class IDirect3DDevice8DelegateHolder {
        internal static Dictionary<IntPtr, IDirect3DDevice8DelegateHolder> DelegateCaches = new();

        internal IDirect3DDevice8* DevicePointer;

        internal delegate int  QueryInterfaceDelegate(IDirect3DDevice8* device, Guid riid, void** ppvObj);
        internal delegate uint AddRefDelegate(IDirect3DDevice8* device);
        internal delegate uint ReleaseDelegate(IDirect3DDevice8* device);
        internal delegate int  TestCooperativeLevelDelegate(IDirect3DDevice8* device);
        internal delegate uint GetAvailableTextureMemDelegate(IDirect3DDevice8* device);
        internal delegate int  ResourceManagerDiscardBytesDelegate(IDirect3DDevice8* device, int Bytes);
        internal delegate int  GetDirect3DDelegate(IDirect3DDevice8* device, IDirect3D8** ppD3D8);
        internal delegate int  GetDeviceCapsDelegate(IDirect3DDevice8* device, D3DCAPS8* pCaps);
        internal delegate int  GetDisplayModeDelegate(IDirect3DDevice8* device, D3DDISPLAYMODE* pMode);
        internal delegate int  GetCreationParametersDelegate(IDirect3DDevice8* device, D3DDEVICE_CREATION_PARAMETERS* pParameters);
        internal delegate int  SetCursorPropertiesDelegate(IDirect3DDevice8* device, uint XHotSpot, uint YHotSpot, IDirect3DSurface8* pCursorBitmap);
        internal delegate void SetCursorPositionDelegate(IDirect3DDevice8* device, uint XScreenSpace, uint YScreenSpace, int Flags);
        internal delegate bool ShowCursorDelegate(IDirect3DDevice8* device, int bShow);
        internal delegate int  CreateAdditionalSwapChainDelegate(IDirect3DDevice8* device, D3DPRESENT_PARAMETERS* pPresentationParameters, IDirect3DSwapChain8** pSwapChain);
        internal delegate int  ResetDelegate(IDirect3DDevice8* device, D3DPRESENT_PARAMETERS* pPresentationParameters);
        internal delegate int  PresentDelegate(IDirect3DDevice8* device, RECT* pSourceRect, RECT* pDestRect, IntPtr hDestWindowOverride, void* pDirtyRegion);
        internal delegate int  GetBackBufferDelegate(IDirect3DDevice8* device, uint BackBuffer, D3DBACKBUFFER_TYPE Type, IDirect3DSurface8** ppBackBuffer);
        internal delegate int  GetRasterStatusDelegate(IDirect3DDevice8* device, D3DRASTER_STATUS* pRasterStatus);
        internal delegate void SetGammaRampDelegate(IDirect3DDevice8* device, int Flags, D3DGAMMARAMP* pRamp);
        internal delegate void GetGammaRampDelegate(IDirect3DDevice8* device, D3DGAMMARAMP* pRamp);
        internal delegate int  CreateTextureDelegate(IDirect3DDevice8* device, uint Width, uint Height, uint Levels, int Usage, D3DFORMAT Format, D3DPOOL Pool, IDirect3DTexture8** ppTexture);
        internal delegate int  CreateVolumeTextureDelegate(IDirect3DDevice8* device, uint Width, uint Height, uint Depth, uint Levels, int Usage, D3DFORMAT Format, D3DPOOL Pool, IDirect3DVolumeTexture8** ppVolumeTexture);
        internal delegate int  CreateCubeTextureDelegate(IDirect3DDevice8* device, uint EdgeLength, uint Levels, int Usage, D3DFORMAT Format, D3DPOOL Pool, IDirect3DCubeTexture8** ppCubeTexture);
        internal delegate int  CreateVertexBufferDelegate(IDirect3DDevice8* device, uint Length, int Usage, int FVF, D3DPOOL Pool, IDirect3DVertexBuffer8** ppVertexBuffer);
        internal delegate int  CreateIndexBufferDelegate(IDirect3DDevice8* device, uint Length, int Usage, D3DFORMAT Format, D3DPOOL Pool, IDirect3DIndexBuffer8** ppIndexBuffer);
        internal delegate int  CreateRenderTargetDelegate(IDirect3DDevice8* device, uint Width, uint Height, D3DFORMAT Format, D3DMULTISAMPLE_TYPE MultiSample, int Lockable, IDirect3DSurface8** ppSurface);
        internal delegate int  CreateDepthStencilSurfaceDelegate(IDirect3DDevice8* device, uint Width, uint Height, D3DFORMAT Format, D3DMULTISAMPLE_TYPE MultiSample, IDirect3DSurface8** ppSurface);
        internal delegate int  CreateImageSurfaceDelegate(IDirect3DDevice8* device, uint Width, uint Height, D3DFORMAT Format, IDirect3DSurface8** ppSurface);
        internal delegate int  CopyRectsDelegate(IDirect3DDevice8* device, IDirect3DSurface8* pSourceSurface, RECT* pSourceRectsArray, uint cRects, IDirect3DSurface8* pDestinationSurface, D3DPOINT* pDestPointsArray);
        internal delegate int  UpdateTextureDelegate(IDirect3DDevice8* device, IDirect3DBaseTexture8* pSourceTexture, IDirect3DBaseTexture8* pDestinationTexture);
        internal delegate int  GetFrontBufferDelegate(IDirect3DDevice8* device, IDirect3DSurface8* pDestSurface);
        internal delegate int  SetRenderTargetDelegate(IDirect3DDevice8* device, IDirect3DSurface8* pRenderTarget, IDirect3DSurface8* pNewZStencil);
        internal delegate int  GetRenderTargetDelegate(IDirect3DDevice8* device, IDirect3DSurface8** ppRenderTarget);
        internal delegate int  GetDepthStencilSurfaceDelegate(IDirect3DDevice8* device, IDirect3DSurface8** ppZStencilSurface);
        internal delegate int  BeginSceneDelegate(IDirect3DDevice8* device);
        internal delegate int  EndSceneDelegate(IDirect3DDevice8* device);
        internal delegate int  ClearDelegate(IDirect3DDevice8* device, int Count, D3DRECT* pRects, D3DCLEAR Flags, D3DCOLOR Color, float Z, int Stencil);
        internal delegate int  SetTransformDelegate(IDirect3DDevice8* device, D3DTRANSFORMSTATETYPE State, Matrix4x4* pMatrix);
        internal delegate int  GetTransformDelegate(IDirect3DDevice8* device, D3DTRANSFORMSTATETYPE State, Matrix4x4* pMatrix);
        internal delegate int  MultiplyTransformDelegate(IDirect3DDevice8* device, D3DTRANSFORMSTATETYPE state, Matrix4x4* pMatrix);
        internal delegate int  SetViewportDelegate(IDirect3DDevice8* device, D3DVIEWPORT8* pViewport);
        internal delegate int  GetViewportDelegate(IDirect3DDevice8* device, D3DVIEWPORT8* pViewport);
        internal delegate int  SetMaterialDelegate(IDirect3DDevice8* device, D3DMATERIAL8* pMaterial);
        internal delegate int  GetMaterialDelegate(IDirect3DDevice8* device, D3DMATERIAL8* pMaterial);
        internal delegate int  SetLightDelegate(IDirect3DDevice8* device, int Index, D3DLIGHT8* light);
        internal delegate int  GetLightDelegate(IDirect3DDevice8* device, int Index, D3DLIGHT8* light);
        internal delegate int  LightEnableDelegate(IDirect3DDevice8* device, int Index, int Enable);
        internal delegate int  GetLightEnableDelegate(IDirect3DDevice8* device, int Index, int* pEnable);
        internal delegate int  SetClipPlaneDelegate(IDirect3DDevice8* device, int Index, float* pPlane);
        internal delegate int  GetClipPlaneDelegate(IDirect3DDevice8* device, int Index, float* pPlane);
        internal delegate int  SetRenderStateDelegate(IDirect3DDevice8* device, D3DRENDERSTATETYPE State, int Value);
        internal delegate int  GetRenderStateDelegate(IDirect3DDevice8* device, D3DRENDERSTATETYPE State, int* pValue);
        internal delegate int  BeginStateBlockDelegate(IDirect3DDevice8* device);
        internal delegate int  EndStateBlockDelegate(IDirect3DDevice8* device, int* pToken);
        internal delegate int  ApplyStateBlockDelegate(IDirect3DDevice8* device, int Token);
        internal delegate int  CaptureStateBlockDelegate(IDirect3DDevice8* device, int Token);
        internal delegate int  DeleteStateBlockDelegate(IDirect3DDevice8* device, int Token);
        internal delegate int  CreateStateBlockDelegate(IDirect3DDevice8* device, D3DSTATEBLOCKTYPE Type, int* pToken);
        internal delegate int  SetClipStatusDelegate(IDirect3DDevice8* device, D3DCLIPSTATUS8* pClipStatus);
        internal delegate int  GetClipStatusDelegate(IDirect3DDevice8* device, D3DCLIPSTATUS8* pClipStatus);
        internal delegate int  GetTextureDelegate(IDirect3DDevice8* device, int Stage, IDirect3DBaseTexture8** ppTexture);
        internal delegate int  SetTextureDelegate(IDirect3DDevice8* device, int Stage, IDirect3DBaseTexture8* pTexture);
        internal delegate int  GetTextureStageStateDelegate(IDirect3DDevice8* device, int Stage, D3DTEXTURESTAGESTATETYPE Type, int* pValue);
        internal delegate int  SetTextureStageStateDelegate(IDirect3DDevice8* device, int Stage, D3DTEXTURESTAGESTATETYPE Type, int Value);
        internal delegate int  ValidateDeviceDelegate(IDirect3DDevice8* device, int* pNumPasses);
        internal delegate int  GetInfoDelegate(IDirect3DDevice8* device, int DevInfoID, void* pDevInfoStruct, int DevInfoStructSize);
        internal delegate int  SetPaletteEntriesDelegate(IDirect3DDevice8* device, uint PaletteNumber, D3DPALETTEENTRY* pEntries);
        internal delegate int  GetPaletteEntriesDelegate(IDirect3DDevice8* device, uint PaletteNumber, D3DPALETTEENTRY* pEntries);
        internal delegate int  SetCurrentTexturePaletteDelegate(IDirect3DDevice8* device, uint PaletteNumber);
        internal delegate int  GetCurrentTexturePaletteDelegate(IDirect3DDevice8* device, uint* PaletteNumber);
        internal delegate int  DrawPrimitiveDelegate(IDirect3DDevice8* device, D3DPRIMITIVETYPE PrimitiveType, uint StartVertex, uint PrimitiveCount);
        internal delegate int  DrawIndexedPrimitiveDelegate(IDirect3DDevice8* device, D3DPRIMITIVETYPE primitiveType, uint minIndex, uint NumVertices, uint startIndex, uint primCount);
        internal delegate int  DrawPrimitiveUPDelegate(IDirect3DDevice8* device, D3DPRIMITIVETYPE PrimitiveType, uint PrimitiveCount, void* pVertexStreamZeroData, uint VertexStreamZeroStride);
        internal delegate int  DrawIndexedPrimitiveUPDelegate(IDirect3DDevice8* device, D3DPRIMITIVETYPE PrimitiveType, uint MinVertexIndex, uint NumVertexIndices, uint PrimitiveCount, void* pIndexData, D3DFORMAT IndexDataFormat, void* pVertexStreamZeroData, uint VertexStreamZeroStride);
        internal delegate int  ProcessVerticesDelegate(IDirect3DDevice8* device, uint SrcStartIndex, uint DestIndex, uint VertexCount, IDirect3DVertexBuffer8* pDestBuffer, int Flags);
        internal delegate int  CreateVertexShaderDelegate(IDirect3DDevice8* device, int* pDeclaration, int* pFunction, int* pHandle, int Usage);
        internal delegate int  SetVertexShaderDelegate(IDirect3DDevice8* device, int Handle);
        internal delegate int  GetVertexShaderDelegate(IDirect3DDevice8* device, int* pHandle);
        internal delegate int  DeleteVertexShaderDelegate(IDirect3DDevice8* device, int Handle);
        internal delegate int  SetVertexShaderConstantDelegate(IDirect3DDevice8* device, int Register, void* pConstantData, int ConstantCount);
        internal delegate int  GetVertexShaderConstantDelegate(IDirect3DDevice8* device, int Register, void* pConstantData, int ConstantCount);
        internal delegate int  GetVertexShaderDeclarationDelegate(IDirect3DDevice8* device, int Handle, void* pData, int* pSizeOfData);
        internal delegate int  GetVertexShaderFunctionDelegate(IDirect3DDevice8* device, int Handle, void* pData, int* pSizeOfData);
        internal delegate int  SetStreamSourceDelegate(IDirect3DDevice8* device, uint StreamNumber, IDirect3DVertexBuffer8* pStreamData, uint Stride);
        internal delegate int  GetStreamSourceDelegate(IDirect3DDevice8* device, uint StreamNumber, IDirect3DVertexBuffer8** ppStreamData, uint* pStride);
        internal delegate int  SetIndicesDelegate(IDirect3DDevice8* device, IDirect3DIndexBuffer8* pIndexData, uint BaseVertexIndex);
        internal delegate int  GetIndicesDelegate(IDirect3DDevice8* device, IDirect3DIndexBuffer8** ppIndexData, uint* pBaseVertexIndex);
        internal delegate int  CreatePixelShaderDelegate(IDirect3DDevice8* device, int* pFunction, int* pHandle);
        internal delegate int  SetPixelShaderDelegate(IDirect3DDevice8* device, int Handle);
        internal delegate int  GetPixelShaderDelegate(IDirect3DDevice8* device, int* pHandle);
        internal delegate int  DeletePixelShaderDelegate(IDirect3DDevice8* device, int Handle);
        internal delegate int  SetPixelShaderConstantDelegate(IDirect3DDevice8* device, int Register, void* pConstantData, int ConstantCount);
        internal delegate int  GetPixelShaderConstantDelegate(IDirect3DDevice8* device, int Register, void* pConstantData, int ConstantCount);
        internal delegate int  GetPixelShaderFunctionDelegate(IDirect3DDevice8* device, int Handle, void* pData, int* pSizeOfData);
        internal delegate int  DrawRectPatchDelegate(IDirect3DDevice8* device, uint Handle, float* pNumSegs, D3DRECTPATCH_INFO* pRectPatchInfo);
        internal delegate int  DrawTriPatchDelegate(IDirect3DDevice8* device, uint Handle, float* pNumSegs, D3DTRIPATCH_INFO* pTriPatchInfo);
        internal delegate int  DeletePatchDelegate(IDirect3DDevice8* device, uint Handle);

        internal QueryInterfaceDelegate              QueryInterfaceDelegateFunction;
        internal AddRefDelegate                      AddRefDelegateFunction;
        internal ReleaseDelegate                     ReleaseDelegateFunction;
        internal TestCooperativeLevelDelegate        TestCooperativeLevelDelegateFunction;
        internal GetAvailableTextureMemDelegate      GetAvailableTextureMemDelegateFunction;
        internal ResourceManagerDiscardBytesDelegate ResourceManagerDiscardBytesDelegateFunction;
        internal GetDirect3DDelegate                 GetDirect3DDelegateFunction;
        internal GetDeviceCapsDelegate               GetDeviceCapsDelegateFunction;
        internal GetDisplayModeDelegate              GetDisplayModeDelegateFunction;
        internal GetCreationParametersDelegate       GetCreationParametersDelegateFunction;
        internal SetCursorPropertiesDelegate         SetCursorPropertiesDelegateFunction;
        internal SetCursorPositionDelegate           SetCursorPositionDelegateFunction;
        internal ShowCursorDelegate                  ShowCursorDelegateFunction;
        internal CreateAdditionalSwapChainDelegate   CreateAdditionalSwapChainDelegateFunction;
        internal ResetDelegate                       ResetDelegateFunction;
        internal PresentDelegate                     PresentDelegateFunction;
        internal GetBackBufferDelegate               GetBackBufferDelegateFunction;
        internal GetRasterStatusDelegate             GetRasterStatusDelegateFunction;
        internal SetGammaRampDelegate                SetGammaRampDelegateFunction;
        internal GetGammaRampDelegate                GetGammaRampDelegateFunction;
        internal CreateTextureDelegate               CreateTextureDelegateFunction;
        internal CreateVolumeTextureDelegate         CreateVolumeTextureDelegateFunction;
        internal CreateCubeTextureDelegate           CreateCubeTextureDelegateFunction;
        internal CreateVertexBufferDelegate          CreateVertexBufferDelegateFunction;
        internal CreateIndexBufferDelegate           CreateIndexBufferDelegateFunction;
        internal CreateRenderTargetDelegate          CreateRenderTargetDelegateFunction;
        internal CreateDepthStencilSurfaceDelegate   CreateDepthStencilSurfaceDelegateFunction;
        internal CreateImageSurfaceDelegate          CreateImageSurfaceDelegateFunction;
        internal CopyRectsDelegate                   CopyRectsDelegateFunction;
        internal UpdateTextureDelegate               UpdateTextureDelegateFunction;
        internal GetFrontBufferDelegate              GetFrontBufferDelegateFunction;
        internal SetRenderTargetDelegate             SetRenderTargetDelegateFunction;
        internal GetRenderTargetDelegate             GetRenderTargetDelegateFunction;
        internal GetDepthStencilSurfaceDelegate      GetDepthStencilSurfaceDelegateFunction;
        internal BeginSceneDelegate                  BeginSceneDelegateFunction;
        internal EndSceneDelegate                    EndSceneDelegateFunction;
        internal ClearDelegate                       ClearDelegateFunction;
        internal SetTransformDelegate                SetTransformDelegateFunction;
        internal GetTransformDelegate                GetTransformDelegateFunction;
        internal MultiplyTransformDelegate           MultiplyTransformDelegateFunction;
        internal SetViewportDelegate                 SetViewportDelegateFunction;
        internal GetViewportDelegate                 GetViewportDelegateFunction;
        internal SetMaterialDelegate                 SetMaterialDelegateFunction;
        internal GetMaterialDelegate                 GetMaterialDelegateFunction;
        internal SetLightDelegate                    SetLightDelegateFunction;
        internal GetLightDelegate                    GetLightDelegateFunction;
        internal LightEnableDelegate                 LightEnableDelegateFunction;
        internal GetLightEnableDelegate              GetLightEnableDelegateFunction;
        internal SetClipPlaneDelegate                SetClipPlaneDelegateFunction;
        internal GetClipPlaneDelegate                GetClipPlaneDelegateFunction;
        internal SetRenderStateDelegate              SetRenderStateDelegateFunction;
        internal GetRenderStateDelegate              GetRenderStateDelegateFunction;
        internal BeginStateBlockDelegate             BeginStateBlockDelegateFunction;
        internal EndStateBlockDelegate               EndStateBlockDelegateFunction;
        internal ApplyStateBlockDelegate             ApplyStateBlockDelegateFunction;
        internal CaptureStateBlockDelegate           CaptureStateBlockDelegateFunction;
        internal DeleteStateBlockDelegate            DeleteStateBlockDelegateFunction;
        internal CreateStateBlockDelegate            CreateStateBlockDelegateFunction;
        internal SetClipStatusDelegate               SetClipStatusDelegateFunction;
        internal GetClipStatusDelegate               GetClipStatusDelegateFunction;
        internal GetTextureDelegate                  GetTextureDelegateFunction;
        internal SetTextureDelegate                  SetTextureDelegateFunction;
        internal GetTextureStageStateDelegate        GetTextureStageStateDelegateFunction;
        internal SetTextureStageStateDelegate        SetTextureStageStateDelegateFunction;
        internal ValidateDeviceDelegate              ValidateDeviceDelegateFunction;
        internal GetInfoDelegate                     GetInfoDelegateFunction;
        internal SetPaletteEntriesDelegate           SetPaletteEntriesDelegateFunction;
        internal GetPaletteEntriesDelegate           GetPaletteEntriesDelegateFunction;
        internal SetCurrentTexturePaletteDelegate    SetCurrentTexturePaletteDelegateFunction;
        internal GetCurrentTexturePaletteDelegate    GetCurrentTexturePaletteDelegateFunction;
        internal DrawPrimitiveDelegate               DrawPrimitiveDelegateFunction;
        internal DrawIndexedPrimitiveDelegate        DrawIndexedPrimitiveDelegateFunction;
        internal DrawPrimitiveUPDelegate             DrawPrimitiveUpDelegateFunction;
        internal DrawIndexedPrimitiveUPDelegate      DrawIndexedPrimitiveUpDelegateFunction;
        internal ProcessVerticesDelegate             ProcessVerticesDelegateFunction;
        internal CreateVertexShaderDelegate          CreateVertexShaderDelegateFunction;
        internal SetVertexShaderDelegate             SetVertexShaderDelegateFunction;
        internal GetVertexShaderDelegate             GetVertexShaderDelegateFunction;
        internal DeleteVertexShaderDelegate          DeleteVertexShaderDelegateFunction;
        internal SetVertexShaderConstantDelegate     SetVertexShaderConstantDelegateFunction;
        internal GetVertexShaderConstantDelegate     GetVertexShaderConstantDelegateFunction;
        internal GetVertexShaderDeclarationDelegate  GetVertexShaderDeclarationDelegateFunction;
        internal GetVertexShaderFunctionDelegate     GetVertexShaderFunctionDelegateFunction;
        internal SetStreamSourceDelegate             SetStreamSourceDelegateFunction;
        internal GetStreamSourceDelegate             GetStreamSourceDelegateFunction;
        internal SetIndicesDelegate                  SetIndicesDelegateFunction;
        internal GetIndicesDelegate                  GetIndicesDelegateFunction;
        internal CreatePixelShaderDelegate           CreatePixelShaderDelegateFunction;
        internal SetPixelShaderDelegate              SetPixelShaderDelegateFunction;
        internal GetPixelShaderDelegate              GetPixelShaderDelegateFunction;
        internal DeletePixelShaderDelegate           DeletePixelShaderDelegateFunction;
        internal SetPixelShaderConstantDelegate      SetPixelShaderConstantDelegateFunction;
        internal GetPixelShaderConstantDelegate      GetPixelShaderConstantDelegateFunction;
        internal GetPixelShaderFunctionDelegate      GetPixelShaderFunctionDelegateFunction;
        internal DrawRectPatchDelegate               DrawRectPatchDelegateFunction;
        internal DrawTriPatchDelegate                DrawTriPatchDelegateFunction;
        internal DeletePatchDelegate                 DeletePatchDelegateFunction;

        public IDirect3DDevice8DelegateHolder(void** vtbl) {
            QueryInterfaceDelegateFunction              = Marshal.GetDelegateForFunctionPointer<QueryInterfaceDelegate>((IntPtr)vtbl[0]);
            AddRefDelegateFunction                      = Marshal.GetDelegateForFunctionPointer<AddRefDelegate>((IntPtr)vtbl[1]);
            ReleaseDelegateFunction                     = Marshal.GetDelegateForFunctionPointer<ReleaseDelegate>((IntPtr)vtbl[2]);
            TestCooperativeLevelDelegateFunction        = Marshal.GetDelegateForFunctionPointer<TestCooperativeLevelDelegate>((IntPtr)vtbl[3]);
            GetAvailableTextureMemDelegateFunction      = Marshal.GetDelegateForFunctionPointer<GetAvailableTextureMemDelegate>((IntPtr)vtbl[4]);
            ResourceManagerDiscardBytesDelegateFunction = Marshal.GetDelegateForFunctionPointer<ResourceManagerDiscardBytesDelegate>((IntPtr)vtbl[5]);
            GetDirect3DDelegateFunction                 = Marshal.GetDelegateForFunctionPointer<GetDirect3DDelegate>((IntPtr)vtbl[6]);
            GetDeviceCapsDelegateFunction               = Marshal.GetDelegateForFunctionPointer<GetDeviceCapsDelegate>((IntPtr)vtbl[7]);
            GetDisplayModeDelegateFunction              = Marshal.GetDelegateForFunctionPointer<GetDisplayModeDelegate>((IntPtr)vtbl[8]);
            GetCreationParametersDelegateFunction       = Marshal.GetDelegateForFunctionPointer<GetCreationParametersDelegate>((IntPtr)vtbl[9]);
            SetCursorPropertiesDelegateFunction         = Marshal.GetDelegateForFunctionPointer<SetCursorPropertiesDelegate>((IntPtr)vtbl[10]);
            SetCursorPositionDelegateFunction           = Marshal.GetDelegateForFunctionPointer<SetCursorPositionDelegate>((IntPtr)vtbl[11]);
            ShowCursorDelegateFunction                  = Marshal.GetDelegateForFunctionPointer<ShowCursorDelegate>((IntPtr)vtbl[12]);
            CreateAdditionalSwapChainDelegateFunction   = Marshal.GetDelegateForFunctionPointer<CreateAdditionalSwapChainDelegate>((IntPtr)vtbl[13]);
            ResetDelegateFunction                       = Marshal.GetDelegateForFunctionPointer<ResetDelegate>((IntPtr)vtbl[14]);
            PresentDelegateFunction                     = Marshal.GetDelegateForFunctionPointer<PresentDelegate>((IntPtr)vtbl[15]);
            GetBackBufferDelegateFunction               = Marshal.GetDelegateForFunctionPointer<GetBackBufferDelegate>((IntPtr)vtbl[16]);
            GetRasterStatusDelegateFunction             = Marshal.GetDelegateForFunctionPointer<GetRasterStatusDelegate>((IntPtr)vtbl[17]);
            SetGammaRampDelegateFunction                = Marshal.GetDelegateForFunctionPointer<SetGammaRampDelegate>((IntPtr)vtbl[18]);
            GetGammaRampDelegateFunction                = Marshal.GetDelegateForFunctionPointer<GetGammaRampDelegate>((IntPtr)vtbl[19]);
            CreateTextureDelegateFunction               = Marshal.GetDelegateForFunctionPointer<CreateTextureDelegate>((IntPtr)vtbl[20]);
            CreateVolumeTextureDelegateFunction         = Marshal.GetDelegateForFunctionPointer<CreateVolumeTextureDelegate>((IntPtr)vtbl[21]);
            CreateCubeTextureDelegateFunction           = Marshal.GetDelegateForFunctionPointer<CreateCubeTextureDelegate>((IntPtr)vtbl[22]);
            CreateVertexBufferDelegateFunction          = Marshal.GetDelegateForFunctionPointer<CreateVertexBufferDelegate>((IntPtr)vtbl[23]);
            CreateIndexBufferDelegateFunction           = Marshal.GetDelegateForFunctionPointer<CreateIndexBufferDelegate>((IntPtr)vtbl[24]);
            CreateRenderTargetDelegateFunction          = Marshal.GetDelegateForFunctionPointer<CreateRenderTargetDelegate>((IntPtr)vtbl[25]);
            CreateDepthStencilSurfaceDelegateFunction   = Marshal.GetDelegateForFunctionPointer<CreateDepthStencilSurfaceDelegate>((IntPtr)vtbl[26]);
            CreateImageSurfaceDelegateFunction          = Marshal.GetDelegateForFunctionPointer<CreateImageSurfaceDelegate>((IntPtr)vtbl[27]);
            CopyRectsDelegateFunction                   = Marshal.GetDelegateForFunctionPointer<CopyRectsDelegate>((IntPtr)vtbl[28]);
            UpdateTextureDelegateFunction               = Marshal.GetDelegateForFunctionPointer<UpdateTextureDelegate>((IntPtr)vtbl[29]);
            GetFrontBufferDelegateFunction              = Marshal.GetDelegateForFunctionPointer<GetFrontBufferDelegate>((IntPtr)vtbl[30]);
            SetRenderTargetDelegateFunction             = Marshal.GetDelegateForFunctionPointer<SetRenderTargetDelegate>((IntPtr)vtbl[31]);
            GetRenderTargetDelegateFunction             = Marshal.GetDelegateForFunctionPointer<GetRenderTargetDelegate>((IntPtr)vtbl[32]);
            GetDepthStencilSurfaceDelegateFunction      = Marshal.GetDelegateForFunctionPointer<GetDepthStencilSurfaceDelegate>((IntPtr)vtbl[33]);
            BeginSceneDelegateFunction                  = Marshal.GetDelegateForFunctionPointer<BeginSceneDelegate>((IntPtr)vtbl[34]);
            EndSceneDelegateFunction                    = Marshal.GetDelegateForFunctionPointer<EndSceneDelegate>((IntPtr)vtbl[35]);
            ClearDelegateFunction                       = Marshal.GetDelegateForFunctionPointer<ClearDelegate>((IntPtr)vtbl[36]);
            SetTransformDelegateFunction                = Marshal.GetDelegateForFunctionPointer<SetTransformDelegate>((IntPtr)vtbl[37]);
            GetTransformDelegateFunction                = Marshal.GetDelegateForFunctionPointer<GetTransformDelegate>((IntPtr)vtbl[38]);
            MultiplyTransformDelegateFunction           = Marshal.GetDelegateForFunctionPointer<MultiplyTransformDelegate>((IntPtr)vtbl[39]);
            SetViewportDelegateFunction                 = Marshal.GetDelegateForFunctionPointer<SetViewportDelegate>((IntPtr)vtbl[40]);
            GetViewportDelegateFunction                 = Marshal.GetDelegateForFunctionPointer<GetViewportDelegate>((IntPtr)vtbl[41]);
            SetMaterialDelegateFunction                 = Marshal.GetDelegateForFunctionPointer<SetMaterialDelegate>((IntPtr)vtbl[42]);
            GetMaterialDelegateFunction                 = Marshal.GetDelegateForFunctionPointer<GetMaterialDelegate>((IntPtr)vtbl[43]);
            SetLightDelegateFunction                    = Marshal.GetDelegateForFunctionPointer<SetLightDelegate>((IntPtr)vtbl[44]);
            GetLightDelegateFunction                    = Marshal.GetDelegateForFunctionPointer<GetLightDelegate>((IntPtr)vtbl[45]);
            LightEnableDelegateFunction                 = Marshal.GetDelegateForFunctionPointer<LightEnableDelegate>((IntPtr)vtbl[46]);
            GetLightEnableDelegateFunction              = Marshal.GetDelegateForFunctionPointer<GetLightEnableDelegate>((IntPtr)vtbl[47]);
            SetClipPlaneDelegateFunction                = Marshal.GetDelegateForFunctionPointer<SetClipPlaneDelegate>((IntPtr)vtbl[48]);
            GetClipPlaneDelegateFunction                = Marshal.GetDelegateForFunctionPointer<GetClipPlaneDelegate>((IntPtr)vtbl[49]);
            SetRenderStateDelegateFunction              = Marshal.GetDelegateForFunctionPointer<SetRenderStateDelegate>((IntPtr)vtbl[50]);
            GetRenderStateDelegateFunction              = Marshal.GetDelegateForFunctionPointer<GetRenderStateDelegate>((IntPtr)vtbl[51]);
            BeginStateBlockDelegateFunction             = Marshal.GetDelegateForFunctionPointer<BeginStateBlockDelegate>((IntPtr)vtbl[52]);
            EndStateBlockDelegateFunction               = Marshal.GetDelegateForFunctionPointer<EndStateBlockDelegate>((IntPtr)vtbl[53]);
            ApplyStateBlockDelegateFunction             = Marshal.GetDelegateForFunctionPointer<ApplyStateBlockDelegate>((IntPtr)vtbl[54]);
            CaptureStateBlockDelegateFunction           = Marshal.GetDelegateForFunctionPointer<CaptureStateBlockDelegate>((IntPtr)vtbl[55]);
            DeleteStateBlockDelegateFunction            = Marshal.GetDelegateForFunctionPointer<DeleteStateBlockDelegate>((IntPtr)vtbl[56]);
            CreateStateBlockDelegateFunction            = Marshal.GetDelegateForFunctionPointer<CreateStateBlockDelegate>((IntPtr)vtbl[57]);
            SetClipStatusDelegateFunction               = Marshal.GetDelegateForFunctionPointer<SetClipStatusDelegate>((IntPtr)vtbl[58]);
            GetClipStatusDelegateFunction               = Marshal.GetDelegateForFunctionPointer<GetClipStatusDelegate>((IntPtr)vtbl[59]);
            GetTextureDelegateFunction                  = Marshal.GetDelegateForFunctionPointer<GetTextureDelegate>((IntPtr)vtbl[60]);
            SetTextureDelegateFunction                  = Marshal.GetDelegateForFunctionPointer<SetTextureDelegate>((IntPtr)vtbl[61]);
            GetTextureStageStateDelegateFunction        = Marshal.GetDelegateForFunctionPointer<GetTextureStageStateDelegate>((IntPtr)vtbl[62]);
            SetTextureStageStateDelegateFunction        = Marshal.GetDelegateForFunctionPointer<SetTextureStageStateDelegate>((IntPtr)vtbl[63]);
            ValidateDeviceDelegateFunction              = Marshal.GetDelegateForFunctionPointer<ValidateDeviceDelegate>((IntPtr)vtbl[64]);
            GetInfoDelegateFunction                     = Marshal.GetDelegateForFunctionPointer<GetInfoDelegate>((IntPtr)vtbl[65]);
            SetPaletteEntriesDelegateFunction           = Marshal.GetDelegateForFunctionPointer<SetPaletteEntriesDelegate>((IntPtr)vtbl[66]);
            GetPaletteEntriesDelegateFunction           = Marshal.GetDelegateForFunctionPointer<GetPaletteEntriesDelegate>((IntPtr)vtbl[67]);
            SetCurrentTexturePaletteDelegateFunction    = Marshal.GetDelegateForFunctionPointer<SetCurrentTexturePaletteDelegate>((IntPtr)vtbl[68]);
            GetCurrentTexturePaletteDelegateFunction    = Marshal.GetDelegateForFunctionPointer<GetCurrentTexturePaletteDelegate>((IntPtr)vtbl[69]);
            DrawPrimitiveDelegateFunction               = Marshal.GetDelegateForFunctionPointer<DrawPrimitiveDelegate>((IntPtr)vtbl[70]);
            DrawIndexedPrimitiveDelegateFunction        = Marshal.GetDelegateForFunctionPointer<DrawIndexedPrimitiveDelegate>((IntPtr)vtbl[71]);
            DrawPrimitiveUpDelegateFunction             = Marshal.GetDelegateForFunctionPointer<DrawPrimitiveUPDelegate>((IntPtr)vtbl[72]);
            DrawIndexedPrimitiveUpDelegateFunction      = Marshal.GetDelegateForFunctionPointer<DrawIndexedPrimitiveUPDelegate>((IntPtr)vtbl[73]);
            ProcessVerticesDelegateFunction             = Marshal.GetDelegateForFunctionPointer<ProcessVerticesDelegate>((IntPtr)vtbl[74]);
            CreateVertexShaderDelegateFunction          = Marshal.GetDelegateForFunctionPointer<CreateVertexShaderDelegate>((IntPtr)vtbl[75]);
            SetVertexShaderDelegateFunction             = Marshal.GetDelegateForFunctionPointer<SetVertexShaderDelegate>((IntPtr)vtbl[76]);
            GetVertexShaderDelegateFunction             = Marshal.GetDelegateForFunctionPointer<GetVertexShaderDelegate>((IntPtr)vtbl[77]);
            DeleteVertexShaderDelegateFunction          = Marshal.GetDelegateForFunctionPointer<DeleteVertexShaderDelegate>((IntPtr)vtbl[78]);
            SetVertexShaderConstantDelegateFunction     = Marshal.GetDelegateForFunctionPointer<SetVertexShaderConstantDelegate>((IntPtr)vtbl[79]);
            GetVertexShaderConstantDelegateFunction     = Marshal.GetDelegateForFunctionPointer<GetVertexShaderConstantDelegate>((IntPtr)vtbl[80]);
            GetVertexShaderDeclarationDelegateFunction  = Marshal.GetDelegateForFunctionPointer<GetVertexShaderDeclarationDelegate>((IntPtr)vtbl[81]);
            GetVertexShaderFunctionDelegateFunction     = Marshal.GetDelegateForFunctionPointer<GetVertexShaderFunctionDelegate>((IntPtr)vtbl[82]);
            SetStreamSourceDelegateFunction             = Marshal.GetDelegateForFunctionPointer<SetStreamSourceDelegate>((IntPtr)vtbl[83]);
            GetStreamSourceDelegateFunction             = Marshal.GetDelegateForFunctionPointer<GetStreamSourceDelegate>((IntPtr)vtbl[84]);
            SetIndicesDelegateFunction                  = Marshal.GetDelegateForFunctionPointer<SetIndicesDelegate>((IntPtr)vtbl[85]);
            GetIndicesDelegateFunction                  = Marshal.GetDelegateForFunctionPointer<GetIndicesDelegate>((IntPtr)vtbl[86]);
            CreatePixelShaderDelegateFunction           = Marshal.GetDelegateForFunctionPointer<CreatePixelShaderDelegate>((IntPtr)vtbl[87]);
            SetPixelShaderDelegateFunction              = Marshal.GetDelegateForFunctionPointer<SetPixelShaderDelegate>((IntPtr)vtbl[88]);
            GetPixelShaderDelegateFunction              = Marshal.GetDelegateForFunctionPointer<GetPixelShaderDelegate>((IntPtr)vtbl[89]);
            DeletePixelShaderDelegateFunction           = Marshal.GetDelegateForFunctionPointer<DeletePixelShaderDelegate>((IntPtr)vtbl[90]);
            SetPixelShaderConstantDelegateFunction      = Marshal.GetDelegateForFunctionPointer<SetPixelShaderConstantDelegate>((IntPtr)vtbl[91]);
            GetPixelShaderConstantDelegateFunction      = Marshal.GetDelegateForFunctionPointer<GetPixelShaderConstantDelegate>((IntPtr)vtbl[92]);
            GetPixelShaderFunctionDelegateFunction      = Marshal.GetDelegateForFunctionPointer<GetPixelShaderFunctionDelegate>((IntPtr)vtbl[93]);
            DrawRectPatchDelegateFunction               = Marshal.GetDelegateForFunctionPointer<DrawRectPatchDelegate>((IntPtr)vtbl[94]);
            DrawTriPatchDelegateFunction                = Marshal.GetDelegateForFunctionPointer<DrawTriPatchDelegate>((IntPtr)vtbl[95]);
            DeletePatchDelegateFunction                 = Marshal.GetDelegateForFunctionPointer<DeletePatchDelegate>((IntPtr)vtbl[96]);

            DelegateCaches.Add((IntPtr)vtbl, this);
        }
    }

    public unsafe struct IDirect3DDevice8 {
        public void** Vtbl;

        public IntPtr Identifer => (IntPtr)Vtbl;

        public D3DRESULT Clear(D3DRECT[] rects, D3DCLEAR clearTarget, D3DCOLOR clearColor, float z, int stencil) {
            IDirect3DDevice8DelegateHolder delegateHolder = IDirect3DDevice8DelegateHolder.DelegateCaches[Identifer];

            int count = rects.Length;

            fixed (D3DRECT* ptrRects = rects) {
                int ret = delegateHolder.ClearDelegateFunction(delegateHolder.DevicePointer, count, ptrRects, clearTarget, clearColor, z, stencil);

                return (D3DRESULT) ret;
            }
        }

        public D3DRESULT Clear(D3DCLEAR clearTarget, D3DCOLOR clearColor, float z = 0, int stencil = 0) {
            IDirect3DDevice8DelegateHolder delegateHolder = IDirect3DDevice8DelegateHolder.DelegateCaches[Identifer];

            int ret = delegateHolder.ClearDelegateFunction(delegateHolder.DevicePointer, 0, null, clearTarget, clearColor, z, stencil);

            return (D3DRESULT) ret;
        }

        public D3DRESULT Present(RECT sourceRect, RECT destRect, IntPtr windowOverride) {
            IDirect3DDevice8DelegateHolder delegateHolder = IDirect3DDevice8DelegateHolder.DelegateCaches[Identifer];

            int ret = delegateHolder.PresentDelegateFunction(delegateHolder.DevicePointer, &sourceRect, &destRect, windowOverride, null);

            return (D3DRESULT) ret;
        }

        public D3DRESULT Present(IntPtr windowOverride) {
            IDirect3DDevice8DelegateHolder delegateHolder = IDirect3DDevice8DelegateHolder.DelegateCaches[Identifer];

            int ret = delegateHolder.PresentDelegateFunction(delegateHolder.DevicePointer, null, null, windowOverride, null);

            return (D3DRESULT) ret;
        }

        public D3DRESULT Present() {
            IDirect3DDevice8DelegateHolder delegateHolder = IDirect3DDevice8DelegateHolder.DelegateCaches[Identifer];

            int ret = delegateHolder.PresentDelegateFunction(delegateHolder.DevicePointer, null, null, IntPtr.Zero, null);

            return (D3DRESULT) ret;
        }
    }
}
