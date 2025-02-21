﻿using AIIVE.BookReview.Core.Data;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AIIVE.BookReview.Catalogo.Domain
{
    public interface IBookRepository : IRepository<Book>
    {
        Task<IEnumerable<Book>> GetBooks(string term);
        Task<Book> GetById(long id);
        Task<IEnumerable<Book>> GetBooksAsync(string term);
    }
}
