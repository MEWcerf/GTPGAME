using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movecum : MonoBehaviour
{
    private Transform player;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Vector2 PlayerPos = player.transform.position;
        transform.position = new Vector2(PlayerPos.x, PlayerPos.y);
    }
}
