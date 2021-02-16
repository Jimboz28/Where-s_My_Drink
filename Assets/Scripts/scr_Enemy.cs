using UnityEngine;
using UnityEngine.AI;

public class scr_Enemy : MonoBehaviour
{
    public Transform [] points;
    public int destPoint = 0;
    public NavMeshAgent agent;
    
    void Start()
    {
        NavMeshAgent agent = GetComponent<NavMeshAgent>();
        agent.autoBraking = false;
        GotoNextPoint();
    }
    void GotoNextPoint()
    {
        if (points.Length == 0)
        return;
        agent.destination = points[destPoint].position;
        destPoint = (destPoint + 1) % points.Length;
    }

    void Update()
    {
        if (!agent.pathPending && agent.remainingDistance < 0.5f)
        GotoNextPoint();
    }

}
