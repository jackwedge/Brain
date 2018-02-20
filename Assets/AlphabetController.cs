using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AlphabetController : MonoBehaviour {


	public Sprite[] Alphabetsprites;
	public SpriteRenderer AlphabetSpriterenderer;
	int alphabet;
	int pressedtimes;
	int lastkey;
	string answer= "VESELKA" ;

	public string[] currentletters = new string[7];

	public int letterindex ;





	// Use this for initialization
	void Start () {


		
	}

	// Update is called once per frame
	void Update () {
		
	}

	public void ChangeLetter (int key){

		Debug.Log ("what key" + key);

		if (lastkey == key) {
			pressedtimes += 1;
			if (pressedtimes > 4) {
				pressedtimes = 1;
			}
		} else {
			lastkey = key;
			pressedtimes = 1;
		}
		
		if  (letterindex< 1 || letterindex>7 || AlphabetSpriterenderer == null){

			return;
		}

		if (lastkey == 0) {
			if (pressedtimes == 1) {
				Debug.Log ("W");
				currentletters [letterindex-1] = ("W");
				AlphabetSpriterenderer.sprite = Alphabetsprites [22];

			} else if (pressedtimes == 2) {
				Debug.Log ("Q");
				currentletters [letterindex-1] = ("Q");
				AlphabetSpriterenderer.sprite = Alphabetsprites [16];

			} else if (pressedtimes == 3) {
				Debug.Log ("J");
				currentletters [letterindex-1] = ("J");
				AlphabetSpriterenderer.sprite = Alphabetsprites [9];

			} else if (pressedtimes == 4) {
				Debug.Log ("B");
				currentletters [letterindex-1] = ("B");
				AlphabetSpriterenderer.sprite = Alphabetsprites [1];

			}

				
		}


		if (lastkey == 1) {
			if (pressedtimes == 1) {
				Debug.Log ("U");
				currentletters [letterindex-1] = ("U");
				AlphabetSpriterenderer.sprite = Alphabetsprites [20];
			} else if (pressedtimes == 2) {
				Debug.Log ("S");
				currentletters [letterindex-1] = ("S");
				AlphabetSpriterenderer.sprite = Alphabetsprites [18];
			} else if (pressedtimes == 3) {
				Debug.Log ("L");
				currentletters [letterindex-1] = ("L");
				AlphabetSpriterenderer.sprite = Alphabetsprites [11];
			} else if (pressedtimes == 4) {
				Debug.Log ("D");
				currentletters [letterindex-1] = ("D");
				AlphabetSpriterenderer.sprite = Alphabetsprites [3];
			}

		}


		if (lastkey == 2) {
			if (pressedtimes == 1) {
				Debug.Log ("Y");
				currentletters [letterindex-1] = ("Y");
				AlphabetSpriterenderer.sprite = Alphabetsprites [23];
			} else if (pressedtimes == 2) {
				Debug.Log ("V");
				currentletters [letterindex-1] = ("V");
				AlphabetSpriterenderer.sprite = Alphabetsprites [21];
			} else if (pressedtimes == 3) {
				Debug.Log ("N");
				currentletters [letterindex-1] = ("N");
			AlphabetSpriterenderer.sprite = Alphabetsprites [13];
			} else if (pressedtimes == 4) {
			Debug.Log ("U");
				currentletters [letterindex-1] = ("U");
				AlphabetSpriterenderer.sprite = Alphabetsprites [20];
		}

		}


		if (lastkey == 3) {
			if (pressedtimes == 1) {
				Debug.Log ("X");
				currentletters [letterindex-1] = ("X");
				AlphabetSpriterenderer.sprite = Alphabetsprites [24];
			} else if (pressedtimes == 2) {
				Debug.Log ("T");
				currentletters [letterindex-1] = ("T");
				AlphabetSpriterenderer.sprite = Alphabetsprites [19];
			} else if (pressedtimes == 3) {
				Debug.Log ("O");
				currentletters [letterindex-1] = ("O");
				AlphabetSpriterenderer.sprite = Alphabetsprites [14];
			} else if (pressedtimes == 4) {
				Debug.Log ("G");
				currentletters [letterindex-1] = ("G");
				AlphabetSpriterenderer.sprite = Alphabetsprites [6];
			}

		}

		if (lastkey == 4) {
			if (pressedtimes == 1) {
				Debug.Log ("P");
				currentletters [letterindex-1] = ("P");
				AlphabetSpriterenderer.sprite = Alphabetsprites [15];
			} else if (pressedtimes == 2) {
				Debug.Log ("I");
				currentletters [letterindex-1] = ("I");
				AlphabetSpriterenderer.sprite = Alphabetsprites [8];
			} else if (pressedtimes == 3) {
				Debug.Log ("R");
				currentletters [letterindex-1] = ("R");
				AlphabetSpriterenderer.sprite = Alphabetsprites [17];
			}

		}

		if (lastkey == 5) {
			if (pressedtimes == 1) {
				Debug.Log ("Z");
				currentletters [letterindex-1] = ("Z");
				AlphabetSpriterenderer.sprite = Alphabetsprites [25];
			} else if (pressedtimes == 2) {
				Debug.Log ("E");
				currentletters [letterindex-1] = ("E");
				AlphabetSpriterenderer.sprite = Alphabetsprites [4];
			} else if (pressedtimes == 3) {
				Debug.Log ("K");
				currentletters [letterindex-1] = ("K");
				AlphabetSpriterenderer.sprite = Alphabetsprites [10];
			} else if (pressedtimes == 4) {
				Debug.Log ("M");
				currentletters [letterindex-1] = ("M");
				AlphabetSpriterenderer.sprite = Alphabetsprites [12];
			}

		}

		if (lastkey == 6) {
			if (pressedtimes == 1) {
				Debug.Log ("A");
				currentletters [letterindex-1] = ("A");
				AlphabetSpriterenderer.sprite = Alphabetsprites [0];
			} else if (pressedtimes == 2) {
				Debug.Log ("C");
				currentletters [letterindex-1] = ("C");
				AlphabetSpriterenderer.sprite = Alphabetsprites [2];
			} else if (pressedtimes == 3) {
				Debug.Log ("F");
				currentletters [letterindex-1] = ("F");
				AlphabetSpriterenderer.sprite = Alphabetsprites [5];
			} else if (pressedtimes == 4) {
				Debug.Log ("H");
				currentletters [letterindex-1] = ("H");
				AlphabetSpriterenderer.sprite = Alphabetsprites [7];
			}

		}

	
		string currentanswer = "";
		foreach (string letter in currentletters) {
			currentanswer = currentanswer + letter;

		}

		Debug.Log (" currentanswer " + currentanswer);

		if (currentanswer == answer) {
			Debug.Log ("YOU WIN");
		}
		
	//AlphabetSpriterenderer.sprite = Alphabetsprites [alphabet];



	}




	public	void setAlphabetSpriterenderer (SpriteRenderer sr, int index){
		AlphabetSpriterenderer = sr;
		letterindex = index;
	}

}

