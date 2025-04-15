using PBL_Tan.DTO;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBL_Tan.DAL
{
    class DAL_Book
    {
        #region khoi tao
        private static DAL_Book instance;

        internal static DAL_Book Instance {
            get
            {
                if (instance == null)
                {
                    instance = new DAL_Book();
                }
                return instance;
            } 
            set => instance = value; }
        private DAL_Book() { }
        #endregion

        #region filePath
        private string filePath = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName + @"\PBL_Tan\Data\Book.csv";
        #endregion
        List<Book> books = new List<Book>();
        public List<Book> getBook()
        {
            try
            {
                books.Clear();
                List<string[]> data = DataProvider.Instance.ReadCsv(filePath);
                if (data.Count == 0)
                {
                    System.Diagnostics.Debug.WriteLine("Không có dữ liệu trong file CSV.");
                }
                foreach (var row in data)
                {
                    if (row.Length == 6)
                    {
                        books.Add(new Book(row[0], row[1], row[2], row[3], row[4]));
                    }
                    else
                    {
                        System.Diagnostics.Debug.WriteLine($"Dòng không đủ cột: {string.Join(",", row)}");
                    }
                }
                System.Diagnostics.Debug.WriteLine($"Tổng số khách hàng: {books.Count}");
                return books;
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine($"Lỗi đọc CSV: {ex.Message}");
                throw new Exception($"Lỗi khi đọc dữ liệu khách hàng: {ex.Message}");
            }
        }
    }
}
