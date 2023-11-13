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
    public class BookTypeRes
    {
        public static List<BookType> GetAllType()
        {
            object[] value = { };
            SQLCommand connection = new SQLCommand(ConstValue.ConnectString);
            DataTable result = connection.Select("Book_GetAllType", value);
            List<BookType> lstResult = new List<BookType>();
            if (connection.errorCode == 0 && result.Rows.Count > 0)
            {
                foreach (DataRow dr in result.Rows)
                {
                    BookType bookType = new BookType();
                    bookType.BookTypeID = dr["BookTypeID"].ToString();
                    bookType.BookTypeName = dr["BookTypeName"].ToString();

                    lstResult.Add(bookType);
                }
            }
            return lstResult;
        }

        public static BookType BookTypeWithID(string ID)
        {
            object[] value = { ID};
            SQLCommand connection = new SQLCommand(ConstValue.ConnectString);
            DataTable result = connection.Select("Book_BookTypeWithID", value);
            if (connection.errorCode == 0 && result.Rows.Count > 0)
            {
                foreach (DataRow dr in result.Rows)
                {
                    BookType bookType = new BookType();
                    bookType.BookTypeID = dr["BookTypeID"].ToString();
                    bookType.BookTypeName = dr["BookTypeName"].ToString();
                    return bookType;
                }
            }
            return null;
        }

    }
}
