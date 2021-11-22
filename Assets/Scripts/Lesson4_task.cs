using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lesson4_task : MonoBehaviour {

    int[] array = {1,2,3,4,5};
    void Start() {

        for (int i = 0; i < array.Length; i++) {
            Debug.Log(array[i]);
        }

        for (int i = array.Length - 1; i >= 0; i--) {
            Debug.Log(array[i]);
        }

    }
}
