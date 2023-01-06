using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wepon : MonoBehaviour
{
    public float offset;
    public float time;
    public float StartTime;

    public GameObject bullet;
    public Transform point;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 difference = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        float rotateZ = Mathf.Atan2(difference.y, difference.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.Euler(0f, 0f, rotateZ + offset);

        
        if(Input.GetMouseButtonDown(0))
        {
            Instantiate(bullet, point.position, transform.rotation );
        }
        
    }
}
