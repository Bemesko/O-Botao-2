using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectDestructor : MonoBehaviour
{
    [SerializeField]
    private float lifeTime = 0.3f;
    void Start()
    {
        Destroy(gameObject, lifeTime);
    }
}
