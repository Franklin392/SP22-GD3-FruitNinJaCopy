using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RightFruit : MonoBehaviour
{
    public GameObject Me;
    public float speed = 5;
   
    private void Start()
    {
        
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Destroy")
        {
            Destroy(Me);
            Debug.Log("Destroy Right half");

        }
    }
}
