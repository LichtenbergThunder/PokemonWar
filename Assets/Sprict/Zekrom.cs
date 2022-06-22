using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zekrom : MonoBehaviour
{
    [SerializeField]
    private Animator anim = null;

    [SerializeField]
    private Renderer r = null;

    private Rigidbody rb = null;

    static readonly int barkId = Animator.StringToHash("Bark");

    void Start()
    {
        TryGetComponent(out rb);

        StartCoroutine(LightOn());
    }

    void Update()
    {
        rb.velocity = new Vector3(0, 0, 0);
    }

    IEnumerator LightOn()
    {
        yield return new WaitForSeconds(4f);

        Material[] materialColor = r.materials;

        anim.SetTrigger(barkId);

        for(float i = 100;i > 20; i--)
        {
            yield return new WaitForSeconds(0.01f);

            materialColor[0].color = new Color(0, (100 - i) / 100, (100 - i)/100,1);
            materialColor[5].color = new Color(0,0,0,i/100);
        }

        yield return new WaitForSeconds(1.5f);

        MusicOperation.instance.SetPlaySE("Bark");


        for (float i = 20; i < 100; i++)
        {
            Debug.Log("aaa");

            yield return new WaitForSeconds(0.03f);

            materialColor[0].color = new Color(0, (100 - i) / 100, (100 - i) / 100, 1);
            materialColor[5].color = new Color(0, 0, 0, i / 100);
        }

        yield return null;
    }
}
