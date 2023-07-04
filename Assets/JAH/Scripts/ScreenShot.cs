using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
using System.IO;

#if UNITY_ANDROID
using UnityEngine.Android;
#endif

public class ScreenShot : MonoBehaviour
{
    // UI ���� ȭ��ĸ��
    public Button screenShotWithoutUIButton;

    // ��ũ���� �Ҷ� �÷���
    public ScreenShotFlash flash;

    public string folderName = "ScreenShots";
    public string fileName = "MyScreenShot";
    public string extName = "png";

    private bool _willTakeScreenShot = false;

    private Texture2D _imageTexture; // imageToShow�� �ҽ� �ؽ���

    private string RootPath
    {
        get
        {
#if UNITY_EDITOR || UNITY_STANDALONE
            return Application.dataPath;
#elif UNITY_ANDROID
            return $"/storage/emulated/0/DCIM/{Application.productName}/";
            //return Application.persistentDataPath;
#endif
        }
    }
    private string FolderPath => $"{RootPath}/{folderName}";
    private string TotalPath => $"{FolderPath}/{fileName}_{DateTime.Now.ToString("MMdd_HHmmss")}.{extName}";

    private string lastSavedPath;

    private void Awake()
    {
        // ��ũ���� ��ư ���� �� �߻��ϴ� �̺�Ʈ
        screenShotWithoutUIButton.onClick.AddListener(TakeScreenShotWithoutUI);

    }

    /// UI ������, ���� ī�޶� �������ϴ� ȭ�鸸 ĸ�� 
    private void TakeScreenShotWithoutUI()
    {
#if UNITY_ANDROID
        CheckAndroidPermissionAndDo(Permission.ExternalStorageWrite, () => _willTakeScreenShot = true);
       

#else
        _willTakeScreenShot = true;
#endif
    }

    // UI �����ϰ� ���� ī�޶� �������ϴ� ��� ĸ��
    private void OnPostRender()
    {
        if (_willTakeScreenShot)
        {
            _willTakeScreenShot = false;
            CaptureScreenAndSave();
        }
    }

#if UNITY_ANDROID
    /// �ȵ���̵� - ���� Ȯ���ϰ�, ���ν� ���� �����ϱ� 
    private void CheckAndroidPermissionAndDo(string permission, Action actionIfPermissionGranted)
    {
        // �ȵ���̵� : ����� ���� Ȯ���ϰ� ��û�ϱ�
        if (Permission.HasUserAuthorizedPermission(permission) == false)
        {
            PermissionCallbacks pCallbacks = new PermissionCallbacks();
            pCallbacks.PermissionGranted += str => Debug.Log($"{str} ����");
            pCallbacks.PermissionGranted += str => AndroidToast.I.ShowToastMessage($"{str} ������ �����ϼ̽��ϴ�.");
            pCallbacks.PermissionGranted += _ => actionIfPermissionGranted(); // ���� �� ��� ����

            pCallbacks.PermissionDenied += str => Debug.Log($"{str} ����");
            pCallbacks.PermissionDenied += str => AndroidToast.I.ShowToastMessage($"{str} ������ �����ϼ̽��ϴ�.");

            pCallbacks.PermissionDeniedAndDontAskAgain += str => Debug.Log($"{str} ���� �� �ٽô� ���� ����");
            pCallbacks.PermissionDeniedAndDontAskAgain += str => AndroidToast.I.ShowToastMessage($"{str} ������ ���ϰ� �����ϼ̽��ϴ�.");

            Permission.RequestUserPermission(permission, pCallbacks);
        }
        else
        {
            actionIfPermissionGranted(); // �ٷ� ��� ����
        }
    }
#endif

    /// <summary> ��ũ������ ��� ��ο� �����ϱ� </summary>
    private void CaptureScreenAndSave()
    {
        string totalPath = TotalPath; // ������Ƽ ���� �� �ð��� ���� �̸��� �����ǹǷ� ĳ��

        Texture2D screenTex = new Texture2D(Screen.width, Screen.height, TextureFormat.RGB24, false);
        Rect area = new Rect(0f, 0f, Screen.width, Screen.height);

        // ���� ��ũ�����κ��� ���� ������ �ȼ����� �ؽ��Ŀ� ����
        screenTex.ReadPixels(area, 0, 0);

        bool succeeded = true;
        try
        {
            // ������ �������� ������ ���� ����
            if (Directory.Exists(FolderPath) == false)
            {
                Directory.CreateDirectory(FolderPath);
            }

            // ��ũ���� ����
            File.WriteAllBytes(totalPath, screenTex.EncodeToPNG());
        }
        catch (Exception e)
        {
            succeeded = false;
            Debug.LogWarning($"Screen Shot Save Failed : {totalPath}");
            Debug.LogWarning(e);
        }

        // ������ �۾�
        Destroy(screenTex);

        if (succeeded)
        {
            Debug.Log($"Screen Shot Saved : {totalPath}");
            flash.Show(); // ȭ�� ��½
            lastSavedPath = totalPath; // �ֱ� ��ο� ����
        }

        // ������ ����
        RefreshAndroidGallery(totalPath);
    }

    [System.Diagnostics.Conditional("UNITY_ANDROID")]
    private void RefreshAndroidGallery(string imageFilePath)
    {
#if !UNITY_EDITOR
        AndroidJavaClass classPlayer = new AndroidJavaClass("com.unity3d.player.UnityPlayer");
        AndroidJavaObject objActivity = classPlayer.GetStatic<AndroidJavaObject>("currentActivity");
        AndroidJavaClass classUri = new AndroidJavaClass("android.net.Uri");
        AndroidJavaObject objIntent = new AndroidJavaObject("android.content.Intent", new object[2]
        { "android.intent.action.MEDIA_SCANNER_SCAN_FILE", classUri.CallStatic<AndroidJavaObject>("parse", "file://" + imageFilePath) });
        objActivity.Call("sendBroadcast", objIntent);
#endif
    }

}
