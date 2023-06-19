using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MenuController : MonoBehaviour
{
    public string gameScene;
    // public Button startButton;
    // public Button dutchLanguage;
    // public Button englishLanguage;
    
    void Start()
    {
        // startButton.onClick.AddListener(newGame);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void newGame(){
        SceneManager.LoadScene(gameScene, LoadSceneMode.Single);
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
