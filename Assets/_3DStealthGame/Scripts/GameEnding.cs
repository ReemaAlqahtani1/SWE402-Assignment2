using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UIElements;

public class GameEnding : MonoBehaviour
{
    public float fadeDuration = 1f;
    public float displayImageDuration = 1f;
    public GameObject player;
    public UIDocument uiDocument;
    public AudioSource exitAudio;
    public AudioSource caughtAudio;

    bool m_IsPlayerAtExit;
    bool m_IsPlayerCaught;
    float m_Timer;
    bool m_HasAudioPlayed;

    private VisualElement m_EndScreen;
    private VisualElement m_CaughtScreen;

    float m_GameTimer;
    Label m_TimerLabel;

    void Start()
    {
        m_EndScreen = uiDocument.rootVisualElement.Q<VisualElement>("EndScreen");
        m_CaughtScreen = uiDocument.rootVisualElement.Q<VisualElement>("CaughtScreen");
        m_TimerLabel = uiDocument.rootVisualElement.Q<Label>("TimerLabel");
    }
    
    void OnTriggerEnter (Collider other)
    {
        if (other.gameObject == player)
        {
            m_IsPlayerAtExit = true;
        }
    }

    public void CaughtPlayer ()
    {
        m_IsPlayerCaught = true;
    }

    void Update ()
    {
        if (m_IsPlayerAtExit)
        {
            EndLevel (m_EndScreen, false, exitAudio);
        }
        else if (m_IsPlayerCaught)
        {
            EndLevel (m_CaughtScreen, true, caughtAudio);
        }
        if (!m_IsPlayerAtExit && !m_IsPlayerCaught)
        {
            m_GameTimer += Time.deltaTime;

            if (m_TimerLabel != null)
            {
                m_TimerLabel.text = $"Time: {m_GameTimer:0.00}";
            }
        }
    }

    void EndLevel (VisualElement element, bool doRestart, AudioSource audioSource)
    {
        if (!m_HasAudioPlayed)
        {
            audioSource.Play();
            m_HasAudioPlayed = true;
        }
            
        m_Timer += Time.deltaTime;
        element.style.opacity = m_Timer / fadeDuration;

        if (m_Timer > fadeDuration + displayImageDuration)
        {
            if (doRestart)
            {
                SceneManager.LoadScene (0);
            }
            else
            {
                Application.Quit();
                Time.timeScale = 0;
               
            }
        }
    }
}