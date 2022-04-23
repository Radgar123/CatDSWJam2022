using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Enemy : MonoBehaviour
{
    [SerializeField] List<GameObject> MoveList = new List<GameObject>();
    [SerializeField] float rotateIfNotZero = 0;

    NavMeshAgent agent;

    int destIndex = 0;

    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        
        if(rotateIfNotZero == 0)
            agent.SetDestination(MoveList[0].transform.position);
    }

    void Update()
    {
        if(rotateIfNotZero == 0)
        {
            if(Vector3.Distance(transform.position, MoveList[destIndex].transform.position) <= 0.5f)
            {
                agent.SetDestination(GetNextPoint(ref destIndex));
            }
        }
        else
        {
            transform.Rotate(0, rotateIfNotZero * Time.deltaTime, 0f, Space.Self);
        }
    }

    Vector3 GetNextPoint(ref int index)
    {
        if(++index >= MoveList.Count) index -= MoveList.Count;

        return MoveList[index].transform.position;
    }

}
