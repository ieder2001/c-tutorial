using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace programing_practice
{
    abstract class  Creature // base class // 抽象類別可以使用抽象参數及類別，以強迫子類別定義方法及参數
    {
        public string name;
        private int HP = 100;
        protected int MP = 100; //protected 層級之變數或方法可由繼承之類別存取，且仍能確保外部無法存取。
        public Creature(string name, int MP)
        {
            this.name = name;
            this.MP = MP;
        }
        public int GetHP()
        {
            return HP;
        }
        public void Injure(int Injurepoint)
        {
            this.HP -= Injurepoint;
        }
        public virtual string Attack(Creature c1) 
        // 利用base class 當輸入可以減少重複建構不同方法以描述不同的derived class方法 
        // 為了可以讓要繼承的class改寫方法內的內容，則必須加上virtual
        {
            Random random = new Random();
            if (c1.GetType() == typeof(Player))
                c1.Injure(random.Next(50, 100));
            else
                c1.Injure((random.Next(0, 50)));
            return name + "受傷了";
        }
        public int GetMP()
        {
            return MP;
        }
        public string Talk()
        {
            return "嗨大家好";
        }
        abstract public string Sayhi(); //抽向類別以強迫子類別實作定義此方法
    }
}
