using UnityEngine;

public class Brick : MonoBehaviour
{
    void Start()
    {
        BrickManager.Instance.RegisterBrick();
    }

    void OnDestroy()
    {
        if (BrickManager.Instance != null)
        {
            BrickManager.Instance.BrickDestroyed();
        }
    }
}