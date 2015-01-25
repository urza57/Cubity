using UnityEngine;
using System.Collections;

public class getKey : MonoBehaviour {
	
	public GameObject player;
	public float distanceMin = 2f;

	// Use this for initialization
	void Start () {
		PlayerPrefs.SetInt("NbKey", 0);
		player = GameObject.Find("First Person Controller");
	}
	
	// Update is called once per frame
	void Update () {
		float distance = Vector3.Distance(player.transform.position, gameObject.transform.position);

		if(distance <= distanceMin){
			int nb = PlayerPrefs.GetInt("NbKey");
			PlayerPrefs.SetInt("NbKey", nb+1);
			Destroy(gameObject);
		}
	}
}
