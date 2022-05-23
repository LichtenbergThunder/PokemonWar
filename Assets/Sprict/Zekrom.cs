using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zekrom : MonoBehaviour
{
    [SerializeField]
    private Animator anim = null;

    private Rigidbody rb = null;

    void Start()
    {
        TryGetComponent(out rb);
    }

    void Update()
    {
        rb.velocity = new Vector3(0, 0, 10);
    }
}
