using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.XR.ARFoundation;
using UnityEngine.XR.ARSubsystems;


public class ObjectSpawner : MonoBehaviour
{
    public GameObject[] objectToSpawn;
    private int i=0;
    private PlacementIndicator placementIndicator;

    void Start()
    {
        placementIndicator = FindObjectOfType<PlacementIndicator>();
    }

    // Update is called once per frame
    public void SpawnObj()
    {
        GameObject obj = Instantiate(objectToSpawn[i], placementIndicator.transform.position, placementIndicator.transform.rotation);
    }

    public void ChangeObject(int a){
        i=a;
    }
}
