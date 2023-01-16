//2.15

using UnityEngine;
using UnityEngine.SceneManagement;//****

public class EndTrigger : MonoBehaviour
{
    public GameManager gameManager;
    public bool win;
    private bool coderuned = false;

    void Update()
    {
        Debug.Log(win);
        if (coderuned)
        {
            win = true;
        }
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log(collision.gameObject.tag);
        
        if (coderuned == false)
        {
            if (collision.gameObject.tag == "Player")   
            {   
                SceneManager.LoadScene("CompleteScene");
                
                win = true;
                gameManager.CompleteLevel();
                coderuned = true;

                
                
            }
        }

    }


}
