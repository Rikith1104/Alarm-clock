using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Clock : MonoBehaviour
{

	public Alarm alarm;
	public ButtonManager button;
	public Display display;
	public ModeManager modeMrg;
	public SixtySecondTimer time;
	public TimeManager timeMrg;
	
	// Use this for initialization
	void Start () {
		timeMrg.alarmTime.StartTimer();
		timeMrg.currentTime.StartTimer();
	}
	
}
