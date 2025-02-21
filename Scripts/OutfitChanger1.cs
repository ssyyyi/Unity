using UnityEngine;

public class OutfitChanger : MonoBehaviour
{
    public GameObject[] pantsOptions; // 바지 오브젝트 배열
    private int currentIndex = 0; // 현재 활성화된 바지 인덱스

    void Start()
    {
        // 모든 바지 비활성화 후 기본 바지만 활성화
        for (int i = 0; i < pantsOptions.Length; i++)
        {
            pantsOptions[i].SetActive(i == currentIndex);
        }
    }

    public void ChangePants(int index)
    {
        if (index < 0 || index >= pantsOptions.Length) return; // 잘못된 인덱스 방지

        // 현재 바지 비활성화
        pantsOptions[currentIndex].SetActive(false);

        // 새로운 바지 활성화
        pantsOptions[index].SetActive(true);

        // 인덱스 업데이트
        currentIndex = index;
    }
}
