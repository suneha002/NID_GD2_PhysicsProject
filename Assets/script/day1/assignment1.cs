// using UnityEngine;

// public class assignment1 : MonoBehaviour
// {
//     // Start is called once before the first execution of Update after the MonoBehaviour is created
//     Vector3 normalScale, rotate;
//     void Start()
//     {
//         rotate = transform.rotation;
//     }

//     // Update is called once per frame
//     void Update()
//     {
//         if (Input.GetKey(KeyCode.G))
//         {
//             transform.localScale = normalScale + new Vector3(0, 0.8f,0);
//             transform.position += new Vector3(0, 0.02f,0);
//         }
//         else
//         {
//             transform.localScale = normalScale;
//         }
//         if (Input.GetKey(KeyCode.V))
//         {
//             transform.rotation = rotate + new Vector3(0, 0.8f,0);
//             transform.position += new Vector3(0, -0.02f,0);
//         }
//         else
//         {
//             transform.localScale = normalScale;
//         }
//         if (Input.GetKey(KeyCode.W))
//         {
//             transform.localScale = normalScale + new Vector3(0, 0, 0.8f);
//             transform.position += new Vector3(0,0, 0.02f);
//         }
//         else
//         {
//             transform.localScale = normalScale;
//         }
//          if (Input.GetKey(KeyCode.S))
//         {
//             transform.rotation = rotate + new Vector3(0, 0, 0.8f);
//             transform.position += new Vector3(0,0, -0.02f);
//         }
//         else
//         {
//             transform.localScale = normalScale;
//         }
//          if (Input.GetKey(KeyCode.A))
//         {
//             transform.rotation = rotate + new Vector3(0.8f, 0, 0);
//             transform.position += new Vector3(-0.02f,0,0);
//         }
//         else
//         {
//             transform.localScale = normalScale;
//         }
//               if (Input.GetKey(KeyCode.D))
//         {
//             transform.localScale = normalScale + new Vector3(0.8f, 0, 0);
//             transform.position += new Vector3(0.02f,0,0);
//         }
//         else
//         {
//             transform.localScale = normalScale;
//         }
 
//     }
// }
