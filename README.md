# Library Management System (Professional 3-Tier Architecture) 📚

A comprehensive Windows Desktop application built with **C#** and **SQL Server**. This project showcases advanced software engineering principles, focusing on high-performance data access and a scalable class hierarchy.

---

## 🏗️ Architectural Overview
The project follows the **3-Tier Architecture** pattern to ensure a clean separation of concerns:

* **LibraryPL (Presentation Layer):** Responsive WinForms UI for seamless user interaction.
* **LibraryBL (Business Logic Layer):** Implements core business rules, entity relationships, and data validation (The engine of the application).
* **LibraryDAL (Data Access Layer):** Direct communication with SQL Server using optimized **ADO.NET** for maximum performance.

---

## 🧬 Advanced OOP Implementation
The system is built on a sophisticated and reusable class hierarchy:

### 👤 The Person Hierarchy
The project utilizes an **Abstract Base Class** `clsPerson` to centralize common attributes (Name, Contact, Gender), which is inherited by:
* **`clsEmployee`**: Features a **Bitwise Permission System**, salary tracking, and authentication.
* **`clsUser`**: Handles library memberships and card management.
* **`clsAuthor`**: Manages biographical data linked to the book catalog.

### 📖 Book & Inventory Logic
* **`clsBook` vs `clsBookCopies`**: A smart separation between book metadata (ISBN/Title) and physical inventory tracking (Availability/Status).
* **`clsBorrowingRecord`**: Orchestrates the loan lifecycle, including due-date calculations.
* **`clsFine`**: Automatic penalty calculation logic based on overdue days.

---

## 🛠️ Tech Stack & Tools
| Technology | Usage |
| :--- | :--- |
| **C# (.NET)** | Core Programming Language |
| **SQL Server** | Relational Database Management |
| **ADO.NET** | High-performance Data Access (Manual Mapping) |
| **OOP** | Inheritance, Abstraction, Polymorphism, Encapsulation |

---

## ✨ Key Technical Features
* **Bitwise Permissions:** Efficient access control for employees (e.g., `pBook`, `pBorrowing`, `pFines`).
* **Mode-Based State Management:** Entities track their state (`AddMode` vs `UpdateMode`) for intelligent `Save()` operations.
* **Manual SQL Control:** Leveraging ADO.NET and Stored Procedures for optimized database performance over standard ORMs.
* **Nullable Logic:** Proper handling of optional data like `ActualReturnDate` using `Nullable<DateTime>`.

---

## 📂 Project Structure
* 📁 **LibraryPL**: Windows Forms and UI components.
* 📁 **LibraryBL**: Business entities and logic (The heart of the app).
* 📁 **LibraryDAL**: SQL commands and database connection management.
* 📁 **Database**: Contains `LibraryDB.sql` for table and stored procedure creation.

---

## 🚀 Installation & Setup
1.  **Clone the repo:** `git clone https://github.com/YourUsername/Library-Management-System-3Tier.git`
2.  **Database:** Run the `LibraryDB.sql` script in your SQL Server Management Studio (SSMS).
3.  **Config:** Update the `ConnectionString` in the `App.config` or DAL layer.
4.  **Run:** Open the `.sln` file in Visual Studio and press **F5**.

---

## 🚧 Roadmap (Upcoming Features)
- [ ] **Advanced Dashboard:** Visual analytics for library statistics (Books, Active Borrows, Fines).
- [ ] **Email Notifications:** Automatic reminders for overdue books.
- [ ] **Exporting Reports:** Export data to Excel or PDF.

---
**Developed by [Hasan Ameen Hasan AL-fahd]** *Passionate about Clean Code and Scalable Software Architecture.*
