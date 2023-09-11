using System;
using System.Data;
using System.Data.SqlClient;
//First Add Reference to System.Transactions DLL and then import the same
using System.Transactions;
namespace AdoNetConsoleApplication
{
    class TransactionTest
    {
        void RootMethod()
        {
            using (TransactionScope scope = new TransactionScope())
            {
                /* Perform transactional work here */
                SomeMethod();
                //
                scope.Complete(); 
            }
        }

        void SomeMethod()
        {
            using (TransactionScope scope = new TransactionScope())
            {
                /* Perform transactional work here */
                scope.Complete();
            }
        }

        //    void Test()
        //    {
        //        using (TransactionScope transactionScope = new TransactionScope())
        //        {
        //            try
        //            {
        //                string SqlString = @"data source=LAPTOP-ICA2LCQL\SQLEXPRESS; database=AXISBankDB; integrated security=TRUE";
        //                string OraString = @"data source=LAPTOP-ICA2LCQL\SQLEXPRESS; database=ICICIBankDB; integrated security=TRUE";
        //                DataSet TotData = new DataSet();
        //                TotData = DbSettings.GetDataSetSQL(SqlString, "Select * from TestSql");
        //                for (int i = 0; i < TotData.Tables[0].Rows.Count; i++)
        //                {
        //                    DataSet Oracleds = new DataSet();
        //                    Oracleds = DbSettings.GetDataSetOracle(OraString, "Select NVL(MAX(SRLNO),0)+1 from TestOracle");
        //                    int k = DbSettings.ExecuteNonQueryOracle(OraString, "Insert into TestOracle(NAME,SALARY,SRLNO) values('" + TotData.Tables[0].Rows[i][0].ToString() + "'," + Convert.ToInt32(TotData.Tables[0].Rows[i][1]) + "," + Convert.ToInt32(Oracleds.Tables[0].Rows[0][0]) + ")");
        //                    if (k == 1)
        //                    {
        //                        int j = DbSettings.ExecuteNonQuerySQL(SqlString, "Update TestSql Set status='UPD' where Name='" + TotData.Tables[0].Rows[i][0].ToString() + "'");
        //                    }
        //                }
        //                transactionScope.Complete();
        //                MessageBox.Show("Successful");
        //            }
        //            catch (TransactionException ex)
        //            {
        //                MessageBox.Show("Transaction Exception Occured");
        //            }
        //            catch (Exception ex1)
        //            {
        //                MessageBox.Show(ex1.Message);
        //            }
        //        }
        //        Console.ReadKey();
        //    }
        //}
    }
}