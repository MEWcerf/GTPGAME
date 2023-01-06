using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Preffab : MonoBehaviour
{
    
    public float speed;
    public float distance;
    public int damage;
    public GameObject distroyEffect;
    public GameObject bloodSplash;
    public LayerMask layerMask;

    void Start()
    {
      
        
    }

    // Update is called once per frame
    void Update()
    {
        RaycastHit2D other = Physics2D.Raycast(transform.position, transform.up, distance, layerMask);
        if (other.collider != null)
        {
            if (other.collider.CompareTag("Enemy"))
            {
                other.collider.GetComponent<Enemy>().TakeDamage(damage);
                
                Destroy(gameObject);
                
            }
            if (other.collider.CompareTag("Ground"))
            {
                
                Destroy(gameObject);
            }
        }
        transform.Translate(Vector2.up * speed * Time.deltaTime);
        
    }
   
}
