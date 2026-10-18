using UnityEngine;

public class MoveObject : MonoBehaviour
{
    public float speed = 2f;
    public float direction = 1f;
    public float maxDistance = 3f;

    private float traveled = 0f;

    void Update()
    {
        float step = direction * speed * Time.deltaTime;
        transform.Translate(0f, 0f, step);
        traveled += step;

        if (Mathf.Abs(traveled) >= maxDistance)
        {
            direction = -direction;
            traveled = Mathf.Sign(traveled) * maxDistance;
        }
    }
}