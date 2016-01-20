using UnityEngine;
using System.Collections;

public class NumberWizard : MonoBehaviour {

	// Use this for initialization
	int max;
	int min;
	int guess;
	
	void Start () {
		StartGame ();
	}

	void StartGame () {
		max = 1000;
		min = 1;
		guess = 500;
		
		print ("======New Game=======");
		print ("Welcome To Number Wizard");
		print ("Pick a number in your head, but don't tell me what it is.");
	
		print ("The highest number you can pick is " + max);
		print ("The lowest number you can pick is " + min);
	
		print ("Is the number higher or lower than " + guess + "?");
		print ("Press the UP arrow for higher, the DOWN arrow for lower, or enter for equals.");
		max++ ;
	}
	
	
	void NextGuess (){
		guess = (max + min) / 2;
		print ("Higher or lower than " + guess + "?");
		print ("Press the UP arrow for higher, the DOWN arrow for lower, or enter for equals.");
	}
	
	// Update is called once per frame
	void Update () {
		if (max < guess || min > guess ){
			print ("No one likes a liar...");
			
		} else if (Input.GetKeyDown (KeyCode.UpArrow)) {
			//print ("Up Arrow pressed");
			min = guess + 1;
			NextGuess();
			
		}else if (Input.GetKeyDown (KeyCode.DownArrow)) {
			//print ("Down Arrow pressed");
			max = guess;
			NextGuess();
			
		}else if (Input.GetKeyDown (KeyCode.Return)) {
			print ("I won!");
			StartGame ();
		}
	}
}
