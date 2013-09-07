using UnityEngine;
using System.Collections;

public class lvl1_obj : MonoBehaviour {
	
	void Start () {
		SceneManager.bricks = 14;
		SceneManager.lvl = 0;
		
		Destroy(gameObject);
	}
	
}
