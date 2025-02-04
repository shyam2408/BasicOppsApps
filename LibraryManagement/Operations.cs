using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace LibraryManagement
{
    public class Operations
    {
        //creating list to store data
        List<UserDetails> users = new List<UserDetails>();
        List<BorrowDetails> borrows = new List<BorrowDetails>();
        List<BookDetails> books = new List<BookDetails>();
        UserDetails currentLoginedUser;
        BookDetails borrowbook;
        BorrowDetails currentBorrow;
        BorrowDetails lastBorrow = null;
        public void DefaultValue()
        {
            //Adding default values
            UserDetails user1 = new UserDetails("Ravichandran", "Male", DepartmentDetails.EEE, "9938388333", "ravi@gmail.com", 100);
            UserDetails user2 = new UserDetails("Priyadharshini", "Female", DepartmentDetails.CSE, "9944444455", "priya@gmail.com", 150);
            users.AddRange(new List<UserDetails>() { user1, user2 });



            BookDetails book1 = new BookDetails("BID1001", "C#", "Author1", AvailablityDetails.Issued);
            BookDetails book2 = new BookDetails("BID1002", "C#", "Author1", AvailablityDetails.Issued);
            BookDetails book3 = new BookDetails("BID1003", "C#", "Author1", AvailablityDetails.Issued);
            BookDetails book4 = new BookDetails("BID1004", "HTML", "Author2", AvailablityDetails.Available);
            BookDetails book5 = new BookDetails("BID1005", "HTML", "Author2", AvailablityDetails.Damaged);
            BookDetails book6 = new BookDetails("BID1006", "CSS", "Author1", AvailablityDetails.Available);
            BookDetails book7 = new BookDetails("BID1007", "CSS", "Author1", AvailablityDetails.Available);
            BookDetails book8 = new BookDetails("BID1008", "JS", "Author1", AvailablityDetails.Available);
            BookDetails book9 = new BookDetails("BID1009", "JS", "Author1", AvailablityDetails.Available);
            BookDetails book10 = new BookDetails("BID10010", "JS", "Author1", AvailablityDetails.Available);
            BookDetails book11 = new BookDetails("BID10011", "TS", "Author2", AvailablityDetails.Available);
            BookDetails book12 = new BookDetails("BID10012", "TS", "Author2", AvailablityDetails.Damaged);
            BookDetails book13 = new BookDetails("BID10013", "TS", "Author2", AvailablityDetails.Available);
            books.AddRange(new List<BookDetails>() { book1, book2, book3, book4, book5, book6, book7, book8, book9, book10, book11, book12, book13 });


            BorrowDetails borrow1 = new BorrowDetails("BID1001", "SF3001", new DateTime(2024, 09, 10), BookingStatus.Borrowed, 0);
            BorrowDetails borrow2 = new BorrowDetails("BID1002", "SF3001", new DateTime(2024, 09, 12), BookingStatus.Borrowed, 0);
            BorrowDetails borrow3 = new BorrowDetails("BID1003", "SF3001", new DateTime(2024, 08, 14), BookingStatus.Returned, 16);
            BorrowDetails borrow4 = new BorrowDetails("BID1004", "SF3001", new DateTime(2024, 09, 11), BookingStatus.Borrowed, 0);
            //orrowDetails borrow4 = new BorrowDetails("BID1004", "SF3002", new DateTime(2024, 09, 11), BookingStatus.Borrowed, 0);
            BorrowDetails borrow5 = new BorrowDetails("BID1005", "SF3002", new DateTime(2024, 07, 07), BookingStatus.Returned, 20);
            borrows.AddRange(new List<BorrowDetails>() { borrow1, borrow2, borrow3, borrow4, borrow5 });

        }

        public void MainMenu()
        {
            try
            {
                bool flag = true;
                do
                {
                    //showing or displaying Mainmenu to the user
                    Console.WriteLine("Enter the option\n1.Registration \n2.Login \n3.Exit");
                    int option = Convert.ToInt32(Console.ReadLine());
                    switch (option)
                    {
                        case 1:
                            {
                                Registration();
                                break;
                            }
                        case 2:
                            {
                                Login();
                                break;
                            }
                        case 3:
                            {
                                Console.WriteLine("EXIT the application");
                                flag = false;
                                break;
                            }
                    }
                } while (flag);
            }
            catch (Exception e)
            {
                Console.WriteLine($"error occurred {e.Message}");
            }

        }

        public void Registration()
        {
            try
            {
                //getting inputs from the user for registration process 
                Console.WriteLine("Enter your name :");
                string userName = Console.ReadLine();
                Console.WriteLine("Enter Gender :");
                string gender = Console.ReadLine();
                Console.WriteLine("Enter your department :");
                DepartmentDetails department = Enum.Parse<DepartmentDetails>(Console.ReadLine().ToUpper());
                Console.WriteLine("Enter your phone Number :");
                string mobileNumber = Console.ReadLine();
                Console.WriteLine("Enter your MailID :");
                string emailID = Console.ReadLine();
                Console.WriteLine("Enter your Wallet balance :");
                double walletBalance = Convert.ToInt64(Console.ReadLine());
                UserDetails user = new UserDetails(userName, gender, department, mobileNumber, emailID, walletBalance);
                users.Add(user);
                Console.WriteLine("Registration Successful your  " + user.UserID);
            }
            catch (Exception ei)
            {
                Console.WriteLine($"An Error occured {ei.Message}");
            }
        }

        public void Login()
        {
            try
            {
                Console.WriteLine("Enter your UserID :");
                string CurrentID = Console.ReadLine().ToUpper();
                bool falg = true;
                foreach (UserDetails user in users)
                {
                    if (user.UserID.Equals(CurrentID))
                    {
                        Console.WriteLine("User Logined successfully");
                        currentLoginedUser = user;
                        SubMenu();
                        falg = false;
                        break;
                    }
                }
                if (falg)
                {
                    Console.WriteLine("Invalid User");
                }
            }
            catch (Exception ei)
            {
                Console.WriteLine($"{ei.Message}");
            }
        }
        public void SubMenu()
        {
            try
            {
                bool flag = true;
                do
                {
                    Console.WriteLine("Enter your choice: \n1.Borrowbook \n2.showBorowedHistry \n3.Returnbooks \n4.Walletrecharge \n5.Exit");
                    int option = Convert.ToInt32(Console.ReadLine());
                    switch (option)
                    {
                        case 1:
                            {
                                BorrowBook();
                                break;
                            }
                        case 2:
                            {
                                BorrowedHistory();
                                break;
                            }
                        case 3:
                            {
                                Returnbooks();
                                break;
                            }
                        case 4:
                            {
                                WalletRecharge();
                                break;
                            }
                        case 5:
                            {
                                flag = false;
                                return;
                            }
                    }

                } while (flag);
            }
            catch (Exception ei)
            {
                Console.WriteLine(ei.Message);
            }
        }

        public void BorrowBook()
        {
            try
            {
                Console.WriteLine("Borrowing book");
                foreach (BookDetails book in books)
                {
                    if (book.Availablity.Equals(AvailablityDetails.Available))
                    {
                        Console.WriteLine($"{book.BookID,-15} | {book.BookName,-15} |");
                    }
                }
                Console.WriteLine("Enter the book you want to borrow :");
                string currentBookID = Console.ReadLine().ToUpper();
                bool flag = true;
                foreach (BookDetails book in books)
                {
                    //•	If the bookID is not available, then display “Invalid Book ID. Please enter the valid one”.
                    if (currentBookID.Equals(book.BookID) && book.Availablity.Equals(AvailablityDetails.Available))
                    {
                        flag = true;
                        Console.WriteLine("the book is available...");
                        borrowbook = book;
                        if (book.Availablity.Equals(AvailablityDetails.Issued))
                        {
                            //o	If a book is in an Issued status, then print the next available date of a book by retrieving its Borrowed Date from the borrowed history and 
                            //adding 15 days to it.Show “The book will be available on {borrowed date + 15 days}”. 
                            foreach (BorrowDetails borrow in borrows)
                            {
                                if (book.BookID.Equals(borrow.BookID))
                                {
                                    lastBorrow = borrow;
                                }
                            }

                            if (lastBorrow != null)
                            {
                                DateTime dateTime = lastBorrow.BorrowDate.AddDays(15);
                            }
                        }
                        break;
                    }
                }
                if (!flag)
                {
                    Console.WriteLine("Invalid userID");
                }
                int userCount = 0;
                foreach (BorrowDetails borrow1 in borrows)
                {
                    if (currentLoginedUser.UserID.Equals(borrow1.UserID))
                    {
                        userCount += 1;
                    }
                }
                if (userCount >= 3)
                {
                    Console.WriteLine("you have already taken three books");
                }
                else
                {
                    BorrowDetails borrow3 = new(currentBookID, currentLoginedUser.UserID, DateTime.Now, BookingStatus.Borrowed, 0);
                    Console.WriteLine("book borrowed successfully " + borrow3.BookID);
                }


            }
            catch (Exception m)
            {
                Console.WriteLine("Error Occured" + (m.Message));
            }



        }
        public void BorrowedHistory()
        {
            Console.WriteLine("borrowing history");
            foreach (BorrowDetails borrow in borrows)
            {
                //showing borrow history to the user by checking 
                //current looged customerid with borrowdatails custmeerid
                if (borrow.UserID.Equals(currentLoginedUser.UserID))
                {
                    Console.WriteLine($"|{borrow.BookID,-15} |{borrow.BorrowID,-15}| {borrow.BorrowDate,-15} |{borrow.Status,-15} |{borrow.PaidFineAmount,-15}|");
                }
            }
        }
        public void Returnbooks()
        {
            Console.WriteLine("Returning Books");
            //show the borrowed book details of the current user
            bool flag = false;
            foreach (BorrowDetails borrow in borrows)
            {
                //showing borrow history to the user by checking 
                //current looged customerid with borrowdatails custmeerid
                if (borrow.UserID.Equals(currentLoginedUser.UserID))
                {
                    Console.WriteLine($"|{borrow.BorrowID,-15} |{borrow.BookID,-15}| {borrow.BorrowDate,-15} |{borrow.Status,-15} |{borrow.PaidFineAmount,-15}|");
                    flag = true;
                }
            }
            if (!flag)
            {
                Console.WriteLine("No books borrowed");
            }
            /*Ask and get the user to select the BorrowID to return the book.*/
            Console.WriteLine("Enter the borrowID to return :");
            string returnBorrowID = Console.ReadLine().ToUpper();
            bool secondFlag = true;
            //alidate that ID, by traversing users borrow list. 	
            // the user given BorrowID is invalid, then show “Invalid BorrowID, please enter the valid one”.

            foreach (BorrowDetails borrow in borrows)
            {
                if (returnBorrowID.Equals(borrow.BorrowID) && borrow.UserID.Equals(currentLoginedUser.UserID))
                {
                    secondFlag =false;
                    currentBorrow = borrow;
                    break;
                }
            }
            if (secondFlag)
            {
                Console.WriteLine("plz enter the valid userID");
            }

            DateTime dueDate = currentBorrow.BorrowDate.AddDays(15);
            DateTime returnDate = currentBorrow.BorrowDate;

            int totalDays = (dueDate > returnDate) ? (dueDate - returnDate).Days : 0;

            double fine = totalDays * 1;
            //rowID is valid then, check the return date (15 days from borrow date), 
            //f the date has elapsed, then calculate and show the fine amount (Rs. 1 / per day) for each book.

            //ck the book's condition, if its status is Damaged, add fine Rs. 300.
            int Damage1 = currentBorrow.Status.Equals(AvailablityDetails.Damaged) ? 300 : 0;
            ///alculate total fine amount = Damage +Late fine.
            double totalfine = fine + Damage1;

            //hen check whether the user has sufficient balance for the fine amount.
            if (currentLoginedUser.Wallet < totalfine)
            {
                Console.WriteLine("plz recharge to proceed furthur");
            }
            currentLoginedUser.DeductBalance(totalfine);
            currentBorrow.PaidFineAmount = totalfine;
            currentBorrow.Status = BookingStatus.Returned;
            Console.WriteLine("book returned successfully");
            //f user has insufficient balance, then show “Insufficient balance. Please recharge and proceed”.*/

        }
        public void WalletRecharge()
        {
            System.Console.WriteLine("Wallet Recharge.......");
            Console.WriteLine("Enter amount to recharge:");
            double amount = Convert.ToInt64(Console.ReadLine());
            if (amount > 0)
            {
                currentLoginedUser.Recharge(amount);
            }
            else
            {
                Console.WriteLine("Insufficient balance");
            }
        }
    }
}
