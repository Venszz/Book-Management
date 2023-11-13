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
    public class BookRes
    {
        public static List<Book> GetAll()
        {
            object[] value = { };
            SQLCommand connection = new SQLCommand(ConstValue.ConnectString);
            DataTable result = connection.Select("Book_GetAll", value);
            List<Book> lstResult = new List<Book>();
            if (connection.errorCode == 0 && result.Rows.Count > 0)
            {
                foreach (DataRow dr in result.Rows)
                {
                    Book book = new Book();
                    book.BookID = dr["BookID"].ToString();
                    book.BookName = dr["BookName"].ToString();
                    book.BookTypeID = dr["BookTypeID"].ToString();
                    book.Author = dr["Author"].ToString();
                    book.Nxb = dr["Nxb"].ToString();
                    book.Description = dr["Description"].ToString();
                    book.Image = dr["Image"].ToString();

                    book.Price = string.IsNullOrEmpty(dr["Price"].ToString()) ? 0 : int.Parse(dr["Price"].ToString());
                    book.Quantity = string.IsNullOrEmpty(dr["Quantity"].ToString()) ? 0 : int.Parse(dr["Quantity"].ToString());
                    book.OrderedQuantity = string.IsNullOrEmpty(dr["OrderedQuantity"].ToString()) ? 0 : int.Parse(dr["OrderedQuantity"].ToString());

                    lstResult.Add(book);
                }
            }
            return lstResult;
        }
        public static List<Book> GetBookWithSelling()
        {
            object[] value = { };
            SQLCommand connection = new SQLCommand(ConstValue.ConnectString);
            DataTable result = connection.Select("Book_BookWithSelling", value);
            List<Book> lstResult = new List<Book>();
            if (connection.errorCode == 0 && result.Rows.Count > 0)
            {
                foreach (DataRow dr in result.Rows)
                {
                    Book book = new Book();
                    book.BookID = dr["BookID"].ToString();
                    book.BookName = dr["BookName"].ToString();
                    book.BookTypeID = dr["BookTypeID"].ToString();
                    book.Author = dr["Author"].ToString();
                    book.Nxb = dr["Nxb"].ToString();
                    book.Description = dr["Description"].ToString();
                    book.Image = dr["Image"].ToString();

                    book.Price = string.IsNullOrEmpty(dr["Price"].ToString()) ? 0 : int.Parse(dr["Price"].ToString());
                    book.Quantity = string.IsNullOrEmpty(dr["Quantity"].ToString()) ? 0 : int.Parse(dr["Quantity"].ToString());
                    book.OrderedQuantity = string.IsNullOrEmpty(dr["OrderedQuantity"].ToString()) ? 0 : int.Parse(dr["OrderedQuantity"].ToString());

                    lstResult.Add(book);
                }
            }
            return lstResult;
        }

        public static List<Book> GetTypeList(string ID)//type ID
        {
            object[] value = { ID };
            SQLCommand connection = new SQLCommand(ConstValue.ConnectString);
            DataTable result = connection.Select("Book_GetTypeList", value);
            List<Book> lstResult = new List<Book>();
            if (connection.errorCode == 0 && result.Rows.Count > 0)
            {
                foreach (DataRow dr in result.Rows)
                {
                    Book book = new Book();
                    book.BookID = dr["BookID"].ToString();
                    book.BookName = dr["BookName"].ToString();
                    book.BookTypeID = dr["BookTypeID"].ToString();
                    book.Author = dr["Author"].ToString();
                    book.Nxb = dr["Nxb"].ToString();
                    book.Description = dr["Description"].ToString();
                    book.Image = dr["Image"].ToString();

                    book.Price = string.IsNullOrEmpty(dr["Price"].ToString()) ? 0 : int.Parse(dr["Price"].ToString());
                    book.Quantity = string.IsNullOrEmpty(dr["Quantity"].ToString()) ? 0 : int.Parse(dr["Quantity"].ToString());
                    book.OrderedQuantity = string.IsNullOrEmpty(dr["OrderedQuantity"].ToString()) ? 0 : int.Parse(dr["OrderedQuantity"].ToString());

                    lstResult.Add(book);
                }
            }
            return lstResult;
        }
        public static Book BookWithID(string ID)//type ID
        {
            object[] value = { ID };
            SQLCommand connection = new SQLCommand(ConstValue.ConnectString);
            DataTable result = connection.Select("Book_BookWithID", value);
            //List<Book> lstResult = new List<Book>();
            if (connection.errorCode == 0 && result.Rows.Count > 0)
            {
                foreach (DataRow dr in result.Rows)
                {
                    Book book = new Book();
                    book.BookID = dr["BookID"].ToString();
                    book.BookName = dr["BookName"].ToString();
                    book.BookTypeID = dr["BookTypeID"].ToString();
                    book.Author = dr["Author"].ToString();
                    book.Nxb = dr["Nxb"].ToString();
                    book.Description = dr["Description"].ToString();
                    book.Image = dr["Image"].ToString();

                    book.Price = string.IsNullOrEmpty(dr["Price"].ToString()) ? 0 : int.Parse(dr["Price"].ToString());
                    book.Quantity = string.IsNullOrEmpty(dr["Quantity"].ToString()) ? 0 : int.Parse(dr["Quantity"].ToString());
                    book.OrderedQuantity = string.IsNullOrEmpty(dr["OrderedQuantity"].ToString()) ? 0 : int.Parse(dr["OrderedQuantity"].ToString());
                    return book;
                    //lstResult.Add(book);
                }
            }
            return null;
        }
        public static int Book_Count()
        {
            return GetAll().Count;
        }
        public static bool Book_CreateBook(Book book)
        {
            object[] value = { book.BookID,book.BookName, book.BookTypeID, book.Author, book.Nxb, book.Description, book.Image, book.Price, book.Quantity, book.OrderedQuantity };
            SQLCommand connection = new SQLCommand(ConstValue.ConnectString);
            DataTable result = connection.Select("Book_CreateBook", value);

            if (connection.errorCode == 0 && connection.errorMessage == "")
            {
                return true;
            }
            return false;
        }
        public static bool Book_Update(Book book)
        {
            object[] value = { book.BookID, book.BookName, book.BookTypeID, book.Author, book.Nxb, book.Description, book.Image, book.Price, book.Quantity, book.OrderedQuantity };
            SQLCommand connection = new SQLCommand(ConstValue.ConnectString);
            DataTable result = connection.Select("Book_Update", value);

            if (connection.errorCode == 0 && connection.errorMessage == "")
            {
                return true;
            }
            return false;
        }
        public static bool Book_Delete(string ID)
        {
            object[] value = { ID };
            SQLCommand connection = new SQLCommand(ConstValue.ConnectString);
            DataTable result = connection.Select("Book_Delete", value);

            if (connection.errorCode == 0 && connection.errorMessage == "")
            {
                return true;
            }
            return false;
        }
    }
}
