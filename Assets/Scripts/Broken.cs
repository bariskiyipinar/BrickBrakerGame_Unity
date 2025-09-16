using UnityEngine;

public class Broken : MonoBehaviour
{
    [SerializeField] private int m_healthcount = 2; 
    [SerializeField] private Sprite m_sprite;


    GameManager gameManager;

    private void Start()
    {
        gameManager = FindAnyObjectByType<GameManager>();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Ball"))
        {
            BrokenBlockHealth();
        }
    }

    public void BrokenBlockHealth()
    {
        m_healthcount--; 

        if (m_healthcount == 1)
        {
            gameManager.UpdateScoreBall(5);
            GetComponent<SpriteRenderer>().sprite = m_sprite;
        }
        else if (m_healthcount <= 0)
        {
            gameManager.UpdateScoreBall(10);
            Destroy(this.gameObject);
        }
    }
}
