using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventFunctionsTest : MonoBehaviour
{
    private void Awake()
    {
        Debug.Log("awake");
    }

    private void Start()
    {
        Debug.Log("start");
    }

    private void OnEnable()
    {
        Debug.Log("onenable");
    }

    private void Update()
    {
        Debug.Log("update");
    }

    private void LateUpdate()
    {
        Debug.Log("lateupdate");
    }

    private void FixedUpdate()
    {
        Debug.Log("fixedupdate");
    }

    private void OnDestroy()
    {
        Debug.Log("ondestroy");
    }

    private void OnApplicationQuit()
    {
        Debug.Log("onapplicationquit");
    }

    private void OnDisable()
    {
        Debug.Log("ondisable");
    }
}
