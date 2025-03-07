using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;


public class Score : MonoBehaviour
{
    //スコアを表示
    private GameObject scoreText;

    //合計スコア
    public static int totalScore = 0;

    //スコアを表示するテキスト 
    private GameObject scoretex;     

    void OnCollisionEnter(Collision collision)
    {
        //オブジェクト名前によってスコア判別  collisionいらないのでは?
        int scoretotal = 0;

        if (collision.gameObject.name == "LargeCloud")
        {
            scoretotal += 10;
        }
        else if (collision.gameObject.name == "SmallCloud")
        {
            scoretotal += 5;
        }
        else if (collision.gameObject.name == "LargeStar")
        {
            scoretotal += 15;
        }
        else if (collision.gameObject.name == "SmallStar")
        {
            scoretotal += 1;
        }

         //合計スコアを表示
        totalScore += scoretotal;
            
        Debug.Log(gameObject.name + "に衝突！ポイント獲得: " + scoretotal + " 合計: " + totalScore);

        }
    

    // Start is called before the first frame update
    void Start()
{
    {
        // シーン中の ScoreText オブジェクトを取得
        scoreText = GameObject.Find("ScoreText");
    }
}

// Update is called once per frame　毎フレーム実行される
void Update()
{
    // ScoreText にスコアを表示と +totalScore.ToString() で得点を更新
    if (scoreText != null)
    { 

    //GameoverTextにスコアを表示と+totalScore.ToString()で得点を更新
    scoreText.GetComponent<Text>().text = "ScoreText" + totalScore.ToString();

    }
}

}

