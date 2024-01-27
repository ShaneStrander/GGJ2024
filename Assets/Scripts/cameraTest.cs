using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class cameraTest : MonoBehaviour
{
    public GameObject PopUp;
    public GameObject Camera;

    WebCamTexture webCam;
    public RawImage img;
    void Start()
    {
        webCam = new WebCamTexture();
        img.texture = webCam;
        webCam.Play();
        Invoke("Delay", 5.0f);
    }

    public void Delay()
    {
        PopUp.SetActive(true);
        Camera.SetActive(false);
    }
}
