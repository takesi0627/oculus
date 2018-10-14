using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour {

	[SerializeField] static int score = 0;
	[SerializeField] static int maxScore = 100;

	static public void addScore (int delta) {
		score += delta;
		updateScore ();
	}

	static void updateScore () {
		scoreText.text = "Score: " + score + "/" + maxScore;
	}
	private static Text scoreText;
	// Use this for initialization
	void Start () {
		scoreText = GetComponent<Text>();
		updateScore ();
	}
	
	// Update is called once per frame
	void Update () {

	}
}
