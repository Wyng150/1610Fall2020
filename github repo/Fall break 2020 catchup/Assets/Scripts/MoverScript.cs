using UnityEngine;

public class MoverScript : MonoBehaviour
{
   public float speed = 3f, x, y, z;
   public float health = 100;
   public string talkingPoint = "Hello World.";
   private void Update()
   {
      var vInput = speed * Time.deltaTime * Input.GetAxis("Vertical");
      var hInput = speed * Time.deltaTime * Input.GetAxis("Horizontal");
      transform.Translate(hInput,vInput,0);
      
   }

   public void Up()
   {
      transform.Translate(0,speed,0);
      
   }

   public void Down()
   {
      transform.Translate(0,-speed,0);
   }
}
