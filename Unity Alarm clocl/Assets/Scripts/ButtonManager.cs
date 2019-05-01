using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonManager : MonoBehaviour
{

	public TimeManager timeMgr;
	public Alarm alarm;
	
	public void EnableDisableAlarm()
	{
		if (alarm.isEnabled)
			alarm.Off();
		else
			alarm.On();
	}

	public void IncrementHour()
	{
		timeMgr.currentTime.IncrementHour();
	}

	public void IncrementMinute()
	{
		timeMgr.currentTime.IncrementMinute();
	}

	public void IncrementAlarmHour()
	{
		timeMgr.alarmTime.IncrementHour();
	}

	public void IncrementAlarmMinute()
	{
		timeMgr.alarmTime.IncrementMinute();
	}

}
