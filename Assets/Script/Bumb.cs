using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Bumb : MonoBehaviour
{
    Rigidbody2D rb;
    public float startForce = 25f;

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Blade")
        {
            Debug.Log("bomb£¡");
            SceneManager.LoadScene(1);
        }
    }
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.AddForce(transform.up * startForce, ForceMode2D.Impulse);
    }
}
