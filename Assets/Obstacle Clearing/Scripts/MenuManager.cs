using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
    [SerializeField] GameObject QuitPanel,InGamePanel,MenuPanel;

    // Start is called before the first frame update
    void Start()
    {
        Helper.GameOver = false;
    }
    public void OnPlayButton()
    {
        InGamePanel.SetActive(true);
        MenuPanel.SetActive(false);
        Helper.StartGame = true;
        Debug.Log(Helper.StartGame);
    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            QuitPanel.SetActive(true);
        }
    }
    public void Quit()
    {
        Application.Quit();
    }
}
