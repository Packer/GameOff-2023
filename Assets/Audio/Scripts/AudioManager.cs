using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public static AudioManager Instance;

    #region Variables

       #region Events
        [Header("Events")]
    
        #region Music System Events
        [SerializeField] private AK.Wwise.Event musicSystem_PlayEvent;
        [SerializeField] private AK.Wwise.Event musicSystem_StopEvent;
        [SerializeField] private AK.Wwise.Event musicSystem_PauseEvent;
        #endregion

        #region SFX Events
        [SerializeField] private AK.Wwise.Event playFootstep;
        #endregion




       #endregion

       #region States

       [Header("States")]
           //Might be best to change these to public, TEST
               #region Game States
              [SerializeField] private AK.Wwise.State inGame_State;
              [SerializeField] private AK.Wwise.State paused_State;
              [SerializeField] private AK.Wwise.State mainMenu_State;
               #endregion
       
               #region Player States
               [SerializeField] private AK.Wwise.State alive_State;
               [SerializeField] private AK.Wwise.State dead_State;
               [SerializeField] private AK.Wwise.State blinded_State;
               #endregion
    
        #endregion
    
       #region Switches
        [Header("Switches")]
            #region Music Switches
            [SerializeField] private AK.Wwise.Switch testMusic_Switch;
            [SerializeField] private AK.Wwise.Switch combatBoss_Switch;
            [SerializeField] private AK.Wwise.Switch drilling_Switch;
            [SerializeField] private AK.Wwise.Switch combatLight_Switch;
            [SerializeField] private AK.Wwise.Switch exploration_Switch;
            [SerializeField] private AK.Wwise.Switch idle_Switch;
            [SerializeField] private AK.Wwise.Switch noMusic_Switch;

    #endregion

    #endregion

       #region RTPCs
       [Header("RTPCs")]
       [SerializeField] private AK.Wwise.RTPC playerSpeed_RTPC;
       #endregion

    #region Target GameObjects
    [Header("Target GameObjects")]
       //Game Object references for 2D wwise events
       public GameObject ambienceTargetAudioGO;
       public GameObject musicTargetAudioGO;
       public GameObject uiTargetAudioGO;
       public GameObject voTargetAudioGO;
       public GameObject playerGameObject;
       #endregion
    
       #region Volume Control
       [Header("Volume Control")]
       //Wwise Volume control
       //SetGlobalValue() in PlayerPrefs or on UI slider directly;
    
       public AK.Wwise.RTPC masterVolume_RTPC;
       public AK.Wwise.RTPC musicVolume_RTPC;
       public AK.Wwise.RTPC sfxVolume_RTPC;
       public AK.Wwise.RTPC uiVolume_RTPC;
       public AK.Wwise.RTPC voVolume_RTPC;
       #endregion

    #endregion



    #region Monobehavior

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
        else
        {
            Destroy(this);
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        //TestMusicSystem();
        inGame_State.SetValue();
    }

    

    // Update is called once per frame
    void Update()
    {
        
    }

    #endregion

    #region Music Events

    //The music system is dependent on the MusicType switch and GameState. These fields must be set before music system is started.
    private void TestMusicSystem()
    {
        inGame_State.SetValue();
        testMusic_Switch.SetValue(musicTargetAudioGO);
        StartMusicSystem();
    }

    public void StartMusicSystem()
    {
        musicSystem_PlayEvent.Post(musicTargetAudioGO);
    }

    public void PauseMusicSystem()
    {
        musicSystem_PauseEvent.Post(musicTargetAudioGO);
    }

    public void StopMusicSystem()    
    {
        musicSystem_StopEvent.Post(musicTargetAudioGO);
    }

    #endregion

    #region SFX Events

    public void PlayFootstep()
    {
        
        playFootstep.Post(playerGameObject);
        
    }

    

    #endregion

}
