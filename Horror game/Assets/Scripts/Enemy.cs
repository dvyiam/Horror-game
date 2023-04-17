using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Enemy : MonoBehaviour
{
    [SerializeField] Transform player;
    public int speed = 10;
    public int minDis = 4;
    public int maxDis = 1;
    NavMeshAgent agent;
    [SerializeField]Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        agent.enabled = true;
        agent.speed = speed;
    }

    // Update is called once per frame
    void Update()
    {
        transform.LookAt(player);

        if (Vector3.Distance(transform.position, player.position) > minDis ) //not close enough
        {
            animator.SetBool("is_idle", true);
            agent.enabled = true;
            agent.SetDestination(player.position);
            
        }
        else
        {
            agent.enabled = false;
            animator.SetBool("is_idle", false);
        }
    }
}
