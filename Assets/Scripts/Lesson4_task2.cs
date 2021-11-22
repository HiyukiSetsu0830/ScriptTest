using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lesson4_task2 : MonoBehaviour {


    void Start() {

        Boss boss = new Boss();
        for (int i = 0; i < 10; i++) {
            boss.Magic();
        }

        boss.Magic();

    }
}

public class Boss {

    private int mp = 53;

    public void Magic() {
        if (mp >= 5) {
            mp -= 5;
            Debug.Log("魔法攻撃をした。残りMPは" + mp + "。");

        } else {
            Debug.Log("MPが足りないため、魔法が使えない。");
        }
    }

}