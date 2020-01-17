using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
///　ゲームのお金やObj関係
///　staticの初期化
///　神になりかかってきた
/// </summary>

namespace ClikerGame
{
    public class GameManeger : MonoBehaviour
    {
        static public float Maney { get; set; } = 0;
        static public float ClickManey { get; set; } = 1;
        static public float SecondManey { get; set; } = 0;
        static public float ObjSize { get; set; } = 0;
        static public int ObjCount { get; set; } = 0;
        static public int ObjWeight { get; set; } = 0;
        static public float Clere { get; set; } = 0;
        static public float WeghtOver { get; set; } = 0;
        static public int ResultChase { get; set; } = 0;
        static public int AllManey { get; set; } = 0;
        private void Awake()
        {
            Maney = 0;
            ClickManey = 1;
            SecondManey = 0;
            ObjSize = 0;
            ObjCount = 0;
            ObjWeight = 0;
        }
        static public void ResultInitialize()
        {
            Clere = 0;
            WeghtOver = 0;
        }
    }
}

