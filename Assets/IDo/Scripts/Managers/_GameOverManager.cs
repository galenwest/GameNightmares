using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class _GameOverManager : MonoBehaviour
{

    public _PlayerHealth playerHealth;
    public float restartDelay = 2f;
    float restartTimer;

    Animator anim;
    Button btn;

    void Awake()
    {
        anim = GetComponent<Animator>();
    }

    public void OnReLoadScene()
    {
        SceneManager.LoadScene("IDo/Scenes/Main");
    }

    void Update()
    {
        if (playerHealth.currentHealth <= 0 && btn == null)
        {
            anim.SetTrigger("GameOver");

            restartTimer += Time.deltaTime;

            if (restartTimer >= restartDelay)
            {
                btn = GetComponentInChildren<Button>();
                if (btn != null)
                {
                    btn.onClick.AddListener(OnReLoadScene);
                }
            }
        }
    }
}
