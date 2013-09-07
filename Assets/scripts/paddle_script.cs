using UnityEngine;
using System.Collections;

public class paddle_script : MonoBehaviour {
	
	private float hAxes;
	private float sensibility = 10f;
	private float english;
	
	
	// Use this for initialization
	void Start () {
		SceneManager.bricks = 14;
	}
	
	// Update is called once per frame
	void Update () {
		hAxes = Input.GetAxis("Mouse X") * sensibility;

		transform.Translate(new Vector3(-hAxes * Time.deltaTime, 0, 0));
		transform.position = new Vector3( Mathf.Clamp(transform.position.x, -3.78f, 3.78f), 
			transform.position.y, transform.position.z);
	}
	
	void OnCollisionEvent( Collision coll ){
		foreach ( ContactPoint cont in coll.contacts){
			english = cont.point.x - transform.position.x;
			
			cont.otherCollider.rigidbody.AddForce(500f * english, -300f, 0);
		}
	}
	
	
}
