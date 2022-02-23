using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColliderObstacle : MonoBehaviour
{
    // Start is called before the first frame update
    private void OnCollisionEnter(Collision collision)
    {
        // Change color when hit the wall
        GetComponent<MeshRenderer>().material.color = Color.red;
        
        // Destroy a component
        //Destroy(gameObject);
    }
}
