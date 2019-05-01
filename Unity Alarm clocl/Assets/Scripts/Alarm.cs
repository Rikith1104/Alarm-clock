using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Alarm : MonoBehaviour
{

	public TimeManager timeMgr;
	public bool isEnabled = false;
	public GameObject alarmIndicator;
	public SixtySecondTimer timer;
	public AudioSource audio;
	
	public void On()
	{
		isEnabled = true;
	}

	public void Off()
	{
		isEnabled = false;
	}

	private void Update()
	{
		if (isEnabled)
		{
			if (timeMgr.alarmTime.hour == timeMgr.currentTime.hour &&
			    timeMgr.alarmTime.minute == timeMgr.currentTime.minute)
			{
				AlarmRing();
			}
		}
	}

	private void AlarmRing()
	{
		Off();
		alarmIndicator.SetActive(true);
		audio.Play();
		timer.StartTimer();
	}
}
