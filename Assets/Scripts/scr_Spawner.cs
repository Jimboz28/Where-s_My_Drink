using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scr_Spawner : MonoBehaviour
{
    public GameObject dollarPrefab;
    public GameObject moneyBagPrefab;
    public float timeBetweenSpawn = 2.0f;
    float spawnCountdown;
    public bool dollarSpawn = false;

    // Start is called before the first frame update
    void Start()
    {
        spawnCountdown = timeBetweenSpawn;
        //Spawn();
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("spawn countdown" + spawnCountdown);
        if (dollarSpawn == false)
        {
                if (spawnCountdown <= 0)
                {
                Spawn();
                Debug.Log("spawn");
                }
                else
        {
            spawnCountdown -= Time.deltaTime;
            Debug.Log("why you no work");
        }
        }
    }
    void Spawn()
    {
        dollarSpawn = true;
        spawnCountdown = timeBetweenSpawn;
        float randomIndex = Random.Range(0.0f, 10.0f);
        if (randomIndex <= 5.5f)
        {
        Instantiate(dollarPrefab, transform.position, Quaternion.identity);
        }
        if (randomIndex >= 5.5f)
        {
        Instantiate(moneyBagPrefab, transform.position, Quaternion.identity);
        }
    }
}
