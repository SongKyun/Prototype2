using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManagerX : MonoBehaviour
{
    public GameObject[] BallPrefab;

    private float spawnLimitXLeft = -22;
    private float spawnLimitXRight = 7;
    private float spawnPosY = 30;

    private float startDelay = 1.0f;
    private float spawnInterval = 3.0f;

    // Start is called before the first frame update
    void Start()
    {
        // 첫 번째 생성을 위한 랜덤 시간 함수 호출
        Invoke("SpawnRandomBall", Random.Range(startDelay, spawnInterval));
    }

    // Spawn random ball at random x position at top of play area
    void SpawnRandomBall ()
    {
        int BallIndex = Random.Range(0, BallPrefab.Length);

        // Generate random ball index and random spawn position
        Vector3 spawnPos = new Vector3(Random.Range(spawnLimitXLeft, spawnLimitXRight), spawnPosY, 0);

        // instantiate ball at random spawn location
        Instantiate(BallPrefab[BallIndex], spawnPos, BallPrefab[BallIndex].transform.rotation);

        // 다음 생성을 위한 랜덤 시간 함수 호출
        Invoke("SpawnRandomBall", Random.Range(startDelay, spawnInterval));
    }
}
