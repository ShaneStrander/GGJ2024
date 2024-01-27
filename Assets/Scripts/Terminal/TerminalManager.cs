using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Windows;

public class TerminalManager : MonoBehaviour
{
    public GameObject directoryLine;
    public GameObject responseLine;

    public TMP_InputField terminalInput;
    public GameObject userInputLine;
    public ScrollRect sr;
    public GameObject msgList;

    Interpreter interpreter;

    private void Start()
    {
        interpreter = GetComponent<Interpreter>();
    }

    private void OnGUI()
    {
        if (terminalInput.isFocused && terminalInput.text != "" && UnityEngine.Input.GetKeyDown(KeyCode.Return))
        {
            // Store user input
            string userInput = terminalInput.text;

            ClearInputField();

            AddDirectoryLine(userInput);

            //add interpretation lines
            int lines = AddInterpreterLines(interpreter.Interpret(userInput));

            //Scroll to the bottom
            ScrollToBottom(lines);

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

    int AddInterpreterLines(List<string> interpretation)
    {

        for(int i = 0; i < interpretation.Count; i++)
        {
            //instantiate the response line
            GameObject res = Instantiate(responseLine, msgList.transform);
            // Set to end of all messages
            res.transform.SetAsLastSibling();
            //resize message list
            Vector2 listSize = msgList.GetComponent<RectTransform>().sizeDelta;
            msgList.GetComponent<RectTransform>().sizeDelta = new Vector2(listSize.x, listSize.y + 35.0f);
            //set text to interpreter string
            res.GetComponentInChildren<TMP_Text>().text = interpretation[i];


        }
        return interpretation.Count;
    }

    void ScrollToBottom(int lines)
    {
        if(lines > 4) 
        { 
            sr.velocity = new Vector2(0, 450);
        }
        else 
        {
            sr.verticalNormalizedPosition = 0;
        }
    }
}
