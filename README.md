# HospitalManagement





@Bean
    CommandLineRunner initBookData(BookRepository bookRepository, CategoryRepository categoryRepository) {
        return args -> {
            if (bookRepository.count() == 0) {
                bookRepository.save(createSampleBook("B001", "Clean Code", "Robert C. Martin", 2008, "Pearson", 10, "https://example.com/image1.jpg", 1, categoryRepository));
                bookRepository.save(createSampleBook("B002", "Effective Java", "Joshua Bloch", 2018, "Addison-Wesley", 5, "https://example.com/image2.jpg", 1, categoryRepository));
                bookRepository.save(createSampleBook("B003", "Spring in Action", "Craig Walls", 2020, "Manning", 7, "/uploads/books/Elaina_4.jpg", 1, categoryRepository));
                bookRepository.save(createSampleBook("B004", "Java Concurrency in Practice", "Brian Goetz", 2006, "Addison-Wesley", 3, "/uploads/books/OIP.webp", 1, categoryRepository));

                System.out.println("✅ Dữ liệu mẫu sách đã được thêm vào cơ sở dữ liệu.");
            }
        };
    }
    private Books createSampleBook(String id, String title, String author, int year, String publisher, int quantity, String imageUrl, int categoryId, CategoryRepository categoryRepository) {
        Books book = new Books();
        book.setBookId(id);
        book.setBookTitle(title);
        book.setAuthor(author);
        book.setPublicationYear(year);
        book.setNxb(publisher);
        book.setQuantity(quantity);
        book.setImageUrl(imageUrl);

        // Lấy Category từ DB
        Category category = categoryRepository.getReferenceById(categoryId);
        book.setCategory(category);

        return book;
    }
}
