using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class RotateOverTime : MonoBehaviour {
	public float rotationAmount;
	public bool rotating = false;
	public float speed = 100.0f;
	public float angle = -90.0f;
	public List<GameObject> stairs;
	public GameObject[] button;
	//private bool[] haveCube;
	public bool itsOkay = false;
	private GameObject[] dynamic;
	private int result = 0;
	// Use this for initialization
	void Start () {
		//haveCube = new bool[6];
		dynamic = GameObject.FindGameObjectsWithTag("DynamicObject");
	}

	IEnumerator RotateBy(float angle, Vector3 axis, float speed) {
		rotating = true;
		Quaternion start = transform.rotation;
		
		float curAngle = 0.0f;
		
		while (Mathf.Abs (curAngle - angle) > 0.0001f) {
			curAngle = Mathf.MoveTowards (curAngle, angle, Time.deltaTime * speed);
			foreach(GameObject go in stairs){
				go.transform.rotation = Quaternion.AngleAxis (curAngle, axis) * start;
			}
			yield return null;
		}
		
		transform.rotation = Quaternion.AngleAxis (angle, axis) * start;
		//rotating = false;
	}

	// Update is called once per frame
	void Update () {
		result = 0;
		if (!rotating)
		{
			for(int i = 0; i < button.Length; i++)
			{	foreach(GameObject obj in dynamic)
				{
					float dist = Vector3.Distance(button[i].transform.position, obj.transform.position);
					if (dist < 1.0f)
					{
						if (i == 1 || i == 3 || i == 4)
						{
							result++;
						}
						else
						{
							result--;
						}
					}
				}
			}
		}
		if (result == 3)
		{
			itsOkay = true;
		}
		if (!rotating && itsOkay) {
			StartCoroutine(RotateBy(angle, Vector3.right, speed));

		}
		//transform.Rotate (0, rotationAmount * Time.deltaTime, 0); 
	}
}
