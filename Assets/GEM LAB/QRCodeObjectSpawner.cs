// Import necessary namespaces
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QRCodeObjectSpawner : MonoBehaviour
{
    // Public list of GameObjects for AR targets which is needed for each qr code
    public List<GameObject> ARTargets;

    // Private variable to store a QRCode instance
    private Microsoft.MixedReality.SampleQRCodes.QRCode qrCode;

    // Dictionary to map QR code data strings to targets
    private Dictionary<string, int> nameToIndexMap = new Dictionary<string, int>(StringComparer.InvariantCultureIgnoreCase)
    {
        {"A", 0},
        {"B", 1},
        {"C", 2},
        {"D", 3},
        {"E", 4},
        {"F", 5},
        {"G", 6},
        {"H", 7},
        {"I", 8},
        {"J", 9},
        {"K", 10},
        {"L", 11},
    };

    // Private flag indicating if content has been instantiated
    private bool haveInstantiatedContent = false;

    // Reference to the instantiated content GameObject
    private GameObject contentGameObject = null;

    // Function to disable all GameObjects in the ARTargets list
    private void DisableAllGameObjects()
    {
        foreach (var obj in ARTargets)
        {
            obj.SetActive(false);
        }
    }

    // Called when the script instance is being loaded
    private void Start()
    {
        // Disable all AR target GameObjects at the start
       // DisableAllGameObjects();
    }

    // Called once per frame
    private void Update()
    {
        // Check if content has not been instantiated yet
        if (!haveInstantiatedContent)
        {
            // Get the QRCode component attached to this GameObject
            qrCode = GetComponent<Microsoft.MixedReality.SampleQRCodes.QRCode>();

            // Check if a valid QR code has been scanned
            if (qrCode.qrCode != null)
            {
                // Check if the scanned QR code data is in the nameToIndexMap
                if (nameToIndexMap.ContainsKey(qrCode.qrCode.Data))
                {
                    // Get the index associated with the scanned QR code data
                    int index = nameToIndexMap[qrCode.qrCode.Data];

                    //Printing just for checking logs
                    Debug.Log("QR code data found: " + index);

                    // Disable all AR target GameObjects
                    //DisableAllGameObjects();

                    // Instantiate the corresponding AR target GameObject
                    contentGameObject = Instantiate(ARTargets[index]);

                    // Set the position of the instantiated GameObject to match the spawner's position
                    contentGameObject.transform.position = transform.position;

                    // Set the parent of the instantiated GameObject to a child of this spawner's GameObject
                    contentGameObject.transform.parent = gameObject.transform.GetChild(1).transform;

                    // Update the flag to indicate that content has been instantiated
                    haveInstantiatedContent = true;
                }
            }
        }
    }
}
