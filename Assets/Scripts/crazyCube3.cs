using UnityEngine;
using System.Collections;

public class crazyCube3 : MonoBehaviour {

	// Update is called once per frame
	void Update () {
		transform.Rotate(Vector3.right, Time.deltaTime * 100);
		transform.Rotate(Vector3.up, Time.deltaTime * 100, Space.World);
	}
}
