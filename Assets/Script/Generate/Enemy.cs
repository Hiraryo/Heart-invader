using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Generate
{
    [RequireComponent(typeof(GenerateBase))]
    public class Enemy : GenerateBase
    {
        public GameObject EnemyPrefab;
        [SerializeField] private int _numberToGenerate;
        [SerializeField] [Range(5f, 10f)] private float _maxGenerationRadius;
        [SerializeField] [Range(1f, 5f)] private float _minGenerationRadius;
        private void Update()
        {
            //敵の生成座標を計算（生成範囲は円状、座標値はランダム）
            if (_numberToGenerate < 1)
                return;
            Vector3 _generatePosition = transform.localPosition;
            int _angle = Random.Range(0, 360);
            _generatePosition.x = Random.Range(_minGenerationRadius * Mathf.Cos(_angle * Mathf.Deg2Rad), _maxGenerationRadius * Mathf.Cos(_angle * Mathf.Deg2Rad));
            _generatePosition.z = Random.Range(_minGenerationRadius * Mathf.Sin(_angle * Mathf.Deg2Rad), _maxGenerationRadius * Mathf.Sin(_angle * Mathf.Deg2Rad));
            transform.localPosition = _generatePosition;
            Spawn(EnemyPrefab);
            _numberToGenerate--;
        }

        private void Spawn(GameObject spawnPrefab)
        {
            //生成座標値に敵を_numberToGenerate体、生成
            Generate(_numberToGenerate, EnemyPrefab, transform.TransformPoint(transform.localPosition), Quaternion.identity);
            GameObject enemy = spawnPrefab;
        }
    }
}
