using UnityEngine;

public class cameraFollow : MonoBehaviour
{
    public Transform target;
    public Vector3 offset;
    [Range(1, 10)]
    public float FactorSuavidad;

    [SerializeField]
    float LeftLimit;
    [SerializeField]
    float RigtLimit;
    [SerializeField]
    float TopLimit;
    [SerializeField]
    float BottomLimit;

    private void FixedUpdate()
    {
        follow();
        Limit();
    }
    void follow()
    {
        Vector3 targetPosition = target.position + offset;
        Vector3 Suave = Vector3.Lerp(transform.position, targetPosition, FactorSuavidad * Time.fixedDeltaTime);
        transform.position = Suave;
    }

    void Limit()
    {
        transform.position = new Vector3
            (Mathf.Clamp(transform.position.x, LeftLimit, RigtLimit),
             Mathf.Clamp(transform.position.y, BottomLimit, TopLimit),
             transform.position.z
            );
    }

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawLine(new Vector2(LeftLimit, TopLimit), new Vector2(RigtLimit, TopLimit));
        Gizmos.DrawLine(new Vector2(RigtLimit, TopLimit), new Vector2(RigtLimit, BottomLimit));
        Gizmos.DrawLine(new Vector2(RigtLimit, BottomLimit), new Vector2(LeftLimit, BottomLimit));
        Gizmos.DrawLine(new Vector2(LeftLimit, BottomLimit), new Vector2(LeftLimit, TopLimit));
    }
}