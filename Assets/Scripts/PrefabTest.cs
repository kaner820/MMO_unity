using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PrefabTest : MonoBehaviour
{
    GameObject prefab;

    private GameObject tank;
    void Start()
    {
        tank = Managers.Resource.Instantiate("Tank");
        
        Managers.Resource.Destroy(tank, 3.0f);
    }
}