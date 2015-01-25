using UnityEngine;
using System.Collections;

public class crazyCube2 : MonoBehaviour {


	// Update is called once per frame
	void Update () {
		transform.Rotate(Vector3.right, Time.deltaTime * 300);
		transform.Rotate(Vector3.up, Time.deltaTime * 300, Space.World);
	}
}
