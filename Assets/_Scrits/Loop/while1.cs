using System.Collections;
using NaughtyAttributes;
using UnityEngine;

public class while1 : MonoBehaviour
{
    //조건이 참이면 무한루프
    //while(종료조건)
    //{
    //  참이면 실행
    // 한번이라도 거짓이면 탈출
    //}


    [Button("버튼")]
    void WhileLoop5()
    {
        int a = 0; //초기값 설정
                   //while의 목적 (탈출조건)
        while (a < 5)
        {
            Debug.Log($"실행{a}");

            a++; //순서 정해져있음    
        }

    }

}
