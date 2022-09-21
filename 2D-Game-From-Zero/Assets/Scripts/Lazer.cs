using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lazer : MonoBehaviour
{
    [SerializeField]
    private float speed = 5;

    private int damage = 1;

    public GameObject impactEffect;

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
        
        if (other.gameObject.tag == "Enemie")
        {
            var enemieObj = other.GetComponent<Skeleton>();
            enemieObj.TakeDamage(damage);
        }
        // Instancia o efeito de impacto quando acertar algo
        Instantiate(impactEffect, transform.position, transform.rotation);
        Destroy(gameObject);


    }

}
