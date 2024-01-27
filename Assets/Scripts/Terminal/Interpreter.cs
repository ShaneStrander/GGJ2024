using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Interpreter : MonoBehaviour
{
    List<string> response = new List<string>();

    List<string> errorResponses = new List<string>();

    void Start()
    {
        errorResponses.Add("What are you trying to say?");
        errorResponses.Add("That wasn't an option");
        errorResponses.Add("You're pretty bad at following instructions");
        errorResponses.Add("b r u h... type the right thing");
        errorResponses.Add("Please listen to me next time");
    }

    public List<string> Interpret(string userInput)
    {
        response.Clear();

        string[] args = userInput.Split();

        string prevRes = args[0];

        if (args[0] == "Tasks")
        {
            response.Add("Choose a task by typing it in the terminal to begin...");
            response.Add("Task1");
            response.Add("Task2");
            response.Add("Task3");
            response.Add("Task4");

            return response;
        }
        else if (args[0] == "Task1")
        {
            response.Add("Prepare yourself");

            SceneManager.LoadScene("lvl_internet_history");

            return response;
        }
        else if (args[0] == "Task2")
        {
            response.Add("Prepare yourself");

            SceneManager.LoadScene("lvl_heartattack");

            return response;
        }
        else
        {
            int randomIndex = Random.Range(0, errorResponses.Count);
            response.Add(errorResponses[randomIndex]);
            response.Add("Type in the name of a Task below...");

            return response;
        }

    }
}
