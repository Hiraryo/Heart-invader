//敵（遠距離）
//移動と生成は近距離の敵と共通なので、EnemyBaseで行っています。
//攻撃は射撃
using Generate;
using UnityEngine;
using UnityEngine.AI;

namespace Enemy
{
    [RequireComponent(typeof(NavMeshAgent))]
    public class RangeAttackerEnemy : EnemyBase
    {
        public Transform Nose;
        public GameObject Bullet;
        //[SerializeField] private int _numberToGenerate;
        [SerializeField] private float _shotSpeed;
        [SerializeField] private float _attackDistance;
        private int _hp = 25;
        private int _damage = 5;
        private GameObject _heroine;
        private NavMeshAgent _me;
        private float _distance;
        private float _limit;
        private float _generateTime; //弾の生成を開始する時間
        readonly Calculation cal = new Calculation();
        private void Start()
        {
            _heroine = GameObject.Find("Heroine");
            _me = gameObject.GetComponent<NavMeshAgent>();
            _limit = Random.Range(3, 5);
        }
        private void Update()
        {
            Move(_me,_heroine);
            _distance = cal.DistanceCalculation(_heroine,gameObject);
            Debug.Log("距離：" + _distance);
            if (_distance < _attackDistance)
            {
                Debug.Log("limit : " + _limit + "_generateTime : " + _generateTime);
                _generateTime += Time.deltaTime;
                //弾の生成数を使う場合は、
                //if (_numberToGenerate > 0 && _generateTime > limit)
                if (_generateTime > _limit)
                {
                    Attack();
                    _generateTime = 0;
                    //弾の生成数を決めるなら、以下の1行のコメントを解除
                    //_numberToGenerate--;
                }

            }
            else {_generateTime = 0;}
            if (_hp <= 0) { Destroy(gameObject); }

        }
        private void Attack()
        {
            //射撃
            GameObject bullet = Instantiate(Bullet, Nose.position, Nose.rotation);
            bullet.transform.rotation = this.gameObject.transform.rotation;
            transform.position += transform.forward * Time.deltaTime;
            Debug.Log("近い！");
        }
        private void OnCollisionEnter(Collision collision)
        {
            if (collision.gameObject.tag == "playerGun")
            {
                if (_hp > 0) { _hp = Damage(_hp, _damage); }
            }
        }
    }
}