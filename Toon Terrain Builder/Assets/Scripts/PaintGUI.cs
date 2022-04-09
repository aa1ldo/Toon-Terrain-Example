using UnityEditor;
using UnityEditor.UIElements;
using UnityEngine;
using UnityEngine.UIElements;

[CustomEditor(typeof(PaintHeight))]
public class RuntimePaintTexture : Editor
{
    private GameObject obj;
    private PaintHeight objScript;

    void OnEnable()
    {
        obj = Selection.activeGameObject;
        objScript = obj.GetComponent<PaintHeight>();
    }

    public override void OnInspectorGUI()
    {
        DrawDefaultInspector();


        //
        EditorGUILayout.BeginHorizontal();

        if (GUILayout.Button("P : Paint Terrain", GUILayout.MinWidth(80), GUILayout.MaxWidth(350)))
        {
            objScript.Paint();
        }

        EditorGUILayout.EndHorizontal();
    }


    void OnSceneGUI()
    {
        Event e = Event.current;

        if (e.type == EventType.KeyDown)
        {
            switch (e.keyCode)
            {
                case KeyCode.P:
                    objScript.Paint();
                    break;

                default:

                    break;
            }
        }
    }
}