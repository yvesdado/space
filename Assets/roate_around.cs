using UnityEngine;
using System.Collections;

public class roate_around : MonoBehaviour {
	public Transform cube;
	public Transform sphere;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		sphere.RotateAround (cube.position, new Vector3 (10, 1, 0), 70 * Time.deltaTime);
		sphere.RotateAround (sphere.position, new Vector3 (10, 1, 0), 100 * Time.deltaTime);
	}
}
