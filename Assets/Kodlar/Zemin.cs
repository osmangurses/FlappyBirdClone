using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zemin : MonoBehaviour
{
    public int speed;
    void Update()
    {
        if (GameManager.Instance.isGameStarted)
        {
            transform.position += Vector3.left * speed * Time.deltaTime;
            if (transform.position.x < -0.4)
            {
                transform.position = new Vector3(0.5f, transform.position.y, 0);
            }
        }
    }
}
