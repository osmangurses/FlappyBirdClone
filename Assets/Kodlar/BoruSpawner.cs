using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoruSpawner : MonoBehaviour
{
    public GameObject boru;
    public float boruSpawnSuresi;

    private void Start()
    {
        InvokeRepeating("BoruSpawn",0.5f,boruSpawnSuresi);
    }

    void BoruSpawn()
    {
        if (GameManager.Instance.isGameStarted)
        {
            GameObject boruTemp = Instantiate(boru);
            boruTemp.transform.position = new Vector3(transform.position.x, Random.Range(-2.5f, 0.5f));
        }
    }
}
