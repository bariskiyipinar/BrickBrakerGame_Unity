using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting.Antlr3.Runtime;
using UnityEngine;
using DG.Tweening;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI HealthText;
    [SerializeField] private int health;

    [SerializeField] private TextMeshProUGUI ScoreText;
    [SerializeField] private int score;

    bool gameover;

    [SerializeField]
    GameObject gameOverPanel;
    private void Start()
    {
        HealthText.text = "Health: "+health.ToString();
        ScoreText.text= "Score: "+score.ToString();

        gameOverPanel.GetComponent<RectTransform>().localScale = Vector2.zero;
        gameOverPanel.GetComponent<CanvasGroup>().alpha = 0;
    }
    public void HealthBall(int healthCount)
    {
        health += healthCount;

        if(health <=0)
        {
            health = 0;
            gameOver();
            gameover = true;
          
        }
        HealthText.text = "Health: " + health.ToString();
    }


    public void UpdateScoreBall(int m_score)
    {
       this.score += m_score;

        ScoreText.text = "Score: " + score.ToString();

    }


    void gameOver()
    {
        gameOverPanel.GetComponent<RectTransform>().DOScale(1, .5f);
        gameOverPanel.GetComponent<CanvasGroup>().DOFade(1, .5f);
        

        gameover = false;
    }



    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void QuitApplication()
    {
        Application.Quit();
    }

}
