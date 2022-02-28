using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectHit : MonoBehaviour
{
    new MeshRenderer renderer;
    // Show a message each hit in wall
    private void OnCollisionEnter(Collision other)
    {
        if(other.gameObject.tag == "Player")
        {
            renderer = GetComponent<MeshRenderer>();
            // Change color when hit the wall
            renderer.material.color = Color.red;
        }

    }
    void Update()
    {
        if (Time.time > 4)
        {
            GetComponent<BoxCollider>().enabled = false;
        }
    }

}
