using System.Collections;
using System;
using System.Collections.Generic;
using System.Text;

namespace best_fit_algorithm
{
   public class Adventure
    {
        private  int lifePoints;
        private  int manaPoints;
        private  int noOfEquipment;
        private  string nameOfWeapon;
        public  Adventure(string nameOfWeapon = null , int lifePoints = 0 , int manaPoints = 0 , int noOfEquipment = 0 )
        {
            NameOfWeapon = nameOfWeapon;
            NoOfEquipment = noOfEquipment;
            LifePoints = lifePoints;
            ManaPoints = manaPoints ;
        }

        public string NameOfWeapon{get; set;}
        public int NoOfEquipment{get;set;}
        public int LifePoints{get;set;}
        public int ManaPoints{get;set;}
        
    }
}
