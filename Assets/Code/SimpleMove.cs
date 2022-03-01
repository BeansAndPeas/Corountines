using System.Collections;
using UnityEngine;

namespace Code  {
    public class SimpleMove : MonoBehaviour {
        [SerializeField]
        private Rigidbody body;

        void Start() => StartCoroutine(Move());

        IEnumerator Move() {
            for (var times = 0; times < 5; times++) {
                body.AddRelativeForce(Vector3.left * 50f);
                yield return new WaitForSeconds(0.5f);
                body.AddRelativeForce(Vector3.right * 50f);
                yield return new WaitForSeconds(0.5f);
            }
        }
    }
}
