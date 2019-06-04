// Type: <CrtImplementationDetails>.ModuleLoadExceptionHandlerException
// Assembly: fasmdll_managed, Version=1.0.5025.35375, Culture=neutral, PublicKeyToken=null
// MVID: E1E2AABC-E9DC-40C2-AD1D-352EC5BA64A0
// Assembly location: E:\Tools\fasmdll_managed.dll

using \u003CCrtImplementationDetails\u003E;
using System;
using System.Runtime.Serialization;
using System.Security;

namespace \u003CCrtImplementationDetails\u003E
{
  [Serializable]
  internal class ModuleLoadExceptionHandlerException : ModuleLoadException
  {
    private const string formatString = "\n{0}: {1}\n--- Start of primary exception ---\n{2}\n--- End of primary exception ---\n\n--- Start of nested exception ---\n{3}\n--- End of nested exception ---\n";
    private System.Exception \u003Cbacking_store\u003ENestedException;

    public System.Exception NestedException
    {
      get
      {
        return this.\u003Cbacking_store\u003ENestedException;
      }
      set
      {
        this.\u003Cbacking_store\u003ENestedException = value;
      }
    }

    protected ModuleLoadExceptionHandlerException(SerializationInfo info, StreamingContext context)
      : base(info, context)
    {
      this.NestedException = (System.Exception) info.GetValue("NestedException", typeof (System.Exception));
    }

    public ModuleLoadExceptionHandlerException(string message, System.Exception innerException, System.Exception nestedException)
      : base(message, innerException)
    {
      this.NestedException = nestedException;
    }

    public override string ToString()
    {
      string str1 = this.InnerException == null ? string.Empty : this.InnerException.ToString();
      string str2 = this.NestedException == null ? string.Empty : this.NestedException.ToString();
      object[] objArray = new object[4];
      objArray[0] = (object) this.GetType();
      string str3 = this.Message == null ? string.Empty : this.Message;
      objArray[1] = (object) str3;
      string str4 = str1 == null ? string.Empty : str1;
      objArray[2] = (object) str4;
      string str5 = str2 == null ? string.Empty : str2;
      objArray[3] = (object) str5;
      return string.Format("\n{0}: {1}\n--- Start of primary exception ---\n{2}\n--- End of primary exception ---\n\n--- Start of nested exception ---\n{3}\n--- End of nested exception ---\n", objArray);
    }

    [SecurityCritical]
    public override void GetObjectData(SerializationInfo info, StreamingContext context)
    {
      base.GetObjectData(info, context);
      info.AddValue("NestedException", (object) this.NestedException, typeof (System.Exception));
    }
  }
}
