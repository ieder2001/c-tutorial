using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace programing_practice
{
    class Student
    {
        //property
        public int Grade;  
        public string name;
        public int Score;
        /*
        static 可以使用類別直接呼叫方法或參數，不需要創建物件，且不能使用物件存取，可利用來
        修改類別所有物件之共同參數。
        */
        public static int PassScore =100;
        /*
        private限制參數或方法僅可於類別內使用，外部無法存取，有較高的保密性，無法被外界更動。
        */
        private static int PassScore1 = 100;
        //method
        //public + 回傳型別 + method 名稱 (輸入型別與名稱)
        public Student() { }//預設建構子
        /*
        建構子(CONSTRUCTOR):
        1.當class的property 需要重複輸入同樣值時，或需要常常建立並設定時，則可以使用Constructor。
        2.Constuctor為一種Method，名稱與class一樣。
        3.沒有output
        4.當建立一個Constructor後，預設Constructor會消失，如需使用則需要另建。
        */
        public Student(string name,int grade)//重複建構子#1
        {
            this.name = name;//為區別name使用this，this是指類別內的屬性
            Grade = grade;
        }
        public Student(string name, int grade, int score)//重複建構子#2
        {
            this.name = name;
            Grade = grade;
            Score = score;
        }
        public string Say(Student other)
        {
            return "嗨， " + other.Grade + "年級的" + other.name + ",我是" + Grade + "年級的學生" + name;
        }
        public void Upgrade()
        {
            Grade++; 
        }
        public static int YearNow(int StartYear,int AfterYear)//static 方法可以使用類別直接使用，不需要創建物件，且不能使用物件使用。
        {
            int YearNow = StartYear + AfterYear;
            return YearNow;
        }
        public bool Pass()
        {
            if (Score >= PassScore1)
                return true;
            else  
                return false;
        }
    }
}
