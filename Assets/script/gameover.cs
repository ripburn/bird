using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class gameover : MonoBehaviour {

	// Use this for initialization
	void Start () {
		gameObject.GetComponent<Text>().enabled = false;
	
	}
	
	// Update is called once per frame
	public void Lose () {
		gameObject.GetComponent<Text> ().enabled = true;
	
	}
}
