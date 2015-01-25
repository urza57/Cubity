using UnityEngine;
using System.Collections;

public class loadLevelAfterImage : MonoBehaviour {
	
	public bool isEnd = false;
	public float time;

	// Use this for initialization
	void Start () {
		time = 5.0f;
	}
	
	// Update is called once per frame
	void Update () {
		isEnd = false;

		if(time >= 0.0f){
			time -= Time.deltaTime;
		}
		else{
			StartTheGame();
		}
	}	

	public void ExitTheGame()
	{
		Application.Quit();
	}
	
	public void StartTheGame()
	{

		Application.LoadLevel("finalLevel");
	}
}