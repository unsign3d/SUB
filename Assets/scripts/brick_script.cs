using UnityEngine;
using System.Collections;

public class brick_script : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	
	void OnCollisionEnter(Collision coll){
		GameObject.Find("SceneManager").GetComponent<SceneManager>().checkIfWon();
		
		Destroy (gameObject);
	}
	
}
