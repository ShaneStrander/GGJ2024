using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Runtime.InteropServices;
using System;
using UnityEditor;
using UnityEngine.SceneManagement;

public class Start_Script : MonoBehaviour
{

    [DllImport("user32.dll")]
    public static extern int MessageBox2(IntPtr hWnd, string text, string caption, uint type);

    [DllImport("user32.dll")]
    private static extern IntPtr GetActiveWindow();

    [DllImport("Dwmapi.dll")]
    private static extern uint DwmExtendFrameIntoClientArea(IntPtr hWnd, ref MARGINS margins);

    private struct MARGINS
    {
        public int cxLeftWidth;
        public int cxRightWidth;
        public int cyLeftHeight;
        public int cyBottomHeight;
    }


    // Start is called before the first frame update
    void Start()
    {

        IntPtr hWnd = GetActiveWindow();
        MARGINS margins = new MARGINS { cxLeftWidth = -1 };
        DwmExtendFrameIntoClientArea(hWnd, ref margins);
    }

}
