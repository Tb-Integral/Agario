using UnityEngine;

public class randomBall : MonoBehaviour
{
    [SerializeField] private int count = 10;
    [SerializeField] private GameObject[] balls;

    void Start()
    {
        for (int i = 0; i<count; i++)
        {
            Instantiate(balls[Random.Range(0, balls.Length)], new Vector3(Random.Range(-64f, 64f), 0, Random.Range(-66f, 66f)), Quaternion.Euler(0,0,0));
        }
    }
}
