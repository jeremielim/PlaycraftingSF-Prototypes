using UnityEngine;
using System.Collections;

public class Spawner : MonoBehaviour
{

    public GameObject prefab;
    public float delay = 2.0f;
    public Vector2 delayRange = new Vector2(1, 2);
    public Vector3 minPosition;
    public Vector3 maxPosition;

    void Start()
    {
        StartCoroutine(EnemyGenerator());
    }

    IEnumerator EnemyGenerator()
    {
        yield return new WaitForSeconds(delay);

        GameObject instance = null;
        var newTransform = new Vector3(Random.Range(minPosition.x, maxPosition.x), Random.Range(minPosition.y, maxPosition.y), Random.Range(minPosition.z, maxPosition.z));

        // GameObjectUtil.Instantiate(prefab, newTransform.position);

        instance = GameObject.Instantiate(prefab);
        instance.transform.position = newTransform;

        ResetDelay();

        StartCoroutine(EnemyGenerator());
    }

    void ResetDelay()
    {
        delay = Random.Range(delayRange.x, delayRange.y);
    }
}
