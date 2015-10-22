using UnityEngine;
using System.Collections;

public class ScriptMainMenu : MonoBehaviour {

	void OnGUI()
	{
		if (GUI.Button (new Rect (150, 10, 100, 50), "Level 1")) 
		{
		print ("Start game");
			Application.LoadLevel("Adventure_level_1");
		}

		if (GUI.Button (new Rect (350, 10, 100, 50), "Exit")) 
		{
		print ("Exit");
		Application.Quit();
		}

		if (GUI.Button (new Rect (550, 10, 100, 50), "Level 2")) 
		{
			print ("Start game");
			Application.LoadLevel("Adventure_level_2");
		}



	}
}
