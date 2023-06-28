using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

// 별 particle을 생성한다
// - 별 파티클 방향
// - 속도
// - 색상

public class Particle : MonoBehaviour
{
    // 이미지
    private Image Img;
    // - 파티클 방향
    private Vector3 dir;
    // - 속도
    public float moveSpeed = 0.1f;
    // - 최소 사이즈
    public float minSize = 0.1f;
    // - 최대 사이즈
    public float maxSize = 0.3f;
    // - 이 줄어드는 속도
    public float sizeSpeed = 1;
    // - 색상
    public Color[] colors;
    // - 색상이 투명해지는 속도
    public float colorSpeed = 5;
    void Start()
    {
        // 이미지 초기화
        Img = GetComponent<Image>();
        // 방향이 랜덤이 되도록
        dir = new Vector3(Random.Range(-1, 1), Random.Range(-1, 1), Random.Range(-1, 1));
        // 크기 랜덤으로
        float size = Random.Range(minSize, maxSize);
        transform.localScale = new Vector3(size, size, size);

        // 색상을 color 배열 중 랜덤으로 하나 지정
        Img.color = colors[Random.Range(0, colors.Length)];
    }

    void Update()
    {
        // 파티클이 움직이게 한다
        transform.Translate(dir * moveSpeed);
        // 크기를 점점 줄어들게 한다
        transform.localScale = Vector3.Lerp(transform.localScale, Vector3.zero, Time.deltaTime * sizeSpeed);

        // 색상을 점점 투명하게 한다
        Color color = Img.color;
        color.a = Mathf.Lerp(Img.color.a, 0, Time.deltaTime*colorSpeed);
        // 색상 초기화
        Img.color = color;

        // 별의 알파값이 0이하로 떨어지면 파괴한다
        if (Img.color.a <= 0.01f)
            Destroy(gameObject);
    }
}
