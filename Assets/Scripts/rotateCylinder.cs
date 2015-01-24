using UnityEngine;
using System.Collections;

public class rotateCylinder : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		transform.Rotate(Vector3.back, 40f * Time.deltaTime);
	}
}