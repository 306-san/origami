/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (http://www.swig.org).
 * Version 3.0.2
 *
 * Do not make changes to this file unless you know what you are doing--modify
 * the SWIG interface file instead.
 * ----------------------------------------------------------------------------- */

namespace Academy.HoloToolkit.Sharing {

public class ImageTagLocationListener : Listener {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;

  internal ImageTagLocationListener(global::System.IntPtr cPtr, bool cMemoryOwn) : base(SharingClientPINVOKE.ImageTagLocationListener_SWIGUpcast(cPtr), cMemoryOwn) {
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(ImageTagLocationListener obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~ImageTagLocationListener() {
    Dispose();
  }

  public override void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          SharingClientPINVOKE.delete_ImageTagLocationListener(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
      base.Dispose();
    }
  }

  public virtual void OnTagLocated(ImageTagLocation location) {
    if (SwigDerivedClassHasMethod("OnTagLocated", swigMethodTypes0)) SharingClientPINVOKE.ImageTagLocationListener_OnTagLocatedSwigExplicitImageTagLocationListener(swigCPtr, ImageTagLocation.getCPtr(location)); else SharingClientPINVOKE.ImageTagLocationListener_OnTagLocated(swigCPtr, ImageTagLocation.getCPtr(location));
  }

  public virtual void OnTagLocatingCompleted() {
    if (SwigDerivedClassHasMethod("OnTagLocatingCompleted", swigMethodTypes1)) SharingClientPINVOKE.ImageTagLocationListener_OnTagLocatingCompletedSwigExplicitImageTagLocationListener(swigCPtr); else SharingClientPINVOKE.ImageTagLocationListener_OnTagLocatingCompleted(swigCPtr);
  }

  public ImageTagLocationListener() : this(SharingClientPINVOKE.new_ImageTagLocationListener(), true) {
    SwigDirectorConnect();
  }

  private void SwigDirectorConnect() {
    if (SwigDerivedClassHasMethod("OnTagLocated", swigMethodTypes0))
      swigDelegate0 = new SwigDelegateImageTagLocationListener_0(SwigDirectorOnTagLocated);
    if (SwigDerivedClassHasMethod("OnTagLocatingCompleted", swigMethodTypes1))
      swigDelegate1 = new SwigDelegateImageTagLocationListener_1(SwigDirectorOnTagLocatingCompleted);
    SharingClientPINVOKE.ImageTagLocationListener_director_connect(swigCPtr, swigDelegate0, swigDelegate1);
  }

  private bool SwigDerivedClassHasMethod(string methodName, global::System.Type[] methodTypes) {
    global::System.Reflection.MethodInfo methodInfo = this.GetType().GetMethod(methodName, global::System.Reflection.BindingFlags.Public | global::System.Reflection.BindingFlags.NonPublic | global::System.Reflection.BindingFlags.Instance, null, methodTypes, null);
    bool hasDerivedMethod = methodInfo.DeclaringType.IsSubclassOf(typeof(ImageTagLocationListener));
    return hasDerivedMethod;
  }

  private void SwigDirectorOnTagLocated(global::System.IntPtr location) {
    OnTagLocated((location == global::System.IntPtr.Zero) ? null : new ImageTagLocation(location, true));
  }

  private void SwigDirectorOnTagLocatingCompleted() {
    OnTagLocatingCompleted();
  }

  public delegate void SwigDelegateImageTagLocationListener_0(global::System.IntPtr location);
  public delegate void SwigDelegateImageTagLocationListener_1();

  private SwigDelegateImageTagLocationListener_0 swigDelegate0;
  private SwigDelegateImageTagLocationListener_1 swigDelegate1;

  private static global::System.Type[] swigMethodTypes0 = new global::System.Type[] { typeof(ImageTagLocation) };
  private static global::System.Type[] swigMethodTypes1 = new global::System.Type[] {  };
}

}
