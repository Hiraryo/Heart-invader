using UnityEngine;
using UnityEngine.AI;

namespace Enemy
{
    public abstract class EnemyBase : MonoBehaviour
    {
        virtual protected void Move(NavMeshAgent my,GameObject target)
        {
            if (target != null)
            {
                my.destination = target.transform.position;
            }
        }
    }
}