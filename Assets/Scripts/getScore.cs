using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class getScore : MonoBehaviour
{
	public int score;        // The player's score.


	Text text;                      // Reference to the Text component.


	void Awake ()
	{
		// Set up the reference.
		text = GetComponent <Text> ();
        score = PlayerPrefs.GetInt("currentpoints");
		// Reset the score.
	}


	void Update ()
	{
		// Set the displayed text to be the word "Score" followed by the score value.
		text.text = "Score: " + score;
	}
}
