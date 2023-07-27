using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public GameObject gameOverCanvas;
    public Text finalScore;
    public Text counter;
    // Start is called before the first frame update
    private void Start()
    {
        Time.timeScale = 1;
    }
    public void GameOver()
    {
        counter.enabled = false;
        finalScore.text = Score.score.ToString();
        gameOverCanvas.SetActive(true);
        Time.timeScale = 0;
    }

    public void Replay()
    {
        counter.enabled = true;
        SceneManager.LoadScene(0);
        Score.score = 0;
    }

}
