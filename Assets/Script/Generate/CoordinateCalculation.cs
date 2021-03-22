//ここでは敵や弾を生成する時に必要な計算を行っています。
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Generate
{
    public class CoordinateCalculation : GenerateBase
    {
        public GameObject EnemyPrefab;
        private int _numberToGenerate = 5;
        [SerializeField] [Range(5f, 10f)] private float _maxGenerationRadius;
        [SerializeField] [Range(1f, 5f)] private float _minGenerationRadius;
        private void Start()
        {
            //_numberToGenerate = EnemyManager.Instance.numberToGenerate;
        }
        private void Update()
        {
            if (_numberToGenerate < 1)
                return;
            Calculation();
        }

        private void Calculation()
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
    }
}
