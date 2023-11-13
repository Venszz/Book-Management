﻿using CAIT.SQLHelper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using WedStore.Const;
using WedStore.Models;

namespace WedStore.Repositories
{
    public class InfoOrderRes
    {
        public static bool InfoOrder_create(InfoOrder infoOrder)// tạo đơn hàng mới
        {
            object[] value = { infoOrder.InfoOrderID, infoOrder.OrderID, infoOrder.Name,
                               infoOrder.Email, infoOrder.Phone,infoOrder. Address,
                               infoOrder.TotalPrice, infoOrder.Status };
            SQLCommand connection = new SQLCommand(ConstValue.ConnectString);
            DataTable result = connection.Select("InfoOrder_Create", value);

            if (connection.errorCode == 0 && connection.errorMessage == "")
            {
                return true;
            }
            return false;
        }
        public static InfoOrder InfoOrder_GetInfoOrdersWithID(string id)
        {
            object[] value = { id };
            SQLCommand connection = new SQLCommand(ConstValue.ConnectString);
            DataTable result = connection.Select("InfoOrder_GetInfoOrdersWithID", value);
            if (connection.errorCode == 0 && connection.errorMessage == "")
            {
                foreach (DataRow dr in result.Rows)
                {
                    InfoOrder infoOrder = new InfoOrder();
                    infoOrder.InfoOrderID = dr["InfoOrderID"].ToString();
                    infoOrder.OrderID = dr["OrderID"].ToString();
                    infoOrder.Name = dr["Name"].ToString();
                    infoOrder.Email = dr["Email"].ToString();
                    infoOrder.Phone = dr["Phone"].ToString();
                    infoOrder.Address = dr["Address"].ToString();

                    infoOrder.TotalPrice = string.IsNullOrEmpty(dr["TotalPrice"].ToString()) ? 0 : int.Parse(dr["TotalPrice"].ToString());
                    infoOrder.Status = string.IsNullOrEmpty(dr["Status"].ToString()) ? 0 : int.Parse(dr["Status"].ToString());
                    return infoOrder;
                }
            }
            return null;
        }
        public static InfoOrder InfoOrder_GetInfoOrdersWithOrderID(string id)
        {
            object[] value = { id };
            SQLCommand connection = new SQLCommand(ConstValue.ConnectString);
            DataTable result = connection.Select("InfoOrder_GetInfoOrderWithOrderID", value);
            if (connection.errorCode == 0 && connection.errorMessage == "")
            {
                foreach (DataRow dr in result.Rows)
                {
                    InfoOrder infoOrder = new InfoOrder();
                    infoOrder.InfoOrderID = dr["InfoOrderID"].ToString();
                    infoOrder.OrderID = dr["OrderID"].ToString();
                    infoOrder.Name = dr["Name"].ToString();
                    infoOrder.Email = dr["Email"].ToString();
                    infoOrder.Phone = dr["Phone"].ToString();
                    infoOrder.Address = dr["Address"].ToString();

                    infoOrder.TotalPrice = string.IsNullOrEmpty(dr["TotalPrice"].ToString()) ? 0 : int.Parse(dr["TotalPrice"].ToString());
                    infoOrder.Status = string.IsNullOrEmpty(dr["Status"].ToString()) ? 0 : int.Parse(dr["Status"].ToString());
                    return infoOrder;
                }
            }
            return null;
        }

        public static List<InfoOrder> InfoOrder_GetInfoOrderWithEmail(string email)
        {
            object[] value = { email };
            SQLCommand connection = new SQLCommand(ConstValue.ConnectString);
            DataTable result = connection.Select("InfoOrder_GetInfoOrderWithEmail", value);
            List<InfoOrder> lstInfoOrder = new List<InfoOrder>();
            if (connection.errorCode == 0 && connection.errorMessage == "")
            {
                foreach (DataRow dr in result.Rows)
                {
                    InfoOrder infoOrder = new InfoOrder();
                    infoOrder.InfoOrderID = dr["InfoOrderID"].ToString();
                    infoOrder.OrderID = dr["OrderID"].ToString();
                    infoOrder.Name = dr["Name"].ToString();
                    infoOrder.Email = dr["Email"].ToString();
                    infoOrder.Phone = dr["Phone"].ToString();
                    infoOrder.Address = dr["Address"].ToString();

                    infoOrder.TotalPrice = string.IsNullOrEmpty(dr["TotalPrice"].ToString()) ? 0 : int.Parse(dr["TotalPrice"].ToString());
                    infoOrder.Status = string.IsNullOrEmpty(dr["Status"].ToString()) ? 0 : int.Parse(dr["Status"].ToString());

                    lstInfoOrder.Add(infoOrder);
                }
            }
            return lstInfoOrder;
        }
        public static List<InfoOrder> InfoOrder_GetAll() {
            object[] value = { };
            SQLCommand connection = new SQLCommand(ConstValue.ConnectString);
            DataTable result = connection.Select("InfoOrder_GetAll", value);
            List<InfoOrder> lstInfoOrder = new List<InfoOrder>();
            if (connection.errorCode == 0 && connection.errorMessage == "")
            {
                foreach (DataRow dr in result.Rows)
                {
                    InfoOrder infoOrder = new InfoOrder();
                    infoOrder.InfoOrderID = dr["InfoOrderID"].ToString();
                    infoOrder.OrderID = dr["OrderID"].ToString();
                    infoOrder.Name = dr["Name"].ToString();
                    infoOrder.Email = dr["Email"].ToString();
                    infoOrder.Phone = dr["Phone"].ToString();
                    infoOrder.Address = dr["Address"].ToString();

                    infoOrder.TotalPrice = string.IsNullOrEmpty(dr["TotalPrice"].ToString()) ? 0 : int.Parse(dr["TotalPrice"].ToString());
                    infoOrder.Status = string.IsNullOrEmpty(dr["Status"].ToString()) ? 0 : int.Parse(dr["Status"].ToString());

                    lstInfoOrder.Add(infoOrder);
                }
            }
            return lstInfoOrder;
        }
        public static bool InfoOrder_Delete(string InfoOrderID)
        {
            object[] value = { InfoOrderID };
            SQLCommand connection = new SQLCommand(ConstValue.ConnectString);
            DataTable result = connection.Select("InfoOrder_Delete", value);

            if (connection.errorCode == 0 && connection.errorMessage == "")
            {
                return true;
            }
            return false;
        }
        public static bool InfoOrder_Update(InfoOrder infoOrder)
        {
            object[] value = { infoOrder.InfoOrderID, infoOrder.OrderID, infoOrder.Name,
                               infoOrder.Email, infoOrder.Phone,infoOrder. Address,
                               infoOrder.TotalPrice, infoOrder.Status };
            SQLCommand connection = new SQLCommand(ConstValue.ConnectString);
            DataTable result = connection.Select("InfoOrder_Update", value);

            if (connection.errorCode == 0 && connection.errorMessage == "")
            {
                return true;
            }
            return false;
        }
    }
}
