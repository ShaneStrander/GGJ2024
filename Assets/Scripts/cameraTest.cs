using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class cameraTest : MonoBehaviour
{
    WebCamTexture webCam;
    public RawImage img;
    void Start()
    {
        webCam = new WebCamTexture();
        img.texture = webCam;
        webCam.Play();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
