using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;

    public bool IsGameOver => isGameOver;
    private bool isGameOver;

    public SpawnManager spawnManager;

    public GameObject gameOverUI;

    private void Awake()
    {
        Instance = this;
        //gameOverUI.SetActive(false);
    }

    public void GameOver()
    {
        isGameOver = true;
        spawnManager.StopSpawning();
        // gameOverUI.SetActive(true);
    }

    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }


}
