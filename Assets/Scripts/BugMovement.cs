using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BugMovement : MonoBehaviour
{
    public GameObject[] objectsToInstantiate;
    public int numberOfCopies = 10;

    private float screenWidth;
    private float screenHeight;

    private GameObject[] instantiatedObjects;
    private Vector2[] targetPositions;
    private float movementSpeed = 3f;

    void Start()
    {
        screenWidth = Camera.main.orthographicSize * 2 * Camera.main.aspect;
        screenHeight = Camera.main.orthographicSize * 2;

        instantiatedObjects = new GameObject[objectsToInstantiate.Length * numberOfCopies];
        targetPositions = new Vector2[instantiatedObjects.Length];

        // Instantiate copies of each object and set initial target positions
        for (int i = 0; i < objectsToInstantiate.Length; i++)
        {
            for (int j = 0; j < numberOfCopies; j++)
            {
                int index = i * numberOfCopies + j;
                instantiatedObjects[index] = Instantiate(objectsToInstantiate[i], GetRandomPosition(), Quaternion.identity);
                instantiatedObjects[index].tag = "CloneTag";
                targetPositions[index] = GetRandomPosition();
            }
        }
    }

    Vector2 GetRandomPosition()
    {
        float x = Random.Range(-screenWidth / 2f, screenWidth / 2f);
        float y = Random.Range(-screenHeight / 2f, screenHeight / 2f);

        return new Vector2(x, y);
    }

    void Update()
    {
        for (int i = 0; i < instantiatedObjects.Length; i++)
        {
            MoveToTargetPosition(i);
        }
    }

    void MoveToTargetPosition(int index)
    {
        instantiatedObjects[index].transform.position = Vector2.MoveTowards(
            instantiatedObjects[index].transform.position,
            targetPositions[index],
            movementSpeed * Time.deltaTime
        );

        if ((Vector2)instantiatedObjects[index].transform.position == targetPositions[index])
        {
            // Object has reached the target, set a new random target
            targetPositions[index] = GetRandomPosition();
        }
    }

}
