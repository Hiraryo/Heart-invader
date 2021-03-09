using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

namespace Enemy
{
    [RequireComponent(typeof(EnemyBase))]
    [RequireComponent(typeof(NavMeshAgent))]
    public class RangeAttackerEnemy : EnemyBase
    {
        private GameObject Heroine;
        private NavMeshAgent _me;
        private void Start()
        {
            Heroine = GameObject.Find("Heroine");
            _me = gameObject.GetComponent<NavMeshAgent>();
        }
        private void Update()
        {       
            Move(_me,Heroine);
        }
    }
}