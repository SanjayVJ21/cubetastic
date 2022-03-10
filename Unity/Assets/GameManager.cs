using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    bool Valid = false;
    public float delay;
    public GameObject completelevelui;
    public GameObject gameoverui;
    public void EndGame()
    {
        if (Valid == false)
        {
            Valid = true;
            gameoverui.SetActive(true);
            Invoke("Restart", delay);
        }
    }
    void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name); 
    }
    public void completelevel()
    {
        completelevelui.SetActive(true);
    }
  
}
