using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ClownCamera : MonoBehaviour
{
    public GameObject PopUp1;
    public GameObject PopUp2;
    public GameObject GroupImage;
    public GameObject Camera;

    public void Ok()
    {
        PopUp1.SetActive(false);
        GroupImage.SetActive(true);
    }

    public void PressToClown()
    {
        GroupImage.SetActive(false);
        Camera.SetActive(true);
    }

    public void ToTerminal()
    {
        SceneManager.LoadScene("Terminal");
    }
}
