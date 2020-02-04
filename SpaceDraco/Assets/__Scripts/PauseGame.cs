using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PauseGame : MonoBehaviour {

	public Transform canvas;
	public Text gameoverText; 


	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown(KeyCode.Escape)) 
		{
			Pause();
		}
		if (Input.GetKeyDown (KeyCode.Q)) 
		{
			Quit ();
		}
		if (Input.GetKeyDown (KeyCode.R)) 
		{
			Restart ();
		}
		if (Input.GetKeyDown (KeyCode.P))
		{
			canvas.gameObject.SetActive (false);
			Time.timeScale = 1;
		}
	}

	public void Pause()
	{
		
			if (canvas.gameObject.activeInHierarchy == false)
			{
				canvas.gameObject.SetActive (true);
				Time.timeScale = 0;
			} 
			else
			{
				canvas.gameObject.SetActive (false);
				Time.timeScale = 1;
			}
		}
	public void Restart()
	{
		

		Application.LoadLevel ("_Scene_0");
		//ClockScript.startTime = 60;
		Time.timeScale = 1;
		//ClockScript.timesUp = false;
}

	public void Quit()
	{
		canvas.gameObject.SetActive (false);
		gameoverText.text = "Game O'V";
		Time.timeScale = 0;
	}

}
