using UnityEngine;
using System.Collections;

public class crazyObject : MonoBehaviour {

	private GameObject player;
//	public GameObject room_1;
//	public GameObject room_4;
	private bool hasmove = false;
	public GameObject couloir;
	// Update is called once per frame

	void Start()
	{
		player = GameObject.Find("First Person Controller");
	}

	void Update () {
		transform.Rotate(Vector3.right, Time.deltaTime * 300);
		transform.Rotate(Vector3.up, Time.deltaTime * 300, Space.World);
		if (!hasmove)
		{
			if (Vector3.Distance(transform.position, player.transform.position) <= 9.0f)
			{

				player.transform.parent = couloir.transform;
				couloir.transform.position = new Vector3(137.32f, 6.5f, -47.9f);
				//room_1.transform.position = pos4;
				//room_4.transform.position = pos1;
				player.transform.parent = null;
				hasmove = true;
				//move room
			}
		}
	}
	
	void OnDrawGizmos() {
		Gizmos.color = Color.yellow;
		Gizmos.DrawWireSphere(transform.position, 9.0f);
	}
}
