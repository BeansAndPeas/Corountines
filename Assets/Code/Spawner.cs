using System.Collections;
using UnityEngine;

namespace Code  {
    public class Spawner : MonoBehaviour {
        [SerializeField]
        private GameObject simpleBean, advancedBean;

        private void Start() => StartCoroutine(Spawn());

        private IEnumerator Spawn() {
            for (var times = 0; times < 100; times++) {
                if (times < 10) {
                    GameObject simple = Instantiate(simpleBean);
                    Vector3 simplePos = simple.transform.position;
                    simplePos.y += 10;
                    simple.transform.position = simplePos;
                }
                GameObject advanced = Instantiate(advancedBean);
                Vector3 advancedPos = advanced.transform.position;
                advancedPos.y += 10;
                advanced.transform.position = advancedPos;
                
                yield return new WaitForSeconds(1);
            }
        }
    }
}
