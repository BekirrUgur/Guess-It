using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Gyro : MonoBehaviour
{
    #region instance
    private static Gyro instance;
    public static Gyro Instance
    {
        get 
        {
            if (instance == null) 
            {
                instance = FindObjectOfType<Gyro>();
                if (instance == null) 
                {
                    instance = new GameObject("Spawned GyroManager", typeof(Gyro)).GetComponent<Gyro>();
                }
            }
            return instance; 
        }
        set 
        {
            instance = value;
        }


    }
    #endregion

    [Header("Logic")]
    private Gyroscope gyro;
    private Quaternion rotation;
    private bool gyroActive;

    public void EnableGyro() 
    {
        //Already activated

        if (gyroActive)
            return;

        if(SystemInfo.supportsGyroscope)
        {
            Input.gyro.enabled = true;
            gyroActive = Input.gyro.enabled;

        }

    }
    private void Update()
    {
        if (gyroActive) 
        {
            rotation = Input.gyro.attitude;
        }
    }
    public Quaternion GetGyroRotation() 
    {
        return rotation;
    }

}

#region test
/*   public Image backGround;
 *   private float goster;
   private void Start()
   {

       if (SystemInfo.supportsGyroscope)
       {
           Input.gyro.enabled = true;
       }
   }
   private void Update()
   {
       GyroBaslat();
   }
   public void GyroBaslat()
   {


       // Buradaki kodu ben de pek anlamýyorum, 
       // kaynaktan copy-paste yaptým sayýlýr
      Quaternion fw = Input.gyro.attitude;


       //Debug.Log(ConvertRotation(fw).y);

       if(ConvertRotation(fw).x < 0) 
       {
           goster = (ConvertRotation(fw).x*-1);

           Debug.Log(goster);
       }
       else 
       {
           goster = (ConvertRotation(fw).x);
           Debug.Log(goster);
       }

       if (goster < 0.2f) 
       {
           backGround.color = Color.green;
       }
       if ( goster <=0.7 && goster >= 0.2f)
       {
           backGround.color = Color.black;
       }
       if (goster > 0.7f)
       {
           backGround.color = Color.red;
       }

   }

   private Quaternion ConvertRotation(Quaternion q)
   {
       return new Quaternion(q.x, q.y, q.z, q.w);
   }
*/
#endregion