using System;
using System.Collections;
using System.Collections.Generic;
using Microsoft.MixedReality.Toolkit;
using Microsoft.MixedReality.Toolkit.Input;
using UnityEngine;

public class TapToSetAnchor : MonoBehaviour, IMixedRealityPointerHandler
{
    public GameObject ParentAnchor;
    public void Start()
    {
        CoreServices.InputSystem?.RegisterHandler<IMixedRealityPointerHandler>(this);
    }

    public void OnEnable()
    {
        CoreServices.InputSystem?.RegisterHandler<IMixedRealityPointerHandler>(this);
    }

    public void OnDisable()
    {
        CoreServices.InputSystem?.UnregisterHandler<IMixedRealityPointerHandler>(this);
    }
    
    public void OnPointerDown(MixedRealityPointerEventData eventData)
    {
        //Do Nothing
    }

    public void OnPointerDragged(MixedRealityPointerEventData eventData)
    {
        //Do Nothing
    }

    public void OnPointerUp(MixedRealityPointerEventData eventData)
    {
        //Do Nothing
    }

    /// <summary>
    /// Position's the anchor object on the QR code. This will not create an anchor to allow for rotation fine tuning
    /// The hand menu contains a create anchor option.
    ///
    /// We don't care (at least for now) what is the QR code as we assume there will be only one in sight.
    /// </summary>
    /// <param name="eventData">Event data from the pointer interaction. Not used in this method</param>
    public void OnPointerClicked(MixedRealityPointerEventData eventData)
    {
        var QRCodeList = GameObject.FindGameObjectsWithTag("QRTag");
        if (QRCodeList == null)
        {
            return;
        }

        foreach (var QRCode in QRCodeList){
            var QRCodeScript = QRCode.GetComponent<Microsoft.MixedReality.SampleQRCodes.QRCode>();
            //a null check would be nice

            //double check how to compare strings in #
            if (QRCodeScript.qrCode.Data == "Maze")
            {
                ParentAnchor.transform.position = QRCode.transform.position;
                //Ignore the X and Z rotations to keep the building level :)

#if !UNITY_EDITOR
                ParentAnchor.transform.rotation = Quaternion.Euler(0, QRCode.transform.rotation.eulerAngles.y - 270, 0);
#endif

                //Unparent the building
                gameObject.transform.GetChild(0).transform.parent = null;
                //Destroy the QR Code
                Destroy(this.gameObject);
            }
        }

        return;
    }

}
