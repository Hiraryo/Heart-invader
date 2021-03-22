//敵（遠距離）
//移動と生成は近距離の敵と共通なので、EnemyBaseで行っています。
//攻撃は射撃
using UnityEngine;
using UnityEngine.AI;

namespace Enemy
{
    [RequireComponent(typeof(NavMeshAgent))]
    public class RangeAttackerEnemy : EnemyBase
    {
        private int _hp = 400;
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
        private void Attack()
        {
            //銃撃
            //弾の生成はGunUserを使う（使えたら）
        }
        private void Damage(int damage)
        {
            if(_hp > 0)
            {
                _hp -= damage;
            }
            else
            {
                Destroy(gameObject);
            }

        }
        private void OnCollisionEnter(Collision collision)
        {
            if(collision.gameObject.tag == "playerGun")
            {
                Damage(20);
            }
        }
    }
}