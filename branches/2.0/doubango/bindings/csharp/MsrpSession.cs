/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (http://www.swig.org).
 * Version 2.0.2
 *
 * Do not make changes to this file unless you know what you are doing--modify
 * the SWIG interface file instead.
 * ----------------------------------------------------------------------------- */

namespace org.doubango.tinyWRAP {

using System;
using System.Runtime.InteropServices;

public class MsrpSession : InviteSession {
  private HandleRef swigCPtr;

  internal MsrpSession(IntPtr cPtr, bool cMemoryOwn) : base(tinyWRAPPINVOKE.MsrpSession_SWIGUpcast(cPtr), cMemoryOwn) {
    swigCPtr = new HandleRef(this, cPtr);
  }

  internal static HandleRef getCPtr(MsrpSession obj) {
    return (obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr;
  }

  ~MsrpSession() {
    Dispose();
  }

  public override void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          tinyWRAPPINVOKE.delete_MsrpSession(swigCPtr);
        }
        swigCPtr = new HandleRef(null, IntPtr.Zero);
      }
      GC.SuppressFinalize(this);
      base.Dispose();
    }
  }

  public MsrpSession(SipStack pStack, MsrpCallback pCallback) : this(tinyWRAPPINVOKE.new_MsrpSession(SipStack.getCPtr(pStack), MsrpCallback.getCPtr(pCallback)), true) {
  }

  public bool setCallback(MsrpCallback pCallback) {
    bool ret = tinyWRAPPINVOKE.MsrpSession_setCallback(swigCPtr, MsrpCallback.getCPtr(pCallback));
    return ret;
  }

  public bool callMsrp(string remoteUriString, ActionConfig config) {
    bool ret = tinyWRAPPINVOKE.MsrpSession_callMsrp__SWIG_0(swigCPtr, remoteUriString, ActionConfig.getCPtr(config));
    return ret;
  }

  public bool callMsrp(string remoteUriString) {
    bool ret = tinyWRAPPINVOKE.MsrpSession_callMsrp__SWIG_1(swigCPtr, remoteUriString);
    return ret;
  }

  public bool callMsrp(SipUri remoteUri, ActionConfig config) {
    bool ret = tinyWRAPPINVOKE.MsrpSession_callMsrp__SWIG_2(swigCPtr, SipUri.getCPtr(remoteUri), ActionConfig.getCPtr(config));
    return ret;
  }

  public bool callMsrp(SipUri remoteUri) {
    bool ret = tinyWRAPPINVOKE.MsrpSession_callMsrp__SWIG_3(swigCPtr, SipUri.getCPtr(remoteUri));
    return ret;
  }

  public bool sendMessage(byte[] payload, uint len, ActionConfig config) {
    bool ret = tinyWRAPPINVOKE.MsrpSession_sendMessage__SWIG_0(swigCPtr, payload, len, ActionConfig.getCPtr(config));
    return ret;
  }

  public bool sendMessage(byte[] payload, uint len) {
    bool ret = tinyWRAPPINVOKE.MsrpSession_sendMessage__SWIG_1(swigCPtr, payload, len);
    return ret;
  }

  public bool sendFile(ActionConfig config) {
    bool ret = tinyWRAPPINVOKE.MsrpSession_sendFile__SWIG_0(swigCPtr, ActionConfig.getCPtr(config));
    return ret;
  }

  public bool sendFile() {
    bool ret = tinyWRAPPINVOKE.MsrpSession_sendFile__SWIG_1(swigCPtr);
    return ret;
  }

}

}