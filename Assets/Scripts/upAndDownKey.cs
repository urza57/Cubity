using UnityEngine;
using System.Collections;

public class upAndDownKey : MonoBehaviour {

	public float moveSpeed = 0.1f;
	public bool isUp = true;

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		if(gameObject.transform.position.y <= 1.5f && isUp == true){
			transform.Translate(new Vector3 (0, 1, 0) * Time.deltaTime * 0.8f);
		}
		else {
			isUp = false;
			if(gameObject.transform.position.y >= 0.5f)
				transform.Translate(new Vector3 (0, -1, 0) * Time.deltaTime * 0.8f);
			else
				isUp = true;
		}
	}
}