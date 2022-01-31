using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fruit : MonoBehaviour
{
    [SerializeField] private Animator myAnimationController;

    Rigidbody2D rb;
    public float startForce = 25f;
    public GameObject Me;
    public GameObject H1;
    public GameObject H2;
    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag == "Blade")
        {
            //myAnimationController.SetBool("Cut", true);
            ScoreManager.instance.AddPoint();
            Debug.Log("Hit fruit！");
            //,gameObject.transform.position, gameObject.transform.rotation
            Instantiate(H1, gameObject.transform.position, Quaternion.Euler(0, 0, 90)); //Quaternion才是旋转角度
            Instantiate(H2, gameObject.transform.position, Quaternion.Euler(0, 0, -90));
            Destroy(this.gameObject);
        }
        if (other.tag == "FruitDestroy")
        {
            Destroy(Me);
            Debug.Log("Destroy Fruit");
            ScoreManager.instance.LosePoint();

        }
    }
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.AddForce(transform.up * startForce, ForceMode2D.Impulse);
    }
}
