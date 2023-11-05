/////////////////////////////////////////////////////////////////////////////////////////////////////
//
// Audiokinetic Wwise generated include file. Do not edit.
//
/////////////////////////////////////////////////////////////////////////////////////////////////////

#ifndef __WWISE_IDS_H__
#define __WWISE_IDS_H__

#include <AK/SoundEngine/Common/AkTypes.h>

namespace AK
{
    namespace EVENTS
    {
        static const AkUniqueID BREAK_FOOTSTEP_MATERIALSWITCH = 3475931801U;
        static const AkUniqueID PAUSE_MUSICSYSTEM = 750153198U;
        static const AkUniqueID PLAY_FOOTSTEP_MATERIALSWITCH = 4225883816U;
        static const AkUniqueID PLAY_TESTTONE_2D = 211167583U;
        static const AkUniqueID START_MUSICSYSTEM = 206882740U;
        static const AkUniqueID STOP_MUSICSYSTEM = 3296906710U;
    } // namespace EVENTS

    namespace STATES
    {
        namespace GAMESTATE
        {
            static const AkUniqueID GROUP = 4091656514U;

            namespace STATE
            {
                static const AkUniqueID INGAME = 984691642U;
                static const AkUniqueID MAINMENU = 3604647259U;
                static const AkUniqueID NONE = 748895195U;
                static const AkUniqueID PAUSE = 3092587493U;
            } // namespace STATE
        } // namespace GAMESTATE

        namespace PLAYERSTATE
        {
            static const AkUniqueID GROUP = 3285234865U;

            namespace STATE
            {
                static const AkUniqueID ALIVE = 655265632U;
                static const AkUniqueID BLINDED = 1088079745U;
                static const AkUniqueID DEAD = 2044049779U;
                static const AkUniqueID NONE = 748895195U;
            } // namespace STATE
        } // namespace PLAYERSTATE

    } // namespace STATES

    namespace SWITCHES
    {
        namespace GROUNDMATERIAL_SWITCH
        {
            static const AkUniqueID GROUP = 4222483982U;

            namespace SWITCH
            {
                static const AkUniqueID BOTTOMFLOOR = 3511220434U;
                static const AkUniqueID STAIRS = 1289942167U;
                static const AkUniqueID TOPFLOOR = 4243861200U;
            } // namespace SWITCH
        } // namespace GROUNDMATERIAL_SWITCH

        namespace MUSICTYPE
        {
            static const AkUniqueID GROUP = 4048174150U;

            namespace SWITCH
            {
                static const AkUniqueID COMBAT_BOSS = 656193027U;
                static const AkUniqueID COMBAT_LIGHT = 2148865076U;
                static const AkUniqueID DRILLING = 2259734576U;
                static const AkUniqueID EXPLORATION = 2582085496U;
                static const AkUniqueID IDLE = 1874288895U;
                static const AkUniqueID NOMUSIC = 1862135557U;
                static const AkUniqueID TEST = 3157003241U;
            } // namespace SWITCH
        } // namespace MUSICTYPE

        namespace PLAYERSPEED_SWITCH
        {
            static const AkUniqueID GROUP = 3427409782U;

            namespace SWITCH
            {
                static const AkUniqueID SPRINT = 1296465089U;
                static const AkUniqueID WALK = 2108779966U;
            } // namespace SWITCH
        } // namespace PLAYERSPEED_SWITCH

    } // namespace SWITCHES

    namespace GAME_PARAMETERS
    {
        static const AkUniqueID RTPC_HULLHEALTH = 3751928492U;
        static const AkUniqueID RTPC_MASTER_BUS = 88991926U;
        static const AkUniqueID RTPC_MUSIC_BUS = 3432596327U;
        static const AkUniqueID RTPC_OVERHEAT = 33426215U;
        static const AkUniqueID RTPC_PLAYERSPEED = 2653406601U;
        static const AkUniqueID RTPC_SFX_BUS = 3067876527U;
        static const AkUniqueID RTPC_UI_BUS = 3538978622U;
        static const AkUniqueID RTPC_VO_BUS = 3115923421U;
    } // namespace GAME_PARAMETERS

    namespace BANKS
    {
        static const AkUniqueID INIT = 1355168291U;
        static const AkUniqueID MAIN = 3161908922U;
        static const AkUniqueID TESTING = 1512859615U;
    } // namespace BANKS

    namespace BUSSES
    {
        static const AkUniqueID AMBIENCE = 85412153U;
        static const AkUniqueID BEDS = 1106291253U;
        static const AkUniqueID CREATURES = 3567116701U;
        static const AkUniqueID EMITTERS = 612957004U;
        static const AkUniqueID EXTERIOR = 2213992659U;
        static const AkUniqueID FOLEY = 247557814U;
        static const AkUniqueID FOOTSTEPS = 2385628198U;
        static const AkUniqueID GEAR = 1172844112U;
        static const AkUniqueID INTERIOR = 1132214669U;
        static const AkUniqueID MASTER_AUDIO_BUS = 3803692087U;
        static const AkUniqueID MUSIC = 3991942870U;
        static const AkUniqueID REVERBS = 3545700988U;
        static const AkUniqueID SFX = 393239870U;
        static const AkUniqueID SHIP = 284967655U;
        static const AkUniqueID UI = 1551306167U;
        static const AkUniqueID VO = 1534528548U;
    } // namespace BUSSES

    namespace AUX_BUSSES
    {
        static const AkUniqueID BRIDGE = 2068062714U;
        static const AkUniqueID CAPTAINSQUARTERS = 2354497765U;
        static const AkUniqueID PAUSEVERB = 249084106U;
    } // namespace AUX_BUSSES

    namespace AUDIO_DEVICES
    {
        static const AkUniqueID NO_OUTPUT = 2317455096U;
        static const AkUniqueID SYSTEM = 3859886410U;
    } // namespace AUDIO_DEVICES

}// namespace AK

#endif // __WWISE_IDS_H__
