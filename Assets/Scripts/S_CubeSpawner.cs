using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class S_CubeSpawner : MonoBehaviour
{
    //Mainly here because the exercise said to instantiate it. Script could technically be removed, if prefab is placed in scene

    //The exercise defined that we should instantiate the object over and over again and just destroy it on collision, but changing the position 
    //and having a single cube seemed more performance friendly with the same outcome
    [SerializeField] private GameObject cube;
    void Start()
    {
        Instantiate(cube, new Vector3(0, 4, 0), Quaternion.identity);   
    }

}
