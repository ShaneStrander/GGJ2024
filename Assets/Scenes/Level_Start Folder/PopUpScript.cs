using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PopUpScript : MonoBehaviour
{
    public Outline outline;

    public GameObject OGPop;
    public GameObject NewPop;

    public void Start()
    {
        outline = GetComponent<Outline>();
    }

    private void OnMouseOver()
    {
        outline.effectColor = new Color32(255,0,0,1);
    }

    public void FirstYes()
    {
        SceneManager.LoadScene("TransparentWindow");
    }

    public void FirstNo()
    {
        OGPop.SetActive(false);
        NewPop.SetActive(true);
    }

    public void Fine()
    {
        SceneManager.LoadScene("TransparentWindow");
    }

    public void SecondNo()
    {
        Application.Quit();
    }
}
