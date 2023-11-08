using Interact.XdeExtension;
using UnityEditor;
using UnityEngine;
using UnityEditor.Events;
using UnityEngine.Events;
using XdeEngine.Assembly;

namespace InteractEditor.XdeExtension
{
    [CustomEditor(typeof(XdeAsbViveControllerHandGrasping))]
    public class XdeAsbViveControllerHandGraspingInspector : UnityEditor.Editor
    {
        SerializedProperty triggerThresholdProp, echoTimeProp;
        SerializedProperty onRightHandOpenedProp, onRightHandClosedProp, onLeftHandOpenedProp, onLeftHandClosedProp;
        SerializedProperty handLeftProp, handRightProp;

        XdeAsbViveControllerHandGrasping vchg;

        // Use this for initialization
        void OnEnable()
        {
            triggerThresholdProp = serializedObject.FindProperty("triggerThreshold");
            echoTimeProp = serializedObject.FindProperty("echoTime");

            handLeftProp = serializedObject.FindProperty("handLeft");
            handRightProp = serializedObject.FindProperty("handRight");

            onRightHandOpenedProp = serializedObject.FindProperty("onRightHandOpened");
            onRightHandClosedProp = serializedObject.FindProperty("onRightHandClosed");

            onLeftHandOpenedProp = serializedObject.FindProperty("onLeftHandOpened");
            onLeftHandClosedProp = serializedObject.FindProperty("onLeftHandClosed");

            vchg = (XdeAsbViveControllerHandGrasping)target;
        }

        public override void OnInspectorGUI()
        {
            EditorGUILayout.PropertyField(handLeftProp, new GUIContent("Left hand tracked object"), true);
            EditorGUILayout.PropertyField(handRightProp, new GUIContent("Right hand tracked object"), true);

            EditorGUILayout.Slider(triggerThresholdProp, 0, 1, new GUIContent("Trigger grasping threshold"));
            EditorGUILayout.Slider(echoTimeProp, 0, 2, new GUIContent("Callback echo duration"));

            EditorGUILayout.PropertyField(onRightHandClosedProp, new GUIContent("On right hand closed"), true);
            EditorGUILayout.PropertyField(onRightHandOpenedProp, new GUIContent("On right hand opened"), true);

            EditorGUILayout.PropertyField(onLeftHandClosedProp, new GUIContent("On left hand closed"), true);
            EditorGUILayout.PropertyField(onLeftHandOpenedProp, new GUIContent("On left hand opened"), true);


            if (GUILayout.Button("Create Vive Controller Hand Grasping Callbacks"))
            {
                DestroyOculusTouchHandGraspingCallbacks();
                CreateOculusTouchHandGraspingCallbacks();
            }

            serializedObject.ApplyModifiedProperties();
        }

        public void CreateOculusTouchHandGraspingCallbacks()
        {
            XdeAsbOperatorHands operatorHands = FindObjectOfType<XdeAsbOperatorHands>();
            if (operatorHands != null)
            {
                if (vchg.listenerIdAttachR == -1 && vchg.onRightHandClosed != null)
                {
                    vchg.listenerIdAttachR = vchg.onRightHandClosed.GetPersistentEventCount();
                    UnityAction attachRightAction = new UnityAction(operatorHands.AttachRightHand);
                    UnityEventTools.AddVoidPersistentListener(vchg.onRightHandClosed, attachRightAction);
                }

                if (vchg.listenerIdDetachR == -1 && vchg.onRightHandOpened != null)
                {
                    vchg.listenerIdDetachR = vchg.onRightHandOpened.GetPersistentEventCount();
                    UnityAction detachRightAction = new UnityAction(operatorHands.DetachRightHand);
                    UnityEventTools.AddVoidPersistentListener(vchg.onRightHandOpened, detachRightAction);
                }

                if (vchg.listenerIdAttachL == -1 && vchg.onLeftHandClosed != null)
                {
                    vchg.listenerIdAttachL = vchg.onLeftHandClosed.GetPersistentEventCount();
                    UnityAction attachLeftAction = new UnityAction(operatorHands.AttachLeftHand);
                    UnityEventTools.AddVoidPersistentListener(vchg.onLeftHandClosed, attachLeftAction);
                }

                if (vchg.listenerIdDetachL == -1 && vchg.onLeftHandOpened != null)
                {
                    vchg.listenerIdDetachL = vchg.onLeftHandOpened.GetPersistentEventCount();
                    UnityAction detachLeftAction = new UnityAction(operatorHands.DetachLeftHand);
                    UnityEventTools.AddVoidPersistentListener(vchg.onLeftHandOpened, detachLeftAction);
                }
            }
        }

        public void DestroyOculusTouchHandGraspingCallbacks()
        {
            if (vchg.listenerIdAttachR >= 0 &&
                vchg.listenerIdAttachR < vchg.onRightHandClosed.GetPersistentEventCount())
                UnityEventTools.RemovePersistentListener(vchg.onRightHandClosed, vchg.listenerIdAttachR);

            vchg.listenerIdAttachR = -1;

            if (vchg.listenerIdDetachR >= 0 &&
                vchg.listenerIdDetachR < vchg.onRightHandOpened.GetPersistentEventCount())
                UnityEventTools.RemovePersistentListener(vchg.onRightHandOpened, vchg.listenerIdDetachR);

            vchg.listenerIdDetachR = -1;

            if (vchg.listenerIdAttachL >= 0 && vchg.listenerIdAttachL < vchg.onLeftHandClosed.GetPersistentEventCount())
                UnityEventTools.RemovePersistentListener(vchg.onLeftHandClosed, vchg.listenerIdAttachL);

            vchg.listenerIdAttachL = -1;

            if (vchg.listenerIdDetachL >= 0 && vchg.listenerIdDetachL < vchg.onLeftHandOpened.GetPersistentEventCount())
                UnityEventTools.RemovePersistentListener(vchg.onLeftHandOpened, vchg.listenerIdDetachL);

            vchg.listenerIdDetachL = -1;
        }

        private void OnDestroy()
        {
            if (Application.isEditor)
            {
                if (target == null)
                    DestroyOculusTouchHandGraspingCallbacks();
            }
        }
    }
}
