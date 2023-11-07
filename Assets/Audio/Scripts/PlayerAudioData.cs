using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "ScriptableObjects/Audio/Player", fileName = "PlayerAudioData")]

public class PlayerAudioData : ScriptableObject
{
    [Header("Movement")]


    public AK.Wwise.Event footstep = null;
}

