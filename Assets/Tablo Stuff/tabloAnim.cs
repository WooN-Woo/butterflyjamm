using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tabloAnim : MonoBehaviour
{
    [Header("Animators")]
    public Animator Animator;
    public Animator Animator1;
    public Animator Animator2;
    public Animator Animator3;

    public bool canPlay;
   public  bool isTeleport;

    private void Update()
    {
        ImageAnim();
    }
    public void ImageAnim()
    {
        if(canPlay == true)
        {
            Animator.Play("imageanim");
            Animator1.Play("image1anim");
            Animator2.Play("image2anim");
            Animator3.Play("image3anim");
           
        }
       

        if (isTeleport == true)
        {
            Animator.Play("imageclose");
            Animator1.Play("image1close");
            Animator2.Play("image2close");
            Animator3.Play("image3close");
        }
       

    }
}
