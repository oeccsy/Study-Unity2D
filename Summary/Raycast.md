# Raycast (Raycast2D, RaycastHit2D)

콜라이더 충돌에서 유용하게 사용되는 기능이다.  
원하는 방향으로 Ray를 만들어내서 Ray와 콜라이더의 충돌을 감지하는 기능이다.

---

## 코드


### Debug.DrawRay()
`Debug.DrawRay(Vector3 origin, Vector3 dir, Color color, float duration);`  
`Debug.DrawRay(gameObject.transform.position, Vector3.down, new Color(0, 1, 0));`  
에디터 상에서 Ray를 그려주는 함수  
origin에서 dir 방향으로 Color 색깔의 레이를 그려낸다.  

### Physics2D.Raycast()
`Physics2D.Raycast(Vector3 origin, Vector3 dir, float maxDistance = Mathf.Infinity, int layerMask = DefualtRaycastLayers);`  
실제 레이를 만들어 내는 함수    
origin에서 dir방향으로 레이를 만들어낸다.  
이때 maxDistance 범위 내에서 어떤 콜라이더와 레이가 충돌했으면 RaycastHit2D를 return한다.  
LayerMask는 레이 캐스팅 시 콜라이더를 선택적으로 무시하는데 사용된다.  

### RaycastHit2D
`RaycastHit2D rayHit = Physics2D.Raycast(gameObject.transform.positon, Vector3.down, 1);`  
rayHit 객체에 레이와 콜라이더의 충돌정보를 저장한다.  
(collider, distance, rigidbody, transform등)  

```C#

        Debug.DrawRay(gameObject.transform.position, Vector3.down, new Color(0, 1, 0));

        RaycastHit2D rayHit = Physics2D.Raycast(rigid.position, Vector3.down, 1, LayerMask.GetMask("Platform"));

        if (rayHit.collider != null)
        {
                Debug.Log(rayHit.collider.name);
        }       
```