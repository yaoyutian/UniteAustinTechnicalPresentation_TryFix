using Unity.Entities;
using Unity.Mathematics;
using UnityEngine.Experimental.AI;

public struct CrowdAgentNavigator : IComponentData
{
    public float3 requestedDestination;
    public NavMeshLocation requestedDestinationLocation;
    public float distanceToDestination;
    public NavMeshLocation pathStart;
    public NavMeshLocation pathEnd;
    public int pathSize;
    public float speed;
    public float nextCornerSide;
    public float3 steeringTarget;
    public boolean newDestinationRequested;
    public boolean goToDestination;
    public boolean destinationInView;
    public boolean destinationReached;
    public boolean active;

    public void MoveTo(float3 dest)
    {
        requestedDestination = dest;
        newDestinationRequested = true;
    }

    public void StartMoving()
    {
        goToDestination = true;
        destinationInView = false;
        destinationReached = false;
        distanceToDestination = -1f;
    }
}

public class CrowdAgentNavigatorComponent : ComponentDataWrapper<CrowdAgentNavigator> {}
