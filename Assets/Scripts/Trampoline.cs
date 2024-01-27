using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trampoline : MonoBehaviour
{
    private Animator _animator;
    public GameObject Player;
    public float TrampolineJump;
    public GameObject Box;
    // Start is called before the first frame update
    void Start()
    {
        _animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void PlayTrampAnimation()
    {
        _animator.SetBool("TrampBool", true);
    }

    public void ResetTrampAnimation()
    {
        _animator.SetBool("TrampBool", false);
    }
}
