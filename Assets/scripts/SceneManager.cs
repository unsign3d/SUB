using UnityEngine;
using System.Collections;

public class SceneManager : MonoBehaviour {
	
	public static int bricks;
	public static int lvl;
	
	public void checkIfWon(){
		//decrement the numbers of bricks and if 0 simply write you won
		Debug.Log(bricks);
		if(--bricks == 0){
			GameObject.Find("GUI_obj").GetComponent<gui_script>().nextLvlFlag = true;
			GameObject.Find("text").GetComponent<GUIText>().text = "You Won";
			Destroy(GameObject.Find("ball"));
		}
	}
	
	public static void changeLevel(){
		Application.LoadLevel(lvl + 1);
	}
	
	public static void restartLevel(){
		Application.LoadLevel(Application.loadedLevel);
	}
}
