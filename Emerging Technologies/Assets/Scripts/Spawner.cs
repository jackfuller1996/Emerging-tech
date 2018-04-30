using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour {
    public GameObject BottlePrefab;

    void Start()
    {
        GameObject bottleSpawn = (GameObject)Instantiate(BottlePrefab);
    }

}
