using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectHit : MonoBehaviour
{
    // Show a message each hit in wall
    private void OnCollisionEnter(Collision collision)
    {
        // Change color when hit the wall
        GetComponent<MeshRenderer>().material.color = Color.red;
    }
    
}
