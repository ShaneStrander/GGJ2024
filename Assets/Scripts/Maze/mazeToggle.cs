using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Diagnostics;
using System.Windows.Input;


public class mazeToggle : MonoBehaviour
{
    public float crossingXValue = 0.0f;
    public GameObject button;
    public GameObject maze;
    public GameObject crash;
    public GameObject background;
    public GameObject grayPanel;

    [SerializeField] private Texture2D[] cursorArray;
    [SerializeField] private int frameCount;
    [SerializeField] private float frameRate;

    private int currentFrame;
    private float frameTimer;

    public static bool trigger;

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        frameTimer -= Time.deltaTime;

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
                trigger = true;
                //Cursor.lockState = CursorLockMode.Locked;
                Cursor.visible = true;
                Invoke("Freeze", 2.5f);
            }

            if (trigger)
            {
                if (frameTimer <= 0f)
                {
                    frameTimer += frameRate;
                    currentFrame = (currentFrame + 1) % frameCount;
                    Cursor.SetCursor(cursorArray[currentFrame], Vector2.zero, CursorMode.Auto);
                }
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
        Cursor.SetCursor(null, Vector2.zero, CursorMode.Auto);
        trigger = false;
        crash.SetActive(true);
    }

    public void toggle()
    {
        button.SetActive(false);
        maze.SetActive(true);
    }
}
