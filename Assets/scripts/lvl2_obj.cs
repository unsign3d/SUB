using UnityEngine;
using System.Collections;

public class lvl2_obj : MonoBehaviour {
	
	void Start () {
		SceneManager.bricks = 10;
		SceneManager.lvl = 1;
		
		Destroy(gameObject);
	}
	
}
