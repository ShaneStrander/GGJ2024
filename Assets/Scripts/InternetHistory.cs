using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class InternetHistory : MonoBehaviour
{
    public TMP_InputField terminalInput;


    public GameObject question1;
    public GameObject question2;
    public GameObject question3;
    public GameObject question4;
    public GameObject PopUp1;
    public GameObject PopUp2;
    public GameObject PopUp3;
    public GameObject PopUp4;
    public GameObject History;
    public GameObject terminalObject;

    public string Answer1 = "4";
    public string Answer2 = "9";
    public string Answer3 = "6";
    public string Answer4 = "478016";

    public void OnGUI()
    {
        if (terminalInput.isFocused && terminalInput.text != "" && UnityEngine.Input.GetKey(KeyCode.Return))
        {
            string userInput = terminalInput.text;

            if (question1.activeInHierarchy == true && userInput == "4")
            {
                question1.SetActive(false);
                question2.SetActive(true);
                terminalInput.text = "";
            }
            else if (question2.activeInHierarchy == true && userInput == "9")
            {
                question2.SetActive(false);
                question3.SetActive(true);
                terminalInput.text = "";
            }
            else if (question3.activeInHierarchy == true && userInput == "6")
            {
                question3.SetActive(false);
                question4.SetActive(true);
                terminalInput.text = "";
            }
            else if (question4.activeInHierarchy == true && userInput == "478016")
            {
                question4.SetActive(false);
                PopUp3.SetActive(true);
                terminalInput.text = "";
            }
            else
            {
                question1.SetActive(false);
                question2.SetActive(false);
                question3.SetActive(false);
                question4.SetActive(false);
                PopUp4.SetActive(true);
                terminalObject.SetActive(false);
                terminalInput.text = "";
            }
        }
    }

    public void Ok1()
    {
        PopUp1.SetActive(false);
        PopUp2.SetActive(true);
        History.SetActive(true);
    }

    public void Ok2()
    {
        PopUp2.SetActive(false);
        question1.SetActive(true);
        terminalObject.SetActive(true);
    }

    public void GoTerminal()
    {
        SceneManager.LoadScene("TransparentWindow");
    }
}
