using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class TEST : MonoBehaviour
{
    public SeedRandom asd;

    public AbsIntVariable_So a;

    private void Awake()
    {
        Debug.Log(a.value);
    }

    private void Update()
    {
    }

}
