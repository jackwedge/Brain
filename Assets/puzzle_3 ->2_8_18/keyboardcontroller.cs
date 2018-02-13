using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class keyboardcontroller : MonoBehaviour {

	Sprite key_14;
	Sprite key_15;
	public Sprite[] keyboardsprites;
	public SpriteRenderer keyboardSpriterenderer;
	// Use this for initialization

	void Start () {
		keyboardSpriterenderer = GetComponent<SpriteRenderer> ();
		key_14 = keyboardSpriterenderer.sprite;
//		key_15 = keyboardSpriterenderer.sprite = keyboardsprites [keynumber];
	}
	
	// Update is called once per frame
	void Update () {


//		if (Input.GetMouseButtonDown (0)) {
//			Debug.Log ("PLAYING DA MUSIC BRO.");
//			keyboardSpriterenderer.sprite = key_15;
//		}


		if (Input.GetMouseButtonUp (0)) {
			Debug.Log ("Pressed left click.");
			keyboardSpriterenderer.sprite = key_14;


		}


		
		
	}
//
	public void MousePressed(int keynumber){
		keyboardSpriterenderer.sprite = keyboardsprites [keynumber];
//		if (!MousePressed()){
//			key_14 = keyboardSpriterenderer.sprite;

	
	}
}






