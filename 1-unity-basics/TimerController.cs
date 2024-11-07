namespace DefaultNamespace;

using System.Collections;
using UnityEngine;

public class TimeController : MonoBehaviour
{
  // 倒數時間（以秒為單位）
  private float countdownTime;
  private bool isCountingDown;

  void Start()
  {
    // 初始化倒數計時器（例如從伺服器獲取倒數時間）
    countdownTime = LoadCountdownFromServer();
    StartCoroutine(CountdownTimer());
  }

  // Coroutine 用來控制倒數
  IEnumerator CountdownTimer()
  {
    isCountingDown = true;
    while (isCountingDown && countdownTime > 0)
    {
      countdownTime -= Time.deltaTime; // 計時
      yield return null;
    }
    if (countdownTime <= 0)
    {
      OnCountdownComplete();
    }
  }

  void OnCountdownComplete()
  {
    // 倒數完成後的處理，例如自動生成資源
    GenerateResources();
    isCountingDown = false;
  }

  void GenerateResources()
  {
    // 根據設計自動生成資源的邏輯
    Debug.Log("資源已生成！");
  }

  // 當應用暫停或關閉時保存計時器狀態
  void OnApplicationPause(bool pauseStatus)
  {
    if (pauseStatus)
    {
      SaveCountdownToServer(countdownTime);
    }
  }

  // 模擬伺服器讀取和保存倒數時間
  float LoadCountdownFromServer() => 120f; // 預設2分鐘倒數
  void SaveCountdownToServer(float timeLeft) => Debug.Log($"剩餘時間 {timeLeft} 已保存至伺服器");
}
