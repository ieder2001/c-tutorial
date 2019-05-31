using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace programing_practice
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)  //student
        {
            int StartYear = 95;
            int AfterYear = 10;
            Math.Equals(StartYear,AfterYear);//C#內建許多static方法，如Math可以直接使用類別進行計算，不需另外寫方法或建物件使用
            //預設建構子
            Student LEO = new Student(); //reference type : student LEO (reference) = new student()( heap)-->method
            LEO.Grade = 5; 
            LEO.name = "LEO";
            Student POLLY = new Student("POLLY",5, 80);//重複建構子#1
            Student SAM = new Student("SAM", 4);//重複建構子#2
            MessageBox.Show(POLLY.Say(POLLY));
            LEO.Upgrade();
            MessageBox.Show(SAM.Say(POLLY));
            MessageBox.Show(""+ Student.YearNow(StartYear , AfterYear));
            MessageBox.Show("" + POLLY.Pass());
            
        }

        private void button2_Click(object sender, EventArgs e)  //User
        {
            User LEO = new User("ieder2001", "12345678");
            MessageBox.Show(LEO.getUsername());
            MessageBox.Show(LEO.comparePassword("12345678"));
            MessageBox.Show(""+ LEO.hurt(20));
            MessageBox.Show("" + LEO.hurt(20));
            LEO.Money = -5;//利用set 處理器可以直接設定存入限制
            MessageBox.Show(""+ LEO.Money);//利用get處理器直接讀

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Player leo = new Player("leo",50);
            Monster m1 = new Monster("史萊姆",80);
            Monster m2 = new Monster("巴風特",80);
            Villager v1 = new Villager(50);
            Creature c1 = v1;//可用父類別變數存取子類別變數，如呼叫被覆寫的方法，會直接呼叫被覆寫的方法
            //因此已抽象父類別的身分也可以直接存取子類別的抽象實作方法
            //Creature c2 = new Creature();  抽象類別無法被建立物件
            m2.Attack(leo);
            m2.Attack(m1);
            string message;
            message=c1.Attack(m2);
            MessageBox.Show(message);
            MessageBox.Show(leo.name + "的魔力:" + leo.GetMP() + "; "+ m2.name +"的血量:" + m1.GetHP());
        }
    }
}
