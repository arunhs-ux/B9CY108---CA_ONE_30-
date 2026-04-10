# 📘 B9CY108

## Continuous Assessment 1 (30%)

---

## 📌 Project Overview

This project demonstrates the implementation of advanced programming concepts using **C# and Python**. It consists of four tasks covering key areas of software development including:

* Object-Oriented Programming (OOP)
* Data Structures (Queue, Dictionary)
* Client-Server Communication (TCP)
* Database Integration (SQLite)
* Web Scraping and Data Storage (CSV)

Each task simulates a real-world scenario and showcases practical problem-solving skills.

---

## 🧱 Project Structure

```
B9CY108_Assignment/
│
├── Task1_Churros_CSharp/
│   ├── Churros.cs
│   ├── Order.cs
│   ├── Program.cs
│   └── screenshots/
│
├── Task2_PeriodicTable_CSharp/
│   ├── Program.cs
│   └── screenshots/
│
├── Task3_ClientServer_Python/
│   ├── Que3_server.py
│   ├── Que3_client.py
│   ├── users.db
│   └── screenshots/
│
├── Task4_WebScraping_Python/
│   ├── Que4.py
│   ├── books.csv
│   └── screenshots/
│
├── Report.pdf
└── github_link.txt
```

---

## 🔹 Task 1 – Churros Ordering System (C#)

### 📖 Description

A menu-driven console application simulating a food truck ordering system where customers place orders, make payments, and receive an order number. Orders are processed using a queue.

### ⚙️ Key Features

* Menu-driven system
* Order placement and delivery
* Bill calculation
* Queue-based order processing (FIFO)

### 🧠 Concepts Used

* Classes & Objects
* Encapsulation
* Constructors
* Queue Data Structure

### ▶️ How to Run

```bash
cd Task1_Churros_CSharp
dotnet new console -n ChurrosApp
mv *.cs ChurrosApp/
cd ChurrosApp
dotnet run
```

---

## 🔹 Task 2 – Periodic Table System (C#)

### 📖 Description

A console application that stores and retrieves information about the first 30 elements of the periodic table based on atomic number input.

### ⚙️ Key Features

* Fast lookup using Dictionary
* Displays element name and classification
* User interaction loop

### 🧠 Concepts Used

* Dictionary Data Structure
* Efficient lookup (O(1))
* Input validation

### ▶️ How to Run

```bash
cd Task2_PeriodicTable_CSharp
dotnet new console -n PeriodicApp
mv Program.cs PeriodicApp/
cd PeriodicApp
dotnet run
```

---

## 🔹 Task 3 – Client-Server Application (Python)

### 📖 Description

A TCP-based client-server application where users register by submitting personal details. The server stores the data in a SQLite database and returns a unique registration ID.

### ⚙️ Key Features

* Client collects user input
* Server processes and stores data
* SQLite database integration
* Unique ID generation using UUID

### 🧠 Concepts Used

* Socket Programming (TCP)
* Database Persistence
* Real-time communication

### ▶️ How to Run

#### Start Server (Terminal 1)

```bash
cd Task3_ClientServer_Python
python3 Que3_server.py
```

#### Run Client (Terminal 2)

```bash
python3 Que3_client.py
```

#### Check Database

```bash
sqlite3 users.db
SELECT * FROM users;
```

---

## 🔹 Task 4 – Web Scraping Application (Python)

### 📖 Description

A Python program that extracts book data (title, price, rating) from an online source and stores it in a CSV file.

### ⚙️ Key Features

* Web scraping using BeautifulSoup
* Data stored in CSV format
* Display of extracted data in terminal

### 🧠 Concepts Used

* Web Scraping
* File Handling (CSV)
* External data extraction

### ▶️ How to Run

```bash
cd Task4_WebScraping_Python
pip3 install requests beautifulsoup4
python3 Que4.py
```

---

## 📊 Technologies Used

* **C# (.NET SDK)**
* **Python 3**
* **SQLite**
* **BeautifulSoup**
* **Git & GitHub**

---

## 📸 Screenshots

Screenshots demonstrating execution and outputs are included in each task folder:

* Task 1 → Order system execution
* Task 2 → Element lookup
* Task 3 → Client-server communication and database
* Task 4 → Web scraping output and CSV

---

## 🔗 GitHub Repository

```
https://github.com/arunhs-ux/B9CY108---CA_ONE_30-
```

---

## ✅ Key Learning Outcomes

* Applied Object-Oriented Programming principles
* Used efficient data structures for problem-solving
* Built a TCP-based client-server system
* Integrated SQLite database for persistent storage
* Extracted and processed real-world web data
---

## 🚀 Conclusion

This project demonstrates a strong understanding of advanced programming techniques and the ability to integrate multiple technologies into practical solutions. It highlights real-world application development skills and efficient problem-solving approaches.

---
