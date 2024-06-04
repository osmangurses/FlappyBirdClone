using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoruHareketi : MonoBehaviour
{
    public float speed;

    private void Start()
    {
        Destroy(this.gameObject,10);
    }
    private void Update()
    {
        if (GameManager.Instance.isGameStarted)
        {
            transform.position += Vector3.left * speed * Time.deltaTime;
        }
    }
}
