using UnityEngine;
using System.Collections;
using System.Runtime.InteropServices;

public class GLNative  {

	[DllImport ("UnityLineWidthPlugin")]
	private static extern void UnityLineWidthPlugin_Initialize ();
	
//	[DllImport ("UnityLineWidthPlugin")]
//	private static extern void SetLineWidthNotInRenderEvent (float lineWidth);
//	
//	[DllImport ("UnityLineWidthPlugin")]
//	private static extern void UNsetLineWidthNotInRenderEvent ();

	public static void Init() {
		UnityLineWidthPlugin_Initialize ();
	}
	
	public static void SetGlobalLineWidth ( float lineWidth ) {
		GL.IssuePluginEvent ((int)(lineWidth * 100));
	}
	
	public static void DisableGlobalLineWidth () {
		GL.IssuePluginEvent (0);
	}
	
//	public static void SetLineWidth ( float lineWidth) {
//		SetLineWidthNotInRenderEvent ( lineWidth );
//	}
//	
//	public static void UnsetLineWidth () {
//		UNsetLineWidthNotInRenderEvent();
//	}
	
	
}
