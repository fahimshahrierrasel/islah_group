﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IslahGroup.DotNet.DataAccessLayer;

namespace IslahGroup.DotNet.BusinessLogicLayer
{
    public class ExpenditureLogic
    {
        private ExpenditureData expenditureData;

        public ExpenditureLogic()
        {
            expenditureData = new ExpenditureData();
        }

        public bool NewExpenditure(Dictionary<string, string> expenditure)
        {
            SqlParameter[] parameters = new SqlParameter[expenditure.Count];
            parameters[0] = new SqlParameter("ExpnDate", DateTime.Parse(expenditure["ExpnDate"]).Date);
            parameters[1] = new SqlParameter("ExpnNote", expenditure["ExpnNote"]);
            parameters[2] = new SqlParameter("ExpnAmount", double.Parse(expenditure["ExpnAmount"]));
            parameters[3] = new SqlParameter("ExpnType", expenditure["ExpnType"]);
            parameters[4] = new SqlParameter("UserId", expenditure["UserId"]);

            if (expenditureData.Insert(parameters))
                return true;
            return false;
        }
        public DataTable AllExpenditure()
        {
            DataTable allExpenditureTable = new DataTable();
            allExpenditureTable = expenditureData.GetAllExpenditures();
            return allExpenditureTable;
        }

        public DataTable ExpenditureTypes()
        {
            DataTable types = new DataTable();
            types = expenditureData.GetExpenditureTypes();
            return types;
        }

        public DataTable ExpenditureInfo()
        {
            DataTable info = new DataTable();
            info = expenditureData.GetExpenditureInfo();
            return info;
        }
    }
}
