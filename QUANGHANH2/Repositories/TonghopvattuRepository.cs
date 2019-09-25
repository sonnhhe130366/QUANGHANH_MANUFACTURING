﻿using QUANGHANH2.Models;
using QUANGHANH2.ModelViews;
using QUANGHANH2.Repositories.Intefaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Unity;

namespace QUANGHANH2.Repositories
{
    public class TonghopvattuRepository : ITonghopvattuRepository
    {
        [Dependency]
        public QUANGHANHABCEntities context { get; set; }

        public IList<TonghopvattuDepartmentModelView> GetDepartments()
        {
            var departments = context.Database.SqlQuery<TonghopvattuDepartmentModelView>("SELECT " +
                "department_id DepartmentId, department_name DepartmentName, department_type DepartmentType " +
                "FROM Department").ToList();
            return departments;
        }

        public IList<TonghopvattuDetailModelView> GetDetails(TonghopVattuSearchModelView search)
        {
            DateTime monthPicked = DateTime.Parse(search.MonthPicked);
            string query = $"SELECT tmp.SupplyId, s.supply_name SupplyName, s.unit SupplyUnit, tmp.SupplyAverage, st.quantity SupplyQuantity " +
                $"FROM (SELECT supplyid SupplyId, SUM(dinh_muc) AS SupplyAverage FROM SupplyPlan WHERE departmentid = '{search.DepartmentId}' AND YEAR([date]) = {monthPicked.Year} AND MONTH([date]) = {monthPicked.Month} GROUP BY supplyid) tmp, Supply s, Supply_tieuhao st " +
                $"WHERE st.supplyid = tmp.SupplyId AND s.supply_id = tmp.SupplyId AND " +
                $"st.departmentid = '{search.DepartmentId}' AND " +
                $"s.supply_id LIKE N'%{search.SupplyId}%' AND " +
                $"s.supply_name LIKE N'%{search.SupplyName}%'";
            var details = context.Database.SqlQuery<TonghopvattuDetailModelView>(query).ToList();
            return details;
        }

        public IList<TonghopvattuSummaryModelView> GetSummary(TonghopVattuSearchModelView search)
        {
            DateTime monthPicked = DateTime.Parse(search.MonthPicked);
            string query = $"SELECT tmp.SupplyId, tmp.SupplyQuantity, s.supply_name SupplyName, s.unit SupplyUnit " +
                $"FROM (SELECT st.supplyid SupplyId, SUM(st.quantity) SupplyQuantity FROM Supply_tieuhao st, Supply s WHERE st.supplyid = s.supply_id AND YEAR([date]) = {monthPicked.Year} AND MONTH([date]) = {monthPicked.Month} GROUP BY st.supplyid) tmp, Supply s " +
                $"WHERE tmp.SupplyId = s.supply_id AND " +
                $"s.supply_id LIKE N'%{search.SupplyId}%' AND " +
                $"s.supply_name LIKE N'%{search.SupplyName}%'";
            var summary = context.Database.SqlQuery<TonghopvattuSummaryModelView>(query).ToList();
            return summary;
        }
    }
}