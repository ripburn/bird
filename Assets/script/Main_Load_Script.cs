using UnityEngine;
using System.Collections;

public class Main_Load_Script : MonoBehaviour {

	public void LoadMain(){
		Player_Script.gameover = false;
		Application.LoadLevel ("main");
	}
}
