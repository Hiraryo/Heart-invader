//敵や弾を生成する為に必要な計算は、Calculationで行っています。
using UnityEngine;
using UnityEngine.AI;

namespace Enemy
{
    public class EnemyBase : MonoBehaviour
    {
        //敵の移動
        public void Move(NavMeshAgent my,GameObject target)
        {
            if (target != null)
            {
                my.destination = target.transform.position;
            }
        }

        //敵が受けるダメージ
        public int Damage(int hp,int damage)
        {
            return hp - damage;
        }
    }
}