using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
///　ゲームのお金やObj関係
///　神になるかもしれない
/// </summary>

namespace ClikerGame
{
    public class GameManeger : MonoBehaviour
    {
        public float Maney { get; set; } = 0;
        public float ClickManey { get; set; } = 1;
        public float SecondManey { get; set; } = 0;
        static public float ObjSize { get; set; } = 0;
        static public int ObjCount { get; set; } = 0;
    }
}

