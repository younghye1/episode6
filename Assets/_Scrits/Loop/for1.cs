using NaughtyAttributes;
using UnityEngine;


//반복문
//For
//foreach
//while
//do while

// 반복을 위한 조건
// 대량생산0

public class For : MonoBehaviour
{
    // for (초기값; 종료조건; 증감)
    // {
    //      반복 작업
    // }

    void Start()
    {
        int a;

        //for는 if의 확장
        for( a = 1; a < 4; a++) // if를 지정된 횟수만큼 반복 작업
        {
            
            Debug.Log("실행");
        }
    }

//멤버변수 Count만큼 반복 작업
    [Header("반복문")]
    [HorizontalLine(height:1.0f,color:EColor.Orange)]
    [Space(30)] //Attribute
    public int count;

    [Button ("버튼")]
    void For1()
    {
            //초기값; 종료조건; 증감;
        for(int a=0; a<count; a++ )
        {
            //for문 조건이 참일 경우만 실행, 거짓이 되면 탈출. 처음부터 거짓이면 패스
            Debug.Log($"실행{a}");

        }
    }

    [Button("역순버튼")]
    void For10to1()
    {
        // 10부터 1까지 역순으로 출력하기
        for(int a = 10; a > 1 ; --a)
        {
            Debug.Log($"실행{ a }");
        }
    }
}
