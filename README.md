# Car Rental System 🚗

## Project Description

The Car Rental System is a comprehensive platform developed using **C#** and **Windows Forms (WinForms)**, designed for efficient management of vehicle rental processes. This system aims to streamline the daily operations of rental companies, from managing the vehicle fleet and tracking customers and reservations to handling financial transactions.

At its core, the system leverages a **SQL database**, ensuring reliable, secure, and efficient data handling for all operations.

## Key Features ✨

* **Vehicle Fleet Management:**
    * ➕ Add, ✏️ edit, and 🗑️ delete vehicle details (make, model, year, license plate, availability status).
    * 👁️‍🗨️ Track vehicle status (rented, available, under maintenance/repair).
* **Customer Management:**
    * 📝 Register and manage customer information (name, ID, contact details).
    * 📜 View historical rental data for each customer.
* **Reservation & Rental Management:**
    * 📅 Create and manage new reservations.
    * 🗓️ Record pickup and return dates.
    * 💰 Calculate rental costs.
    * 📊 Monitor rental status (open, closed, overdue).
* **Account & Transaction Handling:**
    * 💵 Record payments.
    * 🧾 Generate basic invoices.
* **User-Friendly Interface:**
    * 🖥️ Intuitive Graphical User Interface (GUI) developed with WinForms, ensuring easy and convenient operation for users.

## Technologies Used 🛠️

* **Programming Language:** C#
* **Development Environment:** Windows Forms (WinForms)
* **Database:** SQL Server (or any compatible SQL database)
* **Version Control:** Git & GitHub

## System Requirements (for local execution) 💻

* **Operating System:** Windows 7/8/10/11
* **.NET Framework:** Version 4.x (or .NET Core / .NET 5+ depending on the specific project version)
* **SQL Server:** Installed and running (or SQL Server Express/LocalDB for development purposes).

## How to Run the Project (Developer Guide) 🚀

1.  **Clone the Repository:**
    Open your command prompt (CMD/PowerShell) or Git Bash and navigate to your desired directory:
    ```bash
    git clone [https://github.com/HodayaMoyal/Set-Car-C-Sharp.git](https://github.com/HodayaMoyal/Set-Car-C-Sharp.git)
    ```
    (Please ensure this is the correct link to your GitHub repository.)

2.  **Database Setup:**
    * Create a new database in SQL Server.
    * Execute the necessary table creation scripts (e.g., for `Cars`, `Customers`, `Rentals`). If you have SQL scripts for schema creation (like `SQLQuery1.sql`), run them on your new database.
    * Update the **Connection String** in your project's source code (typically in `App.config` or directly in code) to point to your newly created database.

3.  **Open in IDE:**
    * Open the project in Visual Studio (or any C#/WinForms-compatible IDE). The `.sln` (solution) file is the entry point.

4.  **Build the Project:**
    * Build the solution in Visual Studio (Build > Build Solution).

5.  **Run the Project:**
    * Execute the project from within Visual Studio (Start Debugging or `F5`).

## Project Outcomes and Achievements 🏆

The development of the Car Rental System project showcases significant capabilities in:

* **Desktop Application Development:** Creating interactive and user-friendly interfaces using Windows Forms.
* **Database Integration:** Proficient data management using SQL, including efficient query execution, updates, deletions, and insertions.
* **Software Architecture:** Implementation of Object-Oriented Programming (OOP) principles and a modular architecture, facilitating future maintenance and extensibility.
* **Business Problem Solving:** Addressing a specific business need for car rental company management, enhancing operational efficiency, and reducing human errors.
* **Full Lifecycle Development:** Practical experience in end-to-end project development, from planning to implementation and testing.

---

## Contributions 🤝

Pull Requests are welcome! If you wish to contribute to this project, please follow these steps:

1.  Fork this repository.
2.  Create your feature branch (`git checkout -b feature/AmazingFeature`).
3.  Commit your changes (`git commit -m 'Add some AmazingFeature'`).
4.  Push to the branch (`git push origin feature/AmazingFeature`).
5.  Open a Pull Request.

---

## License 📜

This project is licensed under the MIT License - see the [LICENSE](LICENSE) file for more details.

---

**© 2025 HodayaMoyal.** All rights reserved.
