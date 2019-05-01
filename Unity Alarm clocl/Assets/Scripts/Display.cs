using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class Display : MonoBehaviour
{

	public Alarm alarm;
	public Text currentTime;
	public Text alarmTime;
	public Text alarmButtonText;
	public Text currentTimeIndicator;
	public Text alarmIndicator;
	public TimeManager timeMgr;


	private string hour;
	private string minute;
	private string alarmHour;
	private string alarmMinute;
	private void Update()
	{
		hour = timeMgr.currentTime.hour.ToString();
		minute = timeMgr.currentTime.minute.ToString();
		alarmHour = timeMgr.alarmTime.hour.ToString();
		alarmMinute = timeMgr.alarmTime.minute.ToString();
			
		if (timeMgr.currentTime.hour < 10) hour = "0" + hour;
		if (timeMgr.currentTime.minute < 10) minute = "0" + minute;
		if (timeMgr.alarmTime.hour < 10) alarmHour = "0" + alarmHour;
		if (timeMgr.alarmTime.minute < 10) alarmMinute = "0" + alarmMinute;
			
		currentTime.text = "TIME\n" + hour + ":" + minute;
		alarmTime.text = "ALARM\n" + alarmHour  + ":" + alarmMinute;
		
		alarmButtonText.text = alarm.isEnabled ? "Disable Alarm" : "Enable Alarm";
		currentTimeIndicator.text = timeMgr.currentTime.hour >= 12 ? "PM" : "AM";
		alarmIndicator.text = timeMgr.alarmTime.hour >= 12 ? "PM" : "AM";
	}

	public void ShowHour(int newHour)
	{
		
	}

	public void ShowMinute(int newMinute)
	{
		
	}
}
