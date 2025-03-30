using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChanger : MonoBehaviour
{
    public string nextSceneName;

    void Update()
    {
        if (transform.position.y < -10f)
        {
            SceneManager.LoadScene(nextSceneName);
        }
    }
}