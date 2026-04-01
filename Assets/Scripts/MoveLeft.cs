using UnityEngine;

public class MoveLeft : MonoBehaviour
{
    public float speed = 10;
    private float leftBound = -15f;

    private void Update()
    {
        if ( GameManager.Instance.IsGameOver == false)
        {
            transform.Translate(Vector3.left * Time.deltaTime * speed);
        }

        if (transform.position.x < leftBound && gameObject.CompareTag("Obstacle"))
        {
            Destroy(gameObject);
        }
    }
}

