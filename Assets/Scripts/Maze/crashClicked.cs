using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class crashClicked : MonoBehaviour
{

    public GameObject message;

    private void OnMouseDown()
    {
        // Perform actions when the user clicks on the object
        this.gameObject.SetActive(false);
        message.SetActive(true);
    }

    public void BackToTerminal()
    {
        SceneManager.LoadScene("Terminal");
    }
}
