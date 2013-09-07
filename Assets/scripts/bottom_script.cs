using UnityEngine;
using System.Collections;

public class bottom_script : MonoBehaviour {
	
	public GUIText text;

	
	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	
	void OnCollisionEnter(Collision coll){
		text.text = "YOU LOST";
		Destroy (coll.gameObject);	
	}
}
