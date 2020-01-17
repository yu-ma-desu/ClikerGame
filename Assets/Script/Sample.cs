using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class FileSample : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //カレントディレクトリ,書き込みはダメ
        //Debug.Log($"CurrentDir{ Directory.GetCurrentDirectory()}");

        //ゲーム用パス関連
        Debug.Log(Application.persistentDataPath); //保存先
        Debug.Log(Application.temporaryCachePath); //一時データ
        Debug.Log(Application.dataPath);//Assets フォルダー

        var dir = Application.persistentDataPath;

        //テキストの読み書き
        //File.WriteAllText(dir + "/Sample.txt", "Stand by Redy");

        var TextPath = dir + "/Sample.txt";
        File.WriteAllText(TextPath, "Stand");
        if (File.Exists(TextPath))
        {
            var text = File.ReadAllText(dir + "/Sample.txt");
            Debug.Log($"Text;{text}");
        }

        //バイナリ(バイト配列)の読み書き
        var dataPath = dir + "/Sample.data";
        File.WriteAllBytes(dataPath, new byte[] { 1, 2, 3, 4, 5, 6, 7, 8 });
        if (File.Exists(dataPath))
        {
            var data = File.ReadAllBytes(dataPath);
            Debug.Log(data);
        }
        //大きいデータを使う時
        var s = File.OpenRead("path");
        //s.ReadAsync();

        //書き込みと読み込みは対になるから、使うときには注意する
        //ファイルを実行してる時にセーブの内容を変えるとエラーが起きるから気を付ける
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
