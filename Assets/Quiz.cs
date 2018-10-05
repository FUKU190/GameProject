using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Linq;

public class Quiz : MonoBehaviour
{
    private string[] sentences; // 文章を格納する
    public Text uiText;   // uiTextへの参照
    public List<string[]> csvData = new List<string[]>();
    public TextAsset CSVfile;
    public Text Select1, Select2, Select3, Select4,count;
    [SerializeField]
    [Range(0.001f, 0.3f)]
    float intervalForCharDisplay;   // 1文字の表示にかける時間
    int RandomNum,Count;
    string Ans;
    int[] chk = new int[16];
    private int currentSentenceNum = 0; //現在表示している文章番号
    private string currentSentence = string.Empty;  // 現在の文字列
    private float timeUntilDisplay = 0;     // 表示にかかる時間
    private float timeBeganDisplay = 1;         // 文字列の表示を開始した時間
    private int lastUpdateCharCount = -1;       // 表示中の文字数
    public MyScript MyScript;
    public MoveBlock MoveBlock;
    public CanvasGroup canvas;

    void Start()
    {
        QuizLoad();
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
        if (Count == 10)
        {
            EndQuiz();
        }
        //表示される文字数を計算
        int displayCharCount = (int)(Mathf.Clamp01((Time.time - timeBeganDisplay) / timeUntilDisplay) * currentSentence.Length);
        //表示される文字数が表示している文字数と違う
        if (displayCharCount != lastUpdateCharCount)
        {
            uiText.text = currentSentence.Substring(0, displayCharCount);
            //表示している文字数の更新
            lastUpdateCharCount = displayCharCount;
        }
    }

    // 次の文章をセットする
    public void SetNextSentence()
    {
        
        //リストからランダムで1問取る
        RandomNum = Random.Range(0, 16);
        if(chk[RandomNum] == 1)
        {
            SetNextSentence();
        }
        chk[RandomNum] = 1;
        Ans = csvData[RandomNum][1];
        currentSentence = csvData[RandomNum][0];
        Select1.text = csvData[RandomNum][2];
        Select2.text = csvData[RandomNum][3];
        Select3.text = csvData[RandomNum][4];
        Select4.text = csvData[RandomNum][5];
        timeUntilDisplay = currentSentence.Length * intervalForCharDisplay;
        timeBeganDisplay = Time.time;
        currentSentenceNum++;
        lastUpdateCharCount = 0;
    }

    //選択肢の判定、次の問題の読み込み
    public void Check1()
    {
        if(Ans == Select1.text)
        {
            Count++;
            count.text = "正解数：" + Count;
            StartCoroutine("NextQuiz");
        }
        else if(Ans != Select1.text)
        {
            StartCoroutine("NextQuiz");
        }
    }
    public void Check2()
    {
        if(Ans == Select2.text)
        {
            Count++;
            count.text = "正解数：" + Count;
            StartCoroutine("NextQuiz");
        }
        else if(Ans != Select2.text)
        {
            StartCoroutine("NextQuiz");
        }
    }
    public void Check3()
    {
        if (Ans == Select3.text)
        {
            Count++;
            count.text = "正解数：" + Count;
            StartCoroutine("NextQuiz");
        }
        else if (Ans != Select3.text)
        {
            StartCoroutine("NextQuiz");
        }
    }
    public void Check4()
    {
        if (Ans == Select4.text)
        {
            Count++;
            count.text = "正解数：" + Count;
            StartCoroutine("NextQuiz");
        }
        else if (Ans != Select4.text)
        {
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
        MyScript.speed = 5;
        MoveBlock.upspeed = 4;
        MoveBlock.posision = 40;
        Count = 0;
        StartCoroutine("ObjectOff");
    }
    IEnumerator ObjectOff()
    {
        yield return new WaitForSeconds(1.0f);
        canvas.alpha = 0;
        this.gameObject.SetActive(false);
        yield return null; 
    }
}