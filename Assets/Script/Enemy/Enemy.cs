using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

namespace Enemy
{
    public abstract class EnemyBase : MonoBehaviour
    {
        public NavMeshAgent Me;
        public GameObject EnemyPrefabObj;
        public GameObject Target;
        virtual protected void Move(NavMeshAgent target)
        {
            if (Target != null)
            {
                Me.destination = Target.transform.position;
            }
        }
        virtual protected void Generate(Vector3 spawnPosition)
        {
            Instantiate(EnemyPrefabObj, spawnPosition, Quaternion.identity);
        }
        virtual protected void Attack()
        {

        }
        virtual protected void Damage()
        {

        }
    }
}