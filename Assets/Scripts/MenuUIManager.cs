using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuUIManager : MonoBehaviour
{
    public void StartGame()
    {
        MenuManager.Instance.UpdateName();
        SceneManager.LoadScene(1);
    }
}
