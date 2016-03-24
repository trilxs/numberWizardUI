using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class NumberWizard : MonoBehaviour {
	int max, min, guess; 
	int maxGuessesAllowed = 10;
	
	public Text text, attempts;
	
	void Start () {
		StartGame ();
	}
	
	void StartGame() {
		min = 1; 
		max = 1000;
		guess = Random.Range (min, max + 1);
		text.text = guess.ToString ();
	}
	
	public void GuessHigher() {
		min = guess;
		NextGuess ();
	}
	
	public void GuessLower() {
		max = guess;
		NextGuess ();
	}
	
	void NextGuess() {
		guess = Random.Range (min, max + 1);
		text.text = guess.ToString ();
		maxGuessesAllowed--;
		attempts.text = "Number of tries the \"wizard\" has left: " + 
						maxGuessesAllowed.ToString ();
		if (maxGuessesAllowed <= 0) Application.LoadLevel ("Win");
	}
}
