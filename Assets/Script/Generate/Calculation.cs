//ここでは敵や弾を生成する時に必要な計算を行っています。
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Generate
{
    public class Calculation : GenerateBase
    {
        public GameObject EnemyPrefab;
        private float _generateInterval; //待ち時間
        [SerializeField] private int _numberToGenerate = 10; //敵の生成数
        [SerializeField] [Range(5f, 10f)] private float _maxGenerationRadius;
        [SerializeField] [Range(1f, 5f)] private float _minGenerationRadius;
        private IEnumerator Start()
        {
            while(_numberToGenerate > 0)
            {
                //待ち時間(3〜5秒間)
                _generateInterval = Random.Range(3.0f, 5.0f);
                CoordinateCalculation();
                yield return new WaitForSeconds(_generateInterval);
            }
        }

        private void CoordinateCalculation()
        {
            //敵の生成座標を計算（生成範囲は円状、座標値はランダム）
            Vector3 _generatePosition = transform.localPosition;
            int _angle = Random.Range(0, 360);
            _generatePosition.x = Random.Range(_minGenerationRadius * Mathf.Cos(_angle * Mathf.Deg2Rad), _maxGenerationRadius * Mathf.Cos(_angle * Mathf.Deg2Rad));
            _generatePosition.z = Random.Range(_minGenerationRadius * Mathf.Sin(_angle * Mathf.Deg2Rad), _maxGenerationRadius * Mathf.Sin(_angle * Mathf.Deg2Rad));
            transform.localPosition = _generatePosition;
            Generate(EnemyPrefab, transform.TransformPoint(transform.localPosition), Quaternion.identity);
            _numberToGenerate--;
        }

        public float DistanceCalculation(GameObject heroine, GameObject my)
        {
            //自分とヒロインの間の距離が一定値に達した時に攻撃するので、条件クリア後敵が持つAttack()へ
            //２点間距離は、ヒロイン(x1,z1) 自分(x2,z2)とし
            // √(x2 - x1)^2 + (z2 - z1)^2で算出
            return Mathf.Sqrt((my.transform.position.x - heroine.transform.position.x)
                * (my.transform.position.x - heroine.transform.position.x)
                + (my.transform.position.z - heroine.transform.position.z)
                * (my.transform.position.z - heroine.transform.position.z));
        }
    }
}
