//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (https://www.swig.org).
// Version 4.1.1
//
// Do not make changes to this file unless you know what you are doing - modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------

namespace TestCpp {

public class Base : QObject {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  private bool swigCMemOwnDerived;

  internal Base(global::System.IntPtr cPtr, bool cMemoryOwn) : base(TESTCPPPINVOKE.Base_SWIGSmartPtrUpcast(cPtr), true) {
    swigCMemOwnDerived = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(Base obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  protected override void Dispose(bool disposing) {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwnDerived) {
          swigCMemOwnDerived = false;
          TESTCPPPINVOKE.delete_Base(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      base.Dispose(disposing);
    }
  }

  public QObject GetSharedPtr() {
    global::System.IntPtr cPtr = TESTCPPPINVOKE.Base_GetSharedPtr(swigCPtr);
    QObject ret = (cPtr == global::System.IntPtr.Zero) ? null : new QObject(cPtr, true);
    if (TESTCPPPINVOKE.SWIGPendingException.Pending) throw TESTCPPPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public Base GetSharedPtr2() {
    global::System.IntPtr cPtr = TESTCPPPINVOKE.Base_GetSharedPtr2(swigCPtr);
    Base ret = (cPtr == global::System.IntPtr.Zero) ? null : new Base(cPtr, true);
    if (TESTCPPPINVOKE.SWIGPendingException.Pending) throw TESTCPPPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public SWIGTYPE_p_std__string GetName() {
    SWIGTYPE_p_std__string ret = new SWIGTYPE_p_std__string(TESTCPPPINVOKE.Base_GetName(swigCPtr), true);
    if (TESTCPPPINVOKE.SWIGPendingException.Pending) throw TESTCPPPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public Base() : this(TESTCPPPINVOKE.new_Base(), true) {
  }

}

}