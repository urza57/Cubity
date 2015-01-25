using UnityEngine;
using System.Collections;

public class endGame : MonoBehaviour {

	private GameObject player;
	public GameObject[] level;
	private bool playerArrived = false;
	private float timer = 5.0f;
	private float t = 0;
	public float duration = 10;
	// Use this for initialization
	void Start () {
		player =  GameObject.Find("First Person Controller");
	}
	
	// Update is called once per frame
	void Update () {

		if (Vector3.Distance(this.player.transform.position, transform.position) < 20.0)
		{
			playerArrived = true;
		}
		if (playerArrived)
		{
			timer -= Time.deltaTime;
		}
		if (playerArrived && (timer < 0.0f))
		{
			foreach(GameObject lvl in level)
			{
				lvl.renderer.material.color = Color.Lerp(lvl.renderer.material.color, Color.black, t);
			}
			if (t < 1)
			{
				t += Time.deltaTime/duration;
			}
		}
		if ( t >= 1)
		{
			Application.LoadLevel("credits");
		}
	}
}
