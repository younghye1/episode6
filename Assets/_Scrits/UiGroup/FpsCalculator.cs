
//네임스페이스 영역
using System.Xml;
using TMPro;
using UnityEngine; 

public class FpsCalculator : MonoBehaviour //클래스 영역: 클래스의 부모 클래스
{ 
    //멤버 변수 영역
    public TextMeshProUGUI tmFPS;


    //함수 영역
    
     void Start() //start()는 MonoBehaviour 에 미리 선언된 함수 : 1번만 실행
    {
        
    }


    private float dt = 0.0f;

    void Update()
    {
        int fps;

        //FPS 구하는 공식
        dt += (Time.deltaTime - dt) * 0.1f; //+=는 dt= dt+공식을 줄인 것. -=,*=,%=도 마찬가지
        fps = (int)(1.0f / dt); 

        //FPS 는 80% 사이즈, 나머지는 그대로
        //<size> </size>
        tmFPS.text = $"<size=80%> FPS </size> {fps}";
    }
}
