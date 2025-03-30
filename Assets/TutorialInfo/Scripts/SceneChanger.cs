using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChanger : MonoBehaviour
{
    public void ChangeSceneToScene2()
    {
        SceneManager.LoadScene("map ice");
    }
}