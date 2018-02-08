using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class walkcycle2controller : MonoBehaviour {
	public Animator anim ;
	public SpriteRenderer SR;
	public bool walking = false;

	public MAINCAMERA cameraman;

	public Rigidbody2D rb;





	// Use this for initialization
	void Start () {
		rb = gameObject.GetComponent<Rigidbody2D> ();


		anim = transform.GetComponent<Animator>();
		//		print ("set animator");

	}

	// Update is called once per frame
	void Update () {

//
//		if (this.transform.position.x> ){
//
//		
//
//		}else{
//				
//				
//
//		}
//		}
		
			//	if (guy.transform.position.x > 30|| guy.transform.position.x < 11|| 
			//	guy.transform.position.y > 5|| guy.transform.position.y < -5) {




			if (cameraman.state == 7) {


			if (Input.GetKey (KeyCode.RightArrow)) {
				Vector3 pos = transform.position;
				rb.MovePosition((Vector2)transform.position + new Vector2 (.03f,0));
				//transform.position = pos;
				walking = true;
				SR.flipX = false;
			}

			if (Input.GetKey (KeyCode.LeftArrow)) {
				Vector3 pos = transform.position;
						rb.MovePosition ((Vector2)transform.position + new Vector2 (-.03f,0));
				//transform.position = pos;
				walking = true;
			

				SR.flipX = true;
			}

			if (Input.GetKey (KeyCode.UpArrow)) {
				Vector3 pos = transform.position;
				rb.MovePosition ((Vector2)transform.position + new Vector2 (0, 0.03f));
			//	transform.position = pos;
				walking = true;

				//	transform.position.x += 1;


			}

			if (Input.GetKey (KeyCode.DownArrow)) {
				Vector3 pos = transform.position;
								rb.MovePosition ((Vector2)transform.position + new Vector2 (0, -.03f));
			//	transform.position = pos;
				walking = true;


			}

			if (!Input.anyKey) {
				walking = false;
			}

			anim.SetBool ("walking", walking);
		}




	}
}
