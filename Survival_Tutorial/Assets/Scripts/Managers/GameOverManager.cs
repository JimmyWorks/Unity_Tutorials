using UnityEngine;

public class GameOverManager : MonoBehaviour
{
    public PlayerHealth playerHealth;

    
    Animator anim;
    float restartTimer;
    float restartDelay = 5f;


    void Awake()
    {
        anim = GetComponent<Animator>();
    }


    void Update()
    {
        if (playerHealth.currentHealth <= 0)
        {
            anim.SetTrigger("GameOver");
            restartTimer += Time.deltaTime;

            if(restartTimer >= restartDelay)
            {
                Application.LoadLevel(Application.loadedLevel);
            }
        }
    }
}
