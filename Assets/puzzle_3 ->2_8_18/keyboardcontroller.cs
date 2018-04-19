using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class keyboardcontroller : MonoBehaviour {

	Sprite key_14;
	Sprite key_15;
	public Sprite[] keyboardsprites;
	public SpriteRenderer keyboardSpriterenderer;
	// Use this for initialization
	public rainbowController myColorHighlight;
	public SpriteRenderer RainbowSpriterenderer;
	public Sprite startingRainbow;
	public AlphabetController LetterSelecter;
	public SpriteRenderer AlphabetSpriterenderer;




	void Start () {
		keyboardSpriterenderer = GetComponent<SpriteRenderer> ();
		key_14 = keyboardSpriterenderer.sprite;

		RainbowSpriterenderer = GetComponent<SpriteRenderer> ();
		//rainbow_for_brain0001 = "rainbow_for_brain0001";

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
			myColorHighlight.ChangeRainbowColor (startingRainbow);

			keyboardSpriterenderer.sprite = key_14;



		}
	}

	public void MousePressed(int keynumber){

	
		keyboardSpriterenderer.sprite = keyboardsprites [keynumber];


		myColorHighlight.ChangeRainbowColor (keynumber % 7);


		LetterSelecter.ChangeLetter (keynumber % 7);

	
	
	}




}






