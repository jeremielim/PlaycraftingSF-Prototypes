using UnityEngine;

public class DragRigidBody : MonoBehaviour
{
    private Vector3 scanPos;
    private Vector3 screenPoint;

    void OnMouseDown()
    {
        screenPoint = Camera.main.WorldToScreenPoint(scanPos);
    }

    void OnMouseDrag()
    {
        Vector3 curScreenPoint = new Vector3(Input.mousePosition.x, Input.mousePosition.y, screenPoint.z);
        Vector3 curPosition = Camera.main.ScreenToWorldPoint(curScreenPoint);
        transform.position = curPosition;
    }

}
