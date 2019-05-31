using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace programing_practice
{
    class Monster : Creature //derived class
    {
        public Monster(string name, int mp) : base( name, mp) //如要另外建立建構子, 且父類別已有，則也需要回傳参數給父類別
        {
            this.MP = mp;
            this.name = name;
        }
        public override string Sayhi()//子類別需定義抽象父類別的抽象方法
        {
            return "嗨 我是怪獸";
        }
    }
}
