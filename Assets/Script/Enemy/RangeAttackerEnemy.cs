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
        private GameObject _heroine;
        private NavMeshAgent _me;
        private void Start()
        {
            _heroine = GameObject.Find("Heroine");
            _me = gameObject.GetComponent<NavMeshAgent>();
        }
        private void Update()
        {       
            Move(_me,_heroine);
        }
    }
}