﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageAttack : MonoBehaviour
{
    public float horizontalForce = 15;
    public float verticalForce = 10;
    public float timeDestruction = 1;

    float defaultForce;



    void Start()
    {
        defaultForce = horizontalForce;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    /*private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Enemy"))
        {
           other.gameObject.GetComponent<Enemy>().enabled = false;
            BoxCollider2D[] boxes = other.gameObject.GetComponents<BoxCollider2D>();
            foreach (BoxCollider2D box in boxes)
            {
                box.enabled = false;
            }

            if (other.transform.position.x < transform.position.x)
                horizontalForce *= -1;

            other.gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(horizontalForce, verticalForce), ForceMode2D.Impulse);

            Destroy(other.gameObject, timeDestruction);

            horizontalForce = defaultForce;
        }
    }*/
}
