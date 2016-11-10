using UnityEngine;
using System.Collections;

public class Map_Script : MonoBehaviour {

	public GameObject treePrefab;
	public GameObject movingobj;


	// Use this for initialization
	void Start () {
		StartCoroutine (MoveMap ());
		StartCoroutine (SetTree ());

	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	IEnumerator SetTree(){
		while (true) {
			Vector3 pos = new Vector3 (11, Random.Range (3f, -1.5f), 0);
			GameObject tree = Instantiate (treePrefab, pos, transform.rotation) as GameObject;
			tree.transform.parent = movingobj.transform;
			yield return new WaitForSeconds (1.5f);
		}
	}	              


	IEnumerator MoveMap (){
		while (Player_Script.gameover == false) {
			Vector3 pos = movingobj.transform.position;
			pos.x -= 4 * Time.deltaTime;
			movingobj.transform.position = pos;
			yield return 0;
		}
	}
}
