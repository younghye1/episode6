using System;
using NaughtyAttributes;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class IFattribute : MonoBehaviour
{
    [Header("타이틀")]
    [HorizontalLine(height:1, color:EColor.Red)] //색바꾸기
    [Space(20)] //위아래 간격


    public int A;
    public int B;
    public int C;
    public string E;
    public bool D;
    public bool F;
    public string 참거짓;


    [Button]
    void OperatorEx()
    {
       // A = B; B를 A에 대입
       // A == B; A와 B가 같냐 true 나 False
       // A != B; 다르면 True
       // A += B; 풀어 쓰면 A = A + B;
       // A -= B;
       // A *= B;
       // A /= B;
       // A %= B; 풀어쓰면 A = A % B; A를 B로 나눈 나머지 값

       // A++; 풀어쓰면 A = A + 1; 후행 연산
       // A--; 풀어쓰면 A = A - 1;
    
       // ++B; 풀어쓰면 B = 1 + B; 선행 연산

       // C = A + B++ ; A + B 더하고, C에 더한값을넣어주고, B + 1
       //C = ++A + ++B;
       
       // float a = 1.23f;
       // a++ ;  는 2.23
       
    }

    [Button]
    void IfMethod1()
    {
        if ( A == 1 )
        {
        Debug.Log(E="월");
        }

        else if (A == 2)
        {
        Debug.Log(E="수");
        }
        else if (A == 3)
        {
        Debug.Log(E="금");
        }
        else
        {
        Debug.Log (E="일");
        }
    }

    [Button("삼항연산")]
    void TernaryOperator()
    {
        //D를 체크하면 왼쪽, 언쳌하면 오른쪽이 나오게 하기
        string result = D? "왼쪽" : "오른쪽";
        Debug.Log(result);

        

    }

    [Button("삼항연산(이고, 또는)")]
    void TernaryOperator2()
    {
                //A가 3이상 이고 A가 9미만, 또는 B가 5초과이고 B가 10이하
        string result = (3 <= A&&A < 9) || (5 > B&&B >= 10) ? "참" : "거짓";
        {
            Debug.Log (result);
        }
    }


}
