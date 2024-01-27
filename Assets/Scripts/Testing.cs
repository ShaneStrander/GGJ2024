using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Testing : MonoBehaviour
{
    public string urlToOpen = "https://www.example.com";

    void Start()
    {
        Button openBrowserButton = GetComponent<Button>();

        if (openBrowserButton != null)
        {
            openBrowserButton.onClick.AddListener(OpenDefaultBrowser);
        }
        else
        {
            Debug.LogError("This script should be attached to a GameObject with a Button component.");
        }
    }

    public void OpenDefaultBrowser()
    {
        Application.OpenURL(urlToOpen);
    }
}
