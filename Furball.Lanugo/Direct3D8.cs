using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Furball.Lanugo {

    public unsafe struct Direct3D8 {
        // ReSharper disable once InconsistentNaming
        public const int D3D_SDK_VERSION = 120;

        [DllImport("d3d8", CallingConvention = CallingConvention.Winapi, CharSet = CharSet.Ansi, ExactSpelling = true)]
        private static extern Direct3D8* Direct3DCreate8(uint sdkVersion);

        private static IntPtr QueryInterfacePtr => (IntPtr) _d3d8->LpVtbl[0];
        private static IntPtr AddRefPtr => (IntPtr) _d3d8->LpVtbl[1];
        private static IntPtr ReleasePtr => (IntPtr) _d3d8->LpVtbl[2];
        private static IntPtr RegisterSoftwareDevicePtr => (IntPtr) _d3d8->LpVtbl[3];
        private static IntPtr GetAdapterCountPtr => (IntPtr) _d3d8->LpVtbl[4];
        private static IntPtr GetAdapterIdentifierPtr => (IntPtr) _d3d8->LpVtbl[5];
        private static IntPtr GetAdapterModeCountPtr => (IntPtr) _d3d8->LpVtbl[6];
        private static IntPtr EnumAdapterModesPtr => (IntPtr) _d3d8->LpVtbl[7];
        private static IntPtr GetAdapterDisplayModePtr => (IntPtr) _d3d8->LpVtbl[8];
        private static IntPtr CheckDeviceTypePtr => (IntPtr) _d3d8->LpVtbl[9];
        private static IntPtr CheckDeviceFormatPtr => (IntPtr) _d3d8->LpVtbl[10];
        private static IntPtr CheckDeviceMultisampleTypePtr => (IntPtr) _d3d8->LpVtbl[11];
        private static IntPtr CheckDepthStencilMatchPtr => (IntPtr) _d3d8->LpVtbl[12];
        private static IntPtr GetDeviceCapsPtr => (IntPtr) _d3d8->LpVtbl[13];
        private static IntPtr GetAdapterMonitorPtr => (IntPtr) _d3d8->LpVtbl[14];
        private static IntPtr CreateDevicePtr => (IntPtr) _d3d8->LpVtbl[15];

        #region IUnknown Delegates

        delegate int QueryInterfaceDelegate(Guid riid, void** ppvObj);
        delegate uint AddRefDelegate();
        delegate uint ReleaseDelegate();

        #endregion

        #region IDirect3D8 Delegates

        delegate int RegisterSoftwareDeviceDelegate(Direct3D8* d3d8, void* initializeFunction);
        delegate uint GetAdapterCountDelegate(Direct3D8* d3d8);
        delegate int GetAdapterIdentifierDelegate(Direct3D8* d3d8, uint adapter, uint flags, void* pIdentifier);
        delegate uint GetAdapterModeCountDelegate(Direct3D8* d3d8, uint adapter);
        delegate int EnumAdapterModesDelegate(Direct3D8* d3d8, uint adapter, uint mode, void* pMode);
        delegate int GetAdapterDisplayModeDelegate(Direct3D8* d3d8, uint adapter, D3DDISPLAYMODE* pMode);
        delegate int CheckDeviceTypeDelegate(Direct3D8* d3d8, uint adapter, D3DDEVTYPE checkType, D3DFORMAT displayFormat, D3DFORMAT backBufferFormat, bool windowed);
        delegate int CheckDeviceFormatDelegate(Direct3D8* d3d8, uint adapter, D3DDEVTYPE deviceType, D3DFORMAT adapterFormat, uint usage, D3DRESOURCETYPE rType, D3DFORMAT checkFormat);
        delegate int CheckDeviceMultiSampleTypeDelegate(Direct3D8* d3d8, uint adapter, D3DDEVTYPE deviceType, D3DFORMAT surfaceFormat, bool windowed, D3DMULTISAMPLE_TYPE multisampleType);
        delegate int CheckDepthStencilMatchDelegate(Direct3D8* d3d8, uint adapter, D3DDEVTYPE deviceType, D3DFORMAT adapterFormat, D3DFORMAT renderTargetFormat, D3DFORMAT depthStencilFormat);
        delegate int GetDeviceCapsDelegate(Direct3D8* d3d8, uint adapter, D3DDEVTYPE deviceType, D3DCAPS8* pCaps);
        delegate IntPtr GetAdapterMonitorDelegate(Direct3D8* d3d8, uint adapter);
        delegate int CreateDeviceDelegate(Direct3D8* d3d8, uint adapter, D3DDEVTYPE deviceType, IntPtr hFocusWindow, uint behaviourFlags, void* pPresentationParameters, IDirect3DDevice8** ppReturnedDeviceInterfacce);

        #endregion

        public void** LpVtbl;

        private static Direct3D8* _d3d8;

        private static QueryInterfaceDelegate             _queryInterfaceDelegate;
        private static AddRefDelegate                     _addRefDelegate;
        private static ReleaseDelegate                    _releaseDelegate;

        private static RegisterSoftwareDeviceDelegate     _registerSoftwareDeviceDelegate;
        private static GetAdapterCountDelegate            _getAdapterCountDelegate;
        private static GetAdapterIdentifierDelegate       _getAdapterIdentifierDelegate;
        private static GetAdapterModeCountDelegate        _getAdapterModeCountDelegate;
        private static EnumAdapterModesDelegate           _enumAdapterModesDelegate;
        private static GetAdapterDisplayModeDelegate      _getAdapterDisplayModeDelegate;
        private static CheckDeviceTypeDelegate            _checkDeviceTypeDelegate;
        private static CheckDeviceFormatDelegate          _checkDeviceFormatDelegate;
        private static CheckDeviceMultiSampleTypeDelegate _checkDeviceMultiSampleTypeDelegate;
        private static CheckDepthStencilMatchDelegate     _checkDepthStencilMatchDelegate;
        private static GetDeviceCapsDelegate              _getDeviceCapsDelegate;
        private static GetAdapterMonitorDelegate          _getAdapterMonitorDelegate;
        private static CreateDeviceDelegate               _createDeviceDelegate;

        public static void CreateDirect3D8() {
            Direct3D8* d3d8 = Direct3DCreate8(D3D_SDK_VERSION);

            _d3d8 = d3d8;

            _queryInterfaceDelegate = Marshal.GetDelegateForFunctionPointer<QueryInterfaceDelegate>(QueryInterfacePtr);
            _addRefDelegate         = Marshal.GetDelegateForFunctionPointer<AddRefDelegate>(AddRefPtr);
            _releaseDelegate        = Marshal.GetDelegateForFunctionPointer<ReleaseDelegate>(ReleasePtr);

            _registerSoftwareDeviceDelegate     = Marshal.GetDelegateForFunctionPointer<RegisterSoftwareDeviceDelegate>(RegisterSoftwareDevicePtr);
            _getAdapterCountDelegate            = Marshal.GetDelegateForFunctionPointer<GetAdapterCountDelegate>(GetAdapterCountPtr);
            _getAdapterIdentifierDelegate       = Marshal.GetDelegateForFunctionPointer<GetAdapterIdentifierDelegate>(GetAdapterIdentifierPtr);
            _getAdapterModeCountDelegate        = Marshal.GetDelegateForFunctionPointer<GetAdapterModeCountDelegate>(GetAdapterModeCountPtr);
            _enumAdapterModesDelegate           = Marshal.GetDelegateForFunctionPointer<EnumAdapterModesDelegate>(EnumAdapterModesPtr);
            _getAdapterDisplayModeDelegate      = Marshal.GetDelegateForFunctionPointer<GetAdapterDisplayModeDelegate>(GetAdapterDisplayModePtr);
            _checkDeviceTypeDelegate            = Marshal.GetDelegateForFunctionPointer<CheckDeviceTypeDelegate>(CheckDeviceTypePtr);
            _checkDeviceFormatDelegate          = Marshal.GetDelegateForFunctionPointer<CheckDeviceFormatDelegate>(CheckDeviceFormatPtr);
            _checkDeviceMultiSampleTypeDelegate = Marshal.GetDelegateForFunctionPointer<CheckDeviceMultiSampleTypeDelegate>(CheckDeviceMultisampleTypePtr);
            _checkDepthStencilMatchDelegate     = Marshal.GetDelegateForFunctionPointer<CheckDepthStencilMatchDelegate>(CheckDepthStencilMatchPtr);
            _getDeviceCapsDelegate              = Marshal.GetDelegateForFunctionPointer<GetDeviceCapsDelegate>(GetDeviceCapsPtr);
            _getAdapterMonitorDelegate          = Marshal.GetDelegateForFunctionPointer<GetAdapterMonitorDelegate>(GetAdapterMonitorPtr);
            _createDeviceDelegate               = Marshal.GetDelegateForFunctionPointer<CreateDeviceDelegate>(CreateDevicePtr);
        }

        public static uint GetAdapterCount() => _getAdapterCountDelegate(_d3d8);

        public static void GetAdapterCount(out uint adapterCount) {
            adapterCount = GetAdapterCount();
        }

        public static int GetAdapterIdentifer(uint adapter, uint flags, out D3DADAPTER_IDENTIFIER8 adapterIdentifer) {
            D3DADAPTER_IDENTIFIER8 ptrIdentifer = new D3DADAPTER_IDENTIFIER8();

            int ret = _getAdapterIdentifierDelegate(_d3d8, adapter, flags, &ptrIdentifer);

            adapterIdentifer = ptrIdentifer;

            return ret;
        }

        public static uint GetAdapterModeCount(uint adapter) {
            return _getAdapterModeCountDelegate(_d3d8, adapter);
        }

        public static void GetAdapterModeCount(uint adapter, out uint adapterModeCount) {
            adapterModeCount = GetAdapterModeCount(adapter);
        }

        public static int EnumAdapterModes(uint adapter, uint mode, out D3DDISPLAYMODE displayMode) {
            D3DDISPLAYMODE ptrDisplayMode = new D3DDISPLAYMODE();

            int ret = _enumAdapterModesDelegate(_d3d8, adapter, mode, &ptrDisplayMode);

            displayMode = ptrDisplayMode;

            return ret;
        }

        public static int GetAdapterDisplayMode(uint adapter, out D3DDISPLAYMODE displayMode) {
            D3DDISPLAYMODE ptrDisplayMode = new D3DDISPLAYMODE();

            int ret = _getAdapterDisplayModeDelegate(_d3d8, adapter, &ptrDisplayMode);

            displayMode = ptrDisplayMode;

            return ret;
        }
        /// <summary>
        /// This method verifies whether a certain device type can be used on this adapter and expect hardware acceleration using the given formats.
        /// </summary>
        /// <param name="adapter">Adapter Number</param>
        /// <param name="checkType">Device Type to Check</param>
        /// <param name="displayFormat">Display Format to Check</param>
        /// <param name="backBufferFormat">Back buffer Format to Check</param>
        /// <param name="windowed">Indicator whether to check for Windowed or Fullscreen</param>
        /// <returns>If everything's supported as is, 0</returns>
        public static int CheckDeviceType(uint adapter, D3DDEVTYPE checkType, D3DFORMAT displayFormat, D3DFORMAT backBufferFormat, bool windowed) {
            return _checkDeviceTypeDelegate(_d3d8, adapter, checkType, displayFormat, backBufferFormat, windowed);
        }
        /// <summary>
        /// Checks if a particular format is supported by the hardware for the designated purpose supplied in rType
        /// </summary>
        /// <param name="adapter">Adapter Number></param>
        /// <param name="deviceType">Device Type to Check</param>
        /// <param name="adapterFormat">format of the display mode into which the adapter will be placed.</param>
        /// <param name="usage">Requested usage for a surface of the CheckFormat, in case it's irrelevant, set to RENDERTARGET</param>
        /// <param name="rType">Purpose to check for</param>
        /// <param name="checkFormat">Format to check</param>
        /// <returns></returns>
        public static int CheckDeviceFormat(uint adapter, D3DDEVTYPE deviceType, D3DFORMAT adapterFormat, uint usage, D3DRESOURCETYPE rType, D3DFORMAT checkFormat) {
            return _checkDeviceFormatDelegate(_d3d8, adapter, deviceType, adapterFormat, usage, rType, checkFormat);
        }
        /// <summary>
        /// Checks whether a certain multisample type is supported by the hardware
        /// </summary>
        /// <param name="adapter">Adapter Number></param>
        /// <param name="deviceType">Device Type to Check</param>
        /// <param name="surfaceFormat">Format of the surface being rendered to</param>
        /// <param name="windowed">Windowed</param>
        /// <param name="multisampleType">Multisample type to check</param>
        /// <returns></returns>
        public static int CheckDeviceMultisampleType(uint adapter, D3DDEVTYPE deviceType, D3DFORMAT surfaceFormat, bool windowed, D3DMULTISAMPLE_TYPE multisampleType) {
            return _checkDeviceMultiSampleTypeDelegate(_d3d8, adapter, deviceType, surfaceFormat, windowed, multisampleType);
        }
        /// <summary>
        /// determines whether a depth-stencil format is compatible with a render target format in a particular display mode.
        /// </summary>
        /// <param name="adapter">Adapter Number></param>
        /// <param name="deviceType">Device Type to Check</param>
        /// <param name="adapterFormat">format of the display mode into which the adapter will be placed.</param>
        /// <param name="renderTargetFormat">Format of the Rendertarget</param>
        /// <param name="depthStencilFormat">Depth Stencil format to check</param>
        /// <returns></returns>
        public static int CheckDepthStencilMatch(uint adapter, D3DDEVTYPE deviceType, D3DFORMAT adapterFormat, D3DFORMAT renderTargetFormat, D3DFORMAT depthStencilFormat) {
            return _checkDepthStencilMatchDelegate(_d3d8, adapter, deviceType, adapterFormat, renderTargetFormat, depthStencilFormat);
        }

        public static int GetDeviceCaps(uint adapter, D3DDEVTYPE deviceType, out D3DCAPS8 deviceCaps) {
            D3DCAPS8 caps = new D3DCAPS8();

            int ret = _getDeviceCapsDelegate(_d3d8, adapter, deviceType, &caps);

            deviceCaps = caps;

            return ret;
        }

        public static IntPtr GetAdapterMonitor(uint adapter) {
            return _getAdapterMonitorDelegate(_d3d8, adapter);
        }

        public static void GetAdapterMonitor(uint adapter, out IntPtr monitorHandle) {
            monitorHandle = GetAdapterMonitor(adapter);
        }

        public static int CreateDevice(uint adapter, D3DDEVTYPE deviceType, IntPtr focusWindow, uint behaviorFlags, D3DPRESENT_PARAMETERS* presentationParameters, ref IDirect3DDevice8* device) {
            IntPtr returnedDeviceInterfaceOut = IntPtr.Zero;

            fixed (IDirect3DDevice8** ppReturnedDeviceInterfacePtr = &device) {
                int ret = _createDeviceDelegate(_d3d8, adapter, deviceType, focusWindow, behaviorFlags, presentationParameters, ppReturnedDeviceInterfacePtr);

                return ret;
            }
        }
    }
}