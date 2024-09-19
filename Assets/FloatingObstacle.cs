using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FloatingObstacleScript : MonoBehaviour
{
    new MeshRenderer renderer;
    new Rigidbody rigidbody;

    [SerializeField]float timeToWait = 5f;

    void Start()
    {
        renderer = GetComponent<MeshRenderer>();
        rigidbody = GetComponent<Rigidbody>();
        renderer.enabled = false;
        rigidbody.useGravity = false;
    }

    void RevealAndDrop()
    {
      if(Time.time > timeToWait)
        {
            renderer.enabled = true;
            rigidbody.useGravity = true;
        
        }
     
    }
    void Update()
    {
        if (Time.time > timeToWait)
        {
            Debug.Log(Time.time);
            renderer.enabled = true;
            rigidbody.useGravity = true;

        }
    }
}

