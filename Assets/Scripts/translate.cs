using UnityEngine;
using System.Collections;

public class translate : MonoBehaviour {

	bool enter = true;
	float v;

	// Use this for initialization
	void Start () {
		v = gameObject.transform.position.z;
	}
	
	// Update is called once per frame
	void Update () {
		if (enter) {
			if (gameObject.transform.position.z - v >= 3.0f) {
				enter = !enter;
			}
			gameObject.transform.Translate(new Vector3(0.0f, 0.0f, 1.0f) * Time.deltaTime);
		}
		else {
			if (gameObject.transform.position.z - v <= 1.0f) {
				enter = !enter;
			}
			gameObject.transform.Translate(new Vector3(0.0f, 0.0f, -1.0f) * Time.deltaTime);
		}
	}
}
