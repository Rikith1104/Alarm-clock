using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SixtySecondTimer : MonoBehaviour
{

	public TimeManager timeMgr;
	public GameObject alarmIndicator;
	public AudioSource audio;
	
	public void HandleTimeout()
	{
		alarmIndicator.SetActive(false);
		audio.Pause();
	}

	public void SetTimeManager(TimeManager newTimeMgr)
	{
		timeMgr = newTimeMgr;
	}

	public void StartTimer()
	{
		StartCoroutine(Do60SecondsCount());
	}

	IEnumerator Do60SecondsCount()
	{
		yield return new WaitForSeconds(60);
		HandleTimeout();
	}

	public void StopAlarm()
	{
		StopCoroutine("Do60SecondsCount");
	}
	
}
