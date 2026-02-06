using NUnit.Framework.Constraints;
using UnityEngine;
using static UnityEngine.Rendering.DebugUI.Table;

public class BrickSpawner : MonoBehaviour
{
    public GameObject[] brickPrefabs;
    public GameObject[] purpleBrickPrefab;
    public GameObject[] blackBrickPrefab;
    public GameObject[] prefabsToSpawn;
    public Vector2 brickSize;
    public float maxZOffset;
    public int rowCount;
    public int columnCount;

    void Start()
    {
        
        float z = transform.position.z; // Will not change
        float y = transform.position.y; // Will change for every row of bricks

        for (int row = 0; row < rowCount; row++)
        {
            float x = transform.position.x; // Will change for every brick in a row
            for (int col = 0; col < columnCount; col++)
            {
                int randomIndex = Random.Range(0, brickPrefabs.Length);
                float randomZOffset = Random.Range(0f, maxZOffset);
                GameObject brick = brickPrefabs[randomIndex];
                Instantiate(brick, new Vector3(x, y, z + randomZOffset), brick.transform.rotation);
                x += brickSize.x;
            }
            if (row == row - 1)
            {
                prefabsToSpawn = purpleBrickPrefab;
            }
                y += brickSize.y;
        }
    }
}
  