using UnityEngine;
using TMPro;

public class IfinputController : MonoBehaviour


{
    public TextMeshProUGUI output;
    public TMP_InputField input;


    void Update()
    {
        output.text = input.text;

        //목적: 문자는 패스, 숫자만 입력 후 전달
        //Numfilter
        output.text = NumFilter(input.text);
    }

    //입력: 문자 (string) -> 출력:숫자
    private int _temp;
    string NumFilter(string s)
    {

        //return int.Parse(s).ToString();
        //return $"{int.Parse (s)}";

        //참 일 경우 실행
        if (int.TryParse(s, out int o))
        {
            _temp = o;
            return o.ToString();
        }

        //거짓으로 처리
        else
        {
            return _temp.ToString();
        }
    }
}
