using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interpreter : MonoBehaviour
{
    List<string> response = new List<string>();
    public List<string> Interpret(string userInput)
    {
        response.Clear();

        string[] args = userInput.Split();

        if (args[0] == "Tasks")
        {
            response.Add("Task 1");
            response.Add("Task 2");
            response.Add("Task 3");
            response.Add("Task 4");

            return response;
        }
        else
        {
            response.Add("idk what you typed");

            return response;
        }

    }
}
