using JetBrains.Annotations;
using NaughtyAttributes;
using UnityEngine;

public class for2 : MonoBehaviour
{

    // 1부터 10까지 더하기 매루프 마다 출력
    // 값이 누적이 된다

    [Button("1~10더해져라")]
    void Add4to10()
    {
        int sum = 0;
        for (int a = 1; a <= 10; ++a)
        {
            sum = sum + a;
            Debug.Log($"a = {a} , sum = {sum}");
        }

    }


    //30부터 1까지 역순출력
    // 홀수만 출력
    // Odd30to1()
    // 10 이하면 탈출해라
    // break; 루프를 멈춰라
    // continue; 루프를 건너뛰어라
    [Button("30~1홀수")]
    void Odd30to1()
    {
        int cnt = 0;
        for (int a = 30; a > 0; --a)
        {
            //10 이하면 탈출
            if(a <= 10)
            break; 


            //2로 나머지 연산 값이 1이면 홀수
            //if (a%2==0) 홀수인 경우
            if ((a % 2) != 0) //홀수가 아닌 경우
            {

                Debug.Log($"홀수만 {a}");
            }

            //아래 4가지는 같은 표현이다 (1씩 증가일 경우만)
            //cnt = cnt +1;
            //cnt += 1
            cnt++;
            //++cnt;     
        }
            Debug.Log($"갯수{cnt} ");
    }

    //구구단 n단 출력
    //멤버 변수 n을 입력받는다
    //해당 구구단을 출력한다

    //Gugudan()
public int gugu;

    [Button("구구단For")]
    void Gugudan()
    {
        for (int a=0 ; a<=9 ; a++ )
        {
            int result = gugu*a;
            Debug.Log($"구구단{gugu}x{a}={result}");

        }
    }

    [Button("구구단WHILE")]
    void GugudanWhile()
    {
        //1.초기값
        //2.종료조건
        //3.증감
        int a =1;
        while( a <= 9)
        {
            // while( a <= 9)참일경우만 실행한다
            //거짓이면 패스 혹은 탈출
            int result = gugu*a;
            Debug.Log($"{gugu}x{a}={result}");
            //a++;
            a= a+1;
        }
    }
}
