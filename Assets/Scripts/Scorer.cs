 using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Scorer : MonoBehaviour
{
    private int value = 1;
    private void OnCollisionEnter(Collision collision)
    {
        if(value <= 4)
        {
            Debug.Log($"You've bumped into a thing this many times: {value}");
            value++;
        }
        else
        {
            Debug.Log("Game over!!");
            // Reste game
            SceneManager.LoadScene(0);
        }
    }
}
