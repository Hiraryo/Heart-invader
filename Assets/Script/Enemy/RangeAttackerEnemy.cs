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
        public int NumberToGenerate;
        private int i;
        private void Start()
        {
            Me = gameObject.GetComponent<NavMeshAgent>();
        }
        private void Update()
        {
            for(i = 0; i < NumberToGenerate; i++)
            {
                Generate(new Vector3(1.0f,0.0f,1.0f));
            }
            Move(Me);
        }
    }
}