using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

// �� particle�� �����Ѵ�
// - �� ��ƼŬ ����
// - �ӵ�
// - ����

public class Particle : MonoBehaviour
{
    // �̹���
    private Image Img;
    // - ��ƼŬ ����
    private Vector3 dir;
    // - �ӵ�
    public float moveSpeed = 0.1f;
    // - �ּ� ������
    public float minSize = 0.1f;
    // - �ִ� ������
    public float maxSize = 0.3f;
    // - �� �پ��� �ӵ�
    public float sizeSpeed = 1;
    // - ����
    public Color[] colors;
    // - ������ ���������� �ӵ�
    public float colorSpeed = 5;
    void Start()
    {
        // �̹��� �ʱ�ȭ
        Img = GetComponent<Image>();
        // ������ ������ �ǵ���
        dir = new Vector3(Random.Range(-1, 1), Random.Range(-1, 1), Random.Range(-1, 1));
        // ũ�� ��������
        float size = Random.Range(minSize, maxSize);
        transform.localScale = new Vector3(size, size, size);

        // ������ color �迭 �� �������� �ϳ� ����
        Img.color = colors[Random.Range(0, colors.Length)];
    }

    void Update()
    {
        // ��ƼŬ�� �����̰� �Ѵ�
        transform.Translate(dir * moveSpeed);
        // ũ�⸦ ���� �پ��� �Ѵ�
        transform.localScale = Vector3.Lerp(transform.localScale, Vector3.zero, Time.deltaTime * sizeSpeed);

        // ������ ���� �����ϰ� �Ѵ�
        Color color = Img.color;
        color.a = Mathf.Lerp(Img.color.a, 0, Time.deltaTime*colorSpeed);
        // ���� �ʱ�ȭ
        Img.color = color;

        // ���� ���İ��� 0���Ϸ� �������� �ı��Ѵ�
        if (Img.color.a <= 0.01f)
            Destroy(gameObject);
    }
}
