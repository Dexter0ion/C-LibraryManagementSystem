using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace LibraryMS00
{
    /// <summary>
    /// Jan 23th 2017 初次完成数据添加 查询 删除功能 下一步改进GUI 新增窗口
    /// Coded by Dexion
    /// </summary>
    public partial class Form1 : Form
    {
        DataBaseClass db = new DataBaseClass();
        public Form1()
        {
            InitializeComponent();
            
        }



        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if(txtBookName.Text!="")
                {
                    //decimal bookId = decimal.Parse(txtBookId.Text.ToString().Trim());
                    string bookName = txtBookName.Text.ToString().Trim();
                    BookInfo newBook = new BookInfo(bookName);
                    db.getCmd("SELECT * FROM [tblBookInfo]","insert",newBook);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btnView_Click(object sender, EventArgs e)
        {
            DataSet newDataSet = new DataSet();

            if (txtBookId.Text != "")
            {
                //id查询功能
                //trim() 函数移除字符串两侧的空白字符或其他预定义字符。

                try
                {
                    newDataSet = db.getCmd("SELECT [bookId],[bookName]FROM [tblBookInfo] WHERE [bookId] = " + txtBookId.Text.ToString().Trim(), "check");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("无此编号图书，请重新输入");
                    MessageBox.Show(ex.Message);
                }

            }
            /*else if (txtBookName.Text != "")
            {
                try
                {
                    db.getCmd("SELECT [bookId],[bookName]FROM [tblBookInfo] WHERE [bookName] = " + txtBookName.Text.ToString().Trim(), "check");
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
             */
            else
            {
                //哦嚯 check operationtype在类里并没有说明 偷懒咯?
                try
                {
                    newDataSet = db.getCmd("SELECT [bookId],[bookName]FROM [tblBookInfo]", "check");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

            dataGridView1.DataSource = newDataSet;
            dataGridView1.DataMember = "bookInfo";
            dataGridView1.Columns[0].HeaderText = "图书编号";
            dataGridView1.Columns[0].Width = 120;
            dataGridView1.Columns[1].HeaderText = "图书名称";
            dataGridView1.Columns[1].Width = 120;


        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            db.CntTest();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnNewForm_Click(object sender, EventArgs e)
        {
            Form testForm = new Form();
            testForm.Show();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtBookId.Text != "" && txtBookName.Text == "")
                {
                    decimal bookId = decimal.Parse(txtBookId.Text.ToString().Trim());
                    BookInfo newBook = new BookInfo(bookId);
                    db.getCmd("SELECT * FROM [tblBookInfo]", "delete", newBook);
                }
                if (txtBookId.Text == "" && txtBookName.Text != "")
                {
                    string bookName = txtBookName.Text.ToString().Trim();
                    BookInfo newBook = new BookInfo(bookName);
                    db.getCmd("SELECT * FROM [tblBookInfo]", "delete", newBook);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }


    }
}
