using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace programing_practice
{
    class Villager : Creature
    {
        public Villager(int mp) : base("村民", mp)//如要另外建立建構子, 且父類別已有,則也需要回傳参數給父類別
        {
            this.name = "村民";
            this.MP = mp;
        }
        public override string Attack(Creature c1)//因村民無法攻擊，因此需要改寫方法，必須用override改寫base class的方法
        //如不加override，則為method hiding，以子類別身分呼叫時，則以此方法呼叫，如以父類別身分呼叫則呼叫覆父類別版之方法
        {
            return name + "無法攻擊";
        }
        public override string Sayhi()//子類別需定義抽象父類別的抽象方法
        {
            return "嗨 我是村民";
        }

    }
}
