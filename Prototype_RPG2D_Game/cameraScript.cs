﻿using UnityEngine;
using System.Collections;

public class cameraScript : MonoBehaviour {

    public Transform player;
    public Vector3 offset;

    void Start () {
	}
	
	void Update(){
        transform.position = new Vector3
            (player.position.x + offset.x, player.position.y + offset.y, offset.z);
    }

}
