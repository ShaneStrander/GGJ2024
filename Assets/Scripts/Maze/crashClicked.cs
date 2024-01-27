using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class crashClicked : MonoBehaviour
{
    private void OnMouseDown()
    {
        // Perform actions when the user clicks on the object
        Debug.Log("Object clicked: " + gameObject.name);
    }
}
