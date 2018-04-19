using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class puzzle_1controller : MonoBehaviour {





	public 	IEnumerator delay (float duration, int tempstate)
	{
		yield return new WaitForSeconds (duration);
	
		MAINCAMERA.Me.state = tempstate;

	}

	int currentNumber=1;
	public	puzzle_1buttoncontroller[] buttoncontrollers;

	public void Pressed(int g_buttonNumber) {

		if (currentNumber == g_buttonNumber) {
			//correct button pressed then continue sequence

			currentNumber++;
		} else {
			//reset the buttons
			currentNumber=1;
			//reset to 1

			for (int i = 0; i < buttoncontrollers.Length; i++){

				buttoncontrollers[i].PuzzleFailed();
			}



		}

		if (currentNumber == 10) {
			//when all buttons are pressed move camera
			Debug.Log ("Correct good job (:");

		//	MAINCAMERA.Me.state == 8  && Input.GetMouseButtonDown (0)) {

				MAINCAMERA.Me.state = 7;

			StartCoroutine(delay(2,9));

			StartCoroutine(delay(3,10));

				




		//	transform.position = welcome2brainposition;

			
		}


		

		Debug.Log ("current number:" + currentNumber);
	}




	// Use this for initialization
	void Start () {

}
	
	// Update is called once per frame
	void Update () {
		
	}
}
