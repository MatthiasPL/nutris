﻿using Dietpolix.Classes.Managers;
using Dietpolix.Classes;
using System.Collections.Generic;
using System.Text;

namespace Dietpolix.Models
{
    public class Model
    {
        public APIManager apimanager = new APIManager();
        public DatabaseManager databasemanager = new DatabaseManager();
        public User user;
        public List<Product> listofproducts = new List<Product>();

        public void PrintDiet()
        {
            //TO-DO printing diet
        }

        public string RemoveSpecialCharacters(string str)
        {
            StringBuilder sb = new StringBuilder();
            foreach (char c in str)
            {
                if ((c >= '0' && c <= '9') || (c >= 'A' && c <= 'Z') || (c >= 'a' && c <= 'z') || c == '.' || c == '_' || c==' ')
                {
                    sb.Append(c);
                }
            }
            return sb.ToString();
        }

        public double CountBMI(int weight, int height)
        {
            double BMI = 0;
            if ((weight!=0)&&(height!=0))
            {
                return BMI = weight / (height * height);
            }
            return 0;
        }

        // minimal need for calories per day
        public double CountBMR(int weight, int height, int age, char sex)        // sex is either f or m
        {
            double BMR = 0;
            if ((weight != 0) && (height != 0) && (age != 0) && (sex != 0))
            {
                double allBmr = (9.99 * weight) + (6.25 * height) - (4.92 * age);
                if (sex == 'm')
                    return BMR = allBmr + 5;
                if (sex == 'f')
                    return BMR = allBmr - 161;
            }
            return 0;
        }

        // maximum need for calories per day
        public double CountCPM(double BMR, int lifestyle, int aim)  
        // lifestyle -> 1-couchpotato, 2-programmer, etc.
        // aim -> 1-fatreduction, 2-musclemass
        {
            double CPM = 0;
            if ((BMR != 0) && (lifestyle != 0) && (aim != 0))
            {
                switch(lifestyle)
                {
                    case 1: CPM = BMR * 1.2; break;
                    case 2: CPM = BMR * 1.4; break;
                    case 3: CPM = BMR * 1.6; break;
                    case 4: CPM = BMR * 1.8; break;
                    case 5: CPM = BMR * 2.2; break;
                }
                if (aim == 1)
                    return CPM = CPM - 200;
                if (aim == 2)
                    return CPM = CPM + 300;
            }
            return 0;
        }
    }
}
