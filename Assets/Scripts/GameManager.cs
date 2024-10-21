using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public int playerLives = 10;
    public int playerGold = 100;

    public Text livesText;
    public Text goldText;

    void Update()
    {
        livesText.text = "Vidas: " + playerLives;
        goldText.text = "Ouro: " + playerGold;
    }

    public void LoseLife()
    {
        playerLives--;
        if (playerLives <= 0)
        {
            // Implementar lógica de derrota
        }
    }

    public void AddGold(int amount)
    {
        playerGold += amount;
    }
}
