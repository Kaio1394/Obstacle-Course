using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColliderObstacle : MonoBehaviour
{
    MeshRenderer renderer;
    // Start is called before the first frame update
    private void OnCollisionEnter(Collision collision)
    {
        renderer = GetComponent<MeshRenderer>();
        // Change color when hit the wall
        renderer.material.color = Color.red;

        // Destroy a component
        //Destroy(gameObject);
    }
}
