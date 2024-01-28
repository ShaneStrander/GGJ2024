using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class cameraTest : MonoBehaviour
{
    public GameObject PopUp;
    public GameObject Camera;
    public GameObject FailSafe;

    WebCamTexture webCam;
    public RawImage img;
    void Start()
    {
        WebCamDevice[] devices = WebCamTexture.devices;
        if (devices.Length != 0 && Application.HasUserAuthorization(UserAuthorization.WebCam) == true)
        {
            webCam = new WebCamTexture();
            img.texture = webCam;
            webCam.Play();
            Invoke("Delay", 5.0f);
        }
        else
        {
            FailSafe.SetActive(true);
            Camera.SetActive(false);
            Invoke("Delay", 5.0f);
        }
    }

    public void Delay()
    {
        webCam.Stop();
        PopUp.SetActive(true);
        Camera.SetActive(false);
        FailSafe.SetActive(false);
    }
}
