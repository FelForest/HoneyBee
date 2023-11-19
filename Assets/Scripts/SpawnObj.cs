using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnObj : MonoBehaviour
{
    public GameObject obj;
    public void spawnObj()
    {
        Instantiate(obj);
    }
}
