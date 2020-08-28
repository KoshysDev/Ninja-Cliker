using UnityEngine;

public class PauseMenu : MonoBehaviour
{
    public GameObject pauseMenuUi;
    public GameObject settingsUi;
    public GameObject pauseButton;
    public static bool Death = true;
    public static bool P;
    [SerializeField] private bool s;
    public GameObject[] enemyPrefab = new GameObject[1];
    private int _randomPref;
    private GameObject _o;

    private void Start()
    {
        _o = GameObject.FindGameObjectWithTag("Enemy");
    }

    private void Update()
    {
        _o = GameObject.FindGameObjectWithTag("Enemy");
        if (_o != null) return;
        Death = true;
        EnemySpawner();
    }

    public void OnExit()
    {
     Application.Quit();
    }

    public void OnPlay()
    {
        if (P == false)
        {
            pauseMenuUi.SetActive(true);
            pauseButton.SetActive(false);
            P = true;
        }
        else
        {
            pauseMenuUi.SetActive(false);
            pauseButton.SetActive(true);
            P = false;
        }
    }

    public void Settings()
    {
        if (s == false && P == true)
        {
            settingsUi.SetActive(true);
            pauseMenuUi.SetActive(false);
            s = true;
            GetComponent<SettingsMenu>().SaveSettings();
        }
        else
        {
            pauseMenuUi.SetActive(true);
            settingsUi.SetActive(false);
            s = false;
        }
    }

    public void RedirectDiscord()
    {
        Application.OpenURL("https://discord.gg/ujyhnDP");
    }

    //enemy spawner
    private void EnemySpawner()
    {
        if (Death != true) return;
        Death = false;
        _randomPref = Random.Range(0, enemyPrefab.Length);
        Instantiate(enemyPrefab[_randomPref], new Vector3(-0.05f, -1.5f, 3), Quaternion.identity);
    }
}
