using UnityEngine;
using UnityEngine.UI;

public class BrickManager : MonoBehaviour
{
    public static BrickManager Instance;
    public GameObject youWonUI;

    private int brickCount = 0;

    void Awake()
    {
        Instance = this;
    }

    public void RegisterBrick()
    {
        brickCount++;
    }

    public void BrickDestroyed()
    {
        brickCount--;
        if (brickCount <= 0)
        {
            youWonUI.SetActive(true);
        }
    }
}