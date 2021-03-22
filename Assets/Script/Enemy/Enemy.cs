//生成する為に必要な座標計算は、GenerateBaseで行っています。
using UnityEngine;
using UnityEngine.AI;

namespace Enemy
{
    public abstract class EnemyBase : MonoBehaviour
    {
        //敵の移動
        virtual protected void Move(NavMeshAgent my,GameObject target)
        {
            if (target != null)
            {
                my.destination = target.transform.position;
            }
        }
    }
}