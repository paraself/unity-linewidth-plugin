using UnityEngine;
using System.Collections;
using System.Runtime.InteropServices;

public class AALineEffects : MonoBehaviour
{
    [Range(0.01f, 10.0f)]
    public float
        lineWidth = 1.5f;

   void Start() {
   		GLNative.Init();
   }

    // Enables the line width before rendering the scene.
    void OnPreRender ()
    {
		GLNative.SetGlobalLineWidth(lineWidth);
    }

    // Disables the line width after rendering the scene
    void OnPostRender ()
    {
        GLNative.DisableGlobalLineWidth();
    }
}
