using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

/// <summary>
/// ヒロインの移動に関するクラス
/// </summary>
public class HeroineMover : MonoBehaviour
{
    NavMeshAgent _navMeshAgent;

    private void Start()
    {
        _navMeshAgent = GetComponent<NavMeshAgent>();
    }

    /// <summary>
    /// ヒロインのゴール地点のゲッター
    /// </summary>
    /// <returns>ゴール地点</returns>
    public Vector3 GetNavDestination()
    {
        return _navMeshAgent.destination;
    }

    /// <summary>
    /// ヒロインのゴール地点を設定
    /// </summary>
    /// <param name="destination">ゴール地点</param>
    public void SetNavDestination(Vector3 destination)
    {
        _navMeshAgent?.SetDestination(destination);
    }



    /// <summary>
    /// ヒロインのナビゲーションの再生、停止セッター
    /// </summary>
    public void SetNavStopped(bool isStopped)
    {
        _navMeshAgent.isStopped = isStopped;
    }

    /// <summary>
    /// ヒロインのナビゲーションの再生、停止ゲッター
    /// </summary>
    /// <returns></returns>
    public bool GetNavStopped()
    {
        return _navMeshAgent.isStopped;
    }


    /// <summary>
    /// ゴール到達処理
    /// </summary>
    /// <param name="other"></param>
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Goal")
        {
            // 以下ゴール到達時の処理
            _navMeshAgent.isStopped = true;

        }
    }

    /// <summary>
    /// ゴールまでの距離を返すゲッター
    /// </summary>
    /// ゴールまでの距離が不明の場合はInfinityが返される
    /// <returns>ゴールまでの距離</returns>
    public float GetRemainingDistance()
    {
        return _navMeshAgent.remainingDistance;
    }

}
