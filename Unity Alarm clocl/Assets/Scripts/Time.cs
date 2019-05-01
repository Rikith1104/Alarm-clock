using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Time : MonoBehaviour
{

	public int hour;
	public int minute;

	private float _currentTimer = 0;
	private int _seconds = 0;
	private bool _timeStarted = false;
	public bool isAlarmTimer = false;
	
	private void AddOneMinute()
	{
		Debug.Log("NEW MINUTE!");
		if (minute == 59)
		{
			IncrementHour();
		}
		
		IncrementMinute();
		if(!isAlarmTimer) StartCoroutine(SixtySeconds());
		
	}

	public void Equate(Time aTime)
	{
		
	}

	public int GetHour()
	{
		return hour;
	}

	public int GetMinute()
	{
		return minute;
	}

	public void IncrementHour()
	{
		if (hour == 23)
		{
			hour = 0;
		}
		else
		{
			hour += 1;
		}
	}

	public void IncrementMinute()
	{
		if (minute == 59)
		{
			minute = 0;
		}
		else
		{
			minute += 1;
		}
		
	}

	public void StartTimer()
	{
		//Get the system time
		hour = System.DateTime.Now.Hour;
		minute = System.DateTime.Now.Minute;

		if(!isAlarmTimer) StartCoroutine(SixtySeconds());
	}

	IEnumerator SixtySeconds()
	{
		yield return new WaitForSeconds(60);
		AddOneMinute();
	}
	
}
