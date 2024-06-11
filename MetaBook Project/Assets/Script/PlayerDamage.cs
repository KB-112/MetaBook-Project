using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDamage : MonoBehaviour
{
    private void Start()
    {
        Initialization();
    }
    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("Collision Happen");
        PlayerDamageTaken();
    }

    void PlayerDamageTaken()
    {
        if (Player().playerHealth >0)
        {
            Player().playerHealth -= Player().playerGetDamage;
            Player().playerHealthSlider.value = Player().playerHealth;
        }
        else
        {
            GameOver(true);
        }
    }
    void Initialization()
    {
        Player().playerHealth = 10f;
        Player().playerHealthSlider.maxValue = Player().playerHealth;
        Player().playerGetDamage = 1f;
    }

    public PlayerComponents Player()
    {
        return GameManager.Instance.playerComponents;
    }
    void GameOver(bool state)
    {
        var inst = GameManager.Instance.menuComponent;

        inst.menuandGameOver[0].SetActive(state);
        inst.menuandGameOver[2].SetActive(state);


    }
}
