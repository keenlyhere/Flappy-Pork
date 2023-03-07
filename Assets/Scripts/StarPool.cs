using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StarPool : MonoBehaviour
{
    public int starPoolSize = 5;
    public GameObject starPrefab;
    public float spawnRate = 1f;
    public float starMin = -0.3f;
    public float starMax = 1.5f;

    private GameObject[] stars;
    private Vector2 objectPoolPosition = new Vector2(-15f, -25f);
    private float timeSinceLastSpawned;
    private float spawnXPosition = 7f;
    private int currentStar = 0;

    // Start is called before the first frame update
    void Start()
    {
        stars = new GameObject[starPoolSize];
        for (int i = 0; i < starPoolSize; i++) {
            stars [i] = (GameObject)Instantiate (starPrefab, objectPoolPosition, Quaternion.identity);
        }
    }

    // Update is called once per frame
    void Update()
    {
        timeSinceLastSpawned += Time.deltaTime;
        if (GameControl.instance.gameOver == false && timeSinceLastSpawned >= spawnRate) {
            timeSinceLastSpawned = 0;
            float spawnYPosition = Random.Range(starMin, starMax);
            stars [currentStar].transform.position = new Vector2(spawnXPosition, spawnYPosition);

            currentStar += 1;
            if (currentStar >= starPoolSize) {
                currentStar = 0;
            }
        }
    }
}
