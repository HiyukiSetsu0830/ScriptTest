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
            Debug.Log("���@�U���������B�c��MP��" + mp + "�B");

        } else {
            Debug.Log("MP������Ȃ����߁A���@���g���Ȃ��B");
        }
    }

}