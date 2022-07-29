using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System.Threading.Tasks;

public class GameManager : MonoBehaviour
{

#region singleton
    public static GameManager instance = null;
    private void Awake()
    {
        if(instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(this.gameObject);
        }
    }
    #endregion

    [SerializeField, Header("Game over view instantiate")]
    private GameObject gameObjectView = null;

    private string playGame = "Pokemon";

    async public void GameOver()
    {
        await Task.Delay(2000);
        Instantiate(gameObjectView);
    }

    public void GameOver_ReplayGame()
    {
        LoadScene_N(playGame);
    }

    void LoadScene_N(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }
}
