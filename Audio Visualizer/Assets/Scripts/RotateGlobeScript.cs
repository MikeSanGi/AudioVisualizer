﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateGlobeScript : MonoBehaviour {

	public int rotateSpeed = -100;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () 
	{
		transform.Rotate((rotateSpeed* Vector3.left) * Time.deltaTime);
	}
}
