using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Runtime.InteropServices;
using System;
using UnityEditor;
<<<<<<< Updated upstream
//using System.Windows.Forms;
=======
using UnityEngine.SceneManagement;
>>>>>>> Stashed changes

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

        bool result = EditorUtility.DisplayDialog("Confirmation", "Do you want to proceed?", "Yes", "No");

        // Check the user's choice
        if (result)
        {
            bool confirmedResult = EditorUtility.DisplayDialog("kek", "Excellent.", "OK");
            if (confirmedResult)
            {
                SceneManager.LoadScene("TransparentWindow");
            }    
        }
        else
        {
           bool secondResult = EditorUtility.DisplayDialog("w-what", "Pretty Please? Do it for the GameJam!", "Fine", "Nah");
            if (secondResult)
            {
                SceneManager.LoadScene("TransparentWindow");
            }
            else
            {
                Application.Quit();
            }
        }

        IntPtr hWnd = GetActiveWindow();
        MARGINS margins = new MARGINS { cxLeftWidth = -1 };
        DwmExtendFrameIntoClientArea(hWnd, ref margins);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

}
