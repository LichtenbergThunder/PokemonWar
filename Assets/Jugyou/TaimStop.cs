using System.Collections;
using System.Threading.Tasks;       //asyncを使うときに必要
using System.Collections.Generic;
using UnityEngine;

public class TaimStop : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //下の弐つは同じ。
        StartCoroutine(Stoping());
        OnStartAsync();
    }

    IEnumerator Stoping()
    {
        yield return new WaitForSeconds(2);

        Debug.Log("弐秒待ったよ！");

        yield return null;
    }

    //UniRX この概念からきている
    //async(エイシンク)/await(アウェイト)版
    public async void OnStartAsync()
    {
        await Task.Delay(3000); 

        Debug.Log("参秒待ったよ！");
    }

    // UI Button で使用可能 　/　IEnumerator では使用不可
    async void ButtonAsync()
    {
        await Task.Delay(1000);
        Debug.Log("壱秒待ったよ");
    }
}
