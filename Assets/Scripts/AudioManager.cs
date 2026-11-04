using UnityEngine;

public class AudioManager : MonoBehaviour
{
    // Put variables here 
    [SerializeField] private AudioSource music;
    [SerializeField] private AudioSource jumpSFX;
    [SerializeField] private AudioSource quackSFX;

    private static AudioManager instance;
    public static AudioManager Instance
    {
        get
        {
            // Lazy Instantiation
            if (instance == null)
            {
                instance = Object.FindAnyObjectByType<AudioManager>();

                if (instance == null)
                {
                    GameObject singletonGO = new GameObject("AudioManager");
                    instance = singletonGO.AddComponent<AudioManager>();
                }
            }
            return instance;
        }
    }

    // Destroy potential duplicate, set instance to new singleton
    private void Awake()
    {
        if (instance != null && instance != this)
        {
            Destroy(this.gameObject);
        }
        else
        {
            instance = this;
            DontDestroyOnLoad(instance.gameObject);
        }
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // Start music here 
        music.Play();
    }

    // Create function to play jump sound here 
    public void PlayJumpSound()
    {
        jumpSFX.Play();
    }

    public void PlayQuackSound()
    {
        quackSFX.Play();
    }

    // Create function to play quack sound here  

    // Create pitch shifting trigger here

}
