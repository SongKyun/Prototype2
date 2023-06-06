using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject DogPrefab;

    public KeyCode triggerKey = KeyCode.Space; // 동작 트리거 키
    public float delayTime = 0.5f; // 딜레이 시간

    private bool CanDogShot = true; // 강아지슛 수행 여부

    // Update is called once per frame
    void Update()
    {
        // On spacebar press, send dog
        // 키 동작 후에, 수행할 수 있는 상태인지 확인
        if (Input.GetKeyDown(triggerKey) && CanDogShot)
        {
            Instantiate(DogPrefab, transform.position, DogPrefab.transform.rotation);

            CanDogShot = false;

            StartCoroutine(EnableActionAfterDelay());
        }
    }

    private IEnumerator EnableActionAfterDelay()
    {
        yield return new WaitForSeconds(delayTime);

        CanDogShot = true;
    }
 }
