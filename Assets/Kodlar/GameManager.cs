using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;
    public bool isGameStarted = false;

    private void Start()
    {
        Time.timeScale = 1f;
        Instance = this;
    }
    private void Update()
    {
        if (Input.GetMouseButtonDown(0) && isGameStarted==false)
        {
            isGameStarted = true;
        }
    }
}
