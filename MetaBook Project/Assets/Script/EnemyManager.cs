using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyManager : MonoBehaviour
{
    private void Start()
    {
        StartCoroutine(InstantiateEnemy());
    }
    public EnemyComponents Enemy()
    {
        return GameManager.Instance.enemyComponents;
    }
    IEnumerator InstantiateEnemy()
    {
        while (true)
        {
            Vector2 pos = new Vector2(10f, 1.1f);
            Instantiate(Enemy().enemyPrefab, pos, Quaternion.identity);
            yield return new WaitForSeconds(Enemy().prefabSpawnTime);
        }
    }
}
