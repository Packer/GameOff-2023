using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SystemManager : MonoBehaviour
{
    public static SystemManager instance;

    [Header("Power Systems")]
    public PowerSystem[] systems;
    [Range(0, 100)]
    public int corePower = 100;

    public Navigation navigation = new Navigation();
    public Scanner scanner = new Scanner();
    public Defense defense = new Defense();
    public Drill drill = new Drill();
    public Repair repair = new Repair();

    [System.Serializable]
    public class PowerSystem
    {
        public bool isOn = false;
        [Range(0,100)]
        public int power = 0;
    }

    [System.Serializable]
    public class Navigation : PowerSystem
    {
        [Space]
        public Vector3 destination = Vector3.zero;
        public float speed = 1;
    }

    [System.Serializable]
    public class Scanner : PowerSystem
    {
        [Space]
        public float scanRange = 1;
    }

    [System.Serializable]
    public class Defense : PowerSystem
    {
        [Space]
        public int[] defenseLevel = new int[4];
    }

    [System.Serializable]
    public class Drill : PowerSystem
    {
        [Space]
        public bool isDestroyed = false;
        public float heatLevel = 0;
        public int drillSpeed = 0;
    }

    [System.Serializable]
    public class Repair : PowerSystem
    {
        [Space]
        public int[] hullRepair = new int[5];
        public float[] hullHealth = new float[5];
    }

    public enum SystemType
    {
        Navigation = 0,
        Scanner = 1,
        Defense = 2,
        Drill = 3,
        Repair = 4
    }

    public enum HullType
    {
        Core = 0,
        Drill = 1,
        Left = 2,
        Right = 3,
        Rear = 4
    }

    public void DrainSystem(SystemType type)
    {
        corePower += systems[(int)type].power;
        systems[(int)type].power = 0;
        systems[(int)type].isOn = false;
    }

    public void IncreaseSystemPower(SystemType type, int amount)
    {
        if (corePower == 0)
            return;

        if (corePower < amount)
            amount = corePower;

        //Remove core Power
        corePower -= amount;

        //Power System
        systems[(int)type].power += amount;
    }

    public void DecreaseSystemPower(SystemType type, int amount)
    {
        if (systems[(int)type].power <= 0)
            return;

        //Drain System
        systems[(int)type].power -= amount;

        //Add core power back
        corePower += amount;
    }

    void Start()
    {
        instance = this;

        //Assign Power Systems
        systems = new PowerSystem[5];
        systems[0] = navigation;
        systems[1] = scanner;
        systems[2] = defense;
        systems[3] = drill;
        systems[4] = repair;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
