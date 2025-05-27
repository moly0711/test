using UnityEngine;

public class ShootAndJudge : MonoBehaviour
{
    [SerializeField] private Camera playerCamera;
    [SerializeField] private float maxDistance = 100f;

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = playerCamera.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(ray, out RaycastHit hit, maxDistance))
            {
                Debug.DrawRay(ray.origin, ray.direction * maxDistance, Color.red, 1f);
                Debug.Log($"Hit: {hit.collider.name} at {hit.point}");

                Target target = hit.collider.GetComponent<Target>();
                if (target != null)
                {
                    target.JudgeHit(hit.point);
                }
            }
        }
    }
}
