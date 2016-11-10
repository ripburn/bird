using UnityEngine;
using System.Collections;

public class Player_Script : MonoBehaviour {
	private Rigidbody2D rb2D;
	private float jumpForce = 8.0f;
	public GameObject Score;
	public GameObject gameoverui;
	public static bool gameover = false;
	private Animator anim;
	private App_Touch.TouchInfo touch;

	// Use this for initialization
	void Start () {
		rb2D = GetComponent<Rigidbody2D> ();
		anim = GetComponent ("Animator") as Animator;
	
	}
	
	// Update is called once per frame
	void Update () {

		touch = App_Touch.GetTouch ();
		if ((touch == App_Touch.TouchInfo.Began) && !gameover) {
			Jump ();
		}
		if (gameover == true) {
			anim.SetBool ("gameover", true);
			gameoverui.SendMessage ("Lose");
		}
	}


	void Jump(){
		Debug.Log (rb2D.velocity);
		rb2D.velocity = new Vector2 (0, jumpForce);
	}

	void OnTriggerEnter2D (Collider2D col){
		if (col.tag == ("score_up")){
			Score_Up score_up = Score.GetComponent<Score_Up> ();
			score_up.ScoreUp (1);
			Destroy (col.gameObject);
		}
		else{
			Debug.Log ("log");
			StartCoroutine (GameOver ());
		}

	}
	IEnumerator GameOver(){
		gameover = true;
		yield return new WaitForSeconds (1f);
		while (touch != App_Touch.TouchInfo.Began) {
			yield return 0;
		}
		Application.LoadLevel ("title");
	}


}
