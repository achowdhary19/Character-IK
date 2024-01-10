using UnityEngine;

namespace Assets
{
    [RequireComponent(typeof(Animator))]
    public class IkControl : MonoBehaviour {

        protected Animator Animator;

        public bool IkActive = false;
        //public Transform rightHandObj = null;
        public Transform LookObj = null;

        void Start ()
        {
            Animator = GetComponent<Animator>();
        }

        //a callback for calculating IK
        void OnAnimatorIK()
        {
            if(Animator) {

                //if the IK is active, set the position and rotation directly to the goal.
                if(IkActive) {

                    // Set the look target position, if one has been assigned
                    if(LookObj != null) {
                        Animator.SetLookAtWeight(1);
                        Animator.SetLookAtPosition(LookObj.position);
                    }    

                    // Set the right hand target position and rotation, if one has been assigned
                    /*if(rightHandObj != null) {
                    animator.SetIKPositionWeight(AvatarIKGoal.RightHand,1);
                    animator.SetIKRotationWeight(AvatarIKGoal.RightHand,1);  
                    animator.SetIKPosition(AvatarIKGoal.RightHand,rightHandObj.position);
                    animator.SetIKRotation(AvatarIKGoal.RightHand,rightHandObj.rotation);
                }  */      

                }

                //if the IK is not active, set the position and rotation of the hand and head back to the original position
                else {          
                    //animator.SetIKPositionWeight(AvatarIKGoal.RightHand,0);
                    //animator.SetIKRotationWeight(AvatarIKGoal.RightHand,0);
                    Animator.SetLookAtWeight(0);
                }
            }
        }    
    }
}
