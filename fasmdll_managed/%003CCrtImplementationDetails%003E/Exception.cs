// Type: <CrtImplementationDetails>.Exception
// Assembly: fasmdll_managed, Version=1.0.5025.35375, Culture=neutral, PublicKeyToken=null
// MVID: E1E2AABC-E9DC-40C2-AD1D-352EC5BA64A0
// Assembly location: E:\Tools\fasmdll_managed.dll

using System;
using System.Runtime.Serialization;

namespace \u003CCrtImplementationDetails\u003E
{
  [Serializable]
  internal class Exception : System.Exception
  {
    protected Exception(SerializationInfo info, StreamingContext context)
      : base(info, context)
    {
    }

    public Exception(string message, System.Exception innerException)
      : base(message, innerException)
    {
    }

    public Exception(string message)
      : base(message)
    {
    }
  }
}
