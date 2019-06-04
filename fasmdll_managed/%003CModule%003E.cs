// Type: <Module>
// Assembly: fasmdll_managed, Version=1.0.5025.35375, Culture=neutral, PublicKeyToken=null
// MVID: E1E2AABC-E9DC-40C2-AD1D-352EC5BA64A0
// Assembly location: E:\Tools\fasmdll_managed.dll

using \u003CCppImplementationDetails\u003E;
using \u003CCrtImplementationDetails\u003E;
using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.ConstrainedExecution;
using System.Runtime.ExceptionServices;
using System.Runtime.InteropServices;
using System.Security;
using System.Security.Permissions;
using System.Threading;

internal class \u003CModule\u003E
{
  internal static unsafe byte* _c_fasm_memorybuf;
  internal static __s_GUID _GUID_90f1a06e_7712_4762_86b5_7a5eba6bdb02;
  internal static __s_GUID _GUID_cb2f6722_ab3a_11d2_9c40_00c04fa30a3e;
  internal static \u0024ArrayType\u0024\u0024\u0024BY00Q6MPBXXZ \u003FA0xd56818f8\u002E__xc_mp_z;
  [FixedAddressValueType]
  internal static int \u003FUninitialized\u0040CurrentDomain\u0040\u003CCrtImplementationDetails\u003E\u0040\u0040\u0024\u0024Q2HA;
  internal static __FnPtr<void ()> \u003FA0xd56818f8\u002E\u003FUninitialized\u0024initializer\u0024\u0040CurrentDomain\u0040\u003CCrtImplementationDetails\u003E\u0040\u0040\u0024\u0024Q2P6MXXZA;
  internal static \u0024ArrayType\u0024\u0024\u0024BY00Q6MPBXXZ \u003FA0xd56818f8\u002E__xi_vt_a;
  [FixedAddressValueType]
  internal static Progress.State \u003FInitializedPerAppDomain\u0040CurrentDomain\u0040\u003CCrtImplementationDetails\u003E\u0040\u0040\u0024\u0024Q2W4State\u0040Progress\u00402\u0040A;
  internal static __FnPtr<void ()> \u003FA0xd56818f8\u002E\u003FInitializedPerAppDomain\u0024initializer\u0024\u0040CurrentDomain\u0040\u003CCrtImplementationDetails\u003E\u0040\u0040\u0024\u0024Q2P6MXXZA;
  [FixedAddressValueType]
  internal static bool \u003FIsDefaultDomain\u0040CurrentDomain\u0040\u003CCrtImplementationDetails\u003E\u0040\u0040\u0024\u0024Q2_NA;
  internal static __FnPtr<void ()> \u003FA0xd56818f8\u002E\u003FIsDefaultDomain\u0024initializer\u0024\u0040CurrentDomain\u0040\u003CCrtImplementationDetails\u003E\u0040\u0040\u0024\u0024Q2P6MXXZA;
  internal static \u0024ArrayType\u0024\u0024\u0024BY00Q6MPBXXZ \u003FA0xd56818f8\u002E__xc_ma_a;
  [FixedAddressValueType]
  internal static Progress.State \u003FInitializedNative\u0040CurrentDomain\u0040\u003CCrtImplementationDetails\u003E\u0040\u0040\u0024\u0024Q2W4State\u0040Progress\u00402\u0040A;
  internal static __FnPtr<void ()> \u003FA0xd56818f8\u002E\u003FInitializedNative\u0024initializer\u0024\u0040CurrentDomain\u0040\u003CCrtImplementationDetails\u003E\u0040\u0040\u0024\u0024Q2P6MXXZA;
  [FixedAddressValueType]
  internal static int \u003FInitialized\u0040CurrentDomain\u0040\u003CCrtImplementationDetails\u003E\u0040\u0040\u0024\u0024Q2HA;
  internal static __FnPtr<void ()> \u003FA0xd56818f8\u002E\u003FInitialized\u0024initializer\u0024\u0040CurrentDomain\u0040\u003CCrtImplementationDetails\u003E\u0040\u0040\u0024\u0024Q2P6MXXZA;
  internal static \u0024ArrayType\u0024\u0024\u0024BY00Q6MPBXXZ \u003FA0xd56818f8\u002E__xc_ma_z;
  [FixedAddressValueType]
  internal static Progress.State \u003FInitializedVtables\u0040CurrentDomain\u0040\u003CCrtImplementationDetails\u003E\u0040\u0040\u0024\u0024Q2W4State\u0040Progress\u00402\u0040A;
  internal static __FnPtr<void ()> \u003FA0xd56818f8\u002E\u003FInitializedVtables\u0024initializer\u0024\u0040CurrentDomain\u0040\u003CCrtImplementationDetails\u003E\u0040\u0040\u0024\u0024Q2P6MXXZA;
  internal static __s_GUID _GUID_cb2f6723_ab3a_11d2_9c40_00c04fa30a3e;
  internal static \u0024ArrayType\u0024\u0024\u0024BY00Q6MPBXXZ \u003FA0xd56818f8\u002E__xi_vt_z;
  [FixedAddressValueType]
  internal static Progress.State \u003FInitializedPerProcess\u0040CurrentDomain\u0040\u003CCrtImplementationDetails\u003E\u0040\u0040\u0024\u0024Q2W4State\u0040Progress\u00402\u0040A;
  internal static __FnPtr<void ()> \u003FA0xd56818f8\u002E\u003FInitializedPerProcess\u0024initializer\u0024\u0040CurrentDomain\u0040\u003CCrtImplementationDetails\u003E\u0040\u0040\u0024\u0024Q2P6MXXZA;
  internal static bool \u003FInitializedPerProcess\u0040DefaultDomain\u0040\u003CCrtImplementationDetails\u003E\u0040\u00402_NA;
  internal static bool \u003FEntered\u0040DefaultDomain\u0040\u003CCrtImplementationDetails\u003E\u0040\u00402_NA;
  internal static bool \u003FInitializedNative\u0040DefaultDomain\u0040\u003CCrtImplementationDetails\u003E\u0040\u00402_NA;
  internal static int \u003FCount\u0040AllDomains\u0040\u003CCrtImplementationDetails\u003E\u0040\u00402HA;
  internal static uint \u003FProcessAttach\u0040NativeDll\u0040\u003CCrtImplementationDetails\u003E\u0040\u00400IB;
  internal static uint \u003FThreadAttach\u0040NativeDll\u0040\u003CCrtImplementationDetails\u003E\u0040\u00400IB;
  internal static TriBool.State \u003FhasNative\u0040DefaultDomain\u0040\u003CCrtImplementationDetails\u003E\u0040\u00400W4State\u0040TriBool\u00402\u0040A;
  internal static uint \u003FProcessDetach\u0040NativeDll\u0040\u003CCrtImplementationDetails\u003E\u0040\u00400IB;
  internal static uint \u003FThreadDetach\u0040NativeDll\u0040\u003CCrtImplementationDetails\u003E\u0040\u00400IB;
  internal static uint \u003FProcessVerifier\u0040NativeDll\u0040\u003CCrtImplementationDetails\u003E\u0040\u00400IB;
  internal static TriBool.State \u003FhasPerProcess\u0040DefaultDomain\u0040\u003CCrtImplementationDetails\u003E\u0040\u00400W4State\u0040TriBool\u00402\u0040A;
  internal static bool \u003FInitializedNativeFromCCTOR\u0040DefaultDomain\u0040\u003CCrtImplementationDetails\u003E\u0040\u00402_NA;
  internal static \u0024ArrayType\u0024\u0024\u0024BY00Q6MPBXXZ \u003FA0xd56818f8\u002E__xc_mp_a;
  internal static __s_GUID _GUID_90f1a06c_7712_4762_86b5_7a5eba6bdb02;
  public static unsafe int** __unep\u0040\u003FDoNothing\u0040DefaultDomain\u0040\u003CCrtImplementationDetails\u003E\u0040\u0040\u0024\u0024FCGJPAX\u0040Z;
  public static unsafe int** __unep\u0040\u003F_UninitializeDefaultDomain\u0040LanguageSupport\u0040\u003CCrtImplementationDetails\u003E\u0040\u0040\u0024\u0024FCGJPAX\u0040Z;
  [FixedAddressValueType]
  internal static uint __exit_list_size_app_domain;
  [FixedAddressValueType]
  internal static unsafe __FnPtr<void ()>* __onexitbegin_app_domain;
  internal static uint \u003FA0xe11594df\u002E__exit_list_size;
  [FixedAddressValueType]
  internal static unsafe __FnPtr<void ()>* __onexitend_app_domain;
  internal static unsafe __FnPtr<void ()>* \u003FA0xe11594df\u002E__onexitbegin_m;
  internal static unsafe __FnPtr<void ()>* \u003FA0xe11594df\u002E__onexitend_m;
  [FixedAddressValueType]
  internal static unsafe void* \u003F_lock\u0040AtExitLock\u0040\u003CCrtImplementationDetails\u003E\u0040\u0040\u0024\u0024Q0PAXA;
  [FixedAddressValueType]
  internal static int \u003F_ref_count\u0040AtExitLock\u0040\u003CCrtImplementationDetails\u003E\u0040\u0040\u0024\u0024Q0HA;
  internal static \u0024ArrayType\u0024\u0024\u0024BY0A\u0040P6AXXZ __xc_z;
  internal static volatile uint __native_vcclrit_reason;
  internal static \u0024ArrayType\u0024\u0024\u0024BY0A\u0040P6AXXZ __xc_a;
  internal static \u0024ArrayType\u0024\u0024\u0024BY0A\u0040P6AHXZ __xi_a;
  internal static volatile __enative_startup_state __native_startup_state;
  internal static \u0024ArrayType\u0024\u0024\u0024BY0A\u0040P6AHXZ __xi_z;
  internal static volatile unsafe void* __native_startup_lock;
  internal static volatile uint __native_dllmain_reason;

  [DebuggerStepThrough]
  [SecurityCritical]
  static unsafe \u003CModule\u003E()
  {
    LanguageSupport languageSupport;
    \u003CModule\u003E.\u003CCrtImplementationDetails\u003E\u002ELanguageSupport\u002E\u007Bctor\u007D(&languageSupport);
    // ISSUE: fault handler
    try
    {
      \u003CModule\u003E.\u003CCrtImplementationDetails\u003E\u002ELanguageSupport\u002EInitialize(&languageSupport);
    }
    __fault
    {
      // ISSUE: method pointer
      // ISSUE: cast to a function pointer type
      \u003CModule\u003E.___CxxCallUnwindDtor((__FnPtr<void (void*)>) __methodptr(\u003CCrtImplementationDetails\u003E\u002ELanguageSupport\u002E\u007Bdtor\u007D), (void*) &languageSupport);
    }
    \u003CModule\u003E.\u003CCrtImplementationDetails\u003E\u002ELanguageSupport\u002E\u007Bdtor\u007D(&languageSupport);
  }

  [return: MarshalAs(UnmanagedType.U1)]
  internal static bool \u003CCrtImplementationDetails\u003E\u002ENativeDll\u002EIsInDllMain()
  {
    return (int) \u003CModule\u003E.__native_dllmain_reason != -1;
  }

  [return: MarshalAs(UnmanagedType.U1)]
  internal static bool \u003CCrtImplementationDetails\u003E\u002ENativeDll\u002EIsInProcessAttach()
  {
    return (int) \u003CModule\u003E.__native_dllmain_reason == 1;
  }

  [return: MarshalAs(UnmanagedType.U1)]
  internal static bool \u003CCrtImplementationDetails\u003E\u002ENativeDll\u002EIsInProcessDetach()
  {
    return (int) \u003CModule\u003E.__native_dllmain_reason == 0;
  }

  [return: MarshalAs(UnmanagedType.U1)]
  internal static bool \u003CCrtImplementationDetails\u003E\u002ENativeDll\u002EIsInVcclrit()
  {
    return (int) \u003CModule\u003E.__native_vcclrit_reason != -1;
  }

  [return: MarshalAs(UnmanagedType.U1)]
  internal static bool \u003CCrtImplementationDetails\u003E\u002ENativeDll\u002EIsSafeForManagedCode()
  {
    if (((int) \u003CModule\u003E.__native_dllmain_reason != -1 ? 1 : 0) == 0 || ((int) \u003CModule\u003E.__native_vcclrit_reason != -1 ? 1 : 0) != 0)
      return true;
    else
      return (int) \u003CModule\u003E.__native_dllmain_reason != 1 && (int) \u003CModule\u003E.__native_dllmain_reason != 0;
  }

  internal static void \u003CCrtImplementationDetails\u003E\u002EThrowNestedModuleLoadException(Exception innerException, Exception nestedException)
  {
    throw new ModuleLoadExceptionHandlerException("A nested exception occurred after the primary exception that caused the C++ module to fail to load.\n", innerException, nestedException);
  }

  internal static void \u003CCrtImplementationDetails\u003E\u002EThrowModuleLoadException(string errorMessage)
  {
    throw new ModuleLoadException(errorMessage);
  }

  internal static void \u003CCrtImplementationDetails\u003E\u002EThrowModuleLoadException(string errorMessage, Exception innerException)
  {
    throw new ModuleLoadException(errorMessage, innerException);
  }

  internal static void \u003CCrtImplementationDetails\u003E\u002ERegisterModuleUninitializer(EventHandler handler)
  {
    ModuleUninitializer._ModuleUninitializer.AddHandler(handler);
  }

  [SecuritySafeCritical]
  internal static unsafe Guid \u003CCrtImplementationDetails\u003E\u002EFromGUID(_GUID* guid)
  {
    return new Guid((uint) *(int*) guid, *(ushort*) ((IntPtr) guid + 4), *(ushort*) ((IntPtr) guid + 6), *(byte*) ((IntPtr) guid + 8), *(byte*) ((IntPtr) guid + 9), *(byte*) ((IntPtr) guid + 10), *(byte*) ((IntPtr) guid + 11), *(byte*) ((IntPtr) guid + 12), *(byte*) ((IntPtr) guid + 13), *(byte*) ((IntPtr) guid + 14), *(byte*) ((IntPtr) guid + 15));
  }

  [SecurityCritical]
  internal static unsafe int __get_default_appdomain(IUnknown** ppUnk)
  {
    ICorRuntimeHost* icorRuntimeHostPtr1 = (ICorRuntimeHost*) 0;
    int num1;
    try
    {
      Guid riid = \u003CModule\u003E.\u003CCrtImplementationDetails\u003E\u002EFromGUID((_GUID*) &\u003CModule\u003E._GUID_cb2f6722_ab3a_11d2_9c40_00c04fa30a3e);
      icorRuntimeHostPtr1 = (ICorRuntimeHost*) RuntimeEnvironment.GetRuntimeInterfaceAsIntPtr(\u003CModule\u003E.\u003CCrtImplementationDetails\u003E\u002EFromGUID((_GUID*) &\u003CModule\u003E._GUID_cb2f6723_ab3a_11d2_9c40_00c04fa30a3e), riid).ToPointer();
      goto label_4;
    }
    catch (Exception ex)
    {
      num1 = Marshal.GetHRForException(ex);
    }
    if (num1 < 0)
      goto label_5;
label_4:
    ICorRuntimeHost* icorRuntimeHostPtr2 = icorRuntimeHostPtr1;
    IUnknown** iunknownPtr = ppUnk;
    // ISSUE: cast to a function pointer type
    // ISSUE: function pointer call
    num1 = __calli((__FnPtr<int (IntPtr, IUnknown**)>) *(int*) (*(int*) icorRuntimeHostPtr1 + 52))((IUnknown**) icorRuntimeHostPtr2, (IntPtr) iunknownPtr);
    ICorRuntimeHost* icorRuntimeHostPtr3 = icorRuntimeHostPtr1;
    // ISSUE: cast to a function pointer type
    // ISSUE: function pointer call
    int num2 = (int) __calli((__FnPtr<uint (IntPtr)>) *(int*) (*(int*) icorRuntimeHostPtr3 + 8))((IntPtr) icorRuntimeHostPtr3);
label_5:
    return num1;
  }

  internal static unsafe void __release_appdomain(IUnknown* ppUnk)
  {
    IUnknown* iunknownPtr = ppUnk;
    // ISSUE: cast to a function pointer type
    // ISSUE: function pointer call
    int num = (int) __calli((__FnPtr<uint (IntPtr)>) *(int*) (*(int*) iunknownPtr + 8))((IntPtr) iunknownPtr);
  }

  [SecurityCritical]
  internal static unsafe AppDomain \u003CCrtImplementationDetails\u003E\u002EGetDefaultDomain()
  {
    IUnknown* ppUnk = (IUnknown*) 0;
    int defaultAppdomain = \u003CModule\u003E.__get_default_appdomain(&ppUnk);
    if (defaultAppdomain >= 0)
    {
      try
      {
        return (AppDomain) Marshal.GetObjectForIUnknown(new IntPtr((void*) ppUnk));
      }
      finally
      {
        \u003CModule\u003E.__release_appdomain(ppUnk);
      }
    }
    else
    {
      Marshal.ThrowExceptionForHR(defaultAppdomain);
      return (AppDomain) null;
    }
  }

  [SecurityCritical]
  internal static unsafe void \u003CCrtImplementationDetails\u003E\u002EDoCallBackInDefaultDomain(__FnPtr<int (void*)> function, void* cookie)
  {
    Guid riid = \u003CModule\u003E.\u003CCrtImplementationDetails\u003E\u002EFromGUID((_GUID*) &\u003CModule\u003E._GUID_90f1a06c_7712_4762_86b5_7a5eba6bdb02);
    ICLRRuntimeHost* iclrRuntimeHostPtr1 = (ICLRRuntimeHost*) RuntimeEnvironment.GetRuntimeInterfaceAsIntPtr(\u003CModule\u003E.\u003CCrtImplementationDetails\u003E\u002EFromGUID((_GUID*) &\u003CModule\u003E._GUID_90f1a06e_7712_4762_86b5_7a5eba6bdb02), riid).ToPointer();
    try
    {
      AppDomain defaultDomain = \u003CModule\u003E.\u003CCrtImplementationDetails\u003E\u002EGetDefaultDomain();
      // ISSUE: cast to a function pointer type
      // ISSUE: cast to a function pointer type
      // ISSUE: function pointer call
      int errorCode = __calli((__FnPtr<int (IntPtr, uint, __FnPtr<int (void*)>, void*)>) *(int*) (*(int*) iclrRuntimeHostPtr1 + 32))((void*) iclrRuntimeHostPtr1, (__FnPtr<int (void*)>) defaultDomain.Id, (uint) function, (IntPtr) cookie);
      if (errorCode >= 0)
        return;
      Marshal.ThrowExceptionForHR(errorCode);
    }
    finally
    {
      ICLRRuntimeHost* iclrRuntimeHostPtr2 = iclrRuntimeHostPtr1;
      // ISSUE: cast to a function pointer type
      // ISSUE: function pointer call
      int num = (int) __calli((__FnPtr<uint (IntPtr)>) *(int*) (*(int*) iclrRuntimeHostPtr2 + 8))((IntPtr) iclrRuntimeHostPtr2);
    }
  }

  [SecuritySafeCritical]
  internal static unsafe int \u003CCrtImplementationDetails\u003E\u002EDefaultDomain\u002EDoNothing(void* cookie)
  {
    GC.KeepAlive((object) int.MaxValue);
    return 0;
  }

  [SecuritySafeCritical]
  [return: MarshalAs(UnmanagedType.U1)]
  internal static unsafe bool \u003CCrtImplementationDetails\u003E\u002EDefaultDomain\u002EHasPerProcess()
  {
    if (\u003CModule\u003E.\u003FhasPerProcess\u0040DefaultDomain\u0040\u003CCrtImplementationDetails\u003E\u0040\u00400W4State\u0040TriBool\u00402\u0040A != (TriBool.State) 2)
      return \u003CModule\u003E.\u003FhasPerProcess\u0040DefaultDomain\u0040\u003CCrtImplementationDetails\u003E\u0040\u00400W4State\u0040TriBool\u00402\u0040A == (TriBool.State) -1;
    void** voidPtr = (void**) &\u003CModule\u003E.\u003FA0xd56818f8\u002E__xc_mp_a;
    // ISSUE: explicit reference operation
    // ISSUE: explicit reference operation
    if (@\u003CModule\u003E.\u003FA0xd56818f8\u002E__xc_mp_a < @\u003CModule\u003E.\u003FA0xd56818f8\u002E__xc_mp_z)
    {
      while (*(int*) voidPtr == 0)
      {
        voidPtr += 4;
        // ISSUE: explicit reference operation
        if ((IntPtr) voidPtr >= @\u003CModule\u003E.\u003FA0xd56818f8\u002E__xc_mp_z)
          goto label_5;
      }
      \u003CModule\u003E.\u003FhasPerProcess\u0040DefaultDomain\u0040\u003CCrtImplementationDetails\u003E\u0040\u00400W4State\u0040TriBool\u00402\u0040A = (TriBool.State) -1;
      return true;
    }
label_5:
    \u003CModule\u003E.\u003FhasPerProcess\u0040DefaultDomain\u0040\u003CCrtImplementationDetails\u003E\u0040\u00400W4State\u0040TriBool\u00402\u0040A = (TriBool.State) 0;
    return false;
  }

  [SecuritySafeCritical]
  [return: MarshalAs(UnmanagedType.U1)]
  internal static unsafe bool \u003CCrtImplementationDetails\u003E\u002EDefaultDomain\u002EHasNative()
  {
    if (\u003CModule\u003E.\u003FhasNative\u0040DefaultDomain\u0040\u003CCrtImplementationDetails\u003E\u0040\u00400W4State\u0040TriBool\u00402\u0040A != (TriBool.State) 2)
      return \u003CModule\u003E.\u003FhasNative\u0040DefaultDomain\u0040\u003CCrtImplementationDetails\u003E\u0040\u00400W4State\u0040TriBool\u00402\u0040A == (TriBool.State) -1;
    void** voidPtr1 = (void**) &\u003CModule\u003E.__xi_a;
    // ISSUE: explicit reference operation
    // ISSUE: explicit reference operation
    if (@\u003CModule\u003E.__xi_a < @\u003CModule\u003E.__xi_z)
    {
      while (*(int*) voidPtr1 == 0)
      {
        voidPtr1 += 4;
        // ISSUE: explicit reference operation
        if ((IntPtr) voidPtr1 >= @\u003CModule\u003E.__xi_z)
          goto label_5;
      }
      \u003CModule\u003E.\u003FhasNative\u0040DefaultDomain\u0040\u003CCrtImplementationDetails\u003E\u0040\u00400W4State\u0040TriBool\u00402\u0040A = (TriBool.State) -1;
      return true;
    }
label_5:
    void** voidPtr2 = (void**) &\u003CModule\u003E.__xc_a;
    // ISSUE: explicit reference operation
    // ISSUE: explicit reference operation
    if (@\u003CModule\u003E.__xc_a < @\u003CModule\u003E.__xc_z)
    {
      while (*(int*) voidPtr2 == 0)
      {
        voidPtr2 += 4;
        // ISSUE: explicit reference operation
        if ((IntPtr) voidPtr2 >= @\u003CModule\u003E.__xc_z)
          goto label_9;
      }
      \u003CModule\u003E.\u003FhasNative\u0040DefaultDomain\u0040\u003CCrtImplementationDetails\u003E\u0040\u00400W4State\u0040TriBool\u00402\u0040A = (TriBool.State) -1;
      return true;
    }
label_9:
    \u003CModule\u003E.\u003FhasNative\u0040DefaultDomain\u0040\u003CCrtImplementationDetails\u003E\u0040\u00400W4State\u0040TriBool\u00402\u0040A = (TriBool.State) 0;
    return false;
  }

  [SecuritySafeCritical]
  [return: MarshalAs(UnmanagedType.U1)]
  internal static bool \u003CCrtImplementationDetails\u003E\u002EDefaultDomain\u002ENeedsInitialization()
  {
    return \u003CModule\u003E.\u003CCrtImplementationDetails\u003E\u002EDefaultDomain\u002EHasPerProcess() && !\u003CModule\u003E.\u003FInitializedPerProcess\u0040DefaultDomain\u0040\u003CCrtImplementationDetails\u003E\u0040\u00402_NA || \u003CModule\u003E.\u003CCrtImplementationDetails\u003E\u002EDefaultDomain\u002EHasNative() && !\u003CModule\u003E.\u003FInitializedNative\u0040DefaultDomain\u0040\u003CCrtImplementationDetails\u003E\u0040\u00402_NA && \u003CModule\u003E.__native_startup_state == (__enative_startup_state) 0;
  }

  [return: MarshalAs(UnmanagedType.U1)]
  internal static bool \u003CCrtImplementationDetails\u003E\u002EDefaultDomain\u002ENeedsUninitialization()
  {
    return \u003CModule\u003E.\u003FEntered\u0040DefaultDomain\u0040\u003CCrtImplementationDetails\u003E\u0040\u00402_NA;
  }

  [SecurityCritical]
  internal static unsafe void \u003CCrtImplementationDetails\u003E\u002EDefaultDomain\u002EInitialize()
  {
    // ISSUE: cast to a function pointer type
    \u003CModule\u003E.\u003CCrtImplementationDetails\u003E\u002EDoCallBackInDefaultDomain((__FnPtr<int (void*)>) (IntPtr) \u003CModule\u003E.__unep\u0040\u003FDoNothing\u0040DefaultDomain\u0040\u003CCrtImplementationDetails\u003E\u0040\u0040\u0024\u0024FCGJPAX\u0040Z, (void*) 0);
  }

  internal static void \u003FA0xd56818f8\u002E\u003F\u003F__E\u003FInitialized\u0040CurrentDomain\u0040\u003CCrtImplementationDetails\u003E\u0040\u0040\u0024\u0024Q2HA\u0040\u0040YMXXZ()
  {
    \u003CModule\u003E.\u003FInitialized\u0040CurrentDomain\u0040\u003CCrtImplementationDetails\u003E\u0040\u0040\u0024\u0024Q2HA = 0;
  }

  internal static void \u003FA0xd56818f8\u002E\u003F\u003F__E\u003FUninitialized\u0040CurrentDomain\u0040\u003CCrtImplementationDetails\u003E\u0040\u0040\u0024\u0024Q2HA\u0040\u0040YMXXZ()
  {
    \u003CModule\u003E.\u003FUninitialized\u0040CurrentDomain\u0040\u003CCrtImplementationDetails\u003E\u0040\u0040\u0024\u0024Q2HA = 0;
  }

  internal static void \u003FA0xd56818f8\u002E\u003F\u003F__E\u003FIsDefaultDomain\u0040CurrentDomain\u0040\u003CCrtImplementationDetails\u003E\u0040\u0040\u0024\u0024Q2_NA\u0040\u0040YMXXZ()
  {
    \u003CModule\u003E.\u003FIsDefaultDomain\u0040CurrentDomain\u0040\u003CCrtImplementationDetails\u003E\u0040\u0040\u0024\u0024Q2_NA = false;
  }

  internal static void \u003FA0xd56818f8\u002E\u003F\u003F__E\u003FInitializedVtables\u0040CurrentDomain\u0040\u003CCrtImplementationDetails\u003E\u0040\u0040\u0024\u0024Q2W4State\u0040Progress\u00402\u0040A\u0040\u0040YMXXZ()
  {
    \u003CModule\u003E.\u003FInitializedVtables\u0040CurrentDomain\u0040\u003CCrtImplementationDetails\u003E\u0040\u0040\u0024\u0024Q2W4State\u0040Progress\u00402\u0040A = (Progress.State) 0;
  }

  internal static void \u003FA0xd56818f8\u002E\u003F\u003F__E\u003FInitializedNative\u0040CurrentDomain\u0040\u003CCrtImplementationDetails\u003E\u0040\u0040\u0024\u0024Q2W4State\u0040Progress\u00402\u0040A\u0040\u0040YMXXZ()
  {
    \u003CModule\u003E.\u003FInitializedNative\u0040CurrentDomain\u0040\u003CCrtImplementationDetails\u003E\u0040\u0040\u0024\u0024Q2W4State\u0040Progress\u00402\u0040A = (Progress.State) 0;
  }

  internal static void \u003FA0xd56818f8\u002E\u003F\u003F__E\u003FInitializedPerProcess\u0040CurrentDomain\u0040\u003CCrtImplementationDetails\u003E\u0040\u0040\u0024\u0024Q2W4State\u0040Progress\u00402\u0040A\u0040\u0040YMXXZ()
  {
    \u003CModule\u003E.\u003FInitializedPerProcess\u0040CurrentDomain\u0040\u003CCrtImplementationDetails\u003E\u0040\u0040\u0024\u0024Q2W4State\u0040Progress\u00402\u0040A = (Progress.State) 0;
  }

  internal static void \u003FA0xd56818f8\u002E\u003F\u003F__E\u003FInitializedPerAppDomain\u0040CurrentDomain\u0040\u003CCrtImplementationDetails\u003E\u0040\u0040\u0024\u0024Q2W4State\u0040Progress\u00402\u0040A\u0040\u0040YMXXZ()
  {
    \u003CModule\u003E.\u003FInitializedPerAppDomain\u0040CurrentDomain\u0040\u003CCrtImplementationDetails\u003E\u0040\u0040\u0024\u0024Q2W4State\u0040Progress\u00402\u0040A = (Progress.State) 0;
  }

  [DebuggerStepThrough]
  [SecurityCritical]
  internal static unsafe void \u003CCrtImplementationDetails\u003E\u002ELanguageSupport\u002EInitializeVtables([In] LanguageSupport* obj0)
  {
    \u003CModule\u003E.gcroot\u003CSystem\u003A\u003AString\u0020\u005E\u003E\u002E\u003D((gcroot\u003CSystem\u003A\u003AString\u0020\u005E\u003E*) obj0, "The C++ module failed to load during vtable initialization.\n");
    \u003CModule\u003E.\u003FInitializedVtables\u0040CurrentDomain\u0040\u003CCrtImplementationDetails\u003E\u0040\u0040\u0024\u0024Q2W4State\u0040Progress\u00402\u0040A = (Progress.State) 1;
    \u003CModule\u003E._initterm_m((__FnPtr<void* ()>*) &\u003CModule\u003E.\u003FA0xd56818f8\u002E__xi_vt_a, (__FnPtr<void* ()>*) &\u003CModule\u003E.\u003FA0xd56818f8\u002E__xi_vt_z);
    \u003CModule\u003E.\u003FInitializedVtables\u0040CurrentDomain\u0040\u003CCrtImplementationDetails\u003E\u0040\u0040\u0024\u0024Q2W4State\u0040Progress\u00402\u0040A = (Progress.State) 2;
  }

  [SecurityCritical]
  internal static unsafe void \u003CCrtImplementationDetails\u003E\u002ELanguageSupport\u002EInitializeDefaultAppDomain([In] LanguageSupport* obj0)
  {
    \u003CModule\u003E.gcroot\u003CSystem\u003A\u003AString\u0020\u005E\u003E\u002E\u003D((gcroot\u003CSystem\u003A\u003AString\u0020\u005E\u003E*) obj0, "The C++ module failed to load while attempting to initialize the default appdomain.\n");
    \u003CModule\u003E.\u003CCrtImplementationDetails\u003E\u002EDefaultDomain\u002EInitialize();
  }

  [SecurityCritical]
  [DebuggerStepThrough]
  internal static unsafe void \u003CCrtImplementationDetails\u003E\u002ELanguageSupport\u002EInitializeNative([In] LanguageSupport* obj0)
  {
    \u003CModule\u003E.gcroot\u003CSystem\u003A\u003AString\u0020\u005E\u003E\u002E\u003D((gcroot\u003CSystem\u003A\u003AString\u0020\u005E\u003E*) obj0, "The C++ module failed to load during native initialization.\n");
    \u003CModule\u003E.__security_init_cookie();
    \u003CModule\u003E.\u003FInitializedNative\u0040DefaultDomain\u0040\u003CCrtImplementationDetails\u003E\u0040\u00402_NA = true;
    if (!\u003CModule\u003E.\u003CCrtImplementationDetails\u003E\u002ENativeDll\u002EIsSafeForManagedCode())
      \u003CModule\u003E._amsg_exit(33);
    if (\u003CModule\u003E.__native_startup_state == (__enative_startup_state) 1)
    {
      \u003CModule\u003E._amsg_exit(33);
    }
    else
    {
      if (\u003CModule\u003E.__native_startup_state != (__enative_startup_state) 0)
        return;
      \u003CModule\u003E.\u003FInitializedNative\u0040CurrentDomain\u0040\u003CCrtImplementationDetails\u003E\u0040\u0040\u0024\u0024Q2W4State\u0040Progress\u00402\u0040A = (Progress.State) 1;
      \u003CModule\u003E.__native_startup_state = (__enative_startup_state) 1;
      if (\u003CModule\u003E._initterm_e((__FnPtr<int ()>*) &\u003CModule\u003E.__xi_a, (__FnPtr<int ()>*) &\u003CModule\u003E.__xi_z) != 0)
        \u003CModule\u003E.\u003CCrtImplementationDetails\u003E\u002EThrowModuleLoadException(\u003CModule\u003E.gcroot\u003CSystem\u003A\u003AString\u0020\u005E\u003E\u002E\u002EP\u0024AAVString\u0040System\u0040\u0040((gcroot\u003CSystem\u003A\u003AString\u0020\u005E\u003E*) obj0));
      \u003CModule\u003E._initterm((__FnPtr<void ()>*) &\u003CModule\u003E.__xc_a, (__FnPtr<void ()>*) &\u003CModule\u003E.__xc_z);
      \u003CModule\u003E.__native_startup_state = (__enative_startup_state) 2;
      \u003CModule\u003E.\u003FInitializedNativeFromCCTOR\u0040DefaultDomain\u0040\u003CCrtImplementationDetails\u003E\u0040\u00402_NA = true;
      \u003CModule\u003E.\u003FInitializedNative\u0040CurrentDomain\u0040\u003CCrtImplementationDetails\u003E\u0040\u0040\u0024\u0024Q2W4State\u0040Progress\u00402\u0040A = (Progress.State) 2;
    }
  }

  [DebuggerStepThrough]
  [SecurityCritical]
  internal static unsafe void \u003CCrtImplementationDetails\u003E\u002ELanguageSupport\u002EInitializePerProcess([In] LanguageSupport* obj0)
  {
    \u003CModule\u003E.gcroot\u003CSystem\u003A\u003AString\u0020\u005E\u003E\u002E\u003D((gcroot\u003CSystem\u003A\u003AString\u0020\u005E\u003E*) obj0, "The C++ module failed to load during process initialization.\n");
    \u003CModule\u003E.\u003FInitializedPerProcess\u0040CurrentDomain\u0040\u003CCrtImplementationDetails\u003E\u0040\u0040\u0024\u0024Q2W4State\u0040Progress\u00402\u0040A = (Progress.State) 1;
    \u003CModule\u003E._initatexit_m();
    \u003CModule\u003E._initterm_m((__FnPtr<void* ()>*) &\u003CModule\u003E.\u003FA0xd56818f8\u002E__xc_mp_a, (__FnPtr<void* ()>*) &\u003CModule\u003E.\u003FA0xd56818f8\u002E__xc_mp_z);
    \u003CModule\u003E.\u003FInitializedPerProcess\u0040CurrentDomain\u0040\u003CCrtImplementationDetails\u003E\u0040\u0040\u0024\u0024Q2W4State\u0040Progress\u00402\u0040A = (Progress.State) 2;
    \u003CModule\u003E.\u003FInitializedPerProcess\u0040DefaultDomain\u0040\u003CCrtImplementationDetails\u003E\u0040\u00402_NA = true;
  }

  [DebuggerStepThrough]
  [SecurityCritical]
  internal static unsafe void \u003CCrtImplementationDetails\u003E\u002ELanguageSupport\u002EInitializePerAppDomain([In] LanguageSupport* obj0)
  {
    \u003CModule\u003E.gcroot\u003CSystem\u003A\u003AString\u0020\u005E\u003E\u002E\u003D((gcroot\u003CSystem\u003A\u003AString\u0020\u005E\u003E*) obj0, "The C++ module failed to load during appdomain initialization.\n");
    \u003CModule\u003E.\u003FInitializedPerAppDomain\u0040CurrentDomain\u0040\u003CCrtImplementationDetails\u003E\u0040\u0040\u0024\u0024Q2W4State\u0040Progress\u00402\u0040A = (Progress.State) 1;
    \u003CModule\u003E._initatexit_app_domain();
    \u003CModule\u003E._initterm_m((__FnPtr<void* ()>*) &\u003CModule\u003E.\u003FA0xd56818f8\u002E__xc_ma_a, (__FnPtr<void* ()>*) &\u003CModule\u003E.\u003FA0xd56818f8\u002E__xc_ma_z);
    \u003CModule\u003E.\u003FInitializedPerAppDomain\u0040CurrentDomain\u0040\u003CCrtImplementationDetails\u003E\u0040\u0040\u0024\u0024Q2W4State\u0040Progress\u00402\u0040A = (Progress.State) 2;
  }

  [DebuggerStepThrough]
  [SecurityCritical]
  internal static unsafe void \u003CCrtImplementationDetails\u003E\u002ELanguageSupport\u002EInitializeUninitializer([In] LanguageSupport* obj0)
  {
    \u003CModule\u003E.gcroot\u003CSystem\u003A\u003AString\u0020\u005E\u003E\u002E\u003D((gcroot\u003CSystem\u003A\u003AString\u0020\u005E\u003E*) obj0, "The C++ module failed to load during registration for the unload events.\n");
    \u003CModule\u003E.\u003CCrtImplementationDetails\u003E\u002ERegisterModuleUninitializer(new EventHandler(\u003CModule\u003E.\u003CCrtImplementationDetails\u003E\u002ELanguageSupport\u002EDomainUnload));
  }

  [SecurityCritical]
  [DebuggerStepThrough]
  [ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
  internal static unsafe void \u003CCrtImplementationDetails\u003E\u002ELanguageSupport\u002E_Initialize([In] LanguageSupport* obj0)
  {
    \u003CModule\u003E.\u003FIsDefaultDomain\u0040CurrentDomain\u0040\u003CCrtImplementationDetails\u003E\u0040\u0040\u0024\u0024Q2_NA = AppDomain.CurrentDomain.IsDefaultAppDomain();
    if (\u003CModule\u003E.\u003FIsDefaultDomain\u0040CurrentDomain\u0040\u003CCrtImplementationDetails\u003E\u0040\u0040\u0024\u0024Q2_NA)
      \u003CModule\u003E.\u003FEntered\u0040DefaultDomain\u0040\u003CCrtImplementationDetails\u003E\u0040\u00402_NA = true;
    void* fiberPtrId = \u003CModule\u003E._getFiberPtrId();
    int num1 = 0;
    int num2 = 0;
    int num3 = 0;
    RuntimeHelpers.PrepareConstrainedRegions();
    try
    {
      while (num2 == 0)
      {
        try
        {
        }
        finally
        {
          IntPtr comparand = (IntPtr) 0;
          IntPtr num4 = (IntPtr) fiberPtrId;
          // ISSUE: explicit reference operation
          // ISSUE: cast to a reference type
          void* voidPtr = (void*) Interlocked.CompareExchange((IntPtr&) @\u003CModule\u003E.__native_startup_lock, num4, comparand);
          if ((IntPtr) voidPtr == IntPtr.Zero)
            num2 = 1;
          else if (voidPtr == fiberPtrId)
          {
            num1 = 1;
            num2 = 1;
          }
        }
        if (num2 == 0)
          \u003CModule\u003E.Sleep(1000U);
      }
      \u003CModule\u003E.\u003CCrtImplementationDetails\u003E\u002ELanguageSupport\u002EInitializeVtables(obj0);
      if (\u003CModule\u003E.\u003FIsDefaultDomain\u0040CurrentDomain\u0040\u003CCrtImplementationDetails\u003E\u0040\u0040\u0024\u0024Q2_NA)
      {
        \u003CModule\u003E.\u003CCrtImplementationDetails\u003E\u002ELanguageSupport\u002EInitializeNative(obj0);
        \u003CModule\u003E.\u003CCrtImplementationDetails\u003E\u002ELanguageSupport\u002EInitializePerProcess(obj0);
      }
      else if (\u003CModule\u003E.\u003CCrtImplementationDetails\u003E\u002EDefaultDomain\u002ENeedsInitialization())
        num3 = 1;
    }
    finally
    {
      if (num1 == 0)
      {
        IntPtr num4 = (IntPtr) 0;
        // ISSUE: explicit reference operation
        // ISSUE: cast to a reference type
        Interlocked.Exchange((IntPtr&) @\u003CModule\u003E.__native_startup_lock, num4);
      }
    }
    if (num3 != 0)
      \u003CModule\u003E.\u003CCrtImplementationDetails\u003E\u002ELanguageSupport\u002EInitializeDefaultAppDomain(obj0);
    \u003CModule\u003E.\u003CCrtImplementationDetails\u003E\u002ELanguageSupport\u002EInitializePerAppDomain(obj0);
    \u003CModule\u003E.\u003FInitialized\u0040CurrentDomain\u0040\u003CCrtImplementationDetails\u003E\u0040\u0040\u0024\u0024Q2HA = 1;
    \u003CModule\u003E.\u003CCrtImplementationDetails\u003E\u002ELanguageSupport\u002EInitializeUninitializer(obj0);
  }

  [SecurityCritical]
  internal static void \u003CCrtImplementationDetails\u003E\u002ELanguageSupport\u002EUninitializeAppDomain()
  {
    \u003CModule\u003E._app_exit_callback();
  }

  [SecurityCritical]
  internal static unsafe int \u003CCrtImplementationDetails\u003E\u002ELanguageSupport\u002E_UninitializeDefaultDomain(void* cookie)
  {
    \u003CModule\u003E._exit_callback();
    \u003CModule\u003E.\u003FInitializedPerProcess\u0040DefaultDomain\u0040\u003CCrtImplementationDetails\u003E\u0040\u00402_NA = false;
    if (\u003CModule\u003E.\u003FInitializedNativeFromCCTOR\u0040DefaultDomain\u0040\u003CCrtImplementationDetails\u003E\u0040\u00402_NA)
    {
      \u003CModule\u003E._cexit();
      \u003CModule\u003E.__native_startup_state = (__enative_startup_state) 0;
      \u003CModule\u003E.\u003FInitializedNativeFromCCTOR\u0040DefaultDomain\u0040\u003CCrtImplementationDetails\u003E\u0040\u00402_NA = false;
    }
    \u003CModule\u003E.\u003FInitializedNative\u0040DefaultDomain\u0040\u003CCrtImplementationDetails\u003E\u0040\u00402_NA = false;
    return 0;
  }

  [SecurityCritical]
  internal static unsafe void \u003CCrtImplementationDetails\u003E\u002ELanguageSupport\u002EUninitializeDefaultDomain()
  {
    if (!\u003CModule\u003E.\u003CCrtImplementationDetails\u003E\u002EDefaultDomain\u002ENeedsUninitialization())
      return;
    if (AppDomain.CurrentDomain.IsDefaultAppDomain())
    {
      \u003CModule\u003E.\u003CCrtImplementationDetails\u003E\u002ELanguageSupport\u002E_UninitializeDefaultDomain((void*) 0);
    }
    else
    {
      // ISSUE: cast to a function pointer type
      \u003CModule\u003E.\u003CCrtImplementationDetails\u003E\u002EDoCallBackInDefaultDomain((__FnPtr<int (void*)>) (IntPtr) \u003CModule\u003E.__unep\u0040\u003F_UninitializeDefaultDomain\u0040LanguageSupport\u0040\u003CCrtImplementationDetails\u003E\u0040\u0040\u0024\u0024FCGJPAX\u0040Z, (void*) 0);
    }
  }

  [ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
  [SecurityCritical]
  [PrePrepareMethod]
  internal static void \u003CCrtImplementationDetails\u003E\u002ELanguageSupport\u002EDomainUnload(object source, EventArgs arguments)
  {
    if (\u003CModule\u003E.\u003FInitialized\u0040CurrentDomain\u0040\u003CCrtImplementationDetails\u003E\u0040\u0040\u0024\u0024Q2HA == 0 || Interlocked.Exchange(ref \u003CModule\u003E.\u003FUninitialized\u0040CurrentDomain\u0040\u003CCrtImplementationDetails\u003E\u0040\u0040\u0024\u0024Q2HA, 1) != 0)
      return;
    int num = Interlocked.Decrement(ref \u003CModule\u003E.\u003FCount\u0040AllDomains\u0040\u003CCrtImplementationDetails\u003E\u0040\u00402HA) == 0 ? 1 : 0;
    \u003CModule\u003E.\u003CCrtImplementationDetails\u003E\u002ELanguageSupport\u002EUninitializeAppDomain();
    if ((int) (byte) num == 0)
      return;
    \u003CModule\u003E.\u003CCrtImplementationDetails\u003E\u002ELanguageSupport\u002EUninitializeDefaultDomain();
  }

  [SecurityCritical]
  [DebuggerStepThrough]
  [ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
  internal static unsafe void \u003CCrtImplementationDetails\u003E\u002ELanguageSupport\u002ECleanup([In] LanguageSupport* obj0, Exception innerException)
  {
    try
    {
      bool flag = Interlocked.Decrement(ref \u003CModule\u003E.\u003FCount\u0040AllDomains\u0040\u003CCrtImplementationDetails\u003E\u0040\u00402HA) == 0;
      \u003CModule\u003E.\u003CCrtImplementationDetails\u003E\u002ELanguageSupport\u002EUninitializeAppDomain();
      if (!flag)
        return;
      \u003CModule\u003E.\u003CCrtImplementationDetails\u003E\u002ELanguageSupport\u002EUninitializeDefaultDomain();
    }
    catch (Exception ex)
    {
      \u003CModule\u003E.\u003CCrtImplementationDetails\u003E\u002EThrowNestedModuleLoadException(innerException, ex);
    }
    catch
    {
      \u003CModule\u003E.\u003CCrtImplementationDetails\u003E\u002EThrowNestedModuleLoadException(innerException, (Exception) null);
    }
  }

  [SecurityCritical]
  internal static unsafe LanguageSupport* \u003CCrtImplementationDetails\u003E\u002ELanguageSupport\u002E\u007Bctor\u007D([In] LanguageSupport* obj0)
  {
    \u003CModule\u003E.gcroot\u003CSystem\u003A\u003AString\u0020\u005E\u003E\u002E\u007Bctor\u007D((gcroot\u003CSystem\u003A\u003AString\u0020\u005E\u003E*) obj0);
    return obj0;
  }

  [SecurityCritical]
  internal static unsafe void \u003CCrtImplementationDetails\u003E\u002ELanguageSupport\u002E\u007Bdtor\u007D([In] LanguageSupport* obj0)
  {
    \u003CModule\u003E.gcroot\u003CSystem\u003A\u003AString\u0020\u005E\u003E\u002E\u007Bdtor\u007D((gcroot\u003CSystem\u003A\u003AString\u0020\u005E\u003E*) obj0);
  }

  [DebuggerStepThrough]
  [ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
  [SecurityCritical]
  internal static unsafe void \u003CCrtImplementationDetails\u003E\u002ELanguageSupport\u002EInitialize([In] LanguageSupport* obj0)
  {
    bool flag = false;
    RuntimeHelpers.PrepareConstrainedRegions();
    try
    {
      \u003CModule\u003E.gcroot\u003CSystem\u003A\u003AString\u0020\u005E\u003E\u002E\u003D((gcroot\u003CSystem\u003A\u003AString\u0020\u005E\u003E*) obj0, "The C++ module failed to load.\n");
      RuntimeHelpers.PrepareConstrainedRegions();
      try
      {
      }
      finally
      {
        Interlocked.Increment(ref \u003CModule\u003E.\u003FCount\u0040AllDomains\u0040\u003CCrtImplementationDetails\u003E\u0040\u00402HA);
        flag = true;
      }
      \u003CModule\u003E.\u003CCrtImplementationDetails\u003E\u002ELanguageSupport\u002E_Initialize(obj0);
    }
    catch (Exception ex)
    {
      if (flag)
        \u003CModule\u003E.\u003CCrtImplementationDetails\u003E\u002ELanguageSupport\u002ECleanup(obj0, ex);
      \u003CModule\u003E.\u003CCrtImplementationDetails\u003E\u002EThrowModuleLoadException(\u003CModule\u003E.gcroot\u003CSystem\u003A\u003AString\u0020\u005E\u003E\u002E\u002EP\u0024AAVString\u0040System\u0040\u0040((gcroot\u003CSystem\u003A\u003AString\u0020\u005E\u003E*) obj0), ex);
    }
    catch
    {
      if (flag)
        \u003CModule\u003E.\u003CCrtImplementationDetails\u003E\u002ELanguageSupport\u002ECleanup(obj0, (Exception) null);
      \u003CModule\u003E.\u003CCrtImplementationDetails\u003E\u002EThrowModuleLoadException(\u003CModule\u003E.gcroot\u003CSystem\u003A\u003AString\u0020\u005E\u003E\u002E\u002EP\u0024AAVString\u0040System\u0040\u0040((gcroot\u003CSystem\u003A\u003AString\u0020\u005E\u003E*) obj0), (Exception) null);
    }
  }

  [SecuritySafeCritical]
  [DebuggerStepThrough]
  internal static unsafe gcroot\u003CSystem\u003A\u003AString\u0020\u005E\u003E* gcroot\u003CSystem\u003A\u003AString\u0020\u005E\u003E\u002E\u007Bctor\u007D([In] gcroot\u003CSystem\u003A\u003AString\u0020\u005E\u003E* obj0)
  {
    IntPtr num = (IntPtr) GCHandle.Alloc((object) null);
    *(int*) obj0 = (int) num.ToPointer();
    return obj0;
  }

  [DebuggerStepThrough]
  [SecurityCritical]
  internal static unsafe void gcroot\u003CSystem\u003A\u003AString\u0020\u005E\u003E\u002E\u007Bdtor\u007D([In] gcroot\u003CSystem\u003A\u003AString\u0020\u005E\u003E* obj0)
  {
    (GCHandle) new IntPtr((void*) *(int*) obj0).Free();
    *(int*) obj0 = 0;
  }

  [DebuggerStepThrough]
  [SecurityCritical]
  internal static unsafe gcroot\u003CSystem\u003A\u003AString\u0020\u005E\u003E* gcroot\u003CSystem\u003A\u003AString\u0020\u005E\u003E\u002E\u003D([In] gcroot\u003CSystem\u003A\u003AString\u0020\u005E\u003E* obj0, string t)
  {
    (GCHandle) new IntPtr((void*) *(int*) obj0).Target = (object) t;
    return obj0;
  }

  [SecuritySafeCritical]
  internal static unsafe string gcroot\u003CSystem\u003A\u003AString\u0020\u005E\u003E\u002E\u002EP\u0024AAVString\u0040System\u0040\u0040([In] gcroot\u003CSystem\u003A\u003AString\u0020\u005E\u003E* obj0)
  {
    return (string) (GCHandle) new IntPtr((void*) *(int*) obj0).Target;
  }

  [SecurityCritical]
  [DebuggerStepThrough]
  internal static unsafe ValueType \u003CCrtImplementationDetails\u003E\u002EAtExitLock\u002E_handle()
  {
    if ((IntPtr) \u003CModule\u003E.\u003F_lock\u0040AtExitLock\u0040\u003CCrtImplementationDetails\u003E\u0040\u0040\u0024\u0024Q0PAXA != IntPtr.Zero)
      return (ValueType) GCHandle.FromIntPtr(new IntPtr(\u003CModule\u003E.\u003F_lock\u0040AtExitLock\u0040\u003CCrtImplementationDetails\u003E\u0040\u0040\u0024\u0024Q0PAXA));
    else
      return (ValueType) null;
  }

  [SecurityCritical]
  [DebuggerStepThrough]
  internal static unsafe void \u003CCrtImplementationDetails\u003E\u002EAtExitLock\u002E_lock_Construct(object value)
  {
    \u003CModule\u003E.\u003F_lock\u0040AtExitLock\u0040\u003CCrtImplementationDetails\u003E\u0040\u0040\u0024\u0024Q0PAXA = (void*) 0;
    \u003CModule\u003E.\u003CCrtImplementationDetails\u003E\u002EAtExitLock\u002E_lock_Set(value);
  }

  [DebuggerStepThrough]
  [SecurityCritical]
  internal static unsafe void \u003CCrtImplementationDetails\u003E\u002EAtExitLock\u002E_lock_Set(object value)
  {
    ValueType valueType = \u003CModule\u003E.\u003CCrtImplementationDetails\u003E\u002EAtExitLock\u002E_handle();
    if (valueType == null)
      \u003CModule\u003E.\u003F_lock\u0040AtExitLock\u0040\u003CCrtImplementationDetails\u003E\u0040\u0040\u0024\u0024Q0PAXA = GCHandle.ToIntPtr(GCHandle.Alloc(value)).ToPointer();
    else
      ((GCHandle) valueType).Target = value;
  }

  [DebuggerStepThrough]
  [SecurityCritical]
  internal static object \u003CCrtImplementationDetails\u003E\u002EAtExitLock\u002E_lock_Get()
  {
    ValueType valueType = \u003CModule\u003E.\u003CCrtImplementationDetails\u003E\u002EAtExitLock\u002E_handle();
    if (valueType != null)
      return ((GCHandle) valueType).Target;
    else
      return (object) null;
  }

  [DebuggerStepThrough]
  [SecurityCritical]
  internal static unsafe void \u003CCrtImplementationDetails\u003E\u002EAtExitLock\u002E_lock_Destruct()
  {
    ValueType valueType = \u003CModule\u003E.\u003CCrtImplementationDetails\u003E\u002EAtExitLock\u002E_handle();
    if (valueType == null)
      return;
    ((GCHandle) valueType).Free();
    \u003CModule\u003E.\u003F_lock\u0040AtExitLock\u0040\u003CCrtImplementationDetails\u003E\u0040\u0040\u0024\u0024Q0PAXA = (void*) 0;
  }

  [SecuritySafeCritical]
  [DebuggerStepThrough]
  [return: MarshalAs(UnmanagedType.U1)]
  internal static bool \u003CCrtImplementationDetails\u003E\u002EAtExitLock\u002EIsInitialized()
  {
    return \u003CModule\u003E.\u003CCrtImplementationDetails\u003E\u002EAtExitLock\u002E_lock_Get() != null;
  }

  [SecurityCritical]
  [DebuggerStepThrough]
  internal static void \u003CCrtImplementationDetails\u003E\u002EAtExitLock\u002EAddRef()
  {
    if (!\u003CModule\u003E.\u003CCrtImplementationDetails\u003E\u002EAtExitLock\u002EIsInitialized())
    {
      \u003CModule\u003E.\u003CCrtImplementationDetails\u003E\u002EAtExitLock\u002E_lock_Construct(new object());
      \u003CModule\u003E.\u003F_ref_count\u0040AtExitLock\u0040\u003CCrtImplementationDetails\u003E\u0040\u0040\u0024\u0024Q0HA = 0;
    }
    ++\u003CModule\u003E.\u003F_ref_count\u0040AtExitLock\u0040\u003CCrtImplementationDetails\u003E\u0040\u0040\u0024\u0024Q0HA;
  }

  [SecurityCritical]
  [DebuggerStepThrough]
  internal static void \u003CCrtImplementationDetails\u003E\u002EAtExitLock\u002ERemoveRef()
  {
    --\u003CModule\u003E.\u003F_ref_count\u0040AtExitLock\u0040\u003CCrtImplementationDetails\u003E\u0040\u0040\u0024\u0024Q0HA;
    if (\u003CModule\u003E.\u003F_ref_count\u0040AtExitLock\u0040\u003CCrtImplementationDetails\u003E\u0040\u0040\u0024\u0024Q0HA != 0)
      return;
    \u003CModule\u003E.\u003CCrtImplementationDetails\u003E\u002EAtExitLock\u002E_lock_Destruct();
  }

  [SecurityCritical]
  [DebuggerStepThrough]
  internal static void \u003CCrtImplementationDetails\u003E\u002EAtExitLock\u002EEnter()
  {
    Monitor.Enter(\u003CModule\u003E.\u003CCrtImplementationDetails\u003E\u002EAtExitLock\u002E_lock_Get());
  }

  [SecurityCritical]
  [DebuggerStepThrough]
  internal static void \u003CCrtImplementationDetails\u003E\u002EAtExitLock\u002EExit()
  {
    Monitor.Exit(\u003CModule\u003E.\u003CCrtImplementationDetails\u003E\u002EAtExitLock\u002E_lock_Get());
  }

  [SecurityCritical]
  [DebuggerStepThrough]
  [return: MarshalAs(UnmanagedType.U1)]
  internal static bool \u003FA0xe11594df\u002E__global_lock()
  {
    bool flag = false;
    if (\u003CModule\u003E.\u003CCrtImplementationDetails\u003E\u002EAtExitLock\u002EIsInitialized())
    {
      \u003CModule\u003E.\u003CCrtImplementationDetails\u003E\u002EAtExitLock\u002EEnter();
      flag = true;
    }
    return flag;
  }

  [SecurityCritical]
  [DebuggerStepThrough]
  [return: MarshalAs(UnmanagedType.U1)]
  internal static bool \u003FA0xe11594df\u002E__global_unlock()
  {
    bool flag = false;
    if (\u003CModule\u003E.\u003CCrtImplementationDetails\u003E\u002EAtExitLock\u002EIsInitialized())
    {
      \u003CModule\u003E.\u003CCrtImplementationDetails\u003E\u002EAtExitLock\u002EExit();
      flag = true;
    }
    return flag;
  }

  [SecurityCritical]
  [DebuggerStepThrough]
  [return: MarshalAs(UnmanagedType.U1)]
  internal static bool \u003FA0xe11594df\u002E__alloc_global_lock()
  {
    \u003CModule\u003E.\u003CCrtImplementationDetails\u003E\u002EAtExitLock\u002EAddRef();
    return \u003CModule\u003E.\u003CCrtImplementationDetails\u003E\u002EAtExitLock\u002EIsInitialized();
  }

  [DebuggerStepThrough]
  [SecurityCritical]
  internal static void \u003FA0xe11594df\u002E__dealloc_global_lock()
  {
    \u003CModule\u003E.\u003CCrtImplementationDetails\u003E\u002EAtExitLock\u002ERemoveRef();
  }

  [SecurityCritical]
  internal static unsafe int _atexit_helper(__FnPtr<void ()> func, uint* __pexit_list_size, __FnPtr<void ()>** __ponexitend_e, __FnPtr<void ()>** __ponexitbegin_e)
  {
    // ISSUE: cast to a function pointer type
    __FnPtr<void ()> local1 = (__FnPtr<void ()>) 0;
    if (func == null)
      return -1;
    int num1;
    if (\u003CModule\u003E.\u003FA0xe11594df\u002E__global_lock())
    {
      try
      {
        __FnPtr<void ()>* local2 = (__FnPtr<void ()>*) \u003CModule\u003E.DecodePointer((void*) *(int*) __ponexitbegin_e);
        __FnPtr<void ()>* local3 = (__FnPtr<void ()>*) \u003CModule\u003E.DecodePointer((void*) *(int*) __ponexitend_e);
        int num2 = (int) ((IntPtr) local3 - (IntPtr) local2);
        if (*__pexit_list_size - 1U < (uint) num2 >> 2)
        {
          try
          {
            uint num3 = *__pexit_list_size * 4U;
            uint num4 = num3 >= 2048U ? 2048U : num3;
            IntPtr cb = new IntPtr((int) num3 + (int) num4);
            IntPtr num5 = Marshal.ReAllocHGlobal(new IntPtr((void*) local2), cb);
            local3 = (__FnPtr<void ()>*) ((IntPtr) num5.ToPointer() + num2);
            local2 = (__FnPtr<void ()>*) num5.ToPointer();
            uint num6 = *__pexit_list_size;
            uint num7 = 512U >= num6 ? num6 : 512U;
            *__pexit_list_size = num6 + num7;
          }
          catch (OutOfMemoryException ex)
          {
            IntPtr cb = new IntPtr((int) *__pexit_list_size * 4 + 8);
            IntPtr num3 = Marshal.ReAllocHGlobal(new IntPtr((void*) local2), cb);
            local3 = (__FnPtr<void ()>*) ((IntPtr) num3.ToPointer() - (IntPtr) local2 + (IntPtr) local3);
            local2 = (__FnPtr<void ()>*) num3.ToPointer();
            uint* numPtr = __pexit_list_size;
            int num4 = (int) *numPtr + 4;
            *numPtr = (uint) num4;
          }
        }
        *(int*) local3 = (int) func;
        __FnPtr<void ()>* local4 = (__FnPtr<void ()>*) ((IntPtr) local3 + 4);
        local1 = func;
        *(int*) __ponexitbegin_e = (int) \u003CModule\u003E.EncodePointer((void*) local2);
        *(int*) __ponexitend_e = (int) \u003CModule\u003E.EncodePointer((void*) local4);
      }
      catch (OutOfMemoryException ex)
      {
      }
      finally
      {
        \u003CModule\u003E.\u003FA0xe11594df\u002E__global_unlock();
      }
      if (local1 != null)
      {
        num1 = 0;
        goto label_12;
      }
    }
    num1 = -1;
label_12:
    return num1;
  }

  [SecurityCritical]
  internal static unsafe void _exit_callback()
  {
    if ((int) \u003CModule\u003E.\u003FA0xe11594df\u002E__exit_list_size == 0)
      return;
    __FnPtr<void ()>* local1 = (__FnPtr<void ()>*) \u003CModule\u003E.DecodePointer((void*) \u003CModule\u003E.\u003FA0xe11594df\u002E__onexitbegin_m);
    __FnPtr<void ()>* local2 = (__FnPtr<void ()>*) \u003CModule\u003E.DecodePointer((void*) \u003CModule\u003E.\u003FA0xe11594df\u002E__onexitend_m);
    if ((IntPtr) local1 != IntPtr(-1) && (IntPtr) local1 != IntPtr.Zero && (IntPtr) local2 != IntPtr.Zero)
    {
      __FnPtr<void ()>* local3 = local1;
      __FnPtr<void ()>* local4 = local2;
      while (true)
      {
        __FnPtr<void ()>* local5;
        __FnPtr<void ()>* local6;
        do
        {
          do
          {
            local2 -= 4;
            if (local2 < local1)
              goto label_7;
          }
          while ((IntPtr) *(int*) local2 == (IntPtr) \u003CModule\u003E._encoded_null());
          void* voidPtr = \u003CModule\u003E.DecodePointer((void*) *(int*) local2);
          *(int*) local2 = (int) \u003CModule\u003E._encoded_null();
          // ISSUE: cast to a function pointer type
          // ISSUE: function pointer call
          __calli((__FnPtr<void ()>) (IntPtr) voidPtr)();
          local5 = (__FnPtr<void ()>*) \u003CModule\u003E.DecodePointer((void*) \u003CModule\u003E.\u003FA0xe11594df\u002E__onexitbegin_m);
          local6 = (__FnPtr<void ()>*) \u003CModule\u003E.DecodePointer((void*) \u003CModule\u003E.\u003FA0xe11594df\u002E__onexitend_m);
        }
        while (local3 == local5 && local4 == local6);
        local3 = local5;
        local1 = local5;
        local4 = local6;
        local2 = local6;
      }
label_7:
      Marshal.FreeHGlobal(new IntPtr((void*) local1));
    }
    \u003CModule\u003E.\u003FA0xe11594df\u002E__dealloc_global_lock();
  }

  [SecurityCritical]
  [DebuggerStepThrough]
  internal static unsafe int _initatexit_m()
  {
    int num = 0;
    if (!\u003CModule\u003E.\u003FA0xe11594df\u002E__alloc_global_lock())
      return num;
    \u003CModule\u003E.\u003FA0xe11594df\u002E__onexitbegin_m = (__FnPtr<void ()>*) \u003CModule\u003E.EncodePointer(Marshal.AllocHGlobal(128).ToPointer());
    \u003CModule\u003E.\u003FA0xe11594df\u002E__onexitend_m = \u003CModule\u003E.\u003FA0xe11594df\u002E__onexitbegin_m;
    \u003CModule\u003E.\u003FA0xe11594df\u002E__exit_list_size = 32U;
    return 1;
  }

  internal static __FnPtr<int ()> _onexit_m(__FnPtr<int ()> _Function)
  {
    // ISSUE: cast to a function pointer type
    if (\u003CModule\u003E._atexit_m((__FnPtr<void ()>) _Function) != -1)
    {
      return _Function;
    }
    else
    {
      // ISSUE: cast to a function pointer type
      return (__FnPtr<int ()>) 0;
    }
  }

  [SecurityCritical]
  internal static unsafe int _atexit_m(__FnPtr<void ()> func)
  {
    // ISSUE: cast to a function pointer type
    return \u003CModule\u003E._atexit_helper((__FnPtr<void ()>) (IntPtr) \u003CModule\u003E.EncodePointer((void*) func), &\u003CModule\u003E.\u003FA0xe11594df\u002E__exit_list_size, &\u003CModule\u003E.\u003FA0xe11594df\u002E__onexitend_m, &\u003CModule\u003E.\u003FA0xe11594df\u002E__onexitbegin_m);
  }

  [SecurityCritical]
  [DebuggerStepThrough]
  internal static unsafe int _initatexit_app_domain()
  {
    if (\u003CModule\u003E.\u003FA0xe11594df\u002E__alloc_global_lock())
    {
      \u003CModule\u003E.__onexitbegin_app_domain = (__FnPtr<void ()>*) \u003CModule\u003E.EncodePointer(Marshal.AllocHGlobal(128).ToPointer());
      \u003CModule\u003E.__onexitend_app_domain = \u003CModule\u003E.__onexitbegin_app_domain;
      \u003CModule\u003E.__exit_list_size_app_domain = 32U;
    }
    return 1;
  }

  [SecurityCritical]
  [HandleProcessCorruptedStateExceptions]
  internal static unsafe void _app_exit_callback()
  {
    if ((int) \u003CModule\u003E.__exit_list_size_app_domain == 0)
      return;
    __FnPtr<void ()>* local1 = (__FnPtr<void ()>*) \u003CModule\u003E.DecodePointer((void*) \u003CModule\u003E.__onexitbegin_app_domain);
    __FnPtr<void ()>* local2 = (__FnPtr<void ()>*) \u003CModule\u003E.DecodePointer((void*) \u003CModule\u003E.__onexitend_app_domain);
    try
    {
      if ((IntPtr) local1 == IntPtr(-1) || (IntPtr) local1 == IntPtr.Zero || (IntPtr) local2 == IntPtr.Zero)
        return;
      __FnPtr<void ()>* local3 = local1;
      __FnPtr<void ()>* local4 = local2;
      while (true)
      {
        __FnPtr<void ()>* local5;
        __FnPtr<void ()>* local6;
        do
        {
          do
          {
            local2 -= 4;
          }
          while (local2 >= local1 && (IntPtr) *(int*) local2 == (IntPtr) \u003CModule\u003E._encoded_null());
          if (local2 >= local1)
          {
            // ISSUE: cast to a function pointer type
            __FnPtr<void ()> local7 = (__FnPtr<void ()>) (IntPtr) \u003CModule\u003E.DecodePointer((void*) *(int*) local2);
            *(int*) local2 = (int) \u003CModule\u003E._encoded_null();
            // ISSUE: function pointer call
            __calli(local7)();
            local5 = (__FnPtr<void ()>*) \u003CModule\u003E.DecodePointer((void*) \u003CModule\u003E.__onexitbegin_app_domain);
            local6 = (__FnPtr<void ()>*) \u003CModule\u003E.DecodePointer((void*) \u003CModule\u003E.__onexitend_app_domain);
          }
          else
            goto label_12;
        }
        while (local3 == local5 && local4 == local6);
        local3 = local5;
        local1 = local5;
        local4 = local6;
        local2 = local6;
      }
label_12:;
    }
    finally
    {
      Marshal.FreeHGlobal(new IntPtr((void*) local1));
      \u003CModule\u003E.\u003FA0xe11594df\u002E__dealloc_global_lock();
    }
  }

  [SecurityCritical]
  internal static __FnPtr<int ()> _onexit_m_appdomain(__FnPtr<int ()> _Function)
  {
    // ISSUE: cast to a function pointer type
    if (\u003CModule\u003E._atexit_m_appdomain((__FnPtr<void ()>) _Function) != -1)
    {
      return _Function;
    }
    else
    {
      // ISSUE: cast to a function pointer type
      return (__FnPtr<int ()>) 0;
    }
  }

  [DebuggerStepThrough]
  [SecurityCritical]
  internal static unsafe int _atexit_m_appdomain(__FnPtr<void ()> func)
  {
    // ISSUE: cast to a function pointer type
    return \u003CModule\u003E._atexit_helper((__FnPtr<void ()>) (IntPtr) \u003CModule\u003E.EncodePointer((void*) func), &\u003CModule\u003E.__exit_list_size_app_domain, &\u003CModule\u003E.__onexitend_app_domain, &\u003CModule\u003E.__onexitbegin_app_domain);
  }

  [SecurityCritical]
  [SuppressUnmanagedCodeSecurity]
  [ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
  [DllImport("KERNEL32.dll")]
  public static void* DecodePointer(void* Ptr);

  [SecurityCritical]
  [SuppressUnmanagedCodeSecurity]
  [ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
  [DllImport("MSVCR100.dll", CallingConvention = CallingConvention.Cdecl)]
  public static void* _encoded_null();

  [SecurityCritical]
  [SuppressUnmanagedCodeSecurity]
  [ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
  [DllImport("KERNEL32.dll")]
  public static void* EncodePointer(void* Ptr);

  [DebuggerStepThrough]
  [SecurityCritical]
  internal static unsafe int _initterm_e(__FnPtr<int ()>* pfbegin, __FnPtr<int ()>* pfend)
  {
    int num1 = 0;
    if (pfbegin < pfend)
    {
      while (num1 == 0)
      {
        uint num2 = (uint) *(int*) pfbegin;
        if ((int) num2 != 0)
        {
          // ISSUE: cast to a function pointer type
          // ISSUE: function pointer call
          num1 = __calli((__FnPtr<int ()>) (int) num2)();
        }
        pfbegin += 4;
        if (pfbegin >= pfend)
          break;
      }
    }
    return num1;
  }

  [SecurityCritical]
  [DebuggerStepThrough]
  internal static unsafe void _initterm(__FnPtr<void ()>* pfbegin, __FnPtr<void ()>* pfend)
  {
    if (pfbegin >= pfend)
      return;
    do
    {
      uint num = (uint) *(int*) pfbegin;
      if ((int) num != 0)
      {
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        __calli((__FnPtr<void ()>) (int) num)();
      }
      pfbegin += 4;
    }
    while (pfbegin < pfend);
  }

  [DebuggerStepThrough]
  internal static ModuleHandle \u003CCrtImplementationDetails\u003E\u002EThisModule\u002EHandle()
  {
    return typeof (ThisModule).Module.ModuleHandle;
  }

  [DebuggerStepThrough]
  [SecurityCritical]
  [SecurityPermission(SecurityAction.Assert, UnmanagedCode = true)]
  internal static unsafe void _initterm_m(__FnPtr<void* ()>* pfbegin, __FnPtr<void* ()>* pfend)
  {
    if (pfbegin >= pfend)
      return;
    do
    {
      uint num = (uint) *(int*) pfbegin;
      if ((int) num != 0)
      {
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        void* voidPtr = __calli(\u003CModule\u003E.\u003CCrtImplementationDetails\u003E\u002EThisModule\u002EResolveMethod\u003Cvoid\u0020const\u0020\u002A\u0020__clrcall\u0028void\u0029\u003E((__FnPtr<void* ()>) (int) num))();
      }
      pfbegin += 4;
    }
    while (pfbegin < pfend);
  }

  [SecurityCritical]
  [DebuggerStepThrough]
  internal static unsafe __FnPtr<void* ()> \u003CCrtImplementationDetails\u003E\u002EThisModule\u002EResolveMethod\u003Cvoid\u0020const\u0020\u002A\u0020__clrcall\u0028void\u0029\u003E(__FnPtr<void* ()> methodToken)
  {
    // ISSUE: cast to a function pointer type
    return (__FnPtr<void* ()>) (IntPtr) \u003CModule\u003E.\u003CCrtImplementationDetails\u003E\u002EThisModule\u002EHandle().ResolveMethodHandle((int) methodToken).GetFunctionPointer().ToPointer();
  }

  [SecurityCritical]
  [HandleProcessCorruptedStateExceptions]
  [ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
  [SecurityPermission(SecurityAction.Assert, UnmanagedCode = true)]
  internal static unsafe void ___CxxCallUnwindDtor(__FnPtr<void (void*)> pDtor, void* pThis)
  {
    try
    {
      void* voidPtr = pThis;
      // ISSUE: function pointer call
      __calli(pDtor)(voidPtr);
    }
    catch
    {
      if (\u003CModule\u003E.__FrameUnwindFilter((_EXCEPTION_POINTERS*) Marshal.GetExceptionPointers()) != 0)
        throw;
    }
  }

  [ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
  [SecurityCritical]
  [HandleProcessCorruptedStateExceptions]
  [SecurityPermission(SecurityAction.Assert, UnmanagedCode = true)]
  internal static unsafe void ___CxxCallUnwindDelDtor(__FnPtr<void (void*)> pDtor, void* pThis)
  {
    try
    {
      void* voidPtr = pThis;
      // ISSUE: function pointer call
      __calli(pDtor)(voidPtr);
    }
    catch
    {
      if (\u003CModule\u003E.__FrameUnwindFilter((_EXCEPTION_POINTERS*) Marshal.GetExceptionPointers()) != 0)
        throw;
    }
  }

  [HandleProcessCorruptedStateExceptions]
  [ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
  [SecurityCritical]
  [SecurityPermission(SecurityAction.Assert, UnmanagedCode = true)]
  internal static unsafe void ___CxxCallUnwindVecDtor(__FnPtr<void (void*, uint, int, __FnPtr<void (void*)>)> pVecDtor, void* ptr, uint size, int count, __FnPtr<void (void*)> pDtor)
  {
    try
    {
      void* voidPtr = ptr;
      int num1 = (int) size;
      int num2 = count;
      __FnPtr<void (void*)> local = pDtor;
      // ISSUE: cast to a function pointer type
      // ISSUE: function pointer call
      __calli(pVecDtor)((__FnPtr<void (void*)>) (IntPtr) voidPtr, num1, (uint) num2, (void*) local);
    }
    catch
    {
      if (\u003CModule\u003E.__FrameUnwindFilter((_EXCEPTION_POINTERS*) Marshal.GetExceptionPointers()) != 0)
        throw;
    }
  }

  [SuppressUnmanagedCodeSecurity]
  [MethodImpl(MethodImplOptions.Unmanaged | MethodImplOptions.PreserveSig, MethodCodeType = MethodCodeType.Native)]
  internal static uint _c_FasmAssemble([In] sbyte* obj0, [In] uint obj1, [In] uint obj2)
  {
    // ISSUE: unable to decompile the method.
  }

  [SuppressUnmanagedCodeSecurity]
  [DllImport("", EntryPoint = "", CallingConvention = CallingConvention.StdCall, SetLastError = true)]
  [MethodImpl(MethodImplOptions.Unmanaged, MethodCodeType = MethodCodeType.Native)]
  internal static int WriteProcessMemory([In] void* obj0, [In] void* obj1, [In] void* obj2, [In] uint obj3, [In] uint* obj4)
  {
    // ISSUE: unable to decompile the method.
  }

  [SuppressUnmanagedCodeSecurity]
  [DllImport("", EntryPoint = "", CallingConvention = CallingConvention.StdCall, SetLastError = true)]
  [MethodImpl(MethodImplOptions.Unmanaged, MethodCodeType = MethodCodeType.Native)]
  internal static int CloseHandle([In] void* obj0)
  {
    // ISSUE: unable to decompile the method.
  }

  [SuppressUnmanagedCodeSecurity]
  [DllImport("", EntryPoint = "", CallingConvention = CallingConvention.StdCall, SetLastError = true)]
  [MethodImpl(MethodImplOptions.Unmanaged, MethodCodeType = MethodCodeType.Native)]
  internal static int GetExitCodeThread([In] void* obj0, [In] uint* obj1)
  {
    // ISSUE: unable to decompile the method.
  }

  [SuppressUnmanagedCodeSecurity]
  [DllImport("", EntryPoint = "", CallingConvention = CallingConvention.StdCall, SetLastError = true)]
  [MethodImpl(MethodImplOptions.Unmanaged, MethodCodeType = MethodCodeType.Native)]
  internal static void* CreateRemoteThread([In] void* obj0, [In] _SECURITY_ATTRIBUTES* obj1, [In] uint obj2, [In] __FnPtr<uint (void*)> obj3, [In] void* obj4, [In] uint obj5, [In] uint* obj6)
  {
    // ISSUE: unable to decompile the method.
  }

  [SuppressUnmanagedCodeSecurity]
  [DllImport("", EntryPoint = "", CallingConvention = CallingConvention.StdCall, SetLastError = true)]
  [MethodImpl(MethodImplOptions.Unmanaged, MethodCodeType = MethodCodeType.Native)]
  internal static uint WaitForSingleObject([In] void* obj0, [In] uint obj1)
  {
    // ISSUE: unable to decompile the method.
  }

  [SuppressUnmanagedCodeSecurity]
  [MethodImpl(MethodImplOptions.Unmanaged | MethodImplOptions.PreserveSig, MethodCodeType = MethodCodeType.Native)]
  internal static void* _getFiberPtrId()
  {
    // ISSUE: unable to decompile the method.
  }

  [SuppressUnmanagedCodeSecurity]
  [DllImport("", EntryPoint = "", CallingConvention = CallingConvention.Cdecl, SetLastError = true)]
  [MethodImpl(MethodImplOptions.Unmanaged, MethodCodeType = MethodCodeType.Native)]
  internal static void _amsg_exit([In] int obj0)
  {
    // ISSUE: unable to decompile the method.
  }

  [SuppressUnmanagedCodeSecurity]
  [MethodImpl(MethodImplOptions.Unmanaged | MethodImplOptions.PreserveSig, MethodCodeType = MethodCodeType.Native)]
  internal static void __security_init_cookie()
  {
    // ISSUE: unable to decompile the method.
  }

  [SuppressUnmanagedCodeSecurity]
  [DllImport("", EntryPoint = "", CallingConvention = CallingConvention.StdCall, SetLastError = true)]
  [MethodImpl(MethodImplOptions.Unmanaged, MethodCodeType = MethodCodeType.Native)]
  internal static void Sleep([In] uint obj0)
  {
    // ISSUE: unable to decompile the method.
  }

  [SuppressUnmanagedCodeSecurity]
  [DllImport("", EntryPoint = "", CallingConvention = CallingConvention.Cdecl, SetLastError = true)]
  [MethodImpl(MethodImplOptions.Unmanaged, MethodCodeType = MethodCodeType.Native)]
  internal static void _cexit()
  {
    // ISSUE: unable to decompile the method.
  }

  [SuppressUnmanagedCodeSecurity]
  [DllImport("", EntryPoint = "", CallingConvention = CallingConvention.Cdecl, SetLastError = true)]
  [MethodImpl(MethodImplOptions.Unmanaged, MethodCodeType = MethodCodeType.Native)]
  internal static int __FrameUnwindFilter([In] _EXCEPTION_POINTERS* obj0)
  {
    // ISSUE: unable to decompile the method.
  }
}
