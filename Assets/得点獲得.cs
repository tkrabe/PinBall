using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class 得点表示 : MonoBehaviour
{
    //スコアを表示する
    private Text scoreText;

    //合計スコア
    public static int totalScore = 0;

    //スコアを表示するテキスト 
    private GameObject scoretex;

    // Scoretotal変数を宣言
    public int scoretotal = 0;

    //他のスクリプトやUnityエディタからアクセス可能な浮動小数点数型の変数visiblePosZを宣言する
    public float visiblePosZ;


    void OnCollisionEnter(Collision collision)
    {
        // 衝突した相手のゲームオブジェクトを取得
        GameObject other = collision.gameObject;

        if (gameObject.CompareTag("LargeCloudTag"))
        {
            scoretotal += 10;
        }
        else if (gameObject.CompareTag("SmallCloudTag"))
        {
            scoretotal += 5;
        }
        else if (gameObject.CompareTag("LargeStarTag"))
        {
            scoretotal += 15;
        }
        else if (gameObject.CompareTag("SmallStarTag"))
        {
            scoretotal += 1;
        }

        //合計スコアを表示
        totalScore += scoretotal;

        Debug.Log(gameObject.name + "に衝突！ポイント獲得: " + scoretotal + " 合計: " + totalScore);
    }

    // Start is called before the first frame update ここに衝突入れない
    void Start()
    {
        // シーン中のScoreTextオブジェクトを取得
        GameObject scoreTextObject = GameObject.Find("ScoreText");
        if (scoreTextObject != null)
        {
            scoreText = scoreTextObject.GetComponent<Text>();
        }
    }

    // Update is called once per frame
    void Update()
    {
        // ScoreTextにスコアを表示と+totalScore.ToString()で得点を更新
        if (scoreText != null)
        {
            scoreText.text = "Score: " + totalScore.ToString();
        }
    }
}
    