using System.Collections;
using System.Threading.Tasks;       //async���g���Ƃ��ɕK�v
using System.Collections.Generic;
using UnityEngine;

public class TaimStop : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //���̓�͓����B
        StartCoroutine(Stoping());
        OnStartAsync();
    }

    IEnumerator Stoping()
    {
        yield return new WaitForSeconds(2);

        Debug.Log("��b�҂�����I");

        yield return null;
    }

    //UniRX ���̊T�O���炫�Ă���
    //async(�G�C�V���N)/await(�A�E�F�C�g)��
    public async void OnStartAsync()
    {
        await Task.Delay(3000); 

        Debug.Log("�Q�b�҂�����I");
    }

    // UI Button �Ŏg�p�\ �@/�@IEnumerator �ł͎g�p�s��
    async void ButtonAsync()
    {
        await Task.Delay(1000);
        Debug.Log("��b�҂�����");
    }
}
