using UnityEngine;

public class Target : MonoBehaviour
{
    [SerializeField] private float goodRadius = 0.2f;
    [SerializeField] private float niceRadius = 0.5f;

    public void JudgeHit(Vector3 hitPoint)
    {
        Vector3 center = GetComponent<Collider>().bounds.center;
        float distance = Vector3.Distance(hitPoint, center);

        if (distance <= goodRadius)
            Debug.Log("Good!");
        else if (distance <= niceRadius)
            Debug.Log("Nice!");
        else
            Debug.Log("Bad!");
    }
}
