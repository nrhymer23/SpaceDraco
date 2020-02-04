using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;





public class ClockScript : MonoBehaviour
{
	public int level = 1;
	public int timeLeft = 60;
	public Text clockText;
	public Text levelText;

	// Use this for initialization
	void Start()
	{
		StartCoroutine("LoseTime");
	}

	// Update is called once per frame
	void Update()
	{
		clockText.text = ("Level up in = " + timeLeft);

		if (timeLeft <= 0)
		{
			StopCoroutine("LoseTime");
			timeLeft = 60;
			level = level + 1;
			levelText.text = ("Level: ") + level;
			StartCoroutine("LoseTime");

		}
	}

	IEnumerator LoseTime()
	{
		while (true)
		{
			yield return new WaitForSeconds(1);
			timeLeft--;
		}
	}
}






 /* public class ClockScript : MonoBehaviour {

	public int level = 1;
	public int startTime = 60;
	public Text clockText;
	public Text levelText;
	private int timeRemaining;
	static public bool timesUp = false;
	public Text gameoverText;

	// Use this for initialization
	void Start () {
		clockText.text = "Level up in = 0:00";

	}
	// Update is called once per frame
	void Update () {

		DoCountDown ();

	
	}

	void DoCountDown()
	{
		



		timeRemaining = startTime - (int)Time.time;

		do 
		if (timeRemaining <= 0 || timesUp == true) {

			Reset ();

		} 
		else 
		{
			int minutes = timeRemaining / 60;
			int seconds = timeRemaining % 60;
			clockText.text = "Level Up In = " + minutes + ":" +
			seconds.ToString ("D2");
		}
		while (level >=100);
	}

		void Reset()
	{
		startTime = 70;
		timesUp = false;
		level = level + 1;
	}
	

	} */

