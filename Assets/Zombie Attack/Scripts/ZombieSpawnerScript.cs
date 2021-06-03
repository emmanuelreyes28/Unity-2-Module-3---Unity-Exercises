using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class ZombieSpawnerScript : MonoBehaviour
{
    public GameObject zombiePrefab;
    public Transform target;

    public float spawnRange = 10;

    public UnityEvent ZombieDied;

    void Start()
    {
        //SpawnZombie();
        StartCoroutine(ZombieSpawnRepeater());
    }

    public Vector3 RandomPosition()
    {
        return new Vector3(Random.Range(-spawnRange, spawnRange), 1, Random.Range(-spawnRange, spawnRange));
    }

    public void SpawnZombie()
    {
        // ADD CODE HERE
        GameObject zombie = Instantiate(zombiePrefab);
        zombie.transform.position = RandomPosition();
        zombie.GetComponent<ZombieScript>().Init(target, this);
        // END OF CODE
    }

    public void ZombieHasDied()
    {
        ZombieDied?.Invoke();
    }

    IEnumerator ZombieSpawnRepeater()
    {
        yield return new WaitForSeconds(1f);
        SpawnZombie();
        StartCoroutine(ZombieSpawnRepeater());
    }
}
