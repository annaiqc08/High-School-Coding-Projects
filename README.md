# High-School-Coding-Projects
Archive of **13 high school programming projects** built in Visual Basic .NET and C++, showcasing progression from foundational console algorithms to multi-form event-driven desktop applications and relational database systems.

*Note: These projects were originally developed during my high school studies in Guatemala, so variable names, comments, and UI prompts within the source code are written in Spanish.*

---

## Featured Database & Enterprise Systems (Visual Basic .NET + Microsoft Access)

### 1. [National Election & Voting Management System](./Election-Voting-Database-VB) (`Election-Voting-Database-VB`)
* **Language:** Visual Basic .NET & Relational Database (`TSEDataSet`)
* **Description:** A 10-form capstone election administration suite managing 9 interconnected database tables—voters (`Padron`), candidates, political parties, public offices, departments, municipalities, system users, and vote tallies.
* **Key Programming Concepts Demonstrated:**
  * Relational multi-table database architecture using `DataSet` and typed `TableAdapter` queries (`Insert`, `Update`, `Delete`, `FillBy`).
  * Database-backed user authentication (`Ingreso`) with **role-based access control** (`Verificador` vs. full administrator privileges).
  * Full CRUD operations and record navigation (`MoveFirst`, `MovePrevious`, `MoveNext`, `MoveLast`) across 9 entity management forms.
  * Centralized `MenuStrip` navigation linking all administrative modules.

### 2. [Supply Chain & Order Fulfillment System](./Order-Fulfillment-Database-VB) (`Order-Fulfillment-Database-VB`)
* **Language:** Visual Basic .NET & Microsoft Access (`Base de Datos Pedidos.accdb`)
* **Description:** A 7-form business logistics application coordinating products, suppliers, customers, employees, orders, and shipping methods.
* **Key Programming Concepts Demonstrated:**
  * Relational database integration with Microsoft Access (`Base_de_Datos_PedidosDataSet`) and custom SQL `TableAdapter` commands.
  * Dynamic form field locking/unlocking and confirmation dialogs before destructive edits.
  * Foreign-key linking across customers, products, suppliers, employees, and shipping modes.

### 3. [Medical Clinic Management System](./Medical-Clinic-Database-VB) (`Medical-Clinic-Database-VB`)
* **Language:** Visual Basic .NET & Relational Database (`ClinicDataSet`)
* **Description:** A 7-form healthcare management suite handling patient records, doctor rosters, medical appointments, clinic staff, inventory, and sales billing.
* **Key Programming Concepts Demonstrated:**
  * Multi-table dataset binding (`pacientes`, `medicos`, `Citas`, `empleados`, `inventario`, `ventas`) with `BindingNavigator` persistence.
  * Modular Windows Forms architecture coordinated through a central `MenuStrip` hub (`MenuP`).

---

## Business, Retail & School Administration Applications

### 4. [School Enrollment, Gradebook & Tuition Billing System](./School-Management-Tuition-CPP) (`School-Management-Tuition-CPP`)
* **Language:** C++ (Visual Studio)
* **Description:** A 6-module school administration system (*Bilingüe El Prado*) supporting student enrollment across four academic levels (*Preprimaria*, *Primaria*, *Básico*, *Diversificado*), grade entry, academic transcript queries, and monthly tuition invoicing.
* **Key Programming Concepts Demonstrated:**
  * Multi-dimensional arrays (`alum`, `datalum`, `notas`) storing student profiles, academic levels, and term grades.
  * Duplicate student ID validation and per-student min/max score analytics alongside pass/fail evaluation.
  * Automated monthly tuition calculation by academic level supporting cash, check, and credit card payments (with a 5% surcharge calculation).

### 5. [Inventory & Point-of-Sale (POS) Billing System](./Inventory-POS-Billing-CPP) (`Inventory-POS-Billing-CPP`)
* **Language:** C++ (Visual Studio)
* **Description:** A full console-based retail management and invoicing system (*INFOPRADO*) supporting product inventory registration, customer profile lookup by tax ID (*NIT*), real-time stock deduction, customer-tier discounts, and invoice generation with 12% VAT (*IVA*).
* **Key Programming Concepts Demonstrated:**
  * Relational data management using parallel 1D and 2D arrays (`prods`, `clie`, `nit`, `nomprod`).
  * Modular architecture across five core business functions (`ingresoprod`, `consprod`, `ingresoclie`, `consulclie`, `facturar`).
  * Input validation, duplicate ID prevention, and real-time inventory stock checks.
  * Automated invoice calculation incorporating tiered customer discounts (2% / 6%) and 12% sales tax (*IVA*).

### 6. [Restaurant Raw Materials & Menu Costing System](./Restaurant-Inventory-Menu-CPP) (`Restaurant-Inventory-Menu-CPP`)
* **Language:** C++ (Visual Studio)
* **Description:** A console-based restaurant management application that tracks raw ingredient inventory (measured in ounces and unit cost), configures menu item recipes (ingredient, sauce, and cheese ratios), and calculates total ingredient investment with animated UI frames and search progress bars.
* **Key Programming Concepts Demonstrated:**
  * Structured multi-dimensional data storage (`materiaprima` and `opciones` matrices) paired with parallel string arrays.
  * Duplicate-entry validation with inline console error recovery and row backtracking.
  * Animated ASCII box drawing and simulated search progress bars using `gotoxy` and `Sleep()`.

### 7. [Fast-Food Order Kiosk & Receipt System](./Fast-Food-POS-Kiosk-VB) (`Fast-Food-POS-Kiosk-VB`)
* **Language:** Visual Basic .NET (Visual Studio)
* **Description:** A 2-form restaurant ordering kiosk (`Form1` order builder and `Form2` checkout summary) supporting size-based customization for burgers, sides, desserts, and beverages.
* **Key Programming Concepts Demonstrated:**
  * Dynamic `ListBox` shopping cart management with item addition, undo-last-item (`RemoveAt`), remove-selected-item, and full cart reset (`Clear`).
  * Real-time order subtotaling (`totalizar()`) and cross-form receipt transfer upon checkout.

### 8. [Student Grade Management System](./Student-Grade-System-CPP) (`Student-Grade-System-CPP`)
* **Language:** C++ (Visual Studio)
* **Description:** A console-based academic record application designed to register student profiles (student ID, first name, last name) and input/display grades across four grading terms (*Bloque 1–4*).
* **Key Programming Concepts Demonstrated:**
  * Multi-dimensional arrays (`string` and `double` matrices) for storing student records and grades.
  * Modular function design (`alumnos()`, `ingnotas()`, `repnotas()`).
  * Interactive CLI menu navigation using `do-while` loops and `switch` statements.
  * Custom console table formatting using the Windows API (`SetConsoleCursorPosition` / `gotoxy`).

### 9. [Bulk Purchase Discount Calculator](./Bulk-Discount-Calculator-VB) (`Bulk-Discount-Calculator-VB`)
* **Language:** Visual Basic .NET (Visual Studio)
* **Description:** A Windows Forms retail pricing calculator that computes gross subtotals, applies tiered bulk discounts (10%, 20%, or 40% based on item quantity), and displays total customer savings alongside the final net price.
* **Key Programming Concepts Demonstrated:**
  * Conditional branching logic (`If / ElseIf`) for multi-tier business rules.
  * User input parsing (`Val()`) and arithmetic calculation across text box controls.
  * Event-driven Windows Forms UI handling (`Button.Click` events).

---

## Interactive Simulations, Games & Console Graphics

### 10. [Dual-Intersection Traffic Light & Car Simulation](./Traffic-Intersection-Simulation-VB) (`Traffic-Intersection-Simulation-VB`)
* **Language:** Visual Basic .NET (Visual Studio)
* **Description:** A real-time visual simulation of two perpendicular traffic signals and moving vehicles at an intersection.
* **Key Programming Concepts Demonstrated:**
  * Four synchronized `Timer.Tick` loops driving independent traffic light state machines (Green → Yellow → Red) and vehicle motion.
  * 2D coordinate animation (`New Point(x, y)`) with conditional collision/stop logic that halts vehicles at yellow and red lights.

### 11. [Memory Card Matching Game](./Memory-Card-Game-VB) (`Memory-Card-Game-VB`)
* **Language:** Visual Basic .NET (Visual Studio)
* **Description:** A multi-form graphical memory matching game featuring a dedicated How-to-Play instructions screen (`Instrucciones`), randomized card placement, a timed memorization preview phase, and interactive card-flipping controls (`Juego`).
* **Key Programming Concepts Demonstrated:**
  * Multi-form Windows Forms GUI navigation (`Juego` main game board and `Instrucciones` rules screen).
  * Pseudo-random number generation (`Randomize()`, `Rnd()`) paired with a custom duplicate-prevention function (`comprepetido`).
  * Event-driven programming (`Click` handlers, `Form.Load`, and `Timer.Tick` countdown events).
  * Dynamic UI control manipulation and embedded resource image loading (`My.Resources`).

### 12. [Timed 4-Stage Interactive Quiz Game](./Timed-Multi-Stage-Quiz-VB) (`Timed-Multi-Stage-Quiz-VB`)
* **Language:** Visual Basic .NET (Visual Studio)
* **Description:** A 12-question, 4-round quiz application with per-stage 30-second countdown timers and instant visual answer feedback.
* **Key Programming Concepts Demonstrated:**
  * Automatic radio-button control locking upon countdown expiration using `Timer.Tick` and dynamic `Controls` collection indexing.
  * Cross-form global score state management and final accuracy breakdown (total score, correct answers, and incorrect answers).

### 13. [Animated ASCII Diamond & Pyramid Generator](./ASCII-Diamond-Animation-CPP) (`ASCII-Diamond-Animation-CPP`)
* **Language:** C++ (Visual Studio)
* **Description:** A console graphics program that constructs a multi-colored diamond pattern in the center of the terminal by rendering four distinct triangular quadrants with timed animation delays.
* **Key Programming Concepts Demonstrated:**
  * Nested `for` loops with ascending and descending index counters to generate geometric patterns.
  * Coordinate-based console rendering using the Windows API (`SetConsoleCursorPosition` / `gotoxy`).
  * Dynamic terminal color manipulation (`SetConsoleTextAttribute`) and frame-by-frame animation timing (`Sleep()`).

---

## How to Run These Projects

* **Visual Basic .NET Projects (`*-VB`):** Open the `.sln` solution file inside each folder using **Microsoft Visual Studio** and press **F5** to build and run.
* **C++ Projects (`*-CPP`):** Open the `.sln` / `.vcxproj` file in **Visual Studio**, or compile the `.cpp` source file directly using any Windows C++ compiler (`g++`, MinGW, or Dev-C++).
