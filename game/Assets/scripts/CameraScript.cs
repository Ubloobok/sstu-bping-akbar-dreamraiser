using UnityEngine;
using System.Collections;

public class CameraScript : MonoBehaviour {
	public float dampTime = 0.5f;
	private Vector3 velocity = Vector3.zero;
	public Transform target;
	public Camera camera;
	bool paused = false;
	// Update is called once per frame


	void Start()
	{
		camera = GetComponent<Camera>();


	}

	void Update () 
	{
		if(Input.GetKeyDown(KeyCode.Escape))
			paused = togglePause();




		if (target)
		{
			Vector3 point = camera.WorldToViewportPoint(new Vector3(target.position.x, target.position.y+0.5f,target.position.z));
			Vector3 delta = new Vector3(target.position.x, target.position.y+0.5f,target.position.z) - camera.ViewportToWorldPoint(new Vector3(0.8f, 0.4f, point.z)); //(new Vector3(0.5, 0.5, point.z));
			Vector3 destination = transform.position + delta;
			
			
			transform.position = Vector3.SmoothDamp(transform.position, destination, ref velocity, dampTime);
		}

	}


	void OnGUI()
	{
		if(paused)
		{
			if(GUI.Button(new Rect (250, 70, 150, 50),"Main Menu"))
				Application.LoadLevel("MainMenu");
			else
			if(GUI.Button(new Rect (250, 250, 150, 50),"Click me to unpause"))
				paused = togglePause();
		}




	}


	bool togglePause()
	{
		if(Time.timeScale == 0f)
		{
			Time.timeScale = 1f;
			return(false);
		}
		else
		{
			Time.timeScale = 0f;
			return(true);    
		}
	}
}