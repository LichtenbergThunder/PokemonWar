using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOver_RePlay : MonoBehaviour
{
    public void GameOver_ReplayLoadScene()
    {
        GameManager.instance.GameOver_ReplayGame();
    }

}
