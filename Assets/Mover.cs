using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{
    [SerializeField]float moveSpeed = 10f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        TranslateFreeXZ(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"), moveSpeed);
    }
    public void TranslateFreeXZ(float x, float y, float z, float moveSpeed)
    {
        float xValue = x * Time.deltaTime * moveSpeed;
        float yValue = y * Time.deltaTime * moveSpeed;
        float zValue = z * Time.deltaTime * moveSpeed;
        transform.Translate(xValue, yValue, zValue);
    }
}
