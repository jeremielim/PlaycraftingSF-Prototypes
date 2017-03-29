using UnityEngine;

public class Switcher : MonoBehaviour
{
    public GameObject[] objects;
	 RaycastHit hitInfo = new RaycastHit();

    void Start()
    {
        InvokeRepeating("showObject", 0f, 0.2f);
    }

    void showObject()
    {
        int showIndex = Random.Range(0, objects.Length);

        for (int i = 0; i < objects.Length; i++)
        {
            if (i != showIndex)
            {
                objects[i].SetActive(false);
            }
            else
            {
                objects[i].SetActive(true);
            }
        }
    }

	void Update()
	{
		Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

        if (Input.GetMouseButtonDown(0))
        {
            if (Physics.Raycast(ray.origin, ray.direction, out hitInfo) && hitInfo.transform.gameObject.name == "OrangeDiamond")
            {
               CancelInvoke();
            }
        }
	}
}
