using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GirlControll : MonoBehaviour{
    public int                 x;
    public Animator      Yasuo                = null;
    public bool[]            isLeft                 = null;
    public string[]          Question           = null;
    public Text               GetText             = null;
    public Text               Button_Left       = null;
    public Text               Button_Right    = null;
    public string[]           Left_Answer    = null;
    public string[]           Right_Answer = null;
    public AudioSource GetSource       = null;
    public AudioClip      HappyClip       = null;
    public AudioClip      SadClip           = null;
    void Start(){
        x = 0;
        GetText.text = Question[x];
        Button_Left.text = Left_Answer[x];
        Button_Right.text = Right_Answer[x];
    }
    public void Left_Button(){
        StartCoroutine(Left_Button_IE());
    }
    public void Right_Button(){
        StartCoroutine(Right_Button_IE());
    }
    IEnumerator Left_Button_IE(){
        if (isLeft[x] == true){
            Yasuo.SetTrigger("Win");
            GetSource.clip = HappyClip;
            GetSource.Play();
            yield return new WaitForSeconds(4);
        }
        else {
            Yasuo.SetTrigger("Lose");
            GetSource.clip = SadClip;
            GetSource.Play();
            yield return new WaitForSeconds(4);
        }
        x += 1;
        GetText.text = Question[x];
        Button_Left.text = Left_Answer[x];
        Button_Right.text = Right_Answer[x];
    }
    IEnumerator Right_Button_IE(){
        if (isLeft[x] != true)
        {
            Yasuo.SetTrigger("Win");
            GetSource.clip = HappyClip;
            GetSource.Play();
            yield return new WaitForSeconds(4);
        }
        else
        {
            Yasuo.SetTrigger("Lose");
            GetSource.clip = SadClip;
            GetSource.Play();
            yield return new WaitForSeconds(4);
        }
        x += 1;
        GetText.text = Question[x];
        Button_Left.text = Left_Answer[x];
        Button_Right.text = Right_Answer[x];
    }
    void Update(){
        
    }
}