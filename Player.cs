using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace programing_practice
{
    class Player : Creature // derived class //如要另外建立建構子, 且父類別已有,則也需要回傳参數給父類別
    {
        public Player(string name, int mp) : base(name, mp)
        {
            this.MP = mp;
            this.name = name;
        }
        public new string Talk()
        {
            return  base.Talk() + "我是勇者";//如要使用父類別相同名稱的方法,則需要使用base呼叫
        }
        public override string Sayhi()//子類別需定義抽象父類別的抽象方法
        {
            return "嗨 我是玩家";
        }
    }
}
