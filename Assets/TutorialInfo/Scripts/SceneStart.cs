using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;

public class SceneStart : MonoBehaviour, IPointerClickHandler 
{
    public string SampleScene;

    public void OnPointerClick(PointerEventData eventData)
    {
        SceneManager.LoadScene(SampleScene);
    }
}
