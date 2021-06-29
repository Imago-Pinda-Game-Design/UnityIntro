using UnityEngine;
using UnityEngine.SceneManagement;
public class ChangeSceneOnClick : MonoBehaviour
{
    public string SceneName;

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            SceneManager.LoadScene(SceneName);
        }
    }
}
