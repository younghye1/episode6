using UnityEditor.Experimental.GraphView;
using UnityEngine;


// if (참/거짓) {}
// Branch 문

public class IFtutorial : MonoBehaviour
{
    public int A;

    void Start()
    {
        //if( A >= 10 && A < 20 ) //A가 10이상이고 20미만이면 TRUE
        //if ( A < 20)
        //{
        //    Debug.Log ("TRUE");            
        //}
        
        //if ( A > 10 )
        //{
        //    Debug.Log ("TRUE"); //참일때만 TRUE, 거짓이면 넘어가
        //}
        
        if(A>=90)
        {
            Debug.Log("A학점");
        }
        else if(90>=80)
        {
            Debug.Log("B학점");
        }
        else if(80>=60)
        {
            Debug.Log("C학점");
        }
        //거짓
        else //else는 바로 위에 있는 if한테만 반응한다 
        {
            Debug.Log("F");
        }
    }
    
}
