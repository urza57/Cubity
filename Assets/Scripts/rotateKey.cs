using UnityEngine;
using System.Collections;

public class rotateKey : MonoBehaviour {

	//public float turnSpeed = 100f;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		transform.Rotate(Vector3.up, 100f * Time.deltaTime);
	}
}