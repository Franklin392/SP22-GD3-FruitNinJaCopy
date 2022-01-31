using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeftFruit : MonoBehaviour
{
    public GameObject Me;
    public float speed = 5;
    public Rigidbody2D rb;
    private void Start()
    {
        rb.velocity = transform.up* speed;
        
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Destroy")
        {
            Destroy(Me);
            Debug.Log("Destroy Left Half");
            
        }
    }
}
