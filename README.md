# Stock Data Optimization

## Overview

This project demonstrates the **Flyweight Pattern**, an essential design pattern used to **minimize memory usage** by sharing objects instead of creating duplicates. The program allows users to enter stock symbols and company names, ensuring that **each stock symbol is stored only once in memory**.

## Features

✔ Implements the **Flyweight Pattern** to reduce duplicate object creation.\
✔ Uses an in-memory **StockFactory** to manage and reuse stock symbol objects.\
✔ Accepts **user input** for stock symbol and company name.\
✔ Demonstrates how objects can be stored efficiently **without an external database**.

## Installation

### Prerequisites

- **.NET 6.0 or later**

### Steps

1. Clone the repository:
   ```bash
   git clone https://github.com/YourUsername/StockDataOptimization.git
   cd StockDataOptimization
   ```
2. Build and run the program:
   ```bash
   dotnet run
   ```

## Usage

1. Run the application.
2. Enter a **stock symbol** (e.g., `AAPL` for Apple).
3. Enter the **company name** (e.g., `Apple Inc.`).
4. The system will check if the stock symbol already exists.
   - If yes, it returns the **existing object**.
   - If no, it **creates and stores a new object**.
5. The program outputs the stored stock details.

### **Example Output**

```
STOCK LOOKUP

Enter stock symbol...
AAPL

Enter company name...
Apple Inc.

Stock Symbol: AAPL, Company Name: Apple Inc.
```

## Project Structure

```
StockDataOptimization
├── Program.cs
├── StockFactory.cs (Manages Flyweight Stock Objects)
├── IStock.cs (Interface for shared stock properties)
├── Stock.cs (Concrete Flyweight - shared stock object)
├── UnsharedStockData.cs (Unshared data that varies per stock instance)
```

## Error Handling

- If the user enters an invalid symbol, the system **creates a new stock object**.
- Future improvements could include **validation using a stock market API**.

## Future Enhancements

🔹 **Integrate a stock API** to autofill stock data dynamically.\
🔹 **Allow lookup by symbol or company name** instead of needing to enter both.\
🔹 **Combine this with the StockPriceMonitoringSystem** for real-time updates.

