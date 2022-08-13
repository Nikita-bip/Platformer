using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[RequireComponent(typeof(Animator))]

public class Animations : MonoBehaviour
{
   private const string IsMoving = "IsMoving";
   private Animator _animator;
   private static readonly int Moving = Animator.StringToHash(IsMoving);
   public bool IsMove { private get; set; }

   private void Start()
   {
      _animator = GetComponent<Animator>();
   }

   private void FixedUpdate()
   {
      _animator.SetBool(Moving, IsMove);
   }
}
