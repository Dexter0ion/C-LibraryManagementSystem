
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Timers;
using System.Windows.Forms;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;

namespace LibraryMS00
{
    class DataBaseClass
    {
        /// <summary>
        /// Jan 16th 2017 第一次编辑 完成连接测试 sql命令处理初期部分
        /// Jan 21st 2017 第二次编辑 基础功能完成 未经测试
        /// code by dexion
        ///
        /// </summary>
        /// <returns></returns>
        public SqlConnection getCnt()
        {
            string ConnectString = "Data Source=.;Database=LmsDb;User ID=LmsDBO;PWD=LmsDBO";
            SqlConnection sqlCnt = new SqlConnection(ConnectString);
            return sqlCnt;
        }

        public void CntTest()
        {
            //创立新连接 打开数据库连接
            SqlConnection sqlNewCnt = this.getCnt();
            //测试连接是否正常打开
            try
            {
                sqlNewCnt.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                MessageBox.Show("数据库打开成功");
                
                sqlNewCnt.Close();
                MessageBox.Show("数据库关闭");
                //释放资源
                sqlNewCnt.Dispose();
                
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sqlCmdStr">sqlCmdStr是要执行的sql命令</param>
        /// <param name="OperationType">OperationType是对命令类型的描述</param>
        /// <param name="newBook"></param>
        public void getCmd(string sqlCmdStr,string OperationType,BookInfo newBook)
            
        {
            //创立新连接 打开数据库连接
            SqlConnection sqlNewCnt = this.getCnt();
            //测试连接是否正常打开
            try
            {
                sqlNewCnt.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
              MessageBox.Show("数据库打开成功");
              /*
              sqlNewCnt.Close();
              MessageBox.Show("数据库关闭");
              //释放资源
              sqlNewCnt.Dispose();
              */
            }

            //建立本地数据库
            DataSet newDataSet = new DataSet();
            try
            {
                //创建命令对象
                SqlCommand sqlCmd = new SqlCommand();
                //建立命令对象的数据库连接关系
                sqlCmd.Connection = sqlNewCnt;
                //创建操作对象
                SqlDataAdapter newDataAdapter = new SqlDataAdapter();
                newDataAdapter.SelectCommand = sqlCmd;
                //DataSet本地微型数据库
                newDataAdapter.Fill(newDataSet, "bookInfo");
                DataTable newDataTable = newDataSet.Tables["bookInfo"];

                //执行sqlCmd并返回影响条数
                sqlCmd.ExecuteNonQuery();
                //释放sqlCmd
                sqlCmd.Dispose();
                //将DataSet的修改提交至数据库
                /*
                SqlCommandBuilder newSqlCommandBuilder = new SqlCommandBuilder(newDataAdapter);
                newDataAdapter.Update(newDataSet, "bookInfo");
                  */

            }
            catch (SqlException se)
            {
                MessageBox.Show(se.ToString(), "消息提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            finally
            {
                //关闭数据库
                sqlNewCnt.Close();
                //释放资源
                sqlNewCnt.Dispose();
            }

        }
        /// <summary>
        /// 返回DataSet类型是干啥的？
        /// </summary>
        /// <param name="sqlCmdStr"></param>
        /// <param name="OperationType"></param>
        /// <returns></returns>
        public DataSet getCmd(string sqlCmdStr, string OperationType)
        {
            SqlConnection sqlCnt = this.getCnt();
            DataSet newDataSet = new DataSet();
            sqlCnt.Open();
            try
            {
                //创建命令对象
                SqlCommand sqlCmd = new SqlCommand(sqlCmdStr, sqlCnt);
                //创建操作对象
                SqlDataAdapter newDataAdapter = new SqlDataAdapter();
                newDataAdapter.SelectCommand = sqlCmd;
                //DataSet本地微型数据库
                newDataAdapter.Fill(newDataSet, "bookInfo");
                DataTable newDataTable = newDataSet.Tables["bookInfo"];
                //执行sqlCnt后返回影响条数
                sqlCmd.ExecuteNonQuery();
                //释放sqlCmd
                sqlCmd.Dispose();
            }
            catch (SqlException se)
            {
                MessageBox.Show(se.ToString(), "消息提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            finally
            {
                //关闭数据库
                sqlCnt.Close();
                //释放资源
                sqlCnt.Dispose();
            }

            return newDataSet;
        }

        public SqlDataReader getReader(string sqlCntStr)
        {
            SqlConnection sqlCnt = this.getCnt();
            SqlCommand sqlCmd =new SqlCommand(sqlCntStr);
            sqlCnt.Open();
            //啥子参数？关闭连接？
            SqlDataReader sqlReader = sqlCmd.ExecuteReader(CommandBehavior.CloseConnection);
            //返回Reader对象
            return sqlReader;
        }

        public DataSet DataBaseOperation(string OperationType, SqlDataAdapter newDataAdapter, BookInfo newBookInfo)
        {
            //DataSet本地微型数据库
            DataSet newDataSet = new DataSet();
            newDataAdapter.Fill(newDataSet,"bookInfo");
            DataTable newDataTable = newDataSet.Tables["bookInfo"];

            //ID 一样 ->更新
            foreach(DataRow myRow in newDataTable.Rows)
            {
                if(decimal.Parse(myRow["booId"].ToString().Trim()) == newBookInfo.Id&&OperationType!="delete")
                {
                    OperationType = "updata";
                }
            }

            if(OperationType == "insert")
            {
                DataRow newRow = newDataTable.NewRow();

                //以下根据数据库列填写 新增一行 会后续增加
                
                newRow["bookId"] = newBookInfo.Id;
                newRow["bookName"] = newBookInfo.Name;
                newRow["bookState"] = 1;
                newDataTable.Rows.Add(newRow);
            }
            
            else if(OperationType  == "delete")
            {
                int sum = 0;
                foreach(DataRow newRow in newDataTable.Rows)
                {
                    if(decimal.Parse(newRow["bookId"].ToString().Trim())==newBookInfo.Id)
                        break;
                    sum++;
                }
                newDataTable.Rows[sum].Delete();
            }
             else if(OperationType == "update")
            {
                 foreach (DataRow newRow in newDataTable.Rows)
                 {
                     if(decimal.Parse(newRow["bookId"].ToString().Trim())==newBookInfo.Id)
                     {
                         newRow["bookId"] = newBookInfo.Id;
                         newRow["bookName"] = newBookInfo.Name;
                         newRow["bookState"]= 2;
                         //更新日期 数据库还没有这个
                         newRow["bookUpdateTime"] = DateTime.Now.ToShortDateString();
                     }
                 }
             }
            return newDataSet;
        }

    }
}
