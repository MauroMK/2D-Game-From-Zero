using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lazer : MonoBehaviour
{
    [SerializeField]
    private float speed = 5;

    void Start()
    {
        var lazerRb = GetComponent<Rigidbody2D>();
        lazerRb.velocity = transform.right * speed;
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            return;
        }
        Destroy(gameObject);

    }

}
