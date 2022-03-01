using System.Collections;
using UnityEngine;

namespace Code  {
    public class AdvancedMove : MonoBehaviour {
        [SerializeField]
        private GameObject bean;
        private readonly System.Random _random = new System.Random();

        private void Start() => StartCoroutine(HandleProcess());

        private IEnumerator HandleProcess() {
            for (var times0 = 0; times0 < 75; times0++) {
                for (var times1 = 0; times1 < _random.Next(3, 12); times1++) {
                    bean.transform.Rotate(new Vector3(0, _random.Next(-90, 90), 0));
                    yield return new WaitForSeconds(0.5f);
                }

                float timePassed = 0;
                while (timePassed < _random.Next(1, 3)) {
                    timePassed += Time.deltaTime;
                    bean.GetComponent<Rigidbody>().AddRelativeForce(Vector3.forward * 2);
                    yield return null;
                }

                bean.GetComponent<Rigidbody>().velocity = Vector3.zero;
                yield return new WaitForSeconds(1);
            }
        }
    }
}
