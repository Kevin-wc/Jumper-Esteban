using UnityEngine;

public class PlatformSpawner : MonoBehaviour
{
    public GameObject platformPrefab;
    public Transform player;

    public float minYGap = 1.5f;
    public float maxYGap = 3f;
    public float minX = -7f;
    public float maxX = 7f;

    private float highestSpawnY = 0f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        for (int i = 0; i < 15; i++)
        {
            spawnPlatform();
        }
    }

    // Update is called once per frame
    void Update()
    {
        while (highestSpawnY < player.position.y)
        {
            spawnPlatform();
        }
    }

    public void spawnPlatform()
    {
        float yGap = Random.Range(minYGap, maxYGap);
        highestSpawnY += yGap;

        float x = Random.Range(minX, maxX);
        Vector3 spawnPosition = new Vector3(x, highestSpawnY, 0f);

        GameObject newPlatform = Instantiate(platformPrefab, spawnPosition, Quaternion.identity);
    }
}
