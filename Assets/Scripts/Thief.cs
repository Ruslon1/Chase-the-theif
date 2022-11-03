using UnityEngine;
using UnityEngine.AI;

public class Thief : MonoBehaviour
{
    private NavMeshAgent _agent;
    [SerializeField] private Finish _finish;
    
    private void Start()
    {
        _agent = GetComponent<NavMeshAgent>();
        SetTargetPosition();
    }

    private void SetTargetPosition()
    {
        _agent.SetDestination(_finish.transform.position);
    }
}