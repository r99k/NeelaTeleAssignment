using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
public class GameManager : MonoBehaviour
{
    public static GameManager I;
    public GameObject InGamePanel, GameOverPanel,PasuePanel;
    // Start is called before the first frame update
    public void Awake()
    {
        I = this;
        Helper.GameOver = false;
    }
    private void Start()
    {
        Debug.Log("GameOver:" + Helper.GameOver);
        Debug.Log("StartGame" + Helper.StartGame);
    }
    public void LoadScene(int buidlIndex )
    { 
        SceneManager.LoadScene(buidlIndex);
        Helper.StartGame = false;
    }
    public void GameOver(int score)
    {
        Helper.GameOver = true;
        Helper.StartGame = false;
        InGamePanel.SetActive(false);
        GameOverPanel.SetActive(true);
    }

    public void GameStart()
    {
        InGamePanel.SetActive(true);
    }
    public void pause()
    {
        Time.timeScale = 0.0f;
        PasuePanel.SetActive(true);
    }
    public void resume()
    {
        Time.timeScale = 1.0f;
        PasuePanel.SetActive(false);
        
    }
    private void OnDisable()
    {
        Helper.StartGame = false;
        Helper.GameOver=false;
    }



}

