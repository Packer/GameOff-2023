using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using UnityEngine.AI;


[RequireComponent(typeof(NavMeshAgent))]
public class VesselController : MonoBehaviour
{
    public static VesselController instance;
    public Transform destinationMarker;
    public float moveDistance = 10;
    private NavMeshAgent agent;
    private NavMeshPath path;

    public Transform cameraPivot;
    public LayerMask terrainMask;
    private Vector3 rotationNormal = Vector3.up;
    public float a, b;

    // Start is called before the first frame update
    void Start()
    {
        instance = this;
        agent = GetComponent<NavMeshAgent>();   
    }

    // Update is called once per frame
    void Update()
    {

        if (destinationMarker != null && destinationMarker.position != agent.destination)
            agent.destination = destinationMarker.position;

        GetGroundNormalDirection();
        cameraPivot.rotation = Quaternion.Euler(Vector3.RotateTowards(cameraPivot.rotation.eulerAngles, rotationNormal, a, b));
    }

    public void GetGroundNormalDirection()
    {
        RaycastHit hit;

        if (Physics.Raycast(cameraPivot.position, Vector3.down, out hit, 4, terrainMask))
        {
            rotationNormal = hit.normal;
        }
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
}
