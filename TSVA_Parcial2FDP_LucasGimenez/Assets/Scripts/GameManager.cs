using UnityEngine;
using UnityEngine.SceneManagement;
public class GameManager : MonoBehaviour
{
    [SerializeField] GameObject PausePanel;
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            PauseToggle();
        }
    }
    public void PauseToggle()
    {
        if (Time.timeScale == 0.0f)
        {
            Time.timeScale = 1.0f;
            PausePanel.SetActive(false);
            Cursor.lockState = CursorLockMode.Locked;
        }
        else
        {
            Time.timeScale = 0.0f;
            PausePanel.SetActive(true);
            Cursor.lockState = CursorLockMode.Confined;
        }
    }
    public void Play()
    {
        SceneManager.LoadScene(1);
    }
    public void Quit()
    {
        Application.Quit();
    }
    public void MainMenu()
    {
        SceneManager.LoadScene("MENU");
    }
}