using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rainbowController : MonoBehaviour {
	public Sprite[] rainbowsprites;
	public SpriteRenderer rainbowSpriterenderer;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {


		
	}


	public void ChangeRainbowColor (int rainbowColor){
		rainbowSpriterenderer.sprite = rainbowsprites [rainbowColor];


	}

	public void ChangeRainbowColor (Sprite thissprite){
		rainbowSpriterenderer.sprite = thissprite;
}
}