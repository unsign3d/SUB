using UnityEngine;
using System.Collections;

public class gui_script : MonoBehaviour {
	
	public bool nextLvlFlag = false;
	public bool reloadFlag  = true;

	void OnGUI(){
		
		if(this.reloadFlag){
			if (GUI.Button(new Rect(10,10,50,30), "Reload")){
				SceneManager.restartLevel();
			}
		}
		
		if(this.nextLvlFlag){
			if (GUI.Button(new Rect(10,70,50,30), "Next Level")){
				SceneManager.changeLevel();
			}
		}
		
	}
}
