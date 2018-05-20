using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerCamera : MonoBehaviour {

    Transform player;
    public float playerX;
    public float playerY;
    public float playerZ;
    public float playRotX;
    public float playRotY;
    public float playRotZ;
    private Vector3 relpos;

    // Use this for initialization
    void Start () {
        player = GameObject.FindGameObjectWithTag("Player").transform;
	}
	
	// Update is called once per frame
	void Update () {
        playerX = player.transform.position.x;
        playerY = player.transform.position.y;
        playerZ = player.transform.position.z;
        playRotX = player.transform.rotation.eulerAngles.x;
        playRotY = player.transform.rotation.eulerAngles.y;
        playRotZ = player.transform.rotation.eulerAngles.z;
        
        transform.position = player.position + new Vector3(0, 5f, 0);
        relpos = player.position - transform.position;
        transform.rotation = Quaternion.LookRotation(relpos);
        
	}
}
