using System.Collections;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject obstaclePrefab;
    private Vector3 spawnPos = new Vector3(25f, 0, 0);

    private float startDelay = 2f;
    // repeatRate를 srand() 같은... 난수를 지정하면 진짜 게임처럼 랜덤으로 나오지 않을까?
    // 최소 시간을 지정해두면 못 피하는 장애물은 막을 수 있지 않을까.. 생각이 듦
    private float repeatRate = 2f;

    private Coroutine spawnCoroutine;

   
    private void Start()
    {
        spawnCoroutine = StartCoroutine(SpawnRoutine());
    }


    // 퍼포먼스 측면에서 굉장히 중요한? 그런 느낌이다.
    IEnumerator SpawnRoutine()
    {
        // startDelay 초 잠깐 멈춤.
        yield return new WaitForSeconds(startDelay);

        while (true)
        {
            // 스폰하고 2초 지난 후에 다시 반복하는 while문
            SpawnObstacle();
            repeatRate = Random.Range(1f, 10f);
            yield return new WaitForSeconds(repeatRate);
        }
    }

    private void SpawnObstacle()
    {
        Instantiate(obstaclePrefab, spawnPos, obstaclePrefab.transform.rotation);
    }

    public void StopSpawning()
    {
        if (spawnCoroutine != null)
        {
            StopCoroutine(spawnCoroutine);
            spawnCoroutine = null;
        }
    }
}