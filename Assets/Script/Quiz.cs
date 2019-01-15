using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Quiz : MonoBehaviour
{
    public List<string[]> csvData = new List<string[]>();　　　// 文章を格納するリスト
    public TextAsset CSVfile;
    public Text uiText, Select1, Select2, Select3, Select4, count; //問題と、選択肢のテキスト
    [SerializeField]
    [Range(0.001f, 0.3f)]
    float IntervalForCharDisplay;                      // 1文字の表示にかける時間
    int RandomNum = 0;                                 //問題をランダムに抽出するための変数
    public int Count,miss,ClearCount;
    private string Ans;                                        //答え合わせ用の文字列を格納する変数
    private int currentSentenceNum = 0;                //現在表示している文章番号
    protected string currentSentence = string.Empty;   // 現在の文字列
    private float timeUntilDisplay = 0;                // 表示にかかる時間
    private float timeBeganDisplay = 1;                // 文字列の表示を開始した時間
    int lastUpdateCharCount = -1;                      // 表示中の文字数
    public MoveBlock MoveBlock;
    public MovingPlayer MovingPlayer;
    public CanvasGroup canvas, QuizText,mission,textbox;
    public Animator ani;
    public GameObject JoyStick;
    public bool posisionUp = true;
    public bool POS0 = true;
    public AudioClip Audio1, Audio2;
    public AudioSource Speker;

    void Start()
    {
        Count = 0;
        canvas.alpha = 0;
    }

    public void QuizLoad()
    {
        //CSVからすべてのクイズを読み込み、リストに格納
        string[] lines = CSVfile.text.Replace("\r\n", "\n").Split("\n"[0]);
        foreach (string line in lines)
        {
            if (line == "") { continue; }
            csvData.Add(line.Split(','));
        }
        SetNextSentence();
    }

    void Update()
    {
        if (Count == 3)
        {
            if (POS0)
            {
                POS0 = false;
                EndQuiz();
            }
        }
        else
        {
            int displayCharCount = (int)(Mathf.Clamp01((Time.time - timeBeganDisplay) / timeUntilDisplay) * currentSentence.Length);
            //表示される文字数が表示している文字数と違う
            if (displayCharCount != lastUpdateCharCount)
            {
                uiText.text = currentSentence.Substring(0, displayCharCount);
                //表示している文字数の更新
                lastUpdateCharCount = displayCharCount;
            }
        }
    }
    // 次の文章をセットする
    public void SetNextSentence()
    {
        //リストからランダムで1問取る
        RandomNum = Random.Range(1, 134);
        Ans = csvData[RandomNum][1];
        currentSentence = csvData[RandomNum][0];
        Select1.text = csvData[RandomNum][2];
        Select2.text = csvData[RandomNum][3];
        Select3.text = csvData[RandomNum][4];
        Select4.text = csvData[RandomNum][5];
        timeUntilDisplay = currentSentence.Length * IntervalForCharDisplay;
        timeBeganDisplay = Time.time;
        currentSentenceNum++;
        lastUpdateCharCount = 0;
    }

    //選択肢の判定&次の問題の読み込み
    public void Check1()
    {
        if (Ans == Select1.text)
        {
            Speker.clip = Audio1;
            Speker.Play();
            Count++;
            if (Count == 3)
            {
                ClearCount++;
                POS0 = true;
                posisionUp = true;
            }
            StartCoroutine("NextQuiz");
        }
        else if (Ans != Select1.text)
        {
            Speker.clip = Audio2;
            Speker.Play();
            Count = 0;
            miss++;
            StartCoroutine("NextQuiz");
        }
    }
    public void Check2()
    {
        if (Ans == Select2.text)
        {
            Speker.clip = Audio1;
            Speker.Play();
            Count++;
            if (Count == 3)
            {
                ClearCount++;
                POS0 = true;
                posisionUp = true;
            }
            StartCoroutine("NextQuiz");
        }
        else if (Ans != Select2.text)
        {
            Speker.clip = Audio2;
            Speker.Play();
            Count = 0;
            miss++;
            StartCoroutine("NextQuiz");
        }
    }
    public void Check3()
    {
        if (Ans == Select3.text)
        {
            Speker.clip = Audio1;
            Speker.Play();
            Count++;
            if(Count == 3)
            {
                ClearCount++;
                POS0 = true;
                posisionUp = true;
            }
            StartCoroutine("NextQuiz");
        }
        else if (Ans != Select3.text)
        {
            Speker.clip = Audio2;
            Speker.Play();
            Count = 0;
            miss++;
            StartCoroutine("NextQuiz");
        }
    }
    public void Check4()
    {
        if (Ans == Select4.text)
        {
            Speker.clip = Audio1;
            Speker.Play();
            Count++;
            if (Count == 3)
            {
                ClearCount++;
                POS0 = true;
                posisionUp = true;
            }
            StartCoroutine("NextQuiz");
        }
        else if (Ans != Select4.text)
        {
            Speker.clip = Audio2;
            Speker.Play();
            Count = 0;
            miss++;
            StartCoroutine("NextQuiz");
        }
    }
    IEnumerator NextQuiz()
    {
        yield return new WaitForSeconds(0.5f);
        yield return null;
        SetNextSentence();
    }
    public void EndQuiz()
    {
        if (posisionUp == true)
        {
            JoyStick.SetActive(true);
            canvas.alpha = 0;
            canvas.interactable = false;
            textbox.alpha = 0;
            posisionUp = false;
            MoveBlock.posision += 20;
            StartCoroutine("FloorMove");
        }
    }

    IEnumerator FloorMove()
    {
        yield return new WaitForSeconds(0.5f);
        yield return null;
        MoveBlock.UpFloor();
    }

    public void AnimationStop()
    {
        ani.SetBool("Wate", true);
        ani.SetBool("Run", false);
        MovingPlayer.SPEED = 0;
    }
}
