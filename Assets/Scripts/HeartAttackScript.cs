using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class HeartAttackScript : MonoBehaviour
{
    public GameObject pop1;
    public GameObject pop2;
    public GameObject pop3;
    public GameObject pop4;

    public GameObject[] skeletons;

    public void FirstYes()
    {
        pop1.SetActive(false);
        pop2.SetActive(true);
        pop3.SetActive(false);
        pop4.SetActive(false);

        UseSkeletons();
    }

    public void FirstNo()
    {
        pop1.SetActive(false);
        pop2.SetActive(false);
        pop3.SetActive(false);
        pop4.SetActive(true);
    }

    public void Ok()
    {
        pop1.SetActive(false);
        pop2.SetActive(false);
        pop3.SetActive(true);
        pop4.SetActive(false);
    }

    public void Return()
    {
        pop1.SetActive(true);
        pop2.SetActive(false);
        pop3.SetActive(false);
        pop4.SetActive(false);
    }

    public void SecondNo()
    {
        Application.Quit();
    }

    public void NextLevel()
    {
        SceneManager.LoadScene("TransparentWindow");
    }

    public void UseSkeletons()
    {
        for (int i = 0; i < skeletons.Length; i++)
        {
            skeletons[i].SetActive(true);
        }
    } 
}
