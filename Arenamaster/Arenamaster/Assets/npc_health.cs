﻿using UnityEngine;
using System.Collections;

public class npc_health : npc_super {

	public float cap;		/* health cap */
	public  float current;

	public string examine;

	// Use this for initialization
	void Start () {
		cap = 100;
		current = 100;
		//id = 10.0F;
	}
	
	// Update is called once per frame
	void Update () {

	}
}
