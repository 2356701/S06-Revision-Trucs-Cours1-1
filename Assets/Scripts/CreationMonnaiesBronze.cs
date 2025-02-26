using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreationMonnaiesBronze : MonoBehaviour
{
    [SerializeField] GameObject _prefabOriginal;
    [SerializeField] Vector3 _positionCreation;

    void Start()
    {
     
        Instantiate(_prefabOriginal, transform.position, transform.rotation);
    }
}
