using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LibraryMS00
{
    class BookInfo
    {
        /// <summary>
        /// Jan 16th 2017 第一次编辑 测试用图书信息类 只有ID和Name
        /// Jan 23th 2017 第二次编辑 由于ID自增 写了只有name参数的初始化函数
        /// code by dexion
        /// </summary>
        private decimal bookId; //录入编号 数据库自增 *主键
        private string bookName;    //测试一般只填写名字
        /*
        private string bookPress;   //出版社
        private string bookColor;   //封面颜色
        private string bookPrice;
        private string bookISBN;    //ISBN号
        private string bookType;    //类别
        */

        public BookInfo()
        {
            this.bookId = 0000;
            this.bookName = "NULL";
        }
        public BookInfo(decimal Id_)
        {
            this.bookId =Id_;
            this.bookName = "NULL";
        }

        public BookInfo(decimal Id_,string Name_)
        {
            this.bookId = Id_;
            this.bookName = Name_;
        }

        public BookInfo(string Name_)
        {
            this.bookName = Name_;
        }

        public decimal Id
        {
            get { return this.bookId; }
            set { this.bookId = value; }
        }

        public string Name
        {
            get { return this.bookName; }
            set { this.bookName = value; }
        }
    }
}
