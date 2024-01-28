using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Interpreter : MonoBehaviour
{
    List<string> response = new List<string>();

    List<string> tasks = new List<string>();

    List<string> errorResponses = new List<string>();

    public GameObject tracker;

    void Start()
    {

        errorResponses.Add("What are you trying to say?");
        errorResponses.Add("That wasn't an option");
        errorResponses.Add("You're pretty bad at following instructions");
        errorResponses.Add("b r u h... type the right thing");
        errorResponses.Add("Please listen to me next time");

        CreateTaskList();
    }

    public List<string> Interpret(string userInput)
    {
        response.Clear();

        string[] args = userInput.Split();

        string prevRes = args[0];

        if (args[0] == "Tasks")
        {
            response.Add("Choose a task by typing it in the terminal to begin...");
            for (int i = 0; i < tasks.Count; i++)
            {
                response.Add(tasks[i]);
            }

            return response;
        }
        else if (args[0] == "Task1")
        {
            response.Add("Prepare yourself");

            SceneManager.LoadScene("lvl_maze");

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

    public void RemoveTask()
    {
        if (SceneManager.GetActiveScene().name == "lvl_maze")
        {
            tasks.Remove("Task1");
        }
    }

    public void CreateTaskList()
    {

        scr_sceneTracker track = tracker.GetComponent<scr_sceneTracker>();

        bool isVisited = track.IsSceneVisited("lvl_maze");

        if(isVisited)
        {
            tasks.Add("Task2");
            tasks.Add("Task3");
            tasks.Add("Task4");
        }
        else
        {
            tasks.Add("Task1");
            tasks.Add("Task2");
            tasks.Add("Task3");
            tasks.Add("Task4");
        }
    }
}
