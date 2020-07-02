using UnityEngine;

public class ModelTrackingScript : VLWorkerReferenceBehaviour
{        
    private void Start()
    {
        InitWorkerReference();
        //workerBehaviour.StartTracking("Examples/ModelTracking/carEcho.vl");
    }

    public void track() {
        workerBehaviour.StartTracking("Examples/ModelTracking/carEcho.vl");
    }

    private void OnDestroy()
    {
        workerBehaviour.StopTracking();
    }
    
    
}
