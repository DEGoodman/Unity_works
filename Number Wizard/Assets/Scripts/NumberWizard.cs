using UnityEngine;
using System.Collections;

public class NumberWizard : MonoBehaviour {

	int max = 1000;
	int min = 1;
	int guess = 500;
	
	// Use this for initialization
	void Start () {
		print ("Welcome to Number Wizard.");
		print ("Pick a number in your head, but don't tell me!");
		
		
		print ("The highest number you can pick is " + max);
		max += 1;
		print ("The lowest number you can pick is " + min);
		
		print ("Is the number higher or lower than " + guess + "?");
		print ("Up = higher, Down = lower, return = equal.");
		
	}
	
	// Update is called once per frame
	void Update () {
		if (max < guess || min > guess ){
			print ("No one likes a liar...");
		}
		
		else if (Input.GetKeyDown(KeyCode.UpArrow)){
			min = guess + 1;
			guess = (max + guess) / 2;
			print ("Is the number higher or lower than " + guess + "?");
		}
		
		else if (Input.GetKeyDown(KeyCode.DownArrow)){
			max = guess;
			guess = (min + guess) / 2;
			print ("Is the number higher or lower than " + guess + "?");
		}
		
		else if (Input.GetKeyDown(KeyCode.Return)){
			print ("I won!");
		}
		
	}
}
