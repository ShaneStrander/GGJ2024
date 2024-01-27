using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Diagnostics;


public class mazeToggle : MonoBehaviour
{
    public float crossingXValue = 0.0f;
    public GameObject button;
    public GameObject maze;
    public GameObject crash;
    public GameObject background;
    public GameObject grayPanel;

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (maze.activeInHierarchy)
        {

            // Get the mouse position in screen coordinates
            Vector3 mousePosition = Input.mousePosition;

            // Convert the mouse position to world coordinates
            Vector3 worldMousePosition = Camera.main.ScreenToWorldPoint(mousePosition);

            // Check if the mouse has crossed the specified X value
            if (worldMousePosition.x > 0)
            {
                grayPanel.SetActive(true);
                Cursor.lockState = CursorLockMode.Locked;
                Invoke("Freeze", 4f);
            }
        }
    }

    void Freeze()
    {
        grayPanel.SetActive(false);
        maze.SetActive(false);
        background.SetActive(false);

        Invoke("Popup", 1.5f);
    }

    void Popup()
    {
        Cursor.lockState = CursorLockMode.None;
        crash.SetActive(true);
    }

    public void toggle()
    {
        button.SetActive(false);
        maze.SetActive(true);
    }
}
