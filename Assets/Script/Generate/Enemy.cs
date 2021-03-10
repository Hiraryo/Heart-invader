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
            Vector3 _generatePosition = transform.localPosition;
            float _angle = Random.Range(0, 360);
            _generatePosition.x = Random.Range(_minGenerationRadius * Mathf.Cos(_angle * Mathf.Deg2Rad), _maxGenerationRadius * Mathf.Cos(_angle * Mathf.Deg2Rad));
            _generatePosition.z = Random.Range(_minGenerationRadius * Mathf.Sin(_angle * Mathf.Deg2Rad), _maxGenerationRadius * Mathf.Sin(_angle * Mathf.Deg2Rad));
            transform.localPosition = _generatePosition;
            Spawn(EnemyPrefab);
        }
        private void Spawn(GameObject spawnPrefab)
        {
            Generate(_numberToGenerate, EnemyPrefab, transform.TransformPoint(transform.localPosition), Quaternion.identity);
            GameObject enemy = spawnPrefab;
        }
    }
}
