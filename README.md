# High-School-Coding-Projects
Archive of high school programming projects built in Visual Basic and C++, showcasing foundational software development and problem-solving skills.

*Note: These projects were originally developed during my high school studies in Guatemala, so variable names, comments, and UI prompts within the source code are written in Spanish.*

## Projects Included

### 1. Student Grade Management System (`prelab`)
* **Language:** C++ (Visual Studio)
* **Description:** A console-based academic record application designed to register student profiles (student ID, first name, last name) and input/display grades across four grading terms (*Bloque 1–4*).
* **Key Programming Concepts Demonstrated:**
  * Multi-dimensional arrays (`string` and `double` matrices) for storing student records and grades.
  * Modular function design (`alumnos()`, `ingnotas()`, `repnotas()`).
  * Interactive CLI menu navigation using `do-while` loops and `switch` statements.
  * Custom console table formatting using the Windows API (`SetConsoleCursorPosition` / `gotoxy`).
    
### 2. Memory Card Matching Game (`Juego`)
* **Language:** Visual Basic .NET (Visual Studio)
* **Description:** A multi-form graphical memory matching game featuring a dedicated How-to-Play instructions screen (`Instrucciones`), randomized card placement, a timed memorization preview phase, and interactive card-flipping controls (`Juego`).
* **Key Programming Concepts Demonstrated:**
  * Multi-form Windows Forms GUI navigation (`Juego` main game board and `Instrucciones` rules screen).
  * Pseudo-random number generation (`Randomize()`, `Rnd()`) paired with a custom duplicate-prevention function (`comprepetido`).
  * Event-driven programming (`Click` handlers, `Form.Load`, and `Timer.Tick` countdown events).
  * Dynamic UI control manipulation and embedded resource image loading (`My.Resources`).

### 3. Bulk Purchase Discount Calculator (`Bulk-Discount-Calculator-VB`)
* **Language:** Visual Basic .NET (Visual Studio)
* **Description:** A Windows Forms retail pricing calculator that computes gross subtotals, applies tiered bulk discounts (10%, 20%, or 40% based on item quantity), and displays total customer savings alongside the final net price.
* **Key Programming Concepts Demonstrated:**
  * Conditional branching logic (`If / ElseIf`) for multi-tier business rules.
  * User input parsing (`Val()`) and arithmetic calculation across text box controls.
  * Event-driven Windows Forms UI handling (`Button.Click` events).

### 4. Inventory & Point-of-Sale (POS) Billing System (`Inventory-POS-Billing-CPP`)
* **Language:** C++ (Visual Studio)
* **Description:** A full console-based retail management and invoicing system (*INFOPRADO*) supporting product inventory registration, customer profile lookup by tax ID (*NIT*), real-time stock deduction, customer-tier discounts, and invoice generation with 12% VAT (*IVA*).
* **Key Programming Concepts Demonstrated:**
  * Relational data management using parallel 1D and 2D arrays (`prods`, `clie`, `nit`, `nomprod`).
  * Modular architecture across five core business functions (`ingresoprod`, `consprod`, `ingresoclie`, `consulclie`, `facturar`).
  * Input validation, duplicate ID prevention, and real-time inventory stock checks.
  * Automated invoice calculation incorporating tiered customer discounts (2% / 6%) and 12% sales tax (*IVA*). 

### 5. Animated ASCII Diamond & Pyramid Generator (`ASCII-Diamond-Animation-CPP`)
* **Language:** C++ (Visual Studio)
* **Description:** A console graphics program that constructs a multi-colored diamond pattern in the center of the terminal by rendering four distinct triangular quadrants with timed animation delays.
* **Key Programming Concepts Demonstrated:**
  * Nested `for` loops with ascending and descending index counters to generate geometric patterns.
  * Coordinate-based console rendering using the Windows API (`SetConsoleCursorPosition` / `gotoxy`).
  * Dynamic terminal color manipulation (`SetConsoleTextAttribute`) and frame-by-frame animation timing (`Sleep()`).

### 6. Restaurant Raw Materials & Menu Costing System (`Restaurant-Inventory-Menu-CPP`)
* **Language:** C++ (Visual Studio)
* **Description:** A console-based restaurant management application that tracks raw ingredient inventory (measured in ounces and unit cost), configures menu item recipes (ingredient, sauce, and cheese ratios), and calculates total ingredient investment with animated UI frames and search progress bars.
* **Key Programming Concepts Demonstrated:**
  * Structured multi-dimensional data storage (`materiaprima` and `opciones` matrices) paired with parallel string arrays.
  * Duplicate-entry validation with inline console error recovery and row backtracking.
  * Animated ASCII box drawing and simulated search progress bars using `gotoxy` and `Sleep()`.



