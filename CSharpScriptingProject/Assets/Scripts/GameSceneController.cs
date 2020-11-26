using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public delegate void TextOutputHandler(string text);

public class GameSceneController : MonoBehaviour
{
    [Header("Player Settings")]
    [Range(5, 20)] public float playerSpeed;

    [Header("Screen Settings")]
    [Space] public Vector3 screenBounds;

    [Header("Prefab")]
    [Space]
    [SerializeField] private EnemyController enemyPrefab;
    private HUDController hudController;
    private int totalPoints;

    private PlayerController player;

    void Start()
    {
        hudController = FindObjectOfType<HUDController>();

        screenBounds = GetScreenBounds();
        StartCoroutine(SpawnEnemies());


        player = FindObjectOfType<PlayerController>();
    }


    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            player.SetColor(Color.red);
        }

        if (Input.GetKeyUp(KeyCode.Space))
        {
            player.SetColor(Color.yellow);
        }
    }

    public IEnumerator SpawnEnemies()
    {
        WaitForSeconds wait = new WaitForSeconds(2);

        while (true)
        {
            float horizontalPosition = UnityEngine.Random.Range(-screenBounds.x, screenBounds.x);
            Vector2 spawnPosition = new Vector2(horizontalPosition, screenBounds.y);

            EnemyController enemy = Instantiate(enemyPrefab, spawnPosition, Quaternion.identity);

            enemy.EnemyEscaped += EnemyAtBottom;
            enemy.EnemyKilled += EnemyKilled;

            yield return wait;
        }
    }

    private void EnemyKilled(int pointValue)
    {
        totalPoints += pointValue;
        hudController.scoreText.text = totalPoints.ToString();
    }

    private void EnemyAtBottom(EnemyController enemy)
    {
        Destroy(enemy.gameObject);
        Debug.Log("Enemy escaped");
    }

    private Vector3 GetScreenBounds()
    {
        Camera mainCamera = Camera.main;
        Vector3 screenVector = new Vector3(Screen.width, Screen.height, mainCamera.transform.position.z);

        return mainCamera.ScreenToWorldPoint(screenVector);
    }

    public void KillObject(IKillable killable)
    {
        killable.Kill();
    }

    public void OutputText(string output)
    {
        Debug.LogFormat("{0} output by GameSceneController", output);
    }
}
