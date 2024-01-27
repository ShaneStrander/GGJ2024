using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class TerminalManager : MonoBehaviour
{
    public GameObject directoryLine;
    public GameObject responseLine;

    public TMP_InputField terminalInput;
    public GameObject userInputLine;
    public ScrollRect sr;
    public GameObject msgList;

    private void OnGUI()
    {
        if (terminalInput.isFocused && terminalInput.text != "" && Input.GetKeyDown(KeyCode.Return))
        {
            // Store user input
            string userInput = terminalInput.text;

            ClearInputField();

            AddDirectoryLine(userInput);

            //Move user input line to the end
            userInputLine.transform.SetAsLastSibling();

            //Refocus the input line
            terminalInput.ActivateInputField();
            terminalInput.Select(); 
        }
    }
    void ClearInputField()
    {
        terminalInput.text = "";
    }

    void AddDirectoryLine(string input)
    {
        // Resize the command line container
        Vector2 msgListSize = msgList.GetComponent<RectTransform>().sizeDelta;
        msgList.GetComponent<RectTransform>().sizeDelta = new Vector2(msgListSize.x, msgListSize.y + 35.0f);

        // Instantiate the directory line
        GameObject msg = Instantiate(directoryLine, msgList.transform);

        //Set its child index
        msg.transform.SetSiblingIndex(msgList.transform.childCount - 1);

        //Set the text of this new game object
        //msg.GetComponentsInChildren<Text>()[1].text = "jbcbjiecvbjiho";
        msg.GetComponentsInChildren<TMP_Text>()[1].text = input;

    }
}
