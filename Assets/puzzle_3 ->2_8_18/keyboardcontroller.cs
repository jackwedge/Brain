using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class keyboardcontroller : MonoBehaviour {

	Sprite key_14;
	public Sprite[] keyboardsprites;
	public SpriteRenderer keyboardSpriterenderer;
	// Use this for initialization

	void Start () {
		keyboardSpriterenderer = GetComponent<SpriteRenderer> ();
		key_14 = keyboardSpriterenderer.sprite;
	}
	
	// Update is called once per frame
	void Update () {
		
		
	}

	public void MousePressed(int keynumber){
		keyboardSpriterenderer.sprite = keyboardsprites [keynumber];
//		if (!MousePressed()){
//			key_14 = keyboardSpriterenderer.sprite;


		}
}

