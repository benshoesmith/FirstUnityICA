﻿using UnityEngine;
using System.Collections;

public class Chase : MonoBehaviour {

    public Transform player;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

        if(Vector3.Distance(player.position, this.transform.position) <20 )
        {
            Vector3 direction = player.position - this.transform.position;
            direction.y = 0;

            this.transform.rotation = Quaternion.Slerp(this.transform.rotation, Quaternion.LookRotation(direction), 0.1f);

            if(direction.magnitude > 2)
            {
                this.transform.Translate(0, 0, 0.5f);
            }
        }
	
	}
}
