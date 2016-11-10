using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Score_Up : MonoBehaviour {

	private int score = 0;

	// Use this for initialization
	void Start () {
		GetComponent<Text> ().text = "SCORE:" + score.ToString ();
	
	}
	
	// Update is called once per frame
	public void ScoreUp (int point){
		score += point;
		GetComponent<Text> ().text = "SCORE:" + score.ToString ();
	}
}
