using UnityEngine;
using UnityEngine.SceneManagement;

public class FinishLine : MonoBehaviour
{
    
    public string nextLevelSceneName = "Level 2";

    private void OnTriggerEnter2D(Collider2D collision)
    {
        
        if (collision.CompareTag("Player"))
        {
            
            SceneManager.LoadScene(nextLevelSceneName);
        }
    }
    
}