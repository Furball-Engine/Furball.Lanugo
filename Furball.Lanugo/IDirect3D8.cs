using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Furball.Lanugo {

    public unsafe struct IDirect3D8 {
        // ReSharper disable once InconsistentNaming
        public const int D3D_SDK_VERSION = 120;

        [DllImport("d3d8", CallingConvention = CallingConvention.Winapi, CharSet = CharSet.Ansi, ExactSpelling = true)]
        private static extern IDirect3D8* Direct3DCreate8(uint sdkVersion);

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

        delegate int RegisterSoftwareDeviceDelegate(IDirect3D8* d3d8, void* initializeFunction);
        delegate uint GetAdapterCountDelegate(IDirect3D8* d3d8);
        delegate int GetAdapterIdentifierDelegate(IDirect3D8* d3d8, uint adapter, uint flags, void* pIdentifier);
        delegate uint GetAdapterModeCountDelegate(IDirect3D8* d3d8, uint adapter);
        delegate int EnumAdapterModesDelegate(IDirect3D8* d3d8, uint adapter, uint mode, void* pMode);
        delegate int GetAdapterDisplayModeDelegate(IDirect3D8* d3d8, uint adapter, D3DDISPLAYMODE* pMode);
        delegate int CheckDeviceTypeDelegate(IDirect3D8* d3d8, uint adapter, D3DDEVTYPE checkType, D3DFORMAT displayFormat, D3DFORMAT backBufferFormat, bool windowed);
        delegate int CheckDeviceFormatDelegate(IDirect3D8* d3d8, uint adapter, D3DDEVTYPE deviceType, D3DFORMAT adapterFormat, D3DFORMATCHECKUSAGE usage, D3DRESOURCETYPE rType, D3DFORMAT checkFormat);
        delegate int CheckDeviceMultiSampleTypeDelegate(IDirect3D8* d3d8, uint adapter, D3DDEVTYPE deviceType, D3DFORMAT surfaceFormat, bool windowed, D3DMULTISAMPLE_TYPE multisampleType);
        delegate int CheckDepthStencilMatchDelegate(IDirect3D8* d3d8, uint adapter, D3DDEVTYPE deviceType, D3DFORMAT adapterFormat, D3DFORMAT renderTargetFormat, D3DFORMAT depthStencilFormat);
        delegate int GetDeviceCapsDelegate(IDirect3D8* d3d8, uint adapter, D3DDEVTYPE deviceType, D3DCAPS8* pCaps);
        delegate IntPtr GetAdapterMonitorDelegate(IDirect3D8* d3d8, uint adapter);
        delegate int CreateDeviceDelegate(IDirect3D8* d3d8, uint adapter, D3DDEVTYPE deviceType, IntPtr hFocusWindow, D3DCREATEFLAGS behaviourFlags, void* pPresentationParameters, VirtualTableStruct** ppReturnedDeviceInterfacce);

        #endregion

        public void** LpVtbl;

        private static IDirect3D8* _d3d8;

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

        /// <summary>
        /// Initializes Direct3D8
        /// </summary>
        public static void CreateDirect3D8() {
            IDirect3D8* d3d8 = Direct3DCreate8(D3D_SDK_VERSION);

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
        /// <summary>
        /// Gets the amount of adapters
        /// </summary>
        /// <returns>Adapter Count</returns>
        public static uint GetAdapterCount() => _getAdapterCountDelegate(_d3d8);
        /// <summary>
        /// Gets the number of adapters
        /// </summary>
        /// <param name="adapterCount">Returning adapter count</param>
        public static void GetAdapterCount(out uint adapterCount) {
            adapterCount = GetAdapterCount();
        }
        /// <summary>
        /// Gets information about a card
        /// </summary>
        /// <param name="adapter"></param>
        /// <param name="disableWhqlCheck">Disables the WHQL certification date check</param>
        /// <param name="adapterIdentifer"></param>
        /// <returns></returns>
        public static D3DRESULT GetAdapterIdentifer(uint adapter, bool disableWhqlCheck, out D3DADAPTER_IDENTIFIER8 adapterIdentifer) {
            D3DADAPTER_IDENTIFIER8 ptrIdentifer = new D3DADAPTER_IDENTIFIER8();

            uint flags = disableWhqlCheck ? 1u : 0u;

            int ret = _getAdapterIdentifierDelegate(_d3d8, adapter, flags, &ptrIdentifer);

            adapterIdentifer = ptrIdentifer;

            return (D3DRESULT) ret;
        }
        /// <summary>
        /// Gets the amount of modes available for EnumAdapterModes
        /// </summary>
        /// <param name="adapter">Adapter to check for</param>
        /// <returns></returns>
        public static uint GetAdapterModeCount(uint adapter) {
            return _getAdapterModeCountDelegate(_d3d8, adapter);
        }
        /// <summary>
        /// Gets the amount of modes available for EnumAdapterModes
        /// </summary>
        /// <param name="adapter">Adapter to check for</param>
        /// <param name="adapterModeCount">Returning mode count</param>
        public static void GetAdapterModeCount(uint adapter, out uint adapterModeCount) {
            adapterModeCount = GetAdapterModeCount(adapter);
        }
        /// <summary>
        /// Gets a given adapter mode, where mode is the index
        /// </summary>
        /// <param name="adapter">adapter to check for</param>
        /// <param name="mode">Mode index (query max with GetAdapterModeCount)</param>
        /// <param name="displayMode">Returning Display mode</param>
        /// <returns></returns>
        public static D3DRESULT EnumAdapterModes(uint adapter, uint mode, out D3DDISPLAYMODE displayMode) {
            D3DDISPLAYMODE ptrDisplayMode = new D3DDISPLAYMODE();

            int ret = _enumAdapterModesDelegate(_d3d8, adapter, mode, &ptrDisplayMode);

            displayMode = ptrDisplayMode;

            return (D3DRESULT) ret;
        }
        /// <summary>
        /// Gets the display mode of a adapter
        /// </summary>
        /// <param name="adapter">Adapter to check for</param>
        /// <param name="displayMode">Returning display mode</param>
        /// <returns></returns>
        public static D3DRESULT GetAdapterDisplayMode(uint adapter, out D3DDISPLAYMODE displayMode) {
            D3DDISPLAYMODE ptrDisplayMode = new D3DDISPLAYMODE();

            int ret = _getAdapterDisplayModeDelegate(_d3d8, adapter, &ptrDisplayMode);

            displayMode = ptrDisplayMode;

            return (D3DRESULT) ret;
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
        public static D3DRESULT CheckDeviceType(uint adapter, D3DDEVTYPE checkType, D3DFORMAT displayFormat, D3DFORMAT backBufferFormat, bool windowed) {
            return (D3DRESULT) _checkDeviceTypeDelegate(_d3d8, adapter, checkType, displayFormat, backBufferFormat, windowed);
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
        public static D3DRESULT CheckDeviceFormat(uint adapter, D3DDEVTYPE deviceType, D3DFORMAT adapterFormat, D3DFORMATCHECKUSAGE usage, D3DRESOURCETYPE rType, D3DFORMAT checkFormat) {
            return (D3DRESULT) _checkDeviceFormatDelegate(_d3d8, adapter, deviceType, adapterFormat, usage, rType, checkFormat);
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
        public static D3DRESULT CheckDeviceMultisampleType(uint adapter, D3DDEVTYPE deviceType, D3DFORMAT surfaceFormat, bool windowed, D3DMULTISAMPLE_TYPE multisampleType) {
            return (D3DRESULT) _checkDeviceMultiSampleTypeDelegate(_d3d8, adapter, deviceType, surfaceFormat, windowed, multisampleType);
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
        public static D3DRESULT CheckDepthStencilMatch(uint adapter, D3DDEVTYPE deviceType, D3DFORMAT adapterFormat, D3DFORMAT renderTargetFormat, D3DFORMAT depthStencilFormat) {
            return (D3DRESULT) _checkDepthStencilMatchDelegate(_d3d8, adapter, deviceType, adapterFormat, renderTargetFormat, depthStencilFormat);
        }
        /// <summary>
        /// Gets Device Capabilities for a given adapter
        /// </summary>
        /// <param name="adapter">Adapter to check</param>
        /// <param name="deviceType">What type of adapter to check for</param>
        /// <param name="deviceCaps">Returning device capabilities</param>
        /// <returns></returns>
        public static D3DRESULT GetDeviceCaps(uint adapter, D3DDEVTYPE deviceType, out D3DCAPS8 deviceCaps) {
            D3DCAPS8 caps = new D3DCAPS8();

            int ret = _getDeviceCapsDelegate(_d3d8, adapter, deviceType, &caps);

            deviceCaps = caps;

            return (D3DRESULT) ret;
        }
        /// <summary>
        /// Gets a adapters monitor handle
        /// </summary>
        /// <param name="adapter">Adapter to check for</param>
        /// <returns></returns>
        public static IntPtr GetAdapterMonitor(uint adapter) {
            return _getAdapterMonitorDelegate(_d3d8, adapter);
        }
        /// <summary>
        /// Gets a adapters monitor handle
        /// </summary>
        /// <param name="adapter">Adapter to check for</param>
        /// <param name="monitorHandle">Returning Monitor Handle</param>
        public static void GetAdapterMonitor(uint adapter, out IntPtr monitorHandle) {
            monitorHandle = GetAdapterMonitor(adapter);
        }
        /// <summary>
        /// Creates a Direct3D8 Device
        /// </summary>
        /// <param name="adapter">Adapter to create it under</param>
        /// <param name="deviceType">What kind of adapter to use</param>
        /// <param name="focusWindow">Window Handle to render to</param>
        /// <param name="behaviorFlags"></param>
        /// <param name="presentationParameters"></param>
        /// <param name="device"></param>
        /// <returns></returns>
        public static D3DRESULT CreateDevice(uint adapter, D3DDEVTYPE deviceType, IntPtr focusWindow, D3DCREATEFLAGS behaviorFlags, D3DPRESENT_PARAMETERS* presentationParameters, out IDirect3DDevice8 device) {
            VirtualTableStruct* ptrDevice;

            int ret = _createDeviceDelegate(_d3d8, adapter, deviceType, focusWindow, behaviorFlags, presentationParameters, &ptrDevice);

            device = new IDirect3DDevice8(ptrDevice);

            return (D3DRESULT) ret;
        }
    }
}