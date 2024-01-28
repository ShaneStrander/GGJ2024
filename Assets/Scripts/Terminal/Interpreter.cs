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

    private string prevResp;

    private bool visitedBreak;


    void Start()
    {
        prevResp = string.Empty;
        //visitedBreak = false;

        errorResponses.Add("What are you trying to say?");
        errorResponses.Add("That wasn't an option");
        errorResponses.Add("You're pretty bad at following instructions");
        errorResponses.Add("b r u h... type the right thing");
        errorResponses.Add("Please listen to me next time");

        CreateTaskList();
    }

    public List<string> Interpret(string userInput)
    {
        Debug.Log(visitedBreak);

        response.Clear();
        if (userInput == "Reward" && prevResp == "Tasks")
        {
            if (tasks.Count == 0)
            {
                SceneManager.LoadScene("lvl_ending");
            }
            else
            {
                response.Add("You tryna cheat?");
            }
        }
        if (userInput == "Tasks")
        {

            if (tasks.Count == 0)
            {
                response.Add("Congrats... you did it!");
                response.Add("Type in 'Reward' to get a prize :)");
                prevResp = "Tasks";
            }
            else if (tasks.Count == 2 && !visitedBreak)
            {
                response.Add("Wow! You've completed 3 tasks already");
                response.Add("Looks likes you deserve a little break");
                response.Add("Type 'ok' to relax a little...");
                prevResp = "breakTime";
            }
            else
            {
                response.Add("Choose a task by typing it in the terminal to begin...");
                for (int i = 0; i < tasks.Count; i++)
                {
                    response.Add(tasks[i]);
                }
                prevResp = "Tasks";
            }

            return response;


        }
        // INTERNET HISTORY
        else if (userInput == "Task1" && tasks.Contains("Task1") && prevResp == "Tasks")
        {
            response.Add("Prepare yourself");
            SceneManager.LoadScene("lvl_internet_history");
            prevResp = null;
            return response;
        }
        // MAZE CRASH
        else if (userInput == "Task2" && tasks.Contains("Task2") && prevResp == "Tasks")
        {
            response.Add("Prepare yourself");
            SceneManager.LoadScene("lvl_maze");
            prevResp = null;
            return response;
        }
        // HEART ATTACK
        else if (userInput == "Task3" && tasks.Contains("Task3") && prevResp == "Tasks")
        {
            response.Add("Prepare yourself");
            SceneManager.LoadScene("lvl_heartattack");
            prevResp = null;
            return response;
        }
        // BUGS BLOW
        else if (userInput == "Task4" && tasks.Contains("Task4") && prevResp == "Tasks")
        {
            response.Add("Prepare yourself");
            SceneManager.LoadScene("Blow");
            prevResp = null;
            return response;
        }
        // CLOWN
        else if (userInput == "Task5" && tasks.Contains("Task5") && prevResp == "Tasks")
        {
            response.Add("Prepare yourself");
            SceneManager.LoadScene("lvl_clowncamera");
            prevResp = null;
            return response;
        }
        else if (userInput == "ok" && !visitedBreak && prevResp == "breakTime")
        {
            response.Add("Prepare yourself");
            SceneManager.LoadScene("lvl_break");
            prevResp = null;
            return response;
        }
        // ERROR MESSAGE
        else
        {
            int randomIndex = Random.Range(0, errorResponses.Count);
            response.Add(errorResponses[randomIndex]);
            response.Add("Try typing 'Tasks'...");

            return response;
        }

    }

   /*public void RemoveTask()
    {
        if (SceneManager.GetActiveScene().name == "lvl_maze")
        {
            tasks.Remove("Task1");
        }
    } */

    public void CreateTaskList()
    {

        tasks.Add("Task1");
        tasks.Add("Task2");
        tasks.Add("Task3");
        tasks.Add("Task4");
        tasks.Add("Task5");

        scr_sceneTracker track = tracker.GetComponent<scr_sceneTracker>();

        bool isVisited1 = track.IsSceneVisited("lvl_internet_history");
        bool isVisited2 = track.IsSceneVisited("lvl_maze");
        bool isVisited3 = track.IsSceneVisited("lvl_heartattack");
        bool isVisited4 = track.IsSceneVisited("Blow");
        bool isVisited5 = track.IsSceneVisited("lvl_clowncamera");
        visitedBreak = track.IsSceneVisited("lvl_break");

        if (isVisited1) { tasks.Remove("Task1"); }
        if (isVisited2) { tasks.Remove("Task2"); }
        if (isVisited3) { tasks.Remove("Task3"); }
        if (isVisited4) { tasks.Remove("Task4"); }
        if (isVisited5) { tasks.Remove("Task5"); }
    }
}
