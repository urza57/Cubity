using UnityEngine;
using System.Collections;

public class crazyCube : MonoBehaviour {

	public float basicScale = 2.0f;
	public float maxScale = 5.0f;
	public bool isplus = false;
	
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		transform.Rotate(Vector3.right, Time.deltaTime * 300);
		transform.Rotate(Vector3.up, Time.deltaTime * 300, Space.World);
		float retval = 0.5f * Time.deltaTime;
		if (Input.GetKeyDown(KeyCode.R))
		{
			isplus = true;
		}
		if (isplus && transform.localScale.x >= 0.0f)
		{
			transform.localScale -= new Vector3(retval, retval, retval);
		}
		if  (transform.localScale.x <= 0.0f)
		{
			Destroy(transform.parent.gameObject);
		}
	}
}
