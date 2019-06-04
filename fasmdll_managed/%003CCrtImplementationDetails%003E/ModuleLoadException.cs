// Type: <CrtImplementationDetails>.ModuleLoadException
// Assembly: fasmdll_managed, Version=1.0.5025.35375, Culture=neutral, PublicKeyToken=null
// MVID: E1E2AABC-E9DC-40C2-AD1D-352EC5BA64A0
// Assembly location: E:\Tools\fasmdll_managed.dll

using System;
using System.Runtime.Serialization;

namespace \u003CCrtImplementationDetails\u003E
{
  [Serializable]
  internal class ModuleLoadException : System.Exception
  {
    public const string Nested = "A nested exception occurred after the primary exception that caused the C++ module to fail to load.\n";

    protected ModuleLoadException(SerializationInfo info, StreamingContext context)
      : base(info, context)
    {
    }

    public ModuleLoadException(string message, System.Exception innerException)
      : base(message, innerException)
    {
    }

    public ModuleLoadException(string message)
      : base(message)
    {
    }
  }
}
