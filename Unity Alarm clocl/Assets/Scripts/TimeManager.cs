using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeManager : MonoBehaviour
{

	public Alarm alarm;
	public Time alarmTime;
	public Time currentTime;
	public Display display;
	public ModeManager modeMgr;
	public Time snoozeTime;

	public void IncrementAlarmHour()
	{
		alarmTime.IncrementHour();
	}

	public void IncrementAlarmMinute()
	{
		alarmTime.IncrementMinute();
	}

	public void IncrementCurrentHour()
	{
		currentTime.IncrementHour();
	}

	public void IncrementCurrentMinute()
	{
		currentTime.IncrementMinute();
	}

	public void SetAlarm(Alarm newAlarm)
	{
		alarm = newAlarm;
	}

	public void SetDisplay(Display newDisplay)
	{
		display = newDisplay;
	}

	public void SetModeManager(ModeManager newModeMgr)
	{
		modeMgr = newModeMgr;
	}

	public void ShowAlarmTime()
	{
		
	}

	public void ShowCurrentTime()
	{
		
	}

	public void Snooze()
	{
		
	}
}
