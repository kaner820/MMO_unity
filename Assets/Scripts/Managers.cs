using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Managers : MonoBehaviour
{
    static Managers Instance;
    public static Managers GetInstance( )
    {
        return Instance;
    }

    private void Start()
    {
        Init();
    }

    private static void Init()
    {
        if (Instance == null)
        {
            GameObject go = GameObject.Find("@Managers");
            if (go == null)
            {
                go = new GameObject() { name = "@Managers" };
                go.AddComponent<Managers>();
            }
            Instance = go.GetComponent<Managers>();
        }
        
    }
}