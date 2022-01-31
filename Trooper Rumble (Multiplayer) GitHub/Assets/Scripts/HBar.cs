using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour     // as a slider
{
    public Slider slider;
    public void setMaxHealth(int health)
    {
        slider.maxValue = health;
      slider.value = health;

    }

   public void setHealth(int haelth)
   {
        slider.value = haelth;
   }

   


   }
