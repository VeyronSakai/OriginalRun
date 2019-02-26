using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMoveHorizontal : MonoBehaviour
{

    Vector3 tapCurrentPos;
    Vector3 tapNewPos;
    Vector3 distance;
    Transform tr;
    [SerializeField] float moveIntensity;

    // Start is called before the first frame update
    void Start()
    {
        tr = this.transform;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            //タップ開始位置を記録
            tapCurrentPos = Input.mousePosition;
        }
        else if (Input.GetMouseButton(0))
        {
            //指のある位置を記録
            tapNewPos = Input.mousePosition;
            //差分をとる (単位はピクセル)
            distance = tapNewPos - tapCurrentPos;
            //ピクセル →　インチへの変換 (端末によって解像度が違うため)
            distance = distance / Screen.dpi;
            //変化量を調整
            distance = distance * moveIntensity;
            //GameObjectの位置の変更
            tr.position += new Vector3(distance.x, 0, 0);
            //変数の更新
            tapCurrentPos = tapNewPos;
        }
    }
}
