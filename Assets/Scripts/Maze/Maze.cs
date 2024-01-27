using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Maze : MonoBehaviour
{
    // Start is called before the first frame update
    private void OnMouseEnter()
    {
        // Perform actions when the mouse hovers over the object
        SceneManager.LoadScene("lvl_maze");

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
