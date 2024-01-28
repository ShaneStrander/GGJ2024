using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndingScript : MonoBehaviour
{

    public string urlToOpen = "https://www.youtube.com/watch?v=dQw4w9WgXcQ";

    public void OpenDefaultBrowser()
    {
        Application.OpenURL(urlToOpen);
        Invoke("QuitDelay", 1f);
    }

    public void QuitDelay()
    {
        Application.Quit();
    }
}
