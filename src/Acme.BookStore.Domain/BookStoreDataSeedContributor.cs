using Acme.BookStore.Books;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Volo.Abp.Data;
using Volo.Abp.DependencyInjection;
using Volo.Abp.Domain.Repositories;

namespace Acme.BookStore
{
    public class BookStoreDataSeedContributor : IDataSeedContributor, ITransientDependency
    {
        private readonly IRepository<Book, Guid> _bookRepository;

        public BookStoreDataSeedContributor(IRepository<Book, Guid> bookRepository)
        {
            _bookRepository = bookRepository;
        }


        public async Task SeedAsync(DataSeedContext context)
        {
            var books = new List<Book>
                    {
                        new Book
                        {
                            Name = "The Stars Beyond",
                            Type = BookType.Fantasy,
                            PublishDate = new DateTime(2015, 7, 21),
                            Price = 19.99m
                        },
                        new Book
                        {
                            Name = "Understanding Quantum Physics",
                            Type = BookType.Science,
                            PublishDate = new DateTime(2020, 3, 15),
                            Price = 29.50m
                        },
                        new Book
                        {
                            Name = "The Rise and Fall of Empires",
                            Type = BookType.History,
                            PublishDate = new DateTime(2010, 11, 5),
                            Price = 24.00m
                        },
                        new Book
                        {
                            Name = "A Life Remembered",
                            Type = BookType.Biography,
                            PublishDate = new DateTime(2018, 6, 12),
                            Price = 17.75m
                        },
                        new Book
                        {
                            Name = "Whispers in the Shadows",
                            Type = BookType.Mystery,
                            PublishDate = new DateTime(2023, 9, 30),
                            Price = 21.30m
                        }
                    };

            if (await _bookRepository.GetCountAsync() <= 0)
            {
                await _bookRepository.InsertManyAsync(books, autoSave: true);
            }
        }
    }
}
