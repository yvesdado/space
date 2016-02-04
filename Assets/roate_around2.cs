﻿using UnityEngine;
using System.Collections;

public class roate_around2 : MonoBehaviour {
	public Transform cube;
	public Transform sphere;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		sphere.RotateAround (cube.position, new Vector3 (0, 1, 0), 10 * Time.deltaTime);
		sphere.RotateAround (sphere.position, new Vector3 (0, 1, 0), 100 * Time.deltaTime);
	}
}
