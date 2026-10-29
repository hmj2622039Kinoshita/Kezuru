using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement; // TextMeshPro用

public class Timer : MonoBehaviour
{
    [SerializeField] GameObject timerText; // タイマーのText入れ
    [SerializeField] float timer = 30f;
    [SerializeField] GameObject ResultImage; // 結果表示オブジェクト
    private void Start()
    {
        ResultImage.SetActive(false);
    }

    private void Update()
    {
        this.timer -= Time.deltaTime; // タイマーの時間を減らす
        this.timerText.GetComponent<TextMeshProUGUI>().text = this.timer.ToString("F0");
        if (timer <= 0)
        {
            ResultImage.SetActive(true);
            this.timerText.GetComponent<TextMeshProUGUI>().text = "0";
            if()
        }
    }
}