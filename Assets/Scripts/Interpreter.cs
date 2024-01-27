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
            response.Add("Task1");
            response.Add("Task2");
            response.Add("Task3");
            response.Add("Task4");

            return response;
        }
        else if (args[0] == "Task1")
        {
            response.Add("Prepare yourself");

            return response;
        }
        else
        {
            response.Add("idk what you typed");

            return response;
        }

    }
}
