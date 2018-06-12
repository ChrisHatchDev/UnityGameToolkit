using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectSpawner : MonoBehaviour {

    public GameObject PrefabToSpawn;
    public List<GameObject> PrefabsToSpawn = new List<GameObject>();

    public List<Vector3> SpawnOffsets = new List<Vector3>();

    public float SpawnDelay = 0.1f;

    private void Start()
    {
        StartCoroutine(WaitToSpawn());
    }

    IEnumerator WaitToSpawn()
    {
        SpawnObject();

        yield return new WaitForSeconds(SpawnDelay);

        StartCoroutine(WaitToSpawn());
    }


    void SpawnObject()
    {
        Instantiate(PrefabsToSpawn[Random.Range(0,PrefabsToSpawn.Count)], transform.position + SpawnOffsets[Random.Range(0,SpawnOffsets.Count)], Quaternion.identity);
    }
}
