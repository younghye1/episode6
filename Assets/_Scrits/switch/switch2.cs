using UnityEngine;
using NaughtyAttributes;
using UnityEngine.UI;
using UnityEngine.UIElements;

public class switch2 : MonoBehaviour
{

    [Foldout("신호등 오브젝트")] public GameObject red;
    [Foldout("신호등 오브젝트")] public GameObject yellow;
    [Foldout("신호등 오브젝트")] public GameObject green;


    public bool signalR;
    public bool signalY;
    public bool signalG;


    [Button]
    void Red()
    {
        signalR = !signalR;
        red.SetActive(!signalR);

    }


    public int A;

    [Button ("신호등 켜기/끄기")]
    void Signal()
    {
        //모두 켜진 경우
        // red.SetActive(true);
        // yellow.SetActive(true);
        // green.SetActive(true);
        
        // %나머지 연산
        int r= A++ % 3 ;

        if (r == 0)
        {
            //빨강만 켜진 경우
            red.SetActive(true);
            yellow.SetActive(false);
            green.SetActive(false);
        }

        if (r == 1)
        {
             //노랑만 켜진 경우
            red.SetActive(false);
            yellow.SetActive(true);
            green.SetActive(false);
        }

        if (r == 2)
        {
             //초록만 켜진 경우
             red.SetActive(false);
             yellow.SetActive(false);
             green.SetActive(true);
        }
    }



}
