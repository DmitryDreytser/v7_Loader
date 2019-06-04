// Type: <CrtImplementationDetails>.ModuleUninitializer
// Assembly: fasmdll_managed, Version=1.0.5025.35375, Culture=neutral, PublicKeyToken=null
// MVID: E1E2AABC-E9DC-40C2-AD1D-352EC5BA64A0
// Assembly location: E:\Tools\fasmdll_managed.dll

using \u003CCrtImplementationDetails\u003E;
using System;
using System.Collections;
using System.Runtime.CompilerServices;
using System.Runtime.ConstrainedExecution;
using System.Security;
using System.Threading;

namespace \u003CCrtImplementationDetails\u003E
{
  internal class ModuleUninitializer : Stack
  {
    private static object @lock = new object();
    internal static ModuleUninitializer _ModuleUninitializer = new ModuleUninitializer();

    [SecurityCritical]
    static ModuleUninitializer()
    {
    }

    [SecuritySafeCritical]
    private ModuleUninitializer()
    {
      EventHandler eventHandler = new EventHandler(this.SingletonDomainUnload);
      AppDomain.CurrentDomain.DomainUnload += eventHandler;
      AppDomain.CurrentDomain.ProcessExit += eventHandler;
    }

    [SecuritySafeCritical]
    internal void AddHandler(EventHandler handler)
    {
      bool lockTaken = false;
      RuntimeHelpers.PrepareConstrainedRegions();
      try
      {
        RuntimeHelpers.PrepareConstrainedRegions();
        Monitor.Enter(ModuleUninitializer.@lock, ref lockTaken);
        RuntimeHelpers.PrepareDelegate((Delegate) handler);
        this.Push((object) handler);
      }
      finally
      {
        if (lockTaken)
          Monitor.Exit(ModuleUninitializer.@lock);
      }
    }

    [PrePrepareMethod]
    [SecurityCritical]
    private void SingletonDomainUnload(object source, EventArgs arguments)
    {
      bool lockTaken = false;
      RuntimeHelpers.PrepareConstrainedRegions();
      try
      {
        RuntimeHelpers.PrepareConstrainedRegions();
        Monitor.Enter(ModuleUninitializer.@lock, ref lockTaken);
        foreach (EventHandler eventHandler in (Stack) this)
          eventHandler(source, arguments);
      }
      finally
      {
        if (lockTaken)
          Monitor.Exit(ModuleUninitializer.@lock);
      }
    }
  }
}
