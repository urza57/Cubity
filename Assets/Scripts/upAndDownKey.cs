using UnityEngine;
using System.Collections;

public class upAndDownKey : MonoBehaviour {

	public float moveSpeed = 2.5f;
	public bool isUp = true;

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		if(gameObject.transform.position.y <= 10.0f && isUp == true){
			transform.Translate(new Vector3 (0, 1, 0) * Time.deltaTime * moveSpeed);
		}
		else {
			isUp = false;
			if(gameObject.transform.position.y >= 2.0f)
				transform.Translate(new Vector3 (0, -1, 0) * Time.deltaTime * moveSpeed);
			else
				isUp = true;
		}
	}
}