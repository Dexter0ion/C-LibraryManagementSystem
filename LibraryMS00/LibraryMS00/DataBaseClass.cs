
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
        /// 
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
        
    }
}
