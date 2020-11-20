using System;
using System.Collections.Generic;
using System.Text;

namespace System.Runtime.InteropServices
{
  [AttributeUsage(AttributeTargets.Method)]
  public sealed class NativeCallableAttribute : Attribute
  {
    public NativeCallableAttribute() { }
    public CallingConvention CallingConvention;
    public string EntryPoint;
  }
}
