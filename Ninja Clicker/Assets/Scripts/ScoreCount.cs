using UnityEngine;
using UnityEngine.UI;

public class ScoreCount : MonoBehaviour
{
    public static int Score;
    public GameObject scoreText;
    public GameObject attackText;
    public int interanalScore;
    public static float CurrentAttack;
    //public int currentMinNeed;
    private static bool _firstRun = true;
    public SettingsMenu settingsScript;
    private Text _text;
    private Text _text1;

    private void Start()
    {
        _text1 = attackText.GetComponent<Text>();
        _text = scoreText.GetComponent<Text>();
    }

    private void FixedUpdate()
    {
        if (_firstRun != true) return;
        // ReSharper disable once Unity.PerformanceCriticalCodeInvocation
        //settingsScript.LoadSettings();
        _firstRun = false;
    }

    private void Update()
    {
        interanalScore = Score;
        _text.text = "" + interanalScore;
        _text1.text = "" + CurrentAttack;
    }
}
