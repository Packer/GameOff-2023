using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using UnityEngine.AI;
using static UnityEngine.GraphicsBuffer;


[RequireComponent(typeof(NavMeshAgent))]
public class VesselController : MonoBehaviour
{
    public static VesselController instance;

    public float moveDistance = 10;
    private NavMeshAgent agent;
    private NavMeshPath path;

    // Start is called before the first frame update
    void Start()
    {
        instance = this;
        agent = GetComponent<NavMeshAgent>();   
    }

    public void StopNavigation()
    {
        agent.isStopped = true;   
    }

    public void StartNavigation()
    {
        agent.speed = SystemManager.instance.navigation.power / moveDistance;
        agent.SetPath(path);
    }

    public bool CanNavigation(Vector3 destination, int power)
    {
        NavMesh.CalculatePath(transform.position, destination, NavMesh.AllAreas, path);

        float distance = 0;
        for (int i = 0; i < path.corners.Length - 1; i++)
        {
            distance += Vector3.Distance(path.corners[i], path.corners[i + 1]);
        }

        if (power * moveDistance > distance)
        {
            return true;
        }


        return false;
    }

    public void SetSpeed(int amount)
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
