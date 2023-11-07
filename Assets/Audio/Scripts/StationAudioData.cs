using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(menuName = "ScriptableObjects/Audio/Station", fileName = "StationAudioData")]

public class StationAudioData : ScriptableObject
{
    [Header("Terminal")]
    public AK.Wwise.Event terminalPowerOn = null;
    public AK.Wwise.Event terminalIdle = null;
    public AK.Wwise.Event terminalPowerDown = null;

    [Header("Alarm")]
    public AK.Wwise.Event alarmStart;
    public AK.Wwise.Event alarmStop;
    public AK.Wwise.Event overheatAlarm;

    [Header("Power Icons")]
    public AK.Wwise.Event icon_NoPower;
    public AK.Wwise.Event icon_InsufficientPower;

    [Header("Operation")]
    public AK.Wwise.Event select;
    public AK.Wwise.Event success;
    public AK.Wwise.Event fail;
    public AK.Wwise.Event idle;
}
