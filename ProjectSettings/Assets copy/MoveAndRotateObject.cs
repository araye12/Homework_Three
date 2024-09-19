using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveAndRotateObject : MonoBehaviour
{
    public float moveSpeed = 4f;
    public float rotationSpeed = 20f;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        // Move the object forward 
        transform.Translate(Vector3.forward * moveSpeed * Time.deltaTime);

        // Rotate the object around the Y-axis 
        transform.Rotate(Vector3.up * rotationSpeed * Time.deltaTime);
    }
}




