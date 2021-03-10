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
        private void Start()
        {
            Spawn(EnemyPrefab);
        }

        private void Spawn(GameObject spawnPrefab)
        {
            //メモ：座標計算はEnemyModelのEnemyGenerationPositionクラスに書いてみる。
            /*
            Vector3 _generatePosition = EnemyPrefab.transform.localPosition;
            int _angle = Random.Range(0, 360);
            _generatePosition.x = Random.Range(_minGenerationRadius * Mathf.Cos(_angle * Mathf.Deg2Rad), _maxGenerationRadius * Mathf.Cos(_angle * Mathf.Deg2Rad));
            _generatePosition.z = Random.Range(_minGenerationRadius * Mathf.Sin(_angle * Mathf.Deg2Rad), _maxGenerationRadius * Mathf.Sin(_angle * Mathf.Deg2Rad));
            EnemyPrefab.transform.localPosition = _generatePosition;
            */
            Generate(_numberToGenerate, EnemyPrefab, EnemyPrefab.transform.localPosition, Quaternion.identity);
            GameObject enemy = spawnPrefab;
        }
    }
}
