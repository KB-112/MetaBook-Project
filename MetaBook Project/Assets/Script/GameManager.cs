using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance { get; private set; }

    private void Awake()
    {
        if (Instance != null && Instance != this)
        {
            Destroy(this);
        }
        else
        {
            Instance = this;
        }
    }
    
    public MenuComponent menuComponent;
    public PlayerComponents playerComponents;
    public EnemyComponents enemyComponents;     
    public SoundComponents soundComponents;   
  
}
[System.Serializable]
public class PlayerComponents
{
    public GameObject player;
    public float playerSpeed;
    public float playerHealth;
    public float playerGetDamage;
    public float playerCanDamage;
    public Slider playerHealthSlider;


    public PlayerComponents(float playerHealth, float playerGetDamage, float playerCanDamage)
    {
        this.playerHealth = playerHealth;
        this.playerGetDamage = playerGetDamage;
        this.playerCanDamage = playerCanDamage;
    }
}
[System.Serializable]
public class EnemyComponents
{
    public float enemySpeed;
    public float enemyRotSpeed;
    public float enemyHealth;
    public float enemyGetDamage;
    public float enemyCanDamage;

    public GameObject enemyPrefab;
    public float prefabSpawnTime;

    public EnemyComponents(float enemyHealth, float enemyGetDamage, float enemyCanDamage)
    {
        this.enemyHealth = enemyHealth;
        this.enemyGetDamage = enemyGetDamage;
        this.enemyCanDamage = enemyCanDamage;
    }
}
[System.Serializable]
public class SoundComponents
{
    public AudioSource playerGetDamage;   
    public AudioSource enemyGetDamage;

}
[System.Serializable]
public class MenuComponent
{
    public GameObject[] menuandGameOver;
    public GameObject[] buttonsObj;
    public Button[] buttons;

    public MenuComponent(GameObject[] menuandGameOver, GameObject[] buttonsObj, Button[] buttons)
    {
        this.menuandGameOver = menuandGameOver;
        this.buttons = buttons;
        this.buttonsObj = buttonsObj;
    }
}



