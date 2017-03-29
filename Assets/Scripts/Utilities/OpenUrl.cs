using UnityEngine;

public class OpenUrl : MonoBehaviour {
    public void GoToURL(string URL) {
        Application.OpenURL(URL);
    }
}