using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class mazeToggle : MonoBehaviour
{

    public GameObject button;
    public GameObject maze;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void toggle()
    {
        button.SetActive(false);
        maze.SetActive(true);
    }
}
