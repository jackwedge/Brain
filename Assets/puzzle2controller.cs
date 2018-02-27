using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class puzzle2controller : MonoBehaviour {
	public SpriteRenderer lensSpriterenderer;
	public Sprite [] mysprites;
	public puzzle2controller lens2;





	int interval= 0;

	// Use this for initialization
	void Start () {
		lensSpriterenderer = GetComponent<SpriteRenderer> ();

		
	}
	
	// Update is called once per frame
	void Update () {



		
	}




	void OnMouseDown (){
		lensSpriterenderer.sprite = mysprites [interval%8];
		if (lens2 != null) {
			lens2.lensSpriterenderer.sprite = mysprites [interval % 8];
		}
			interval++;
	

	}

}

