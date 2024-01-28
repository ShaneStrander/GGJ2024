using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BlowLevelScript : MonoBehaviour
{
    public float TimeLeft;

    public GameObject PopUp1;
    public GameObject PopUp2;
    public GameObject holder;

    private void Update()
    {
        if (TimeLeft > 0)
        {
            TimeLeft -= Time.deltaTime;
        }
        else
        {
            TimeLeft = 0;
            PopUp1.SetActive(false);
            PopUp2.SetActive(true);
            holder.SetActive(false);
        }
    }

    public void ToTerminal()
    {
        SceneManager.LoadScene("Terminal");
    }
}

