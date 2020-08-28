using UnityEngine;
using UnityEngine.Serialization;

public class MainClick : MonoBehaviour
{
    [SerializeField] public HealthBar healthBar;
    public static float Attack = 0.0f;
    public float health = 1.0f;
    public float mobHealth = 100.0f;
    public int pay;
    public int xp;
    public int currentLelvel;
    private int _i = 8;
    public GameObject[] anim = new GameObject[1];
    public new AudioClip[] audio = new AudioClip[3];
    public AudioSource audioS;
    private static int _randomPref;
    private static GameObject _mainCamera;
    private float _timer = 0.0f;
    private static Vector2 _clickPos;
    public static bool IfSoundOn = true;

    public void UpdateXp(int xp)
    {
        this.xp += xp;
        var curLvl = (int)(0.1f * Mathf.Sqrt(this.xp));
        currentLelvel = curLvl;
            //TODO: Add lvlup anim
    }

    private void OnMouseDown()
    {
        if (PauseMenu.P != false) return;
        health -= 0.1f / mobHealth * 100f;
        if (Camera.main != null) _clickPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            //TODO: Animation when hit enemy
    }
    
    private void Start()
    {
        Attack = ScoreCount.CurrentAttack;
        _mainCamera = GameObject.Find("Main Camera");
    }

    private void Update()
    {

        if (_timer >= 1.0f)
        {
            health -= Attack;
            _timer = 0;
        }
        else
        {
            _timer += 0.01f;
        }
        
        if (health <= 0f)
        {
            ScoreCount.Score += pay;
            PauseMenu.Death = true;
            Destroy(this.gameObject);
        }

        healthBar.SetSize(health);
        if (!(health <= 0.3f)) return;
        if(_i <= 0)
        {
            healthBar.SetColore(Color.white);
            _i = 8;
        } else {
            healthBar.SetColore(Color.red);
            _i--;
        }
    }
}
