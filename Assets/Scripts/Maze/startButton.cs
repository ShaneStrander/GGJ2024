using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class startButton : MonoBehaviour
{
    public GameObject maze;

    private void OnMouseEnter()
    {
        Debug.Log("test");
        maze.SetActive(true);
        gameObject.SetActive(false);
    }
}
