using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ModeManager : MonoBehaviour {

	public enum Mode
	{
		ALARM_OFF,
		ALARM_ON,
		SET_ALARM,
		SET_TIME
	}

	public Mode currentMode;

	public Mode GetMode()
	{
		return currentMode;
	}

	public void SetMode(Mode newMode)
	{
		currentMode = newMode;
	}
}
