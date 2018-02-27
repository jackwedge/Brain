using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class puzzle2controller : MonoBehaviour {
	public SpriteRenderer lensSpriterenderer;
	public Sprite [] lens1sprites;
	public Sprite [] lens2sprites;
	public Sprite [] lens3sprites;
	public Sprite [] lens1Asprites;
	public Sprite [] lens2Asprites;
	public Sprite [] lens3Asprites;




	int interval= 0;

	// Use this for initialization
	void Start () {
		lensSpriterenderer = GetComponent<SpriteRenderer> ();

		
	}
	
	// Update is called once per frame
	void Update () {



		
	}




	void OnMouseDown (){
		lensSpriterenderer.sprite = lens1sprites [interval%8];
		interval++;
	}

}

