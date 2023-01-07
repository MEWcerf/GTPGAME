using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;

public class SpawnPlayers : MonoBehaviour
{
    public GameObject player;
    public float minX, minY, maxX, maxY;
    void Start()
    {
        Vector2 randomPosition = new Vector2(Random.Range(minY, minX), Random.Range(maxY, maxX));
        PhotonNetwork.Instantiate(player.name, randomPosition, Quaternion.identity);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
