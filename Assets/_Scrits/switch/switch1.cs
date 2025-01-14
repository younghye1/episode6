using NaughtyAttributes;
using UnityEngine;

// switch ( 조건 )
// {
// case 해당조건1 :
//          작업
//         break;
// case 해당조건2 :
//          작업
//         break;
// default 아닐경우 :
//         break;
// }

public class switch1 : MonoBehaviour
{
    public int a;

    [Button]
    void SwitchDayWeek() // a 가 1이면 월요일,2이면 수요일, 3이면 금요일, 4이면 일요일 그외는 잘못입력
    {
        switch (a) // 변수 자체를 삽입
        {
            case 1:
                Debug.Log("월요일");
                break;

            case 2:
                Debug.Log("수요일");
                break;

            case 3:
                Debug.Log("금요일");
                break;
            case 4:
                Debug.Log("일요일");
                break;
            default:
                Debug.Log("잘못입력");
                break;
        }
    }

    [Button("새로운 스위치 문")]
    void NewSwitch()
    {
        string r = a switch
        {
            1 => "월요일",
            2 => "수요일",
            3 => "금요일",
            4 => "일요일",
            _ => "잘못입력"
        };
        Debug.Log(r);
    }



    [Button("SWITH 계절")] // 딱 맞는 숫자는 스위치가 낫다
    void SeasonSwitch()
    {
        string r = a switch
        {
            3 or 4 or 5 => "봄",
            6 or 7 or 8 => "여름",
            9 or 10 or 11=> "가을",
            12 or 1 or 2=> "겨울",
            _ => "잘못입력"
        };
        Debug.Log(r);
    }


    [Button("IF계절")] //범위는 이프가 낫다
    void SeasonIF()
    {
        string r;
        if (a >= 3 && a <= 5)
            r = "봄";
        else if (a >= 6 && a <= 8)
            r = "여름";
        else if (a >= 9 && a <= 11)
            r = "가을";
        else if (a == 12 || (a > 0 && a <= 2))
            r = "겨울";
        else
            r = " 잘못입력 ";

        Debug.Log(r);
    }
    
}
