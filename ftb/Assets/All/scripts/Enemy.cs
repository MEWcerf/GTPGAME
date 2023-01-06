using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public int health;
    public GameObject dystroyEffect;
    public GameObject bloodSplah;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       if (health <= 0)
        {

            Destroy(gameObject);
        }
    }
    public void TakeDamage(int damage)
    {
        health -= damage;
    }
}
