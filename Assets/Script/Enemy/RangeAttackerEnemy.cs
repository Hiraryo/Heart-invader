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
        //[SerializeField] private int _numberToGenerate;   //生成数(弾)
        [SerializeField] private float _attackDistance;
        private int _hp = 25, _damage = 5;  //仮置きの値です。
        private float _distance, _limit, _generateTime; //弾生成に関する変数(ヒロインと自分の距離,　弾を撃つ時間, 現在の弾準備時間)
        private GameObject _heroine;
        private NavMeshAgent _me;
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
            if (_distance < _attackDistance)
            {
                _generateTime += Time.deltaTime;
                //生成数(弾)を使う場合は、
                //if (_numberToGenerate > 0 && _generateTime > limit)
                if (_generateTime > _limit)
                {
                    Attack();
                    _generateTime = 0;
                    //生成数(弾)を決めるなら、以下の1行のコメントを解除
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