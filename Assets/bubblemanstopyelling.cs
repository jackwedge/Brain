using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class bubblemanstopyelling : MonoBehaviour {

	public SpriteRenderer bubblemanstopyellingSpriterenderer;
	public Sprite [] mysprites;

	float timer;

	float waittime =0.1f;

	int interval= 0;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {







		
	}

	void OnMouseDown (){

		bubblemanstopyellingSpriterenderer.sprite = mysprites [interval];
		interval++;


		if (interval >= mysprites.Length) {
			interval = mysprites.Length - 1;
		}





		timer += waittime;

}
}
