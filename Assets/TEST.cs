using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class TEST : MonoBehaviour
{
    public UnityEvent ue;
    public int n;

    private void Update()
    {
        for(int i = 0; i < n; i++)
        {
            ue.Invoke();
        }
    }
}
