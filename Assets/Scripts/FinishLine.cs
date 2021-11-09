using UnityEngine;
using UnityEngine.SceneManagement;

public class FinishLine : MonoBehaviour
{
    [SerializeField] int maxSceneIndex = 1;
    private void OnTriggerEnter2D(Collider2D other)
    {
        bool finished = false;
        if (other.CompareTag("Player") && !finished)
        {
            int curIndex = SceneManager.GetActiveScene().buildIndex;
            if (SceneManager.GetActiveScene().buildIndex == maxSceneIndex)
            {
                SceneManager.LoadScene(0);
            }
            else
            {
                curIndex++;
                SceneManager.LoadScene(curIndex);
            }
            finished = true;
        }
    }
}
