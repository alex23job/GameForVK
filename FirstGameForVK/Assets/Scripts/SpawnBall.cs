using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnBall : MonoBehaviour
{
    [SerializeField] private GameObject[] prefabsBall;
    [SerializeField] private float SpawnDelay = 2f;

    private float timer;

    // Start is called before the first frame update
    void Start()
    {
        timer = SpawnDelay;
    }

    // Update is called once per frame
    void Update()
    {
        if (timer > 0) timer -= Time.deltaTime;
        else
        {
            timer = SpawnDelay;
            int num = Random.Range(0, prefabsBall.Length);
            GameObject ball = Instantiate(prefabsBall[num], transform.position, Quaternion.identity);
            Destroy(ball, 10f);
        }
    }

    public void SetSpawnDelay(float delay)
    {
        SpawnDelay = delay;
    }
}
