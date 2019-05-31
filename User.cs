using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace programing_practice
{
    class User
    {
        private string Username;// 狀況一: 僅為唯讀狀態   //可用get處理器處理
        private string Password;// 狀況二: 不想讓人看到內容 也不想給人存取 需用方法間接讀取
        private int HP = 100;// 狀況三: 想要在存取時先設定限制  //可用set處理器處理

        private int Count1 = 10, Count5= 5, Count10= 4;
        public int Money
        {
            get { return Count1 * 1 + Count5 * 5 + Count10 * 10;}//於讀取時，自動呼叫，如僅有get存取器即為唯獨参數
            set //於寫入時自動呼叫
            {
                if (value>0)
                    Count1 = value;
                else
                    Count1 = 0;
            }
        }

        public User(string username, string password)
        {
            this.Username = username;
            this.Password = password;
        }
        public string getUsername()
        {
            return Username;
        }
        public string comparePassword(string inputPassword)
        {
            if (this.Password == inputPassword)
                return "密碼正確";
            else
                return "密碼錯誤";

        }
        public int hurt(int decreaseHP)
        {
            if (this.HP >= decreaseHP)
                this.HP -=decreaseHP;
            else
                this.HP = 0;
            return this.HP;
        }
        
    }
}
