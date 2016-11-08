using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class NumberWizard : MonoBehaviour {
	// Use this for initialization
	int max;
	int min;
	int guess;
	int maxNumGuesses = 5;
	int currNumGuesses = 0;

	public Text currGuess;

	void Start() {
		StartGame();
	}
	
	void StartGame() {
		max = 1000;
		min = 1;
		guess = NextGuess();
		currGuess.text = guess.ToString();
		currNumGuesses+=1;
	}


	public void GuessHigher()
	{
		if (currNumGuesses == maxNumGuesses) {
			WinGame();
		}
		min = guess;
		guess = NextGuess();
		currGuess.text = guess.ToString();
		currNumGuesses+=1;
	}

	public void GuessLower()
	{
		if (currNumGuesses == maxNumGuesses) {
			WinGame();
		}
		max = guess;
		guess = NextGuess();
		currGuess.text = guess.ToString();
		currNumGuesses+=1;
	}

	int NextGuess() {
		guess = Random.Range(min, max+1);
		return guess;
	}

	void WinGame() {
		Application.LoadLevel("Win");
	}
}