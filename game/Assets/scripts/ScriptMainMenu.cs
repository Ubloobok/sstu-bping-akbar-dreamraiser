using UnityEngine;
using System.Collections;

public class ScriptMainMenu : MonoBehaviour {

	void OnGUI()
	{
		if (GUI.Button (new Rect (150, 10, 100, 50), "Start")) 
		{
		print ("Start game");
			Application.LoadLevel("Adventure_level_1");
		}

		if (GUI.Button (new Rect (450, 10, 100, 50), "Exit")) 
		{
		print ("Exit");
		Application.Quit();
		}
	}
}
