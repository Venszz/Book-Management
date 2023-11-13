using CAIT.SQLHelper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using WebStore.Models;
using WedStore.Const;

namespace WedStore.Repositories
{
    public class OrderItemRes
    {
        public static bool createOrderItem(OrderItem orderItem)// tạo đơn hàng mới
        {
            object[] value = { orderItem.ItemID, orderItem.OrderID, orderItem.BookID, 
                               orderItem.Quantity, orderItem.TotalPrice, orderItem.Discount };
            SQLCommand connection = new SQLCommand(ConstValue.ConnectString);
            DataTable result = connection.Select("OrderItem_Create", value);

            if (connection.errorCode == 0 && connection.errorMessage == "")
            {
                return true;
            }
            return false;
        }
        public static bool updateOrderItem(OrderItem orderItem)
        {
            object[] value = { orderItem.ItemID, orderItem.OrderID, orderItem.BookID,
                               orderItem.Quantity, orderItem.TotalPrice, orderItem.Discount };
            SQLCommand connection = new SQLCommand(ConstValue.ConnectString);
            DataTable result = connection.Select("OrderItem_Update", value);

            if (connection.errorCode == 0 && connection.errorMessage == "")
            {
                return true;
            }
            return false;
        }
        public static bool deleteOrderItem(string ID)
        {
            object[] value = { ID };
            SQLCommand connection = new SQLCommand(ConstValue.ConnectString);
            DataTable result = connection.Select("OrderItem_Delete", value);

            if (connection.errorCode == 0 && connection.errorMessage == "")
            {
                return true;
            }
            return false;
        }

        public static OrderItem GetOrderItemWithID(string ID)// tạo đơn hàng mới
        {
            object[] value = { ID };
            SQLCommand connection = new SQLCommand(ConstValue.ConnectString);
            DataTable result = connection.Select("OrderItem_GetOrderItemWithID", value);

            if (connection.errorCode == 0 && connection.errorMessage == "")
            {
                foreach (DataRow dr in result.Rows)
                {
                    OrderItem orderItem = new OrderItem();
                    orderItem.ItemID = dr["ItemID"].ToString();
                    orderItem.OrderID = dr["OrderID"].ToString();
                    orderItem.BookID = dr["BookID"].ToString();
                    orderItem.Quantity = string.IsNullOrEmpty(dr["Quantity"].ToString()) ? 0 : int.Parse(dr["Quantity"].ToString());
                    orderItem.TotalPrice = string.IsNullOrEmpty(dr["TotalPrice"].ToString()) ? 0 : int.Parse(dr["TotalPrice"].ToString());
                    orderItem.Discount = string.IsNullOrEmpty(dr["Discount"].ToString()) ? 0 : int.Parse(dr["Discount"].ToString());
                    return orderItem;
                }
            }
            return null;
        }
        public static OrderItem GetOrderItemWithOrderIDBookID(string OrderID, string BookID)// tạo đơn hàng mới
        {
            object[] value = { OrderID, BookID };
            SQLCommand connection = new SQLCommand(ConstValue.ConnectString);
            DataTable result = connection.Select("OrderItem_GetOrderItemWithOrderIDBookID", value);

            if (connection.errorCode == 0 && connection.errorMessage == "")
            {
                foreach (DataRow dr in result.Rows)
                {
                    OrderItem orderItem = new OrderItem();
                    orderItem.ItemID = dr["ItemID"].ToString();
                    orderItem.OrderID = dr["OrderID"].ToString();
                    orderItem.BookID = dr["BookID"].ToString();
                    orderItem.Quantity = string.IsNullOrEmpty(dr["Quantity"].ToString()) ? 0 : int.Parse(dr["Quantity"].ToString());
                    orderItem.TotalPrice = string.IsNullOrEmpty(dr["TotalPrice"].ToString()) ? 0 : int.Parse(dr["TotalPrice"].ToString());
                    orderItem.Discount = string.IsNullOrEmpty(dr["Discount"].ToString()) ? 0 : int.Parse(dr["Discount"].ToString());
                    return orderItem;
                }
            }
            return null;
        }
        public static List<OrderItem> GetOrderItemsWithOrderID(string OrderID)
        {
            object[] value = { OrderID };
            SQLCommand connection = new SQLCommand(ConstValue.ConnectString);
            DataTable result = connection.Select("OrderItem_GetOrderItemWithOrderID", value);
            List<OrderItem> lstResult = new List<OrderItem>();
            if (connection.errorCode == 0 && connection.errorMessage == "")
            {
                foreach (DataRow dr in result.Rows)
                {
                    OrderItem orderItem = new OrderItem();
                    orderItem.ItemID = dr["ItemID"].ToString();
                    orderItem.OrderID = dr["OrderID"].ToString();
                    orderItem.BookID = dr["BookID"].ToString();
                    orderItem.Quantity = string.IsNullOrEmpty(dr["Quantity"].ToString()) ? 0 : int.Parse(dr["Quantity"].ToString());
                    orderItem.TotalPrice = string.IsNullOrEmpty(dr["TotalPrice"].ToString()) ? 0 : int.Parse(dr["TotalPrice"].ToString());
                    orderItem.Discount = string.IsNullOrEmpty(dr["Discount"].ToString()) ? 0 : int.Parse(dr["Discount"].ToString());
                    lstResult.Add(orderItem);
                }
            }
            return lstResult;
        }
    }
}
