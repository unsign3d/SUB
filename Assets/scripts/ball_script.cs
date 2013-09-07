using UnityEngine;
using System.Collections;

public class ball_script : MonoBehaviour {
	
	public GUIText text;
	
	// Use this for initialization
	void Start () {
		rigidbody.AddForce(new Vector3(0, 300, 0));
	}
	
	// Update is called once per frame
	void Update () {

	}
	
}
