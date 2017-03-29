using UnityEngine;

public class SelectToDestroy : MonoBehaviour
{
    RaycastHit hitInfo = new RaycastHit();

    void Update()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

        if (Input.GetMouseButtonDown(0))
        {
            if (Physics.Raycast(ray.origin, ray.direction, out hitInfo) && LayerMask.NameToLayer("Destructible") == 8)
            {
                Destroy(hitInfo.transform.gameObject);
            }
        }
    }
}
