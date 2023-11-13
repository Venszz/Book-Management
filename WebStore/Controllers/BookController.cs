using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Threading.Tasks;
using WebStore.Models;
using WedStore.Repositories;

namespace WedStore.Controllers
{

    
    public class BookController : Controller
    {
        // GET: BookController
        public ActionResult Index(int page)
        {
            if (page == null || page < 1)
            {
                page = 1;
            }
            //
            var lstBook = BookRes.GetAll();
            var lstBookType = BookTypeRes.GetAllType();
            //
            List<Book> books = new List<Book>();
            int i;
            int bookPerPage = 6;
            for (i = (page - 1) * bookPerPage; i < page * bookPerPage; i++)
            {
                if (lstBook.Count == i)
                {
                    break;
                }
                books.Add(lstBook[i]);
            }
            int MaxPage = lstBook.Count / bookPerPage;
            int tmp = lstBook.Count % bookPerPage;// so du
            if (tmp >= 1) MaxPage += 1;

            //
            dynamic dy = new ExpandoObject();
            dy.book = books;
            dy.booktypeNAV = lstBookType;
            //
            dy.maxpage = MaxPage;
            dy.currentpage = page;
            return View(dy);
        }
        
        public ActionResult BookType(string ID,int page)
        {
            if(page == null || page<1)
            {
                page = 1;
            }
            //
            var lstBookTypeList = BookTypeRes.GetAllType();
            var lstBook = BookRes.GetTypeList(ID);//danh sách sản phẩm theo book type
            // lấy 6 sản phẩm trong danh sách
            List<Book> books = new List<Book>();
            int i;
            int bookPerPage = 6;
            for (i =(page-1)*bookPerPage ; i < page*bookPerPage; i++)
            {
                if(lstBook.Count == i)
                {
                    break;
                }
                books.Add(lstBook[i]);
            }
            var BookType = BookTypeRes.BookTypeWithID(ID);

            //chia so luong
            int MaxPage = lstBook.Count / bookPerPage ;
            int tmp = lstBook.Count % bookPerPage;// so du
            if (tmp >= 1) MaxPage += 1;

            dynamic dy = new ExpandoObject();
            dy.booktypeNAV = lstBookTypeList;
            dy.booktypelist = books;
            dy.booktype = BookType;
            dy.maxpage = MaxPage;
            dy.currentpage = page;
            return View(dy);
        }
        // GET: BookController/Details/id
        public ActionResult Details(string id)
        {

            var book = BookRes.BookWithID(id);
            dynamic dy = new ExpandoObject();
            dy.booktypeNAV = BookTypeRes.GetAllType();
            dy.bookdetail = BookRes.BookWithID(id);
            var lstBookWithType = BookRes.GetAll();
            List<Book> lstBook = new List<Book>();
            int tr = 0;
            var it = lstBookWithType.Single(r => r.BookID == book.BookID);
            if (lstBookWithType.Remove(it)) { 
                tr = 1;
            }

            Random rnd = new Random();
            for (int i = 1; i <= 3; i++) 
            {
                int random = rnd.Next(lstBookWithType.Count);
                int j = 0;
                foreach (var item in lstBookWithType)
                {
                    if(j == random)
                    {
                        lstBook.Add(item);
                        lstBookWithType.Remove(item);
                        break;
                    }
                    j++;
                }
            }
            dy.lstBook = lstBook;

            return View(dy);
        }


    }
}
