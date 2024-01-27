using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class mazeToggle : MonoBehaviour
{
    public float crossingXValue = 0.0f;
    public GameObject button;
    public GameObject maze;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(maze.activeInHierarchy)
        {
            
            // Get the mouse position in screen coordinates
            Vector3 mousePosition = Input.mousePosition;

            // Convert the mouse position to world coordinates
            Vector3 worldMousePosition = Camera.main.ScreenToWorldPoint(mousePosition);

            // Check if the mouse has crossed the specified X value
            if (worldMousePosition.x > 0)
            {
                Debug.Log("simulate crash");
                //Diagnostics.Utils.ForceCrash(ForcedCrashCategory.FatalError);
            }
        }
    }

    public void toggle()
    {
        button.SetActive(false);
        maze.SetActive(true);
    }
}
