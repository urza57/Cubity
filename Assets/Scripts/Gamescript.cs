using UnityEngine;
using System.Collections;

public class Gamescript : MonoBehaviour {

	public Texture2D cursorImage;
	private int cursorWidth = 64;
	private int cursorHeight = 64;

	/*public Texture2D cursorTexture;
	public CursorMode cursorMode = CursorMode.Auto;
	public Vector2 hotSpot = Vector2.zero;*/

	// Use this for initialization
	void Start () {
		Screen.showCursor = false;
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey(KeyCode.Escape))
		{
			Application.LoadLevel("menu");
		}
	}
	void OnGUI()
	{
		GUI.DrawTexture(new Rect(Input.mousePosition.x, Screen.height - Input.mousePosition.y, cursorWidth, cursorHeight), cursorImage);
		Screen.lockCursor = true;
	}
}
