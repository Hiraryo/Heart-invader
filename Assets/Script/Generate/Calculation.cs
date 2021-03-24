﻿//ここでは敵や弾を生成する時に必要な計算を行っています。
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Generate
{
    public class Calculation : GenerateBase
    {
        public GameObject EnemyPrefab;
        private float _generateTime,_elapsedTime; //生成時間、経過時間
        [SerializeField] private int _numberToGenerate = 5; //敵の生成数
        [SerializeField] [Range(5f, 10f)] private float _maxGenerationRadius;
        [SerializeField] [Range(1f, 5f)] private float _minGenerationRadius;
        private void Start()
        {
            //生成時間(3〜5秒間)
            _generateTime = Random.Range(3.0f, 5.0f);
            //_numberToGenerate = EnemyManager.Instance.numberToGenerate;
        }
        private void Update()
        {
            _elapsedTime += Time.deltaTime;
            if (_numberToGenerate > 0 && _elapsedTime > _generateTime){ CoordinateCalculation();}
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
            //生成時間(3〜5秒間)
            _generateTime = Random.Range(3.0f, 5.0f);
            _elapsedTime = 0;
        }

        public float DistanceCalculation(GameObject heroine, GameObject my)
        {
            //自分とヒロインの間の距離が一定値に達した時に攻撃するので、条件クリア後敵が持つAttack()へ
            //２点間距離は、ヒロイン(x1,z1) 自分(x2,z2)とし
            // √(x2 - x1)^2 + (z2 - z1)^2で算出
            return Mathf.Sqrt((my.transform.position.x - heroine.transform.position.x)
                * (my.transform.position.x - heroine.transform.position.x)
                + (my.transform.position.y - heroine.transform.position.y)
                * (my.transform.position.y - heroine.transform.position.y));
        }
    }
}
